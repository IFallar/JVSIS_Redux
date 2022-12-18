Public Class Form_Log_In

    Dim acc_id As String
    Dim acc_type As String
    Dim userpass As String
    Dim valid As Boolean = True

    Private Sub log_in_Click(sender As Object, e As EventArgs) Handles log_in.Click

        opencon()

        cmd.Parameters.Clear()

        cmd.Connection = con
        cmd.Parameters.AddWithValue("@username", userName.Text)
        cmd.Parameters.AddWithValue("@password", pass.Text)
        cmd.CommandText = "SELECT `account_id`, `user_name`, `acc_pass`, `acc_level` FROM `account` WHERE user_name = @username AND acc_pass = @password"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                acc_id = cmdreader.GetValue(0)
                acc_type = cmdreader.GetValue(3)
                userpass = cmdreader.GetValue(2)
                valid = True

            Catch ex As System.InvalidCastException

                MessageBox.Show("Account Does Not Exist")

            End Try

        End While

        If pass.Text = userpass Then

            If acc_type = "admin" Then

                Dim a As New Dashboard

                Dashboard.acc_name_lbl.Text = userName.Text
                Dashboard.acc_type_lbl.Text = "Admin"
                Dashboard.GlobalVariables.logged_priv = 0
                Dashboard.GlobalVariables.UserID = acc_id
                Dashboard.GlobalVariables.logged = 1
                MessageBox.Show("Welcome " + userName.Text + "!")

                Me.Hide()

                userName.Text = "USERNAME"
                userName.ForeColor = Color.Silver
                pass.Text = "PASSWORD"
                pass.ForeColor = Color.Silver
                PictureBox2.Image = My.Resources.account_ico

                Dashboard.Show_Home()

            ElseIf acc_type = "user" Then

                Dim a As New Dashboard

                Dashboard.acc_name_lbl.Text = userName.Text
                Dashboard.acc_type_lbl.Text = "User"
                Dashboard.GlobalVariables.logged_priv = 1
                Dashboard.GlobalVariables.UserID = acc_id
                Dashboard.GlobalVariables.logged = 1
                MessageBox.Show("Welcome " + userName.Text + "!")

                Me.Hide()

                userName.Text = "USERNAME"
                userName.ForeColor = Color.Silver
                pass.Text = "PASSWORD"
                pass.ForeColor = Color.Silver
                PictureBox2.Image = My.Resources.account_ico

                Dashboard.Show_Home()

            End If

        Else

            MessageBox.Show("Invalid Credentials")

        End If

        cmdreader.Close()
        con.Close()

    End Sub

    Private Sub USERNAME_ENTER(sender As Object, e As EventArgs) Handles userName.Enter
        If userName.Text = "USERNAME" Then
            userName.Text = ""
            userName.ForeColor = Color.Black
        End If

    End Sub

    Private Sub USERNAME_LEAVE(sender As Object, e As EventArgs) Handles userName.Leave
        If userName.Text = "" Then
            userName.Text = "USERNAME"
            userName.ForeColor = Color.Silver

        End If
    End Sub

    Private Sub PASSWORD_ENTER(sender As Object, e As EventArgs) Handles pass.Enter

        If pass.Text = "PASSWORD" Then
            pass.Text = ""
            pass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub PASSWORD_LEAVE(sender As Object, e As EventArgs) Handles pass.Leave

        If pass.Text = "" Then
            pass.Text = "PASSWORD"
            pass.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

End Class