Imports System.ComponentModel

Public Class Form_Stock_DB

    Dim Query As String = "CONCAT(item_name, ' | ', (SELECT brand_name FROM brands WHERE brand_id = item_brand),' | ',   (SELECT variant_name FROM variants WHERE variant_id = item_variant), ' | ' ,  (SELECT supplier_name FROM supplier WHERE supplier_id = item_supplier))"

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
            CS = cmdreader.GetValue(4)
            TH = cmdreader.GetValue(5)
            SS = cmdreader.GetString(6)
        End While

        cmdreader.Close()
        con.Close()

        NQ = CS

        Cur_Stock.Text = CS.ToString + "/" + TH.ToString
        New_QTY.Text = NQ.ToString + "/" + TH.ToString

        If CS >= TH And CS > 0 Then
            Cur_Stock.BackColor = Color.Green
            New_QTY.BackColor = Color.Green
            Current = True
        ElseIf CS = 0 Then
            Cur_Stock.BackColor = Color.Red
            New_QTY.BackColor = Color.Red
            Current = False
        Else
            Cur_Stock.BackColor = Color.Orange
            New_QTY.BackColor = Color.Orange
            Current = False
        End If

        DTG_SUGGEST.Visible = False
        DTG_SUGGEST.Height = 10

        QTY_HOLDER.Text = 0
        Panel_Num_Controls.Enabled = True

    End Sub

    Private Sub Form_Stock_DB_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Stock_Mode.Text = "Item Screen" Then
            StockSelect()
            FS_RS_TBX.ReadOnly = True
        Else
            FS_RS_TBX.ReadOnly = False
        End If



    End Sub

    Private Sub Form_Stock_DB_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        FS_RS_TBX.Text = ""
        FS_RS_BRAND.Text = ""
        FS_RS_VAR.Text = ""
        FS_RS_SUPP.Text = ""
        Cur_Stock.Text = ""
        Cur_Stock.BackColor = Color.White
        New_QTY.Text = ""
        New_QTY.BackColor = Color.White
        Panel_Num_Controls.Enabled = False
        QTY_HOLDER.Text = 0

        DTG_SUGGEST.Visible = False
        DTG_SUGGEST.Height = 10

        LoadDashDetails()
        DayLog()

    End Sub

    Private Sub FS_RS_TBX_TextChanged(sender As Object, e As EventArgs) Handles FS_RS_TBX.TextChanged

        If Stock_Mode.Text = "Dashboard" Then

            DTG_SUGGEST.Height = 117
            DTG_SUGGEST.Visible = True

            cmd.Parameters.AddWithValue("@searchpara", FS_RS_TBX.Text)
            tableload("SELECT item_id," + Query + " AS 'Details' FROM products WHERE " + Query + " LIKE CONCAT('%',@searchpara,'%')", DTG_ITM_RECC)
            strconn.Close()
            cmd.Parameters.Clear()

            If FS_RS_TBX.Text = "" Then
                Cur_Stock.Text = ""
                Cur_Stock.BackColor = Color.White
                New_QTY.Text = ""
                New_QTY.BackColor = Color.White
                Panel_Num_Controls.Enabled = False
                QTY_HOLDER.Text = 0
                DTG_SUGGEST.Visible = False
                DTG_SUGGEST.Height = 10
            End If

        End If

    End Sub

    'ITEM SELECTION

    Dim CS As Integer
    Dim TH As Integer
    Dim NQ As Integer
    Dim SS As String = ""
    Dim Current As Boolean = False

    Private Sub Item_Table_SelectionChanged(sender As Object, e As EventArgs) Handles DTG_ITM_RECC.CellClick

        Try

            Dashboard.GlobalVariables.Selected_Item = DTG_ITM_RECC.CurrentRow.Cells(0).Value

        Catch ex As NullReferenceException

            Dashboard.GlobalVariables.Selected_Item = 1

        End Try

        StockSelect()

    End Sub

    'CELL SUGGESTIONS

    Private Sub DTG_ITM_RECC_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DTG_ITM_RECC.DataBindingComplete

        DTG_ITM_RECC.ClearSelection()

        DTG_ITM_RECC.RowTemplate.Resizable = False
        DTG_ITM_RECC.Columns(0).Visible = False
        DTG_ITM_RECC.Columns(0).Frozen = True
        DTG_ITM_RECC.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DTG_ITM_RECC.Columns(1).MinimumWidth = 130

        DTG_ITM_RECC.RowTemplate.MinimumHeight = 20

    End Sub

    'QUANTITY CONTROLS

    Dim To_Stock As Integer
    Dim New_Quantity As Integer
    Dim New_Status As String
    Dim RS_Date As Date = Date.Now()
    Dim RS_Date_F As String = RS_Date.ToString("yyyy\-MM\-dd")

    Private Sub FSHS_ADD_BTN_Click(sender As Object, e As EventArgs) Handles FSHS_ADD_BTN.Click

        If QTY_HOLDER.Text = Nothing Then
            QTY_HOLDER.Text = 1
        ElseIf QTY_HOLDER.Text = CS And FORM_LABEL.Text = "STOCK OUT" Then
            MsgBox("Exceeds Inventory Quantity.", MsgBoxStyle.OkOnly, "Insufficient Stock")
        Else
            Dim R_Value As Integer = QTY_HOLDER.Text
            R_Value = R_Value + 1
            QTY_HOLDER.Text = R_Value
        End If

    End Sub

    Private Sub FSHS_MIN_BTN_Click(sender As Object, e As EventArgs) Handles FSHS_MIN_BTN.Click

        If QTY_HOLDER.Text = Nothing Then
            QTY_HOLDER.Text = 0
        ElseIf QTY_HOLDER.Text = 0 Then
            QTY_HOLDER.Text = 0
        Else
            Dim R_Value As Integer = QTY_HOLDER.Text
            R_Value = R_Value - 1
            QTY_HOLDER.Text = R_Value
        End If

    End Sub

    Private Sub QTY_HOLDER_TextChanged_1(sender As Object, e As EventArgs) Handles QTY_HOLDER.TextChanged

        Try

            To_Stock = QTY_HOLDER.Text

            If FORM_LABEL.Text = "RESTOCK ITEM" Then

                New_QTY.Text = (NQ + To_Stock).ToString + "/" + TH.ToString

                If (NQ + To_Stock) >= TH And (NQ + To_Stock) > 0 Then
                    New_QTY.BackColor = Color.Green
                    New_Status = "Normal"
                ElseIf (NQ + To_Stock) = 0 Then
                    New_QTY.BackColor = Color.Red
                    New_Status = "Out of Stock"
                Else
                    New_QTY.BackColor = Color.Orange
                    New_Status = "Low Stock"
                End If

                New_Quantity = NQ + To_Stock

            ElseIf FORM_LABEL.Text = "STOCK OUT" Then

                If QTY_HOLDER.Text > CS Then
                    MsgBox("Exceeds Inventory Quantity.", MsgBoxStyle.OkOnly, "Insufficient Stock")
                    QTY_HOLDER.Text = CS
                End If

                New_QTY.Text = (NQ - To_Stock).ToString + "/" + TH.ToString

                If (NQ - To_Stock) >= TH And (NQ + To_Stock) > 0 Then
                    New_QTY.BackColor = Color.Green
                    New_Status = "Normal"
                ElseIf (NQ - To_Stock) = 0 Then
                    New_QTY.BackColor = Color.Red
                    New_Status = "Out of Stock"
                Else
                    New_QTY.BackColor = Color.Orange
                    New_Status = "Low Stock"
                End If

                New_Quantity = NQ - To_Stock

            End If

        Catch ex As InvalidCastException

            If QTY_HOLDER.Text = Nothing Then
                QTY_HOLDER.Text = ""
            Else
                MsgBox("Please Enter a Number!", MsgBoxStyle.OkOnly, "Warning!")
            End If



        End Try

    End Sub

    Private Sub FI_BTN_CANCEL_Click(sender As Object, e As EventArgs) Handles FI_BTN_CANCEL.Click

        Try
            Me.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub FI_BTN_SAVE_Click(sender As Object, e As EventArgs) Handles FI_BTN_SAVE.Click

        Dim Log_Token As Integer
        Dim LogItemName As String = FS_RS_TBX.Text + " | " + FS_RS_BRAND.Text + " | " + FS_RS_VAR.Text + " | " + FS_RS_SUPP.Text
        Dim PreValue As Double


        opencon()

        cmd.Connection = con
        cmd.CommandText = "Select item_p_cost FROM products WHERE item_id = '" & Dashboard.GlobalVariables.Selected_Item & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            PreValue = cmdreader.GetValue(0)
        End While

        cmd.Parameters.Clear()

        cmdreader.Close()
        con.Close()


        Stock_Function(New_Quantity, New_Status, RS_Date_F, TH, Current)

        Dim LogValue As Double = To_Stock * PreValue

        If FORM_LABEL.Text = "RESTOCK ITEM" Then
            Log_Token = 2
        ElseIf FORM_LABEL.Text = "STOCK OUT" Then
            Log_Token = 3
        End If

        Log_entry(Log_Token, To_Stock, LogItemName, LogValue)

        Dashboard.LoadMain()

    End Sub

End Class