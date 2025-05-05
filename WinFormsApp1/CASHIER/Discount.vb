Imports MySql.Data.MySqlClient

Public Class Discount

    Public Event DiscountUpdated(newDiscount As Decimal)
    Private Sub Discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_updatediscount_Click(sender As Object, e As EventArgs) Handles btn_updatediscount.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tbldiscount` SET `discount`= @discount WHERE `discId` = @discId", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@discount", txt_discount.Text.Trim())
            cmd.Parameters.AddWithValue("@discId", "1001")
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Discount Updated Successfully", vbInformation)

                ' Raise the event to notify the Cashier form
                Dim discountValue As Decimal
                If Decimal.TryParse(txt_discount.Text.Trim(), discountValue) Then
                    RaiseEvent DiscountUpdated(discountValue)
                End If
                txt_discount.Clear()
            Else
                MsgBox("Discount Not Updated", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub txt_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_discount.TextChanged

    End Sub
End Class