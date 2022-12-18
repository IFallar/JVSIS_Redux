Imports System.ComponentModel

Public Class Form_Flagged_Items

    Dim Query As String = "CONCAT(item_name, ' | ', (SELECT brand_name FROM brands WHERE brand_id = item_brand),' | ',   (SELECT variant_name FROM variants WHERE variant_id = item_variant), ' | ' ,  (SELECT supplier_name FROM supplier WHERE supplier_id = item_supplier))"

    Dim QTY As Integer
    Dim TH As Integer
    Dim New_Status As String

    Public Sub LoadFlagged()

        strconn.Close()
        tableload("SELECT `entry_id`, `item_name` AS 'Item Details', `item_unit` AS 'Number of Units', `issue` AS 'ITEM ISSUE', `ret_date` AS 'Added to List on:', `item_id` FROM `flagged_items`", Flagged_Item_GridView)
        strconn.Close()

    End Sub

    Public Sub StockSelect()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `item_name` AS 'Product Name', (SELECT brand_name FROM brands WHERE brand_id = `item_brand`) AS 'Brand', (SELECT variant_name FROM variants WHERE variant_id = `item_variant` ) AS 'Variant', (SELECT supplier_name FROM supplier WHERE supplier_id = `item_supplier` ) as 'Supplier', item_qty, item_threshold, item_stock_status FROM products WHERE item_id = '" & Dashboard.GlobalVariables.Selected_Item & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            FS_RS_TBX.Text = cmdreader.GetString(0)
            FS_RS_BRAND.Text = cmdreader.GetString(1)
            FS_RS_VAR.Text = cmdreader.GetString(2)
            FS_RS_SUPP.Text = cmdreader.GetString(3)
            QTY = cmdreader.GetString(4)
            TH = cmdreader.GetValue(5)
        End While

        cmdreader.Close()
        con.Close()

        DTG_SUGGEST.Visible = False
        DTG_SUGGEST.Height = 10

    End Sub

    Private Sub FS_RS_TBX_TextChanged(sender As Object, e As EventArgs) Handles FS_RS_TBX.TextChanged

        DTG_SUGGEST.Height = 117
        DTG_SUGGEST.Visible = True

        cmd.Parameters.AddWithValue("@searchpara", FS_RS_TBX.Text)
        tableload("SELECT item_id," + Query + " AS 'Details' FROM products WHERE " + Query + " LIKE CONCAT('%',@searchpara,'%')", DTG_ITM_RECC)
        strconn.Close()
        cmd.Parameters.Clear()

        If FS_RS_TBX.Text = "" Then
            DTG_SUGGEST.Visible = False
            DTG_SUGGEST.Height = 10
        End If

    End Sub

    Private Sub Item_Table_SelectionChanged(sender As Object, e As EventArgs) Handles DTG_ITM_RECC.CellClick

        Try

            Dashboard.GlobalVariables.Selected_Item = DTG_ITM_RECC.CurrentRow.Cells(0).Value

        Catch ex As NullReferenceException

            Dashboard.GlobalVariables.Selected_Item = 1

        End Try

        StockSelect()

    End Sub

    Dim FlagEntry As Integer

    Private Sub Flagged_Item_GridView_SelectionChanged(sender As Object, e As EventArgs) Handles Flagged_Item_GridView.CellClick

        Try

            FlagEntry = Flagged_Item_GridView.CurrentRow.Cells(0).Value
            Issue_Box.Text = Flagged_Item_GridView.CurrentRow.Cells(3).Value
            RETURN_UNIT.Value = Flagged_Item_GridView.CurrentRow.Cells(2).Value
            Dashboard.GlobalVariables.Selected_Item = Flagged_Item_GridView.CurrentRow.Cells(5).Value

        Catch ex As NullReferenceException

            FlagEntry = 1

        End Try

        StockSelect()

    End Sub

    Private Sub DTG_ITM_RECC_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DTG_ITM_RECC.DataBindingComplete

        Flagged_Item_GridView.ClearSelection()

        DTG_ITM_RECC.RowTemplate.Resizable = False
        DTG_ITM_RECC.Columns(0).Visible = False
        DTG_ITM_RECC.Columns(0).Frozen = True
        DTG_ITM_RECC.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DTG_ITM_RECC.RowTemplate.MinimumHeight = 20

    End Sub

    Private Sub Flagged_Item_GridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Flagged_Item_GridView.DataBindingComplete

        Flagged_Item_GridView.ClearSelection()

        Flagged_Item_GridView.RowTemplate.Resizable = False
        Flagged_Item_GridView.Columns(0).Visible = False
        Flagged_Item_GridView.Columns(0).Frozen = True
        Flagged_Item_GridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Flagged_Item_GridView.Columns(1).MinimumWidth = 130
        Flagged_Item_GridView.Columns(5).Visible = False
        Flagged_Item_GridView.Columns(5).Frozen = True

        Flagged_Item_GridView.RowTemplate.MinimumHeight = 20

    End Sub

    Private Sub Form_Flagged_Items_Load(sender As Object, e As EventArgs) Handles Me.Load

        StockSelect()
        LoadFlagged()

    End Sub

    Private Sub FI_BTN_SAVE_Click(sender As Object, e As EventArgs) Handles FI_BTN_SAVE.Click

        Dim RS_Date As Date = Date.Now()
        Dim RS_Date_F As String = RS_Date.ToString("yyyy\-MM\-dd")

        Try

            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@item", FS_RS_TBX.Text + " | " + FS_RS_BRAND.Text + " | " + FS_RS_VAR.Text + " | " + FS_RS_SUPP.Text)
            cmd.Parameters.AddWithValue("@issue", Issue_Box.Text)
            cmd.Parameters.AddWithValue("@qty", RETURN_UNIT.Value)
            cmd.Parameters.AddWithValue("@dat", RS_Date_F)

            cmd.CommandText = "INSERT INTO `flagged_items`(`entry_id`, `item_name`, `item_unit`, `issue`, `ret_date`) VALUES (DEFAULT, @item, @qty, @issue, @dat)"

            cmd.ExecuteNonQuery()

            strconn.Close()

            MsgBox("Item Added to List", MsgBoxStyle.OkOnly, "Success!")

            If Deduct.Checked Then

                If QTY >= RETURN_UNIT.Value Then

                    If (QTY - RETURN_UNIT.Value) >= TH And (QTY - RETURN_UNIT.Value) > 0 Then
                        New_Status = "Normal"
                    ElseIf (QTY - RETURN_UNIT.Value) = 0 Then
                        New_Status = "Out of Stock"
                    Else
                        New_Status = "Low Stock"
                    End If

                    strconn.Close()

                    strconnection()

                    cmd.Connection = strconn
                    strconn.Open()

                    cmd.Parameters.Clear()

                    cmd.Parameters.AddWithValue("@qty", QTY - RETURN_UNIT.Value)

                    cmd.CommandText = "UPDATE `products` SET `item_qty`= @qty, `item_stock_status` = '" & New_Status & "' WHERE `item_id` = '" & Dashboard.GlobalVariables.Selected_Item & "'"

                    cmd.ExecuteNonQuery()

                    strconn.Close()

                Else

                    MsgBox("Exceeds Inventory Quantity.", MsgBoxStyle.OkOnly, "Insufficient Stock")

                End If

            End If

        Catch ex As Exception

            MessageBox.Show(String.Format("Error: {0}", ex.Message))

        End Try

        LoadFlagged()
        Dashboard.LoadMain()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FS_RS_TBX.Text = ""
        FS_RS_BRAND.Text = ""
        FS_RS_VAR.Text = ""
        FS_RS_SUPP.Text = ""
        Issue_Box.Text = ""
        RETURN_UNIT.Value = 0

    End Sub

    Private Sub Form_Flagged_Items_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        FS_RS_TBX.Text = ""
        FS_RS_BRAND.Text = ""
        FS_RS_VAR.Text = ""
        FS_RS_SUPP.Text = ""
        Issue_Box.Text = ""
        RETURN_UNIT.Value = 0

    End Sub

    Private Sub FI_BTN_RESET_Click(sender As Object, e As EventArgs) Handles FI_BTN_RLV.Click


        Dim delete = MsgBox("Re-Add Items to Inventory and Delete Entry?", MsgBoxStyle.YesNo, "Delete Item")

        If delete = MsgBoxResult.Yes Then

            Try

                If (QTY + RETURN_UNIT.Value) >= TH And (QTY + RETURN_UNIT.Value) > 0 Then
                    New_Status = "Normal"
                ElseIf (QTY + RETURN_UNIT.Value) = 0 Then
                    New_Status = "Out of Stock"
                Else
                    New_Status = "Low Stock"
                End If

                strconnection()

                cmd.Connection = strconn
                strconn.Open()

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@qty", QTY + RETURN_UNIT.Value)
                cmd.CommandText = "UPDATE `products` SET `item_qty`= @qty, `item_stock_status` = '" & New_Status & "' WHERE `item_id` = '" & Dashboard.GlobalVariables.Selected_Item & "'"

                cmd.ExecuteNonQuery()
                strconn.Close()

                strconnection()

                cmd.Connection = strconn
                strconn.Open()

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@qty", QTY + RETURN_UNIT.Value)
                cmd.CommandText = "DELETE FROM `flagged_items` WHERE entry_id = '" & FlagEntry & "'"

                cmd.ExecuteNonQuery()
                strconn.Close()

                MsgBox("Entry Sucessfully Deleted", MsgBoxStyle.OkOnly, "Delete Item")

            Catch ex As Exception

                MessageBox.Show(String.Format("Error: {0}", ex.Message))

            End Try

        ElseIf delete = MsgBoxResult.No Then

        End If

        LoadFlagged()
        Dashboard.LoadMain()

    End Sub

    Private Sub FI_BTN_CANCEL_Click(sender As Object, e As EventArgs) Handles FI_BTN_RMV.Click

        Dim delete = MsgBox("Are you sure you want delete the selected item?", MsgBoxStyle.YesNo, "Delete Item")

        If delete = MsgBoxResult.Yes Then

            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@qty", QTY + RETURN_UNIT.Value)
            cmd.CommandText = "DELETE FROM `flagged_items` WHERE entry_id = '" & FlagEntry & "'"

            cmd.ExecuteNonQuery()
            strconn.Close()

            MsgBox("Entry Sucessfully Deleted", MsgBoxStyle.OkOnly, "Delete Item")

        ElseIf delete = MsgBoxResult.No Then

        End If

        LoadFlagged()
        Dashboard.LoadMain()

    End Sub


End Class