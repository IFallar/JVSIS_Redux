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

    Private Sub Form_Reports_Load(sender As Object, e As EventArgs) Handles Me.Load

        OutValue(7)

    End Sub

    Private Sub RetrievedItems_GridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles RetrievedItems_GridView.DataBindingComplete

        RetrievedItems_GridView.ClearSelection()

        RetrievedItems_GridView.RowTemplate.Resizable = False
        RetrievedItems_GridView.Columns(0).Visible = False

        RetrievedItems_GridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        RetrievedItems_GridView.RowTemplate.MinimumHeight = 30
        RetrievedItems_GridView.Sort(RetrievedItems_GridView.Columns(0), ListSortDirection.Descending)

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

End Class