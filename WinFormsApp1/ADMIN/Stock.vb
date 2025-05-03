Imports MySql.Data.MySqlClient
Public Class Stock

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Load_stock()
    End Sub

    Sub Load_stock()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `ProductCode`, `ProductName`, `CategoryName`, `ProductDescription`, `Stock`, `Price` FROM `tblinventory`", conn)
            dr = cmd.ExecuteReader()
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ProductCode"), dr.Item("ProductName"), dr.Item("CategoryName"), dr.Item("ProductDescription"), dr.Item("Stock"), dr.Item("Price"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

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

    Private Sub categories_btn_Click(sender As Object, e As EventArgs) Handles categories_btn.Click
        Dim Categories As New Categories()
        Categories.Show()
        Me.Hide()
    End Sub

    Private Sub AddItem_bttn_Click(sender As Object, e As EventArgs) Handles AddItem_bttn.Click

    End Sub

    Private Sub stock_btn_Click(sender As Object, e As EventArgs) Handles stock_btn.Click
        Dim Stock As New Stock()
        Stock.Show()
        Me.Hide()
    End Sub

    Private Sub Logout_btn_Click(sender As Object, e As EventArgs) Handles Logout_btn.Click
        Dim Login As New Login
        Login.Show()
        Hide()
    End Sub
End Class