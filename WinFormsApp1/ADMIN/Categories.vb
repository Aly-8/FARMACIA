Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Pqc.Crypto.Frodo


Public Class Categories 'frm_addgroup

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub additem_btn_Click_1(sender As Object, e As EventArgs) Handles additem_btn.Click
        Dim AddItem As New Stock()
        AddItem.Show()
        Me.Hide()
    End Sub

    Private Sub Inventory_btn_Click_1(sender As Object, e As EventArgs) Handles Inventory_btn.Click
        Dim Inventory As New Inventory()
        Inventory.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_btn_Click_1(sender As Object, e As EventArgs) Handles Dashboard_btn.Click
        Dim Dashboard As New Dashboard()
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `categories`(`CategoryName`) VALUES (@CategoryName)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CategoryName", Txt_CategoryName.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Category Added!", vbInformation)
            Else
                MsgBox("Adding Category Failed!", vbExclamation)
            End If
            Txt_CategoryName.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Inventory.load_Categories()
    End Sub

    Private Sub Logout_btn_Click(sender As Object, e As EventArgs) Handles Logout_btn.Click
        Dim Login As New Login
        Login.Show()
        Hide()
    End Sub
End Class