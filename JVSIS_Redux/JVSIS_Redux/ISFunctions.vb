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



End Module
