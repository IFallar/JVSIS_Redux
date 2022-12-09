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



    '===================================================================================================================================

End Class
