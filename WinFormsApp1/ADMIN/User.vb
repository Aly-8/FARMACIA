Imports MySql.Data.MySqlClient
Public Class User
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        dbconn()
    End Sub

    Sub clear()
        Txt_Username.Clear()
        Txt_Password.Clear()
        cbo_usertype.SelectedIndex = -1
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("SELECT COUNT(*) FROM `tbluser` WHERE `Password` = @Password", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Password", Txt_Password.Text)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("The password already exists. Please use a different password.", vbExclamation)
                Exit Sub
            End If

            cmd = New MySqlCommand("INSERT INTO `tbluser`(`Username`, `Password`, `Role`) VALUES (@Username, @Password, @Role)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Username", Txt_Username.Text)
            cmd.Parameters.AddWithValue("@Password", Txt_Password.Text)
            cmd.Parameters.AddWithValue("@Role", cbo_usertype.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New User Added Successfully!", vbInformation)
            Else
                MsgBox("Failed to Add New User.", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        clear()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Dashboard_btn_Click(sender As Object, e As EventArgs) Handles Dashboard_btn.Click
        Dim Dashboard As New Dashboard()
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Inventory_btn_Click(sender As Object, e As EventArgs) Handles Inventory_btn.Click
        Dim Inventory As New Inventory()
        Inventory.Show()
        Me.Hide()
    End Sub

    Private Sub stock_btn_Click(sender As Object, e As EventArgs) Handles stock_btn.Click
        Dim AddItem As New Stock()
        AddItem.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Categories_Click(sender As Object, e As EventArgs) Handles btn_Categories.Click
        Dim Categories As New Categories()
        Categories.Show()
        Me.Hide()
    End Sub

    Private Sub btn_SalesReport_Click(sender As Object, e As EventArgs) Handles btn_SalesReport.Click
        Dim SalesReport As New SalesReport()
        Cashier_SalesReport.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        Dim User As New User()
        User.Show()
        Me.Hide()
    End Sub
End Class