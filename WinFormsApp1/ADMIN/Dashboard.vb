Imports MySql.Data.MySqlClient
Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        Load_todaySale()
        Load_MonthlySales()
        Load_NoofProducts()
        Load_NoofUser()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles inventory_btn.Click
        Dim Inventory As New Inventory()
        Inventory.Show()
        Me.Hide()
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

    Private Sub salesreport_btn_Click(sender As Object, e As EventArgs) Handles salesreport_btn.Click
        Dim SalesReport As New SalesReport()
        SalesReport.Show()
        Me.Hide()
    End Sub

    Private Sub user_btn_Click(sender As Object, e As EventArgs) Handles user_btn.Click
        Dim User As New User()
        User.Show()
        Me.Hide()
    End Sub

    Sub Load_allData()

    End Sub
    Sub Load_todaySale()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblpos` WHERE OrderDate = '" & Date.Now.ToString("yyyy-MM-dd") & "'group by OrderNo", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("OrderNo"), dr.Item("OrderDate"), dr.Item("OrderMonth"), dr.Item("grandtotal"))
                Dim sum As Double = 0
                For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    sum = sum + DataGridView1.Rows(i).Cells(3).Value
                Next
                TodaySales_lbl.Text = Format(sum, "#,##0.00")
                No_TodaySales_lbl.Text = DataGridView1.Rows.Count - 1 + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub Load_MonthlySales()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblpos` WHERE OrderMonth = '" & Date.Now.ToString("MM") & "'group by OrderNo", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("OrderNo"), dr.Item("OrderDate"), dr.Item("OrderMonth"), dr.Item("grandtotal"))
                Dim sum As Double = 0
                For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    sum = sum + DataGridView1.Rows(i).Cells(3).Value
                Next
                MonthlySales_lbl.Text = Format(sum, "#,##0.00")
                No_MonthlySales_lbl.Text = DataGridView1.Rows.Count - 1 + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub Load_NoofProducts()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT COUNT (`ProductName`) FROM `tblinventory` ", conn)
            NumberOfProduct_lbl.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub Load_NoofUser()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT COUNT (`Username`) FROM `tbluser` ", conn)
            No_OfUsers_lbl.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
