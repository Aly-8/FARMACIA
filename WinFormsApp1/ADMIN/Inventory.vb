Imports MySql.Data.MySqlClient
Public Class Inventory 'manageproduct

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        DataGridView1.RowTemplate.Height = 30


        load_Categories()
        load_product()
    End Sub

    Sub load_Categories()
        cbo_category.Items.Clear()
        Try
            conn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
            cmd = New MySqlCommand("SELECT * FROM `categories`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cbo_category.Items.Add(dr("CategoryName".ToString))
            End While
        End Try
        conn.Close()
    End Sub


    Sub load_product()
        'Search Product
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM `tblinventory`"
            If txt_Search.Text.Trim() <> "" Then
                query &= " WHERE ProductCode LIKE '%" & txt_Search.Text & "%' OR ProductName LIKE '%" & txt_Search.Text & "%' OR CategoryName LIKE '%" & txt_Search.Text & "%'"
            End If

            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ProductCode"), dr.Item("ProductName"), dr.Item("CategoryName"), dr.Item("ProductDescription"), dr.Item("Stock"), dr.Item("Price"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub txt_Search_Text(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        ' Reload the products whenever the search text changes
        load_product()
    End Sub

    Sub clear()
        txt_productcode.Clear()
        txt_productname.Clear()
        txt_productdescription.Clear()
        txt_stock.Clear()
        txt_price.Clear()
        cbo_category.SelectedIndex = -1

    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Dashboard_btn_Click(sender As Object, e As EventArgs)
        Dim Form1 As New Dashboard
        Form1.Show()
        Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim AddItem As New Stock
        AddItem.Show()
        Hide()
    End Sub

    Private Sub Categories_btn_Click(sender As Object, e As EventArgs)
        Dim Categories As New Categories
        Categories.Show()
        Hide()
    End Sub


    Private Sub Dashboard_btn_Click_1(sender As Object, e As EventArgs) Handles Dashboard_btn.Click
        Dim Dashboard As New Dashboard()
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub categories_btn_Click_1(sender As Object, e As EventArgs) Handles categories_btn.Click
        Dim Categories As New Categories()
        Categories.Show()
        Me.Hide()
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Try
            conn.Open()

            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM `tblinventory` WHERE `ProductCode` = @ProductCode", conn)
            checkCmd.Parameters.AddWithValue("@ProductCode", txt_productcode.Text)
            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If count > 0 Then
                ' Product code already exists
                MsgBox("The product code already exists. Please use a different product code.", vbExclamation)
            Else
                cmd = New MySqlCommand("INSERT INTO `tblinventory`(`ProductCode`, `ProductName`, `CategoryName`, `ProductDescription`, `Stock`, `Price`) VALUES (@ProductCode, @ProductName, @CategoryName, @ProductDescription, @Stock, @Price)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ProductCode", txt_productcode.Text)
                cmd.Parameters.AddWithValue("@ProductName", txt_productname.Text)
                cmd.Parameters.AddWithValue("@CategoryName", cbo_category.Text)
                cmd.Parameters.AddWithValue("@ProductDescription", txt_productdescription.Text)
                cmd.Parameters.AddWithValue("@Stock", txt_stock.Text)
                cmd.Parameters.AddWithValue("@Price", txt_price.Text)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("New Product Saved Successfully!", vbInformation)
                Else
                    MsgBox("Saving Failed!", vbExclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged

    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        txt_productcode.ReadOnly = True
        If String.IsNullOrWhiteSpace(txt_SearchProductCode.Text) Then
            MessageBox.Show("Please enter a Product Code.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()

            Dim query As String = "SELECT `ProductCode`, `ProductName`, `CategoryName`, `ProductDescription`, `Stock`, `Price` FROM `tblInventory` WHERE `ProductCode` = @ProductCode"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ProductCode", txt_SearchProductCode.Text.Trim())
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txt_productcode.Text = dr("ProductCode").ToString()
                txt_productname.Text = dr("ProductName").ToString()
                cbo_category.Text = dr("CategoryName").ToString()
                txt_productdescription.Text = dr("ProductDescription").ToString()
                txt_stock.Text = dr("Stock").ToString()
                txt_price.Text = dr("Price").ToString()
            Else
                MessageBox.Show("No matching product found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tblinventory` SET `ProductName`=@ProductName, `CategoryName`= @CategoryName,`ProductDescription`= @ProductDescription,`Stock`= @Stock,`Price`= @Price WHERE `ProductCode`= @ProductCode", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ProductName", txt_productname.Text)
            cmd.Parameters.AddWithValue("@CategoryName", cbo_category.Text)
            cmd.Parameters.AddWithValue("@ProductDescription", txt_productdescription.Text)
            cmd.Parameters.AddWithValue("@Stock", txt_stock.Text)
            cmd.Parameters.AddWithValue("@Price", txt_price.Text)
            cmd.Parameters.AddWithValue("@ProductCode", txt_productcode.Text)

            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Product Update Successfully!", vbInformation)
            Else
                MsgBox("Updating Failed!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        txt_SearchProductCode.Clear()
        load_product()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If MsgBox("Are you sure to delete this product?", vbExclamation + vbYesNo) = vbYes Then
            Try
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tblinventory` WHERE `ProductCode` = @ProductCode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ProductCode", txt_productcode.Text)

                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Product Delete Successfully!", vbInformation)
                Else
                    MsgBox("Deleting Failed!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            txt_SearchProductCode.Clear()
            load_product()
        Else
            Return
        End If
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        clear()
        txt_SearchProductCode.Clear()
    End Sub


    Private Sub Inventory_btn_Click(sender As Object, e As EventArgs) Handles Inventory_btn.Click

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