Imports System.IO
Imports MySql.Data.MySqlClient

Public Class SalesReport

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        Load_Report()
        Total()

    End Sub

    Sub Load_Report()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT  `OrderNo`, `OrderDate`, `OrderMonth`, `OrderMonthYear`,  `grandTotal` FROM `tblpos` Group by OrderNo", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("OrderNo"), dr.Item("OrderDate"), dr.Item("OrderMonth"), dr.Item("OrderMonthYear"), dr.Item("grandTotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT  `OrderNo`, `OrderDate`, `OrderMonth`, `OrderMonthYear`,  `grandTotal` FROM `tblpos` WHERE OrderNo like '&" & txt_search.Text & "&' Group by OrderNo", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("OrderNo"), dr.Item("OrderDate"), dr.Item("OrderMonth"), dr.Item("OrderMonthYear"), dr.Item("grandTotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub rbtn_Today_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_Today.CheckedChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT  `OrderNo`, `OrderDate`, `OrderMonth`, `OrderMonthYear`,  `grandTotal` FROM `tblpos` WHERE OrderDate like '&" & Date.Now.ToString("yyyy-MM-dd") & "&' Group by OrderNo", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("OrderNo"), dr.Item("OrderDate"), dr.Item("OrderMonth"), dr.Item("OrderMonthYear"), dr.Item("grandTotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub rbtn_currentMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_currentMonth.CheckedChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT  `OrderNo`, `OrderDate`, `OrderMonth`, `OrderMonthYear`,  `grandTotal` FROM `tblpos` WHERE OrderMonth like '&" & Date.Now.ToString("MM") & "&' Group by OrderNo", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("OrderNo"), dr.Item("OrderDate"), dr.Item("OrderMonth"), dr.Item("OrderMonthYear"), dr.Item("grandTotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT  `OrderNo`, `OrderDate`, `OrderMonth`, `OrderMonthYear`,  `grandTotal` FROM `tblpos` WHERE OrderDate between '" & date1 & "' and '" & date2 & " Group by OrderNo", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("OrderNo"), dr.Item("OrderDate"), dr.Item("OrderMonth"), dr.Item("OrderMonthYear"), dr.Item("grandTotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub Total()
        Try
            Dim sum As Double = 0
            For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                sum = sum + DataGridView1.Rows(i).Cells(5).Value
            Next
            lbl_totalDisplay.Text = Format(CDec(sum), "#,##0.00")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Total()
    End Sub
End Class