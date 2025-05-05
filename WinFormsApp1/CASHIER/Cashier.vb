Imports MySql.Data.MySqlClient
Public Class Cashier

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        txt_SearchProductCode.Focus()
        total()
        btn_Pay.Enabled = False
        load_discount()
    End Sub

    Public Sub ADDLIST()
        Dim exist As Boolean = False
        Dim numrow As Integer = 0
        Dim numtext As Integer = 0

        For Each itm As DataGridViewRow In DataGridView1.Rows
            If itm.Cells(1).Value IsNot Nothing Then
                If itm.Cells(1).Value.ToString() = txt_SearchProductCode.Text Then
                    exist = True
                    numrow = itm.Index
                    numtext = CInt(itm.Cells(5).Value)
                    Exit For
                End If
            End If
        Next

        If exist Then
            Dim currentQuantity As Integer = numtext + 1
            DataGridView1.Rows(numrow).Cells(5).Value = currentQuantity
            Dim pricePerUnit As Decimal = CDec(DataGridView1.Rows(numrow).Cells(6).Value)
            DataGridView1.Rows(numrow).Cells(7).Value = pricePerUnit * currentQuantity
        Else
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Using cmd As New MySqlCommand("SELECT * FROM `tblinventory` WHERE `ProductCode` = @ProductCode", conn)
                    cmd.Parameters.AddWithValue("@ProductCode", txt_SearchProductCode.Text.Trim())
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            If String.IsNullOrEmpty(txt_SearchProductCode.Text) Then
                                Return
                            End If
                            Dim ProductCode As String = dr("ProductCode").ToString().Trim()
                            Dim ProductName As String = dr("ProductName").ToString().Trim()
                            Dim CategoryName As String = dr("CategoryName").ToString().Trim()
                            Dim ProductDescription As String = dr("ProductDescription").ToString().Trim()
                            Dim Price As Decimal = If(IsDBNull(dr("Price")), 0D, CDec(dr("Price")))
                            Dim totalPrice As Decimal = Price

                            DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, ProductCode, ProductName, CategoryName, ProductDescription, 1, Price, totalPrice)

                            txt_SearchProductCode.Clear()
                            txt_SearchProductCode.Focus()
                        Else
                            MsgBox("Product not found.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub


    Private Sub f2_cancel_Click(sender As Object, e As EventArgs) Handles f2_cancel.Click
        cancel_order.ShowDialog()
    End Sub

    Private Sub txt_SearchProductCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SearchProductCode.KeyDown
        If txt_SearchProductCode.Text = Nothing Then
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                ADDLIST()

                txt_SearchProductCode.Clear()
                txt_SearchProductCode.Focus()
            End If
            Return
        End If
    End Sub

    Public Sub total()
        lbl_noOfItems.Text = DataGridView1.Rows.Count - 1 + 1

        Dim sum As Decimal = 0
        Dim subtotal As Decimal = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(7).Value
            subtotal = subtotal + DataGridView1.Rows(i).Cells(6).Value * DataGridView1.Rows(i).Cells(5).Value
        Next
        Try
            lbl_subtotal.Text = Format(CDec(subtotal), "#,##0.00")
            lbl_TotalPrice.Text = Format(CDec(subtotal), "#,##0.00")
            lbl_Discount.Text = Format(CDec(txt_discount.Text * lbl_TotalPrice.Text / 100), "#,##0.00")
            lbl_GrandTotal.Text = Format(CDec(lbl_TotalPrice.Text - lbl_Discount.Text), "#,##0.00")

            lbl_OverAllGrandTotal.Text = Format(CDec(lbl_GrandTotal.Text), "#,##0.00")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()
    End Sub

    Private Sub txt_amountReceived_TextChanged(sender As Object, e As EventArgs) Handles txt_amountReceived.TextChanged
        Dim amountReceived As Decimal = 0
        Dim grandTotal As Decimal = 0

        If Not String.IsNullOrEmpty(txt_amountReceived.Text) AndAlso Decimal.TryParse(txt_amountReceived.Text, amountReceived) Then
        Else
            amountReceived = 0
        End If

        If Not String.IsNullOrEmpty(lbl_GrandTotal.Text) AndAlso Decimal.TryParse(lbl_GrandTotal.Text, grandTotal) Then
        Else
            grandTotal = 0
        End If

        lbl_Change.Text = Format(amountReceived - grandTotal, "#,##0.00")

        If String.IsNullOrEmpty(txt_amountReceived.Text) Then
            lbl_Change.Text = "0.00"
        End If

        btn_Pay.Enabled = True

    End Sub



    Sub load_discount()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            cmd = New MySqlCommand("SELECT `discount` FROM `tbldiscount` WHERE `discId` = @discId", conn)
            cmd.Parameters.AddWithValue("@discId", "1001")

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txt_discount.Text = dr("discount").ToString().Trim()
            Else
                MsgBox("No discount found for the given ID.", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox("Error loading discount: " & ex.Message, vbCritical)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub f3_setdiscount_Click(sender As Object, e As EventArgs) Handles f3_setdiscount.Click
        Dim discountForm As New Discount()
        discountForm.ShowDialog()

        load_discount()
    End Sub

End Class