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



    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadDashDetails()
        LoadMain()

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

    '===================================================================================================================================

    '=[ITEM SCREEN]=====================================================================================================================

    'TABLE FORMATTING

    Private Sub Item_Table_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Item_Table.DataBindingComplete

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
        Item_Table.Columns(9).ValueType = GetType(Double)
        Item_Table.Columns(9).DefaultCellStyle.Format = "N2"

        Item_Table.RowTemplate.MinimumHeight = 50

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
            cmd.CommandText = "SELECT supplier_name FROM suppliers"
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


    '===================================================================================================================================



End Class
