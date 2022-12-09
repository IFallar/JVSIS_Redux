Public Class Form_Item

    Private Sub Form_Item_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
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
        Else
            FI_TBX_ITEM_TOPAY.Text = ""
            FI_TBX_ITEM_TOPAY.ReadOnly = False
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

End Class