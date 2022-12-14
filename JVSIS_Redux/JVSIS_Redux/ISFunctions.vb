Imports MySql.Data.MySqlClient
Imports System.Runtime.CompilerServices

Module ISFunctions

    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    Sub opencon()
        con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=jvsis_database"
        con.Open()
    End Sub

    Public Function strconnection() As MySqlConnection
        Dim MsqlConn As MySqlConnection
        MsqlConn = New MySqlConnection
        MsqlConn.ConnectionString = "server=localhost;port=3306;username=root;password=;database=jvsis_database"
        Return MsqlConn
    End Function

    Public strconn As MySqlConnection = strconnection()
    Public res As String
    Public cmdreader As MySqlDataReader
    Public adapter As New MySqlDataAdapter
    Public table As New DataTable

    Public Sub tableload(ByVal sql As String, ByVal dtg As Object)

        Try
            table = New DataTable
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = sql
            End With

            adapter.SelectCommand = cmd
            adapter.Fill(table)
            dtg.DataSource = table

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconnection.Close()
        adapter.Dispose()
    End Sub

    Public Sub AddItem()



    End Sub

    'VALIDATION

    Public Sub CheckInput_N(e, sender)

        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))

    End Sub

    Public Sub LoadDashDetails()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT (SELECT SUM(item_qty * item_p_cost) FROM products WHERE 1) AS 'Inventory Value',(SELECT COUNT(item_id) FROM products WHERE 1) as 'Item Count', (SELECT COUNT(item_id) FROM products WHERE item_stock_status = 'Low Stock' OR item_stock_status = 'Out of Stock') AS 'Low Stock', (SELECT (SELECT SUM((SELECT item_p_cost FROM products WHERE item_id = item) * (c_qty * -1))) AS 'VALUE' FROM `transaction_log` WHERE `type` = 'Stock Out' AND l_date >= DATE(NOW() - INTERVAL 7 DAY)) AS 'Week Out'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dashboard.TLB_INVENTORY_VALUE_BTN.Text = "P" + String.Format("{0:n}", cmdreader.GetValue(0))
            Dashboard.TLB_ITEMQTY_BTN.Text = cmdreader.GetValue(1)
            Dashboard.TLB_LOWSTOCK_BTN.Text = cmdreader.GetValue(2)

            Dim OutVal As Double = cmdreader.GetValue(3)
            Dashboard.TLB_VALUEOUT_BTN.Text = "P" + String.Format("{0:n}", OutVal)
        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Public Sub GetSingleParam(Query1, Query2)

        Dim FilterVal As String = ""

        opencon()

        cmd.Connection = con
        cmd.Parameters.AddWithValue("@filval", Dashboard.FILTER_VAL.Text)
        cmd.CommandText = Query1
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            FilterVal = cmdreader.GetValue(0)
        End While

        cmd.Parameters.Clear()

        cmdreader.Close()
        con.Close()

        tableload(Query2 + " = '" & FilterVal & "'", Dashboard.Item_Table)
        strconn.Close()

    End Sub

    Public Sub Stock_Function(Quantity, NewStatus, StockDate, Threshold, Current)

        Try

            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@qty", Quantity)
            cmd.Parameters.AddWithValue("@stat", NewStatus)
            cmd.Parameters.AddWithValue("@dat", StockDate)

            cmd.CommandText = "UPDATE `products` SET `item_qty`= @qty, `item_stock_status`= @stat,`item_last_restock`= @dat WHERE item_id = '" & Dashboard.GlobalVariables.Selected_Item & "'"

            cmd.ExecuteNonQuery()

            strconn.Close()

            MsgBox("Quantity Updated", MsgBoxStyle.OkOnly, "Success!")

        Catch ex As Exception

            MessageBox.Show(String.Format("Error: {0}", ex.Message))

        End Try

        If Current = True And Quantity < Threshold Then

            Try

                strconnection()

                cmd.Connection = strconn
                strconn.Open()

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@dat", StockDate)
                cmd.CommandText = "UPDATE `products` SET `item_warn_date`= @dat WHERE item_id = '" & Dashboard.GlobalVariables.Selected_Item & "'"
                cmd.ExecuteNonQuery()
                strconn.Close()

                MsgBox("Item Added to Low Stock List", MsgBoxStyle.OkOnly, "Attention!")

            Catch ex As Exception

                MessageBox.Show(String.Format("Error: {0}", ex.Message))

            End Try

        End If

        LoadDashDetails()

    End Sub

    Public Sub Log_entry(Entry_Token, Change, Item_Name)

        '++++++++++++++++ VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Dim acc_id_log As Integer = Dashboard.GlobalVariables.UserID
        Dim item_log_name As String = Item_Name

        Dim transaction_type As String = ""
        Dim transaction_qty As String = Change

        Dim log_date As Date = Date.Now()
        Dim transaction_date = log_date.ToString("yyyy\-MM\-dd")
        Dim transaction_time As String = TimeOfDay.ToString("HH:mm:ss tt")

        Dim in_out As String = ""

        If Entry_Token = 1 Then

            transaction_type = "New Item"

        ElseIf Entry_Token = 2 Then

            transaction_type = "Restock"
            in_out = "+"

        ElseIf Entry_Token = 3 Then

            transaction_type = "Stock Out"
            in_out = "-"

        ElseIf Entry_Token = 4 Then

            transaction_type = "Edited Info"
            transaction_qty = "---"

        ElseIf Entry_Token = 5 Then

            transaction_type = "Item Deleted"
            transaction_qty = "---"

        ElseIf Entry_Token = 6 Then

            transaction_type = "Flagged"

        End If

        Try

            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@user", acc_id_log)
            cmd.Parameters.AddWithValue("@item", item_log_name)
            cmd.Parameters.AddWithValue("@type", transaction_type)
            cmd.Parameters.AddWithValue("@change", in_out + transaction_qty)
            cmd.Parameters.AddWithValue("@time", transaction_time)
            cmd.Parameters.AddWithValue("@date", transaction_date)
            cmd.CommandText = "INSERT INTO `transaction_log`(`log_id`, `acc_id`, `item`, `type`, `c_qty`, `l_time`, `l_date`) VALUES (DEFAULT, @user, @item, @type, @change, @time, @date)"
            cmd.ExecuteNonQuery()

            strconn.Close()

        Catch ex As Exception

            MessageBox.Show(String.Format("Error: {0}", ex.Message))
            strconn.Close()

        End Try



    End Sub

End Module
