Public Class SalesReport

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Dashboard_btn_Click(sender As Object, e As EventArgs) Handles Dashboard_btn.Click
        Dim Dashboard As New Dashboard()
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub inventory_btn_Click(sender As Object, e As EventArgs) Handles inventory_btn.Click
        Dim Inventory As New Inventory()
        Inventory.Show()
        Me.Hide()
    End Sub

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click
        Dim Login As New Login()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub additem_btn_Click(sender As Object, e As EventArgs) Handles additem_btn.Click
        Dim AddItem As New Stock()
        AddItem.Show()
        Me.Hide()
    End Sub

    Private Sub salesreport_btn_Click(sender As Object, e As EventArgs) Handles salesreport_btn.Click
        Dim SalesReport As New SalesReport()
        SalesReport.Show()
        Me.Hide()
    End Sub

    Private Sub categories_btn_Click(sender As Object, e As EventArgs) Handles categories_btn.Click
        Dim Categories As New Categories()
        Categories.Show()
        Me.Hide()
    End Sub

    Private Sub user_btn_Click(sender As Object, e As EventArgs) Handles user_btn.Click
        Dim User As New User()
        User.Show()
        Me.Hide()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles btn_Filter.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class