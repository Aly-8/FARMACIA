Imports MySql.Data.MySqlClient

Public Class Categories 'frm_addgroup

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_categories()
    End Sub

    Sub load_categories(Optional searchTerm As String = "")
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "SELECT `CategoryName` FROM `categories`"
            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                query &= " WHERE `CategoryName` LIKE @SearchTerm"
            End If

            cmd = New MySqlCommand(query, conn)

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                cmd.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")
            End If

            dr = cmd.ExecuteReader()

            DataGridView1.Rows.Clear()

            If dr.HasRows Then
                While dr.Read()
                    Dim categoryName As String = dr("CategoryName").ToString()
                    If Not String.IsNullOrWhiteSpace(categoryName) Then
                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, categoryName)
                    End If
                End While
            Else
            End If

        Catch ex As Exception
            MsgBox("Error loading categories: " & ex.Message, vbExclamation)
        Finally
            dr?.Close()
            conn.Close()
        End Try

        DataGridView1.Refresh()
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        Try
            If String.IsNullOrWhiteSpace(Txt_CategoryName.Text) Then
                MsgBox("Category name cannot be empty!", vbExclamation)
                Return
            End If

            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("INSERT INTO `categories`(`CategoryName`) VALUES (@CategoryName)", conn)
            cmd.Parameters.AddWithValue("@CategoryName", Txt_CategoryName.Text.Trim())
            Dim result = cmd.ExecuteNonQuery()

            If result > 0 Then
                MsgBox("New category added successfully!", vbInformation)
                Txt_CategoryName.Clear()
            Else
                MsgBox("Failed to add category.", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox("Error adding category: " & ex.Message, vbExclamation)
        Finally
            conn.Close()
        End Try
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

    Private Sub Logout_btn_Click(sender As Object, e As EventArgs) Handles Logout_btn.Click
        Dim Login As New Login()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If String.IsNullOrWhiteSpace(Txt_CategoryName.Text) Then
            MsgBox("Please enter or select a category to delete.", vbExclamation)
            Return
        End If

        Dim categoryName As String = Txt_CategoryName.Text.Trim()

        If MsgBox($"Are you sure you want to delete the category '{categoryName}'?", vbYesNo + vbExclamation, "Confirm Deletion") = vbYes Then
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Check if the category exists
                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM `categories` WHERE `CategoryName` = @CategoryName", conn)
                checkCmd.Parameters.AddWithValue("@CategoryName", categoryName)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count = 0 Then
                    MsgBox("The category does not exist.", vbInformation)
                Else
                    ' Delete the category
                    Dim deleteCmd As New MySqlCommand("DELETE FROM `categories` WHERE `CategoryName` = @CategoryName", conn)
                    deleteCmd.Parameters.AddWithValue("@CategoryName", categoryName)
                    Dim result As Integer = deleteCmd.ExecuteNonQuery()

                    If result > 0 Then
                        MsgBox("Category deleted successfully.", vbInformation)
                        Txt_CategoryName.Clear()
                        load_categories() ' Refresh the categories list
                    Else
                        MsgBox("Failed to delete the category.", vbExclamation)
                    End If
                End If

            Catch ex As Exception
                MsgBox("Error deleting category: " & ex.Message, vbExclamation)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub txt_SearchCategory_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchCategory.TextChanged
        ' If the search box has text, call load_categories with the search term
        If Not String.IsNullOrWhiteSpace(txt_SearchCategory.Text) Then
            load_categories(txt_SearchCategory.Text.Trim())
        Else
            ' If the search box is empty, load all categories
            load_categories()
        End If
    End Sub

End Class
