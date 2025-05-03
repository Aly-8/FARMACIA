Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Pqc.Crypto.Frodo
Public Class Login
    Dim Username As String
    Dim Password As String
    Dim Role As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Application.Exit()
    End Sub
    Private Sub login_bttn_Click(sender As Object, e As EventArgs) Handles login_bttn.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim found As Boolean = False
            cmd = New MySqlCommand("SELECT * FROM `tbluser` WHERE `Username`='" & Txt_Username.Text & "' AND `Password`='" & Txt_Password.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                Username = dr.Item("Username").ToString
                Password = dr.Item("Password").ToString
                Role = dr.Item("Role").ToString
            Else
                found = False
                Username = ""
                Password = ""
                Role = ""
            End If
            If found = True Then
                If StrComp(Txt_Username.Text, Username, CompareMethod.Binary) Or StrComp(Txt_Password.Text, Password, CompareMethod.Binary) Then
                    MsgBox("Warning : Wrong Username or Password!", vbExclamation)
                    Return
                Else
                    If UCase(Role) = "ADMIN" Then
                        Me.Hide()
                        Dashboard.Show()
                    ElseIf UCase(Role) = "CASHIER" Then
                        Me.Hide()
                        Cashier.Show()
                    End If
                End If
            Else
                MsgBox("Warning : Wrong Username or Password!", vbExclamation)
            End If
            Txt_Password.Clear()
            Txt_Username.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub fdg_Click(sender As Object, e As EventArgs) Handles fdg.Click

    End Sub

    Private Sub Password_lbl_TextChanged(sender As Object, e As EventArgs) Handles Txt_Password.TextChanged

    End Sub

    Private Sub Username_lbl_TextChanged(sender As Object, e As EventArgs) Handles Txt_Username.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class