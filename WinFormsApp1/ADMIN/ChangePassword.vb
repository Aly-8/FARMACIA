Imports MySql.Data.MySqlClient
Public Class ChangePassword
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click
        If txt_oldpassword.Text = String.Empty Then
            MsgBox("Please enter your OLD password!", vbExclamation)
            Return
        ElseIf txt_newpassword.Text = String.Empty Or txt_reenterPassword.Text = String.Empty Then
            MsgBox("Please enter your NEW password!", vbExclamation)
            Return
        ElseIf StrComp(txt_newpassword.Text, txt_reenterPassword.Text, CompareMethod.Binary) Then
            MsgBox("Password does not match!", vbExclamation)
            Return
        Else
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                cmd = New MySqlCommand("SELECT COUNT(*) FROM `tbluser` WHERE `Password` = @Password", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Password", txt_reenterPassword.Text)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MsgBox("The new password already exists. Please choose a different password.", vbExclamation)
                    Return
                End If
                cmd = New MySqlCommand("UPDATE `tbluser` SET `Password`=@Password WHERE `Password`=@Password1", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Password", txt_reenterPassword.Text)
                cmd.Parameters.AddWithValue("@Password1", txt_oldpassword.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Password Change Success!", vbInformation)
                Else
                    MsgBox("Password Change Failed!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
        txt_newpassword.Clear()
        txt_oldpassword.Clear()
        txt_reenterPassword.Clear()
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Application.Exit()
    End Sub
End Class