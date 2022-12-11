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



End Module
