Imports MySql.Data.MySqlClient
Public Class Stock

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Load_stock()
    End Sub

    Sub Load_stock()
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            cmd = New MySqlCommand("SELECT `ProductCode`, `ProductName`, `CategoryName`, `ProductDescription`, `Stock`, `Price` FROM `tblinventory`", conn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1,
                                   dr("ProductCode").ToString(),
                                   dr("ProductName").ToString(),
                                   dr("CategoryName").ToString(),
                                   dr("ProductDescription").ToString(),
                                   dr("Stock").ToString(),
                                   dr("Price").ToString())
            End While

        Catch ex As Exception
            MsgBox("Error while loading stock: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            conn.Close()
        End Try
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

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            cmd = New MySqlCommand("SELECT `ProductCode`, `ProductName`, `CategoryName`, `ProductDescription`, `Stock`, `Price` 
                                FROM `tblinventory` 
                                WHERE `ProductCode` LIKE @Search OR `ProductName` LIKE @Search OR `CategoryName` LIKE @Search", conn)
            cmd.Parameters.AddWithValue("@Search", "%" & txt_Search.Text & "%")
            dr = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1,
                                   dr("ProductCode").ToString(),
                                   dr("ProductName").ToString(),
                                   dr("CategoryName").ToString(),
                                   dr("ProductDescription").ToString(),
                                   dr("Stock").ToString(),
                                   dr("Price").ToString())
            End While
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            conn.Close()
        End Try
    End Sub


    Private Sub UpdateStock_btn_Click(sender As Object, e As EventArgs) Handles UpdateStock_btn.Click
        Try
            conn.Open()
            Dim hasEmptyStock As Boolean = False 

            For j As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim stockCell = DataGridView1.Rows(j).Cells(5)
                Dim stockValue As String = If(stockCell.Value, "").ToString().Trim()
                Dim productName As String = If(DataGridView1.Rows(j).Cells(2).Value, "").ToString().Trim()

                If String.IsNullOrWhiteSpace(stockValue) Then
                    hasEmptyStock = True
                    MsgBox($"Invalid stock value. Stock should not be left empty.", vbExclamation)
                 
                    Exit For
                End If
            Next

            If hasEmptyStock Then
                conn.Close()
                Exit Sub
            End If

            Dim rowsUpdated As Integer = 0 

            For j As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim stockCell = DataGridView1.Rows(j).Cells(5)
                Dim stockValue As String = If(stockCell.Value, "").ToString().Trim()
                Dim productCode As String = If(DataGridView1.Rows(j).Cells(1).Value, "").ToString().Trim()
                Dim stockNumericValue As Integer

                If Integer.TryParse(stockValue, stockNumericValue) AndAlso stockNumericValue >= 0 Then
                   
                    cmd = New MySqlCommand("UPDATE `tblinventory` SET `Stock`=@Stock WHERE `ProductCode`=@ProductCode", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Stock", stockNumericValue)
                    cmd.Parameters.AddWithValue("@ProductCode", productCode)
                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then rowsUpdated += 1
                Else
                    MsgBox($"Invalid stock value for Product Code '{productCode}'. Update skipped for this product.", vbExclamation)
                End If
            Next

            If rowsUpdated > 0 Then
                MsgBox($"{rowsUpdated} product(s) updated successfully.", vbInformation)
            Else
                MsgBox("No products were updated.", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            conn.Close()
            Load_stock() 
            txt_Search.Clear() 
        End Try
    End Sub



End Class
