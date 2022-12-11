Public Class Dashboard

    Public Class GlobalVariables

        '={DESIGN RELATED]===========================

        Public Shared Active_Panel = 0

        '=[ITEM RELATED]=============================

        Public Shared Selected_Item As Integer

        '=[USER RELATED]=============================

        Public Shared UserID As Integer
        Public Shared logged_priv As Integer
        Public Shared logged As Integer = 0

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

    Private Sub HOME_BTN_IN_Click(sender As Object, e As EventArgs) Handles HOME_BTN_IN.Click

        Try
            Dim Modal As New Form_Stock_DB
            Form_Stock_DB.FORM_LABEL.Text = "RESTOCK ITEM"
            Form_Stock_DB.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub HOME_BTN_OUT_Click(sender As Object, e As EventArgs) Handles HOME_BTN_OUT.Click

        Try
            Dim Modal As New Form_Stock_DB
            Form_Stock_DB.FORM_LABEL.Text = "STOCK OUT"
            Form_Stock_DB.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    '===================================================================================================================================

    '=[ITEM SCREEN]=====================================================================================================================

    'TABLE FORMATTING

    Private Sub Item_Table_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Item_Table.DataBindingComplete

        Item_Table.ClearSelection()

        Item_Table.RowTemplate.Resizable = False
        Item_Table.Columns(0).Visible = False
        Item_Table.Columns(0).Frozen = True
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








    '===================================================================================================================================



End Class
