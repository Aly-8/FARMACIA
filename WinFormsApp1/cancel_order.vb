Imports MySql.Data.MySqlClient

Public Class cancel_order
    Private Sub cashier2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbconn() Then
            Load_cancel_order()
        Else
            MsgBox("Failed to connect to the database.", vbCritical)
        End If
    End Sub

    Sub Load_cancel_order()
        DataGridView1.Rows.Clear()
        Try
            Using cmd As New MySqlCommand("SELECT * FROM `tblpos` GROUP BY OrderNo", conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("OrderNo"), dr.Item("OrderDate"), dr.Item("grandTotal"))
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error loading orders: " & ex.Message, vbExclamation)
        End Try
    End Sub


    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            Using cmd As New MySqlCommand("SELECT * FROM `tblpos` WHERE OrderNo LIKE @search GROUP BY OrderNo", conn)
                cmd.Parameters.AddWithValue("@search", "%" & txt_Search.Text & "%")
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("OrderNo"), dr.Item("OrderDate"), dr.Item("grandTotal"))
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error searching orders: " & ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView1.Columns("ColDel").Index Then
                If MsgBox("Are you sure to delete this order?", vbQuestion + vbYesNo) = vbYes Then
                    Dim orderNo As Object = DataGridView1.Rows(e.RowIndex).Cells("OrderNo").Value
                    If orderNo Is Nothing OrElse String.IsNullOrEmpty(orderNo.ToString()) Then
                        MsgBox("Order number is missing. Cannot delete the order.", vbExclamation)
                        Return
                    End If

                    Using cmd As New MySqlCommand("DELETE FROM `tblpos` WHERE OrderNo = @OrderNo", conn)
                        cmd.Parameters.AddWithValue("@OrderNo", orderNo.ToString())
                        If conn.State = ConnectionState.Closed Then conn.Open()
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        If i > 0 Then
                            MsgBox("Order deleted successfully!", vbInformation)
                            Load_cancel_order()
                        Else
                            MsgBox("Failed to delete order!", vbExclamation)
                        End If
                    End Using
                End If
            End If
        Catch ex As Exception
            MsgBox("Error deleting order: " & ex.Message, vbExclamation)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
End Class
