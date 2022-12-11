Public Class Form_Item

    Dim Confirm_string = ""
    Dim Query As Integer

    Public Sub Reset()

        FI_TBX_ITM_NAME.Text = ""
        FI_CBX_ITM_CAT.Text = ""
        FI_CBX_ITM_BRAND.Text = ""
        FI_CBX_ITM_VARIANT.Text = ""

        FI_NUD_ITM_STOCK.Value = 0
        FI_NUD_ITM_THRESHOLD.Value = 0

        RB_OWNED.Checked = False
        RB_CONSIGNED.Checked = False
        RB_LOANED.Checked = False

        FI_TBX_ITEM_TOPAY.Text = ""
        FI_TBX_ITEM_TOPAY.Enabled = False

        FI_CBX_ITEM_SUPP.Text = ""
        FI_TBX_ITEM_COST.Text = ""

        FI_TBX_L_PERCENT.Text = ""
        FI_TBX_U_PERCENT.Text = ""

        Manual_CBX.Checked = False

        FI_TBX_L_PRICE.Text = ""
        FI_TBX_M_PRICE.Text = ""

    End Sub

    Public Sub ItemControl()

        strconn.Close()
        con.Close()

        Dim StockStat As String = ""
        Dim x As String = ""

        If FI_NUD_ITM_STOCK.Value >= FI_NUD_ITM_THRESHOLD.Value Then
            x = "Normal"
        ElseIf FI_NUD_ITM_STOCK.Value = 0 Then
            x = "Out Of Stock"
        Else
            x = "Low Stock"
        End If

        StockStat = x

        Dim StockDate = Date.Now()
        Dim StockDate_F = StockDate.ToString("yyyy\-MM\-dd")

        Try

            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@item", FI_TBX_ITM_NAME.Text)
            cmd.Parameters.AddWithValue("@cat", cat_id)
            cmd.Parameters.AddWithValue("@brand", brand_id)
            cmd.Parameters.AddWithValue("@var", var_id)
            cmd.Parameters.AddWithValue("@supp", supp_id)

            cmd.Parameters.AddWithValue("@pcost", FI_TBX_ITEM_COST.Text)
            cmd.Parameters.AddWithValue("@mincost", FI_TBX_L_PRICE.Text)
            cmd.Parameters.AddWithValue("@maxcost", FI_TBX_M_PRICE.Text)

            cmd.Parameters.AddWithValue("@qty", FI_NUD_ITM_STOCK.Value)
            cmd.Parameters.AddWithValue("@trh", FI_NUD_ITM_THRESHOLD.Value)

            cmd.Parameters.AddWithValue("@sts", StockStat)
            cmd.Parameters.AddWithValue("@dat", StockDate_F)

            cmd.Parameters.AddWithValue("@hold", HoldStat)
            cmd.Parameters.AddWithValue("@tpy", FI_TBX_ITEM_TOPAY.Text)

            If Query = 0 Then
                cmd.CommandText = "INSERT INTO `products`(`item_id`, `item_name`, `item_category`, `item_brand`, `item_variant`, `item_supplier`, `item_p_cost`, `item_s_cost_min`, `item_s_cost_max`, `item_qty`, `item_threshold`, `item_stock_status`, `item_last_restock`, `item_warn_date`, `item_hld_stat`, `item_to_pay`) VALUES (DEFAULT, @item, @cat, @brand, @var, @supp, @pcost, @mincost, @maxcost, @qty, @trh, @sts, @dat, @dat, @hold, @tpy)"
            ElseIf Query = 1 Then
                cmd.CommandText = ""
            End If

            cmd.ExecuteNonQuery()

            strconn.Close()

            MsgBox(Confirm_string, MsgBoxStyle.OkOnly, "Success!")

        Catch ex As Exception

            MsgBox("Please Enter All Details Properly", MsgBoxStyle.OkOnly, "Warning!")

        End Try

        Reset()
        Me.Close()

    End Sub

    Private Sub Form_Item_Load(sender As Object, e As EventArgs) Handles Me.Load

        If FORM_LABEL.Text = "ADD NEW ITEM" Then

            Confirm_string = "ITEM SUCCESSFULY ADDED"
            Query = 0

        End If

        '++++++++++++++++ ADD COMBO BOX VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        FI_CBX_ITM_BRAND.Items.Clear()
        FI_CBX_ITM_CAT.Items.Clear()
        FI_CBX_ITM_VARIANT.Items.Clear()
        FI_CBX_ITEM_SUPP.Items.Clear()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT BRAND_NAME FROM (brands)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim list_brands = cmdreader.GetString("brand_name")
            FI_CBX_ITM_BRAND.Items.Add(list_brands)
        End While

        cmdreader.Close()
        con.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT variant_name FROM variants"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim list_variants = cmdreader.GetString("variant_name")
            FI_CBX_ITM_VARIANT.Items.Add(list_variants)
        End While

        cmdreader.Close()
        con.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT category_name FROM category"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim list_categories = cmdreader.GetString("category_name")
            FI_CBX_ITM_CAT.Items.Add(list_categories)
        End While

        cmdreader.Close()
        con.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `supplier_name` FROM `supplier` WHERE 1"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim list_supp = cmdreader.GetString("supplier_name")
            FI_CBX_ITEM_SUPP.Items.Add(list_supp)
        End While

        cmdreader.Close()
        con.Close()


    End Sub

    '=[VALIDATORS]=======================================================================================================================

    Private Sub FI_TBX_ITEM_TOPAY_KeyPress(sender As Object, e As EventArgs) Handles FI_TBX_ITEM_TOPAY.KeyPress, FI_TBX_ITEM_COST.KeyPress, FI_TBX_L_PRICE.KeyPress, FI_TBX_M_PRICE.KeyPress, FI_TBX_L_PERCENT.KeyPress, FI_TBX_U_PERCENT.KeyPress
        CheckInput_N(e, sender)
    End Sub

    Private Sub FI_TBX_ITEM_COST_TextChanged(sender As Object, e As EventArgs) Handles FI_TBX_ITEM_COST.TextChanged

        If FI_TBX_ITEM_COST.Text IsNot "" Then
            GB_SELL_PRICE.Enabled = True
        Else
            GB_SELL_PRICE.Enabled = False
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Manual_CBX.CheckedChanged

        If Manual_CBX.Checked = True Then
            FI_TBX_L_PERCENT.Text = ""
            FI_TBX_L_PERCENT.Enabled = False
            FI_TBX_U_PERCENT.Text = ""
            FI_TBX_U_PERCENT.Enabled = False
            Price_Manual.Enabled = True
        Else
            Price_Manual.Enabled = False
            FI_TBX_U_PERCENT.Enabled = True
            FI_TBX_L_PERCENT.Enabled = True
        End If

    End Sub

    Private Sub RB_CheckedChanged(sender As Object, e As EventArgs) Handles RB_OWNED.CheckedChanged, RB_CONSIGNED.CheckedChanged, RB_LOANED.CheckedChanged

        If RB_OWNED.Checked = True Then
            FI_TBX_ITEM_TOPAY.Text = 0
            FI_TBX_ITEM_TOPAY.ReadOnly = True
            HoldStat = "Owned"
        ElseIf RB_CONSIGNED.Checked Then
            FI_TBX_ITEM_TOPAY.Text = ""
            FI_TBX_ITEM_TOPAY.ReadOnly = False
            HoldStat = "Consigned"
        ElseIf RB_LOANED.Checked Then
            FI_TBX_ITEM_TOPAY.Text = ""
            FI_TBX_ITEM_TOPAY.ReadOnly = False
            HoldStat = "Loaned"
        End If

    End Sub

    Private Sub FI_TBX_L_PERCENT_TextChanged(sender As Object, e As EventArgs) Handles FI_TBX_L_PERCENT.TextChanged

        Try

            Dim PercentMarginL As Integer
            Dim Price As Integer = FI_TBX_ITEM_COST.Text

            If FI_TBX_L_PERCENT.Text = Nothing Or 0 Then
                PercentMarginL = 100
                FI_TBX_L_PRICE.Text = Price
            Else
                PercentMarginL = 100 + FI_TBX_L_PERCENT.Text
                FI_TBX_L_PRICE.Text = (PercentMarginL / 100) * Price
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub FI_TBX_U_PERCENT_TextChanged(sender As Object, e As EventArgs) Handles FI_TBX_U_PERCENT.TextChanged

        Try

            Dim PercentMarginU As Integer
            Dim Price As Integer = FI_TBX_ITEM_COST.Text

            If FI_TBX_U_PERCENT.Text = Nothing Or 0 Then
                PercentMarginU = 100
                FI_TBX_M_PRICE.Text = Price
            Else
                PercentMarginU = 100 + FI_TBX_U_PERCENT.Text
                FI_TBX_M_PRICE.Text = (PercentMarginU / 100) * Price
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub FI_NUD_ITM_THRESHOLD_ValueChanged(sender As Object, e As EventArgs) Handles FI_NUD_ITM_THRESHOLD.ValueChanged, FI_NUD_ITM_STOCK.ValueChanged

        If FI_NUD_ITM_THRESHOLD.Value > FI_NUD_ITM_STOCK.Value And FI_NUD_ITM_STOCK.Value > 0 Then
            ToolTip1.Show("Will start as Low Stock", FI_NUD_ITM_THRESHOLD)
        ElseIf FI_NUD_ITM_STOCK.Value = 0 Then
            ToolTip1.Show("Will start as Out of Stock", FI_NUD_ITM_THRESHOLD)
        Else
            ToolTip1.Active = False
        End If

    End Sub

    Private Sub FI_TBX_L_PRICE_TextChanged(sender As Object, e As EventArgs) Handles FI_TBX_L_PRICE.TextChanged, FI_TBX_M_PRICE.TextChanged

        If FI_TBX_L_PRICE.Text < FI_TBX_ITEM_COST.Text Or FI_TBX_M_PRICE.Text < FI_TBX_ITEM_COST.Text Then
            ToolTip2.Show("Your set prices are lower that the item's set cost!", FI_TBX_L_PRICE)
            ToolTip2.Show("Your set prices are lower that the item's set cost!", FI_TBX_M_PRICE)
        Else
            ToolTip2.Active = False
        End If

    End Sub

    '=[BUTTON FUNCTIONS]=======================================================================================================================

    Dim HoldStat As String = ""
    Dim cat_id As Integer
    Dim brand_id As Integer
    Dim var_id As Integer
    Dim supp_id As Integer

    Private Sub FI_BTN_SAVE_Click(sender As Object, e As EventArgs) Handles FI_BTN_SAVE.Click

        Try

            opencon()

            cmd.Connection = con
            cmd.Parameters.AddWithValue("@cat", FI_CBX_ITM_CAT.Text)
            cmd.Parameters.AddWithValue("@brand", FI_CBX_ITM_BRAND.Text)
            cmd.Parameters.AddWithValue("@var", FI_CBX_ITM_VARIANT.Text)
            cmd.Parameters.AddWithValue("@supp", FI_CBX_ITEM_SUPP.Text)
            cmd.CommandText = "SELECT (SELECT category_id FROM category WHERE category_name = @cat), (SELECT brand_id FROM brands WHERE brand_name = @brand), (SELECT variant_id FROM variants WHERE variant_name = @var), (SELECT supplier_id FROM supplier WHERE supplier_name = @supp)"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                cat_id = cmdreader.GetValue(0)
                brand_id = cmdreader.GetValue(1)
                var_id = cmdreader.GetValue(2)
                supp_id = cmdreader.GetValue(3)
            End While

            cmd.Parameters.Clear()

            cmdreader.Close()
            con.Close()

        Catch ex As Exception

        End Try


        strconn.Close()
        con.Close()
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Dim dupcheck = Nothing

        If Query = 0 Then

            Try

                opencon()

                cmd.Connection = con
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@item", FI_TBX_ITM_NAME.Text)
                cmd.Parameters.AddWithValue("@cat", cat_id)
                cmd.Parameters.AddWithValue("@brand", brand_id)
                cmd.Parameters.AddWithValue("@var", var_id)
                cmd.Parameters.AddWithValue("@supp", supp_id)
                cmd.CommandText = "SELECT item_id from products WHERE item_name = @item AND item_category = @cat AND item_brand = @brand AND item_variant = @var AND item_supplier = @supp"
                cmd.Prepare()

                cmdreader = cmd.ExecuteReader

                While cmdreader.Read
                    dupcheck = cmdreader.GetValue(0)
                End While

                cmd.Parameters.Clear()

                cmdreader.Close()
                con.Close()

            Catch ex As Exception

                MessageBox.Show(String.Format("Error: {0}", ex.Message))

            End Try

            strconn.Close()
            con.Close()

        End If

        If dupcheck = Nothing Then

            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            ItemControl()

        Else



        End If

        LoadDashDetails()

    End Sub

    Private Sub FI_BTN_CANCEL_Click(sender As Object, e As EventArgs) Handles FI_BTN_CANCEL.Click

        Try
            Me.Close()

        Catch ex As Exception

        End Try

        Reset()

    End Sub

    Private Sub FI_BTN_RESET_Click(sender As Object, e As EventArgs) Handles FI_BTN_RESET.Click

        Reset()

    End Sub


End Class