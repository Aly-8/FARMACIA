Imports MySql.Data.MySqlClient
Public Class cancel_order
    Private Sub cashier2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Load_cancel_order()

    End Sub

    Sub Load_cancel_order()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblpos` WHERE group by Product_Code", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("Product_Code"), dr.Item("total"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class