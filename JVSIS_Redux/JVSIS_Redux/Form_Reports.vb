Imports System.ComponentModel

Public Class Form_Reports

    Public Sub OutValue(Interval)

        Dim DayInt As Integer = Interval
        tableload("SELECT `log_id`,`item`, SUBSTRING(c_qty,2, LENGTH(c_qty) -1), `l_value`, `l_date` FROM `transaction_log` WHERE type = 'Stock Out' AND l_date >= DATE(NOW() - INTERVAL '" & DayInt & "' DAY)", RetrievedItems_GridView)
        strconn.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT COALESCE((SELECT SUM(SUBSTRING(c_qty,2, LENGTH(c_qty) -1)) FROM transaction_log WHERE type = 'Stock Out' AND l_date >= DATE(NOW() - INTERVAL 7 DAY)), 0), COALESCE((SELECT SUM(l_value) FROM transaction_log WHERE type = 'Stock Out' AND l_date >= DATE(NOW() - INTERVAL '" & DayInt & "' DAY)) ,0)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            LBL_R_UNITS.Text = cmdreader.GetString(0)
            LBL_TV.Text = "P" + String.Format("{0:n}", cmdreader.GetValue(1))

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Public Sub CostList()

        Dim SetString As String = "SELECT COALESCE(SUM(`item_p_cost` * `item_qty`), 0) as 'Total Costs',  COALESCE(SUM(item_to_pay),0) AS 'Liabilities',  COALESCE(SUM(`item_s_cost_min` * `item_qty`),0) as 'Sell Value', COALESCE((SUM((`item_s_cost_min` * `item_qty`) - ( `item_p_cost` * `item_qty`))) - SUM(item_to_pay), 0) AS 'Margins' FROM `products`"


        If Min_Price.Checked Then

            tableload("SELECT CONCAT(`item_name`, ' | ', (SELECT brand_name FROM brands WHERE brand_id = item_brand),' | ', (SELECT variant_name FROM variants WHERE variant_id = item_variant)) AS 'Item', item_qty AS QTY, item_p_cost As 'Purchase Cost', `item_p_cost` * `item_qty` as 'Total Costs',  item_to_pay AS 'Liabilities',  item_s_cost_min AS 'Minimum Sell Price', `item_s_cost_min` * `item_qty` as 'Sell Value', ((`item_s_cost_min` * `item_qty`) - ( `item_p_cost` * `item_qty`)) - item_to_pay AS 'Margins' FROM `products`", InventoryValue_GridView)
            strconn.Close()

            SetString = "SELECT COALESCE(SUM(`item_p_cost` * `item_qty`), 0) as 'Total Costs',  COALESCE(SUM(item_to_pay),0) AS 'Liabilities',  COALESCE(SUM(`item_s_cost_min` * `item_qty`),0) as 'Sell Value', COALESCE((SUM((`item_s_cost_min` * `item_qty`) - ( `item_p_cost` * `item_qty`))) - SUM(item_to_pay), 0) AS 'Margins' FROM `products`"

        ElseIf Max_Price.Checked Then

            tableload("SELECT CONCAT(`item_name`, ' | ', (SELECT brand_name FROM brands WHERE brand_id = item_brand),' | ', (SELECT variant_name FROM variants WHERE variant_id = item_variant)) AS 'Item', item_qty AS QTY, item_p_cost As 'Purchase Cost', `item_p_cost` * `item_qty` as 'Total Costs',  item_to_pay AS 'Liabilities',  item_s_cost_max AS 'Minimum Sell Price', `item_s_cost_max` * `item_qty` as 'Sell Value', ((`item_s_cost_max` * `item_qty`) - ( `item_p_cost` * `item_qty`)) - item_to_pay AS 'Margins' FROM `products`", InventoryValue_GridView)
            strconn.Close()

            SetString = "SELECT COALESCE(SUM(`item_p_cost` * `item_qty`), 0) as 'Total Costs',  COALESCE(SUM(item_to_pay),0) AS 'Liabilities',  COALESCE(SUM(`item_s_cost_max` * `item_qty`),0) as 'Sell Value', COALESCE((SUM((`item_s_cost_max` * `item_qty`) - ( `item_p_cost` * `item_qty`))) - SUM(item_to_pay), 0) AS 'Margins' FROM `products`"

        End If

        opencon()

        cmd.Connection = con
        cmd.CommandText = SetString
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            TLB_COST_VALUE.Text = "P" + String.Format("{0:n}", cmdreader.GetValue(0))
            TLB_LIABILITIES.Text = "P" + String.Format("{0:n}", cmdreader.GetValue(1))
            TLB_SELL_VALUE.Text = "P" + String.Format("{0:n}", cmdreader.GetValue(2))
            TLB_PROFIT_MARGIN.Text = "P" + String.Format("{0:n}", cmdreader.GetValue(3))

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Public Sub StockStatus()

        tableload("SELECT CONCAT(`item_name`, ' | ', (SELECT brand_name FROM brands WHERE brand_id = item_brand),' | ', (SELECT variant_name FROM variants WHERE variant_id = item_variant)) AS 'Item', CONCAT(item_qty, '/', item_threshold) AS 'On Hand / Threshold', item_stock_status as 'Stock Level', item_last_restock AS 'Last Restock', item_warn_date as 'Reached Threshold', ABS(DATEDIFF(item_last_restock, item_warn_date)) AS 'Days', ABS(item_qty - item_threshold) AS 'To Order', ABS(item_qty - item_threshold) * item_p_cost AS 'Restock Cost'  FROM products WHERE item_stock_status = 'Low Stock' OR item_stock_status = 'Out of Stock'", LowStock_GridView)
        strconn.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT (SELECT COUNT(item_id) FROM products WHERE item_stock_status = 'Low Stock'), (SELECT COUNT(item_id) FROM products WHERE item_stock_status = 'Out of Stock'), SUM(ABS(item_qty - item_threshold)) AS 'To Order',  SUM(ABS(item_qty - item_threshold) * item_p_cost) AS 'Restock Cost'  FROM products WHERE item_stock_status = 'Low Stock' OR item_stock_status = 'Out of Stock'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Label10.Text = cmdreader.GetValue(0)
            Label12.Text = cmdreader.GetValue(1)
            Label6.Text = cmdreader.GetValue(2)
            Label8.Text = "P" + String.Format("{0:n}", cmdreader.GetValue(3))

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Private Sub Form_Reports_Load(sender As Object, e As EventArgs) Handles Me.Load

        OutValue(7)
        CostList()
        StockStatus()

    End Sub

    Private Sub Form_Reports_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        DayLog()

    End Sub

    Private Sub RetrievedItems_GridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles RetrievedItems_GridView.DataBindingComplete

        RetrievedItems_GridView.ClearSelection()

        RetrievedItems_GridView.RowTemplate.Resizable = False
        RetrievedItems_GridView.Columns(0).Visible = False

        RetrievedItems_GridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        RetrievedItems_GridView.RowTemplate.MinimumHeight = 30
        RetrievedItems_GridView.Sort(RetrievedItems_GridView.Columns(0), ListSortDirection.Descending)

    End Sub

    Private Sub InventoryValue_GridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles InventoryValue_GridView.DataBindingComplete

        InventoryValue_GridView.ClearSelection()

        InventoryValue_GridView.RowTemplate.Resizable = False

        InventoryValue_GridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        InventoryValue_GridView.Columns(0).MinimumWidth = 150
        InventoryValue_GridView.Columns(0).DefaultCellStyle.WrapMode = DataGridViewTriState.True



        InventoryValue_GridView.RowTemplate.MinimumHeight = 30

        InventoryValue_GridView.Columns(2).ValueType = GetType(Double)
        InventoryValue_GridView.Columns(2).DefaultCellStyle.Format = "N2"
        InventoryValue_GridView.Columns(3).ValueType = GetType(Double)
        InventoryValue_GridView.Columns(3).DefaultCellStyle.Format = "N2"
        InventoryValue_GridView.Columns(4).ValueType = GetType(Double)
        InventoryValue_GridView.Columns(4).DefaultCellStyle.Format = "N2"
        InventoryValue_GridView.Columns(5).ValueType = GetType(Double)
        InventoryValue_GridView.Columns(5).DefaultCellStyle.Format = "N2"
        InventoryValue_GridView.Columns(6).ValueType = GetType(Double)
        InventoryValue_GridView.Columns(6).DefaultCellStyle.Format = "N2"
        InventoryValue_GridView.Columns(7).ValueType = GetType(Double)
        InventoryValue_GridView.Columns(7).DefaultCellStyle.Format = "N2"

    End Sub

    Private Sub LowStock_GridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles LowStock_GridView.DataBindingComplete

        InventoryValue_GridView.ClearSelection()

        InventoryValue_GridView.RowTemplate.Resizable = False

        LowStock_GridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        LowStock_GridView.Columns(0).MinimumWidth = 150
        LowStock_GridView.Columns(0).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        LowStock_GridView.Columns(1).Width = 100

        LowStock_GridView.RowTemplate.MinimumHeight = 30

        LowStock_GridView.Columns(7).ValueType = GetType(Double)
        LowStock_GridView.Columns(7).DefaultCellStyle.Format = "N2"

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedIndex = 0 Then
            OutValue(7)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            OutValue(14)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            OutValue(30)
        ElseIf ComboBox1.SelectedIndex = 3 Then
            OutValue(180)
        ElseIf ComboBox1.SelectedIndex = 4 Then
            OutValue(365)
        End If

    End Sub

    Private Sub Min_Price_CheckedChanged(sender As Object, e As EventArgs) Handles Min_Price.CheckedChanged, Max_Price.CheckedChanged

        CostList()

    End Sub



End Class