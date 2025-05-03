Public Class Dashboard

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Dashboard_btn_Click(sender As Object, e As EventArgs) Handles Dashboard_btn.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles inventory_btn.Click
        Dim Inventory As New Inventory()
        Inventory.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Categories_btn_Click(sender As Object, e As EventArgs) Handles Categories_btn.Click
        Dim Categories As New Categories()
        Categories.Show()
        Me.Hide()
    End Sub

    Private Sub Logout_btn_Click(sender As Object, e As EventArgs) Handles Logout_btn.Click
        Dim Login As New Login
        Login.Show()
        Hide()
    End Sub
    Private Sub stock_btn_Click(sender As Object, e As EventArgs) Handles stock_btn.Click
        Dim Stock As New Stock()
        Stock.Show()
        Me.Hide()
    End Sub
End Class
