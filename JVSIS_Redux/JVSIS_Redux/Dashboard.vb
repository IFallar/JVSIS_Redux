Imports System.ComponentModel

Public Class Dashboard

    Public Class GlobalVariables

        '={DESIGN RELATED]===========================

        Public Shared Active_Panel = 0

        '=[ITEM RELATED]=============================

        Public Shared Selected_Item As Integer

        '=[USER RELATED]=============================

        Public Shared UserID As Integer = 1
        Public Shared logged_priv As Integer = 1
        Public Shared logged As Integer = 1

        '=[MODE RELATED]=============================


    End Class

    Dim TableQuery As String = "SELECT `item_id`, `item_name` AS 'Product Name', (SELECT brand_name FROM brands WHERE brand_id = `item_brand`) AS 'Brand', (SELECT variant_name FROM variants WHERE variant_id = `item_variant` ) AS 'Variant', (SELECT category_name FROM category WHERE category_id = `item_category` ) AS 'Category', `item_p_cost` AS 'Cost', `item_s_cost_min` AS 'Min Price', `item_s_cost_max` AS 'Max Price', `item_qty` AS 'Quantity',`item_stock_status` AS 'Stock Level', (item_p_cost * item_qty) AS 'Total',  (SELECT supplier_name FROM supplier WHERE supplier_id = `item_supplier` ) as 'Supplier', `item_last_restock` AS 'Last Restock' FROM `products`"

    Public Sub LoadMain()


        Dim Query1 As String = ""
        Dim Query2 As String = ""

        If FILTER_CAT.SelectedIndex = 1 Then

            Query1 = "SELECT brand_id FROM brands WHERE brand_name = @filval"
            Query2 = TableQuery + "WHERE item_brand"

            GetSingleParam(Query1, Query2)

        ElseIf FILTER_CAT.SelectedIndex = 2 Then

            Query1 = "SELECT category_id FROM category WHERE category_name = @filval"
            Query2 = TableQuery + "WHERE item_category"

            GetSingleParam(Query1, Query2)

        ElseIf FILTER_CAT.SelectedIndex = 3 Then

            Query1 = "SELECT supplier_id FROM supplier WHERE supplier_name = @filval"
            Query2 = TableQuery + "WHERE item_supplier"

            GetSingleParam(Query1, Query2)

        ElseIf FILTER_CAT.SelectedIndex = 4 Then

            tableload(TableQuery + "WHERE item_stock_status  = '" & FILTER_VAL.Text & "'", Item_Table)
            strconn.Close()

        Else
            tableload(TableQuery, Item_Table)
            strconn.Close()
        End If


    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadDashDetails()

        tableload("SELECT account_id, user_name, acc_level FROM account", Acc_List_Grid)
        strconn.Close()

    End Sub

    '=[SIDE BUTTONS]====================================================================================================================

    Private Sub BTN_Side_Home_Click(sender As Object, e As EventArgs) Handles BTN_Side_Home.Click

        Panel_Home.Visible = True
        Panel_Items.Visible = False
        Panel_History.Visible = False
        Panel_Settings.Visible = False

        BTN_Side_Home.BackColor = System.Drawing.Color.White
        BTN_Side_Items.BackColor = System.Drawing.Color.Transparent
        BTN_Side_Logs.BackColor = System.Drawing.Color.Transparent
        BTN_Side_Settings.BackColor = System.Drawing.Color.Transparent

        BTN_Side_Home.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        BTN_Side_Items.ForeColor = System.Drawing.Color.White
        BTN_Side_Logs.ForeColor = System.Drawing.Color.White
        BTN_Side_Settings.ForeColor = System.Drawing.Color.White

        BTN_Side_Home.FlatAppearance.MouseOverBackColor = Color.White
        BTN_Side_Items.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)
        BTN_Side_Logs.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)
        BTN_Side_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)

    End Sub

    Private Sub BTN_Side_Items_Click(sender As Object, e As EventArgs) Handles BTN_Side_Items.Click

        Panel_Home.Visible = False
        Panel_Items.Visible = True
        Panel_History.Visible = False
        Panel_Settings.Visible = False

        BTN_Side_Home.BackColor = System.Drawing.Color.Transparent
        BTN_Side_Items.BackColor = System.Drawing.Color.White
        BTN_Side_Logs.BackColor = System.Drawing.Color.Transparent
        BTN_Side_Settings.BackColor = System.Drawing.Color.Transparent

        BTN_Side_Home.ForeColor = System.Drawing.Color.White
        BTN_Side_Items.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        BTN_Side_Logs.ForeColor = System.Drawing.Color.White
        BTN_Side_Settings.ForeColor = System.Drawing.Color.White

        BTN_Side_Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)
        BTN_Side_Items.FlatAppearance.MouseOverBackColor = Color.White
        BTN_Side_Logs.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)
        BTN_Side_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)

        LoadMain()

    End Sub

    Private Sub BTN_Side_Logs_Click(sender As Object, e As EventArgs) Handles BTN_Side_Logs.Click

        Panel_Home.Visible = False
        Panel_Items.Visible = False
        Panel_History.Visible = True
        Panel_Settings.Visible = False

        BTN_Side_Home.BackColor = System.Drawing.Color.Transparent
        BTN_Side_Items.BackColor = System.Drawing.Color.Transparent
        BTN_Side_Logs.BackColor = System.Drawing.Color.White
        BTN_Side_Settings.BackColor = System.Drawing.Color.Transparent

        BTN_Side_Home.ForeColor = System.Drawing.Color.White
        BTN_Side_Items.ForeColor = System.Drawing.Color.White
        BTN_Side_Logs.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        BTN_Side_Settings.ForeColor = System.Drawing.Color.White

        BTN_Side_Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)
        BTN_Side_Items.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)
        BTN_Side_Logs.FlatAppearance.MouseOverBackColor = Color.White
        BTN_Side_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)

        tableload(LogQuery, Log_View_Grid)
        LoadLogDash()
        strconn.Close()

    End Sub

    Private Sub BTN_Side_Settings_Click(sender As Object, e As EventArgs) Handles BTN_Side_Settings.Click

        Panel_Home.Visible = False
        Panel_Items.Visible = False
        Panel_History.Visible = True
        Panel_Settings.Visible = True

        BTN_Side_Home.BackColor = System.Drawing.Color.Transparent
        BTN_Side_Items.BackColor = System.Drawing.Color.Transparent
        BTN_Side_Logs.BackColor = System.Drawing.Color.Transparent
        BTN_Side_Settings.BackColor = System.Drawing.Color.White

        BTN_Side_Home.ForeColor = System.Drawing.Color.White
        BTN_Side_Items.ForeColor = System.Drawing.Color.White
        BTN_Side_Logs.ForeColor = System.Drawing.Color.White
        BTN_Side_Settings.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)

        BTN_Side_Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)
        BTN_Side_Items.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)
        BTN_Side_Logs.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 50)
        BTN_Side_Settings.FlatAppearance.MouseOverBackColor = Color.White

        GetUserInfo()

    End Sub


    '===================================================================================================================================

    '=[DASHBOARD]=======================================================================================================================

    Private Sub HOME_BTN_ADDITEM_Click(sender As Object, e As EventArgs) Handles HOME_BTN_ADDITEM.Click

        Try
            Dim Modal As New Form_Item
            Form_Item.FORM_LABEL.Text = "ADD NEW ITEM"
            Form_Item.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ITM_BTN_DELETE_Click(sender As Object, e As EventArgs) Handles ITM_BTN_DELETE.Click

        Try

            Dim delete = MsgBox("Are you sure you want delete the selected item?", MsgBoxStyle.YesNo, "Delete Item")

            If delete = MsgBoxResult.Yes Then

                strconnection()

                cmd.Connection = strconn
                strconn.Open()

                cmd.CommandText = "DELETE FROM `products` WHERE item_id = '" & Dashboard.GlobalVariables.Selected_Item & "'"
                cmd.ExecuteNonQuery()
                strconn.Close()

                LoadDashDetails()
                LoadMain()

            ElseIf delete = MsgBoxResult.No Then

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ITM_BTN_EDIT_Click(sender As Object, e As EventArgs) Handles ITM_BTN_EDIT.Click

        Try
            Dim Modal As New Form_Item
            Form_Item.FORM_LABEL.Text = "UPDATE ITEM DETAILS"
            Form_Item.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub HOME_BTN_IN_Click(sender As Object, e As EventArgs) Handles HOME_BTN_IN.Click

        Try
            Dim Modal As New Form_Stock_DB
            Form_Stock_DB.FORM_LABEL.Text = "RESTOCK ITEM"
            Form_Stock_DB.Stock_Mode.Text = "Dashboard"
            Form_Stock_DB.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub HOME_BTN_OUT_Click(sender As Object, e As EventArgs) Handles HOME_BTN_OUT.Click

        Try
            Dim Modal As New Form_Stock_DB
            Form_Stock_DB.FORM_LABEL.Text = "STOCK OUT"
            Form_Stock_DB.Stock_Mode.Text = "Dashboard"
            Form_Stock_DB.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    '===================================================================================================================================

    '=[ITEM SCREEN]=====================================================================================================================

    Private Sub ITM_BTN_NEW_Click(sender As Object, e As EventArgs) Handles ITM_BTN_NEW.Click

        Try
            Dim Modal As New Form_Item
            Form_Item.FORM_LABEL.Text = "ADD NEW ITEM"
            Form_Item.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ITM_BTN_STOCKIN_Click(sender As Object, e As EventArgs) Handles ITM_BTN_STOCKIN.Click

        Try
            Dim Modal As New Form_Stock_DB
            Form_Stock_DB.FORM_LABEL.Text = "RESTOCK ITEM"
            Form_Stock_DB.Stock_Mode.Text = "Item Screen"
            Form_Stock_DB.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ITM_BTN_STOCKOUT_Click(sender As Object, e As EventArgs) Handles ITM_BTN_STOCKOUT.Click

        Try
            Dim Modal As New Form_Stock_DB
            Form_Stock_DB.FORM_LABEL.Text = "STOCK OUT"
            Form_Stock_DB.Stock_Mode.Text = "Item Screen"
            Form_Stock_DB.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    'TABLE FORMATTING

    Private Sub Item_Table_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Item_Table.DataBindingComplete

        Item_Table.ClearSelection()

        Item_Table.RowTemplate.Resizable = False
        Item_Table.Columns(0).Visible = False
        Item_Table.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Item_Table.Columns(1).MinimumWidth = 130

        Item_Table.Columns(5).ValueType = GetType(Double)
        Item_Table.Columns(5).DefaultCellStyle.Format = "N2"
        Item_Table.Columns(6).ValueType = GetType(Double)
        Item_Table.Columns(6).DefaultCellStyle.Format = "N2"
        Item_Table.Columns(7).ValueType = GetType(Double)
        Item_Table.Columns(7).DefaultCellStyle.Format = "N2"
        Item_Table.Columns(10).ValueType = GetType(Double)
        Item_Table.Columns(10).DefaultCellStyle.Format = "N2"

        Item_Table.RowTemplate.MinimumHeight = 50

    End Sub

    Private Sub Item_Table_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Item_Table.CellFormatting

        If e.ColumnIndex = 9 And e.Value IsNot Nothing Then
            Dim content As String = e.Value
            If content = "Low Stock" Then
                e.CellStyle.BackColor = Color.Orange
            ElseIf content = "Out of Stock" Then
                e.CellStyle.BackColor = Color.Red
            Else
                e.CellStyle.BackColor = Color.Green
            End If
        End If

    End Sub

    Private Sub Item_Table_SelectionChanged(sender As Object, e As EventArgs) Handles Item_Table.SelectionChanged

        Try
            GlobalVariables.Selected_Item = Item_Table.CurrentRow.Cells(0).Value

        Catch ex As NullReferenceException

            GlobalVariables.Selected_Item = 1

        End Try

    End Sub

    'FILTER SETTING

    Private Sub FILTER_CAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FILTER_CAT.SelectedIndexChanged

        FILTER_VAL.Items.Clear()
        FILTER_VAL.Text = "All"

        If FILTER_CAT.SelectedIndex = 0 Then

            FILTER_PANEL.Width = 150

        ElseIf FILTER_CAT.SelectedIndex = 1 Then

            FILTER_PANEL.Width = 300

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT brand_name FROM (brands)"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                Dim filter_list = cmdreader.GetString("brand_name")
                FILTER_VAL.Items.Add(filter_list)
            End While

            cmdreader.Close()
            con.Close()

        ElseIf FILTER_CAT.SelectedIndex = 2 Then

            FILTER_PANEL.Width = 300

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT category_name FROM category"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                Dim filter_list = cmdreader.GetString("category_name")
                FILTER_VAL.Items.Add(filter_list)
            End While

            cmdreader.Close()
            con.Close()

        ElseIf FILTER_CAT.SelectedIndex = 3 Then

            FILTER_PANEL.Width = 300

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT supplier_name FROM supplier"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                Dim filter_list = cmdreader.GetString("supplier_name")
                FILTER_VAL.Items.Add(filter_list)
            End While

            cmdreader.Close()
            con.Close()

        ElseIf FILTER_CAT.SelectedIndex = 4 Then

            FILTER_PANEL.Width = 300

            FILTER_VAL.Items.Add("Normal")
            FILTER_VAL.Items.Add("Low Stock")
            FILTER_VAL.Items.Add("Out of Stock")

        End If

    End Sub

    Private Sub FILTER_VAL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FILTER_VAL.SelectedIndexChanged

        LoadMain()

    End Sub

    Private Sub ITM_FLTR_BTN_Click(sender As Object, e As EventArgs) Handles ITM_FLTR_BTN.Click

        FILTER_CAT.SelectedIndex = 0
        FILTER_CAT.Text = "All"
        FILTER_VAL.Text = "All"
        FILTER_VAL.Items.Clear()

        LoadMain()

    End Sub

    Private Sub ITM_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles ITM_SEARCH.TextChanged

        FILTER_CAT.SelectedIndex = 0
        FILTER_CAT.Text = "All"
        FILTER_VAL.Text = "All"
        FILTER_VAL.Items.Clear()

        cmd.Parameters.AddWithValue("@search", ITM_SEARCH.Text)

        tableload(TableQuery + "WHERE CONCAT(item_name, ' ', (SELECT brand_name FROM brands WHERE brand_id = item_brand),' ',   (SELECT variant_name FROM variants WHERE variant_id = item_variant),' ',  (SELECT supplier_name FROM supplier WHERE supplier_id = item_supplier)) LIKE CONCAT('%',@search,'%')", Item_Table)
        strconn.Close()

        cmd.Parameters.Clear()

    End Sub

    '=[HISTORY SCREEN]=====================================================================================================================

    Private Sub RangeSetButton_Click(sender As Object, e As EventArgs) Handles RangeSetButton.Click

        If RangeSetButton.Text = ">" Then

            RangeSetButton.Text = "<"
            DateRangeHolder.Width = 324
            Range_Box.Width = 0

        ElseIf RangeSetButton.Text = "<" Then

            RangeSetButton.Text = ">"
            DateRangeHolder.Width = 26
            Range_Box.Width = 155

        End If

    End Sub

    Dim LogQuery As String = "SELECT `log_id`, (SELECT user_name FROM account WHERE account_id = acc_id) AS 'User', `item` AS 'Item', `type` AS 'Action', `c_qty` AS 'Change', (SELECT TIME_FORMAT(l_time, '%h:%i %p')) AS 'Time', `l_date` AS 'Date' FROM `transaction_log`"


    Private Sub Log_Search_TextChanged(sender As Object, e As EventArgs) Handles Log_Search.TextChanged


        Dim Date_Upper As String = UpperDate.Value.ToString("yyyy\-MM\-dd")
        Dim Date_Lower As String = LowerDate.Value.ToString("yyyy\-MM\-dd")

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@search", Log_Search.Text)
        cmd.Parameters.AddWithValue("@update", Date_Upper)
        cmd.Parameters.AddWithValue("@lodate", Date_Lower)

        If Log_Search.Text = "" Then

            If Range_CBX.Text = "All:" Then

                tableload(LogQuery + "WHERE (SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%')", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            ElseIf Range_CBX.Text = "7 Days" Then

                tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 7 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            ElseIf Range_CBX.Text = "14 Days" Then

                tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 14 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            ElseIf Range_CBX.Text = "30 Days" Then

                tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 30 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            ElseIf Range_CBX.Text = "6 Months" Then

                tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 180 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            ElseIf Range_CBX.Text = "1 Year" Then

                tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 365 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            End If

        Else

            If RangeSetButton.Text = ">" Then

                If Range_CBX.Text = "All:" Then

                    tableload(LogQuery + "WHERE (SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%')", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "7 Days" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 7 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "14 Days" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 14 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "30 Days" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 30 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "6 Months" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 180 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "1 Year" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 365 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                End If

            ElseIf RangeSetButton.Text = "<" Then

                tableload(LogQuery + "WHERE l_date between @lodate and @update AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            End If

        End If

    End Sub

    Private Sub Range_CBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Range_CBX.SelectedIndexChanged

        Dim Date_Upper As String = UpperDate.Value.ToString("yyyy\-MM\-dd")
        Dim Date_Lower As String = LowerDate.Value.ToString("yyyy\-MM\-dd")

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@search", Log_Search.Text)
        cmd.Parameters.AddWithValue("@update", Date_Upper)
        cmd.Parameters.AddWithValue("@lodate", Date_Lower)

        If Log_Search.Text = "" Then

            If Range_CBX.Text = "All:" Then

                tableload(LogQuery + "WHERE (SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%')", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            ElseIf Range_CBX.Text = "7 Days" Then

                tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 7 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            ElseIf Range_CBX.Text = "14 Days" Then

                tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 14 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            ElseIf Range_CBX.Text = "30 Days" Then

                tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 30 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            ElseIf Range_CBX.Text = "6 Months" Then

                tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 180 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            ElseIf Range_CBX.Text = "1 Year" Then

                tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 365 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            End If

        Else

            If RangeSetButton.Text = ">" Then

                If Range_CBX.Text = "All:" Then

                    tableload(LogQuery + "WHERE (SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%')", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "7 Days" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 7 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "14 Days" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 14 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "30 Days" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 30 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "6 Months" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 180 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "1 Year" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 365 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                End If

            ElseIf RangeSetButton.Text = "<" Then

                tableload(LogQuery + "WHERE l_date between @lodate and @update AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            End If

        End If

    End Sub

    Private Sub UpperDate_ValueChanged(sender As Object, e As EventArgs) Handles UpperDate.ValueChanged, LowerDate.ValueChanged

        Dim Date_Upper As String = UpperDate.Value.ToString("yyyy\-MM\-dd")
        Dim Date_Lower As String = LowerDate.Value.ToString("yyyy\-MM\-dd")

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@search", Log_Search.Text)
        cmd.Parameters.AddWithValue("@update", Date_Upper)
        cmd.Parameters.AddWithValue("@lodate", Date_Lower)

        If Log_Search.Text = "" Then

            tableload(LogQuery + "WHERE l_date between @lodate and @update AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
            strconn.Close()

            cmd.Parameters.Clear()

        Else

            If RangeSetButton.Text = ">" Then

                If Range_CBX.Text = "All:" Then

                    tableload(LogQuery + "WHERE (SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%')", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "7 Days" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 7 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "14 Days" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 14 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "30 Days" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 30 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "6 Months" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 180 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                ElseIf Range_CBX.Text = "1 Year" Then

                    tableload(LogQuery + "WHERE l_date >= DATE(NOW() - INTERVAL 365 DAY) AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                    strconn.Close()

                    cmd.Parameters.Clear()

                End If

            ElseIf RangeSetButton.Text = "<" Then

                tableload(LogQuery + "WHERE l_date between @lodate and @update AND ((SELECT user_name FROM account WHERE account_id = acc_id) LIKE CONCAT('%',@search,'%') OR item LIKE CONCAT('%',@search,'%') OR type LIKE CONCAT('%',@search,'%'))", Log_View_Grid)
                strconn.Close()

                cmd.Parameters.Clear()

            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Range_CBX.Text = "All:"
        Log_Search.Text = ""
        UpperDate.Value = Date.Now()
        LowerDate.Value = Date.Now()

        tableload(LogQuery, Log_View_Grid)
        strconn.Close()

    End Sub

    Private Sub Log_View_Grid_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Log_View_Grid.DataBindingComplete

        Log_View_Grid.ClearSelection()

        Log_View_Grid.RowTemplate.Resizable = False
        Log_View_Grid.Columns(0).Visible = False
        Log_View_Grid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Log_View_Grid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Log_View_Grid.RowTemplate.MinimumHeight = 40

        Log_View_Grid.Sort(Log_View_Grid.Columns(0), ListSortDirection.Descending)

    End Sub

    '=[SETTINGS SCREEN]=====================================================================================================================

    Private Sub Acc_List_Grid_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Acc_List_Grid.DataBindingComplete

        Acc_List_Grid.ClearSelection()

        Acc_List_Grid.RowTemplate.Resizable = False
        Acc_List_Grid.Columns(0).Visible = False
        Acc_List_Grid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Acc_List_Grid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Acc_List_Grid.RowTemplate.MinimumHeight = 40

    End Sub


    Private Sub Account_Set_BTN_Click(sender As Object, e As EventArgs) Handles Account_Set_BTN.Click

        If Account_Set_BTN.Text = "Show Settings" Then
            Account_Set_BTN.Text = "Hide Settings"
            Account_Panel.Height = 315
        ElseIf Account_Set_BTN.Text = "Hide Settings" Then
            Account_Set_BTN.Text = "Show Settings"
            Account_Panel.Height = 50
        End If

        tableload("SELECT account_id, user_name, acc_level FROM account", Acc_List_Grid)
        strconn.Close()

    End Sub

    Private Sub Account_Del_Click(sender As Object, e As EventArgs) Handles Account_Del.Click

        If Account_Del.Text = "Edit" And GlobalVariables.logged_priv = 1 Then

            Account_Del.Text = "Cancel"
            Account_SV.Text = "Update"
            Account_SV.Visible = True
            Account_CNC.Visible = True

            SplitContainer2.Panel1.Enabled = True

        ElseIf Account_Del.Text = "Cancel" And GlobalVariables.logged_priv = 1 Then

            Account_Del.Text = "Edit"
            Account_SV.Text = "Save"
            Account_CNC.Visible = False
            Account_SV.Visible = False

            SplitContainer2.Panel1.Enabled = False

            tableload("SELECT account_id, user_name, acc_level FROM account", Acc_List_Grid)
            strconn.Close()

        End If

    End Sub

    Private Sub Account_Add_Click(sender As Object, e As EventArgs) Handles Account_Add.Click

        If GlobalVariables.logged_priv = 1 Then

            TBX_FNAME.Text = ""
            TBX_LNAME.Text = ""
            TBX_Username.Text = ""
            TBX_PASSWORD.Text = ""
            CBX_Type.Text = ""
            TBX_EMAIL.Text = ""
            TBX_NUMBER.Text = ""

            Account_CNC.Text = "Cancel"
            Account_SV.Text = "Add+"
            Account_SV.Visible = True
            Account_CNC.Visible = True
            Account_Del.Visible = False

            SplitContainer2.Panel1.Enabled = True

            tableload("SELECT account_id, user_name, acc_level FROM account", Acc_List_Grid)
            strconn.Close()

        End If

    End Sub

    Private Sub Account_CNC_Click(sender As Object, e As EventArgs) Handles Account_CNC.Click

        If Account_CNC.Text = "Delete" And GlobalVariables.logged_priv = 1 Then



        ElseIf Account_CNC.Text = "Cancel" And GlobalVariables.logged_priv = 1 Then

            Account_Del.Text = "Edit"
            Account_CNC.Text = "Delete"
            Account_SV.Text = "Save"
            Account_SV.Visible = False
            Account_Del.Visible = True
            Account_CNC.Visible = False

            SplitContainer2.Panel1.Enabled = False

            GetUserInfo()

        End If



        tableload("SELECT account_id, user_name, acc_level FROM account", Acc_List_Grid)
        strconn.Close()

    End Sub

    Private Sub Account_SV_Click(sender As Object, e As EventArgs) Handles Account_SV.Click

        If Account_SV.Text = "Add+" And GlobalVariables.logged_priv = 1 Then

        ElseIf Account_SV.Text = "Update" And GlobalVariables.logged_priv = 1 Then

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BVS_Set_btn.Click

        If BVS_Set_btn.Text = "Show Settings" Then
            BVS_Set_btn.Text = "Hide Settings"
            BVS_Panel.Height = 365
        ElseIf BVS_Set_btn.Text = "Hide Settings" Then
            BVS_Set_btn.Text = "Show Settings"
            BVS_Panel.Height = 49
        End If

    End Sub













    '===================================================================================================================================



End Class
