Imports MySql.Data.MySqlClient
Public Class Cashier

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        txt_SearchProductCode.Focus()
        total()
        btn_Pay.Enabled = False
        load_discount()
        txt_OrderNo.Text = GetOrderNo()
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
        If Not String.IsNullOrEmpty(txt_SearchProductCode.Text) AndAlso e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ADDLIST()
            txt_SearchProductCode.Clear()
            txt_SearchProductCode.Focus()
        End If
    End Sub

    Public Sub total()
        lbl_noOfItems.Text = (DataGridView1.Rows.Count - 1 + 1).ToString()

        Dim subtotal As Decimal = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            subtotal += CDec(DataGridView1.Rows(i).Cells(6).Value) * CDec(DataGridView1.Rows(i).Cells(5).Value)
        Next

        lbl_subtotal.Text = Format(subtotal, "#,##0.00")
        lbl_TotalPrice.Text = Format(subtotal, "#,##0.00")

        Dim discount As Decimal = CDec(If(String.IsNullOrEmpty(txt_discount.Text), 0, txt_discount.Text)) * subtotal / 100
        lbl_Discount.Text = Format(discount, "#,##0.00")

        Dim grandTotal As Decimal = subtotal - discount
        lbl_GrandTotal.Text = Format(grandTotal, "#,##0.00")
        lbl_OverAllGrandTotal.Text = Format(grandTotal, "#,##0.00")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()
    End Sub

    Private Sub txt_amountReceived_TextChanged(sender As Object, e As EventArgs) Handles txt_amountReceived.TextChanged
        Try
            lbl_Change.Text = Format(CDec(txt_amountReceived.Text) - CDec(lbl_GrandTotal.Text), "#,##0.00")
        Catch ex As Exception
            lbl_Change.Text = "0.00"
        End Try

        btn_Pay.Enabled = True

    End Sub



    Sub load_discount()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Using cmd As New MySqlCommand("SELECT `discount` FROM `tbldiscount` WHERE `discId` = @discId", conn)
                cmd.Parameters.AddWithValue("@discId", "1001")
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        txt_discount.Text = dr("discount").ToString().Trim()
                    Else
                        MsgBox("No discount found for the given ID.", vbExclamation)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error loading discount: " & ex.Message, vbCritical)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



    Private Sub f3_setdiscount_Click(sender As Object, e As EventArgs) Handles f3_setdiscount.Click
        ' Create an instance of the Discount form
        Dim discountForm As New Discount()

        ' Subscribe to the DiscountUpdated event
        AddHandler discountForm.DiscountUpdated, AddressOf UpdateDiscountInCashier

        ' Show the Discount form
        discountForm.Show()
    End Sub

    Private Sub UpdateDiscountInCashier(newDiscount As Decimal)
        ' Update the discount textbox
        txt_discount.Text = newDiscount.ToString("#,##0.00")

        ' Recalculate totals to reflect the new discount
        total()
    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
        lbl_date.Text = Date.Now.ToString("dd-MMMM-yyyy dddd")

    End Sub

    Private Sub lbl_time_Click(sender As Object, e As EventArgs) Handles lbl_time.Click

    End Sub

    Sub Save_Order()
        If cbo_paymentMode.Text = String.Empty Then
            MsgBox("Please Select a Payment Mode.", vbInformation)
            Return
        ElseIf txt_amountReceived.Text = String.Empty Then
            MsgBox("Please Enter Amount Received.", vbInformation)
            Return
        ElseIf Val(lbl_GrandTotal.Text) > Val(txt_amountReceived.Text) Then
            MsgBox("Insufficient Amount Received!", vbInformation)
            Return
        End If

        Try
            conn.Open()
            For j As Integer = 0 To DataGridView1.Rows.Count - 1
                Using cmd As New MySqlCommand("
                    INSERT INTO tblpos (
                        OrderNo, OrderDate, OrderMonth, OrderMonthYear,
                        Product_Code, Product_Name, CategoryName, ProductDescription, 
                        Quantity, Price, Subtotal, totalPrice, discount, grandTotal, 
                        paymentMode, amountReceived, balance
                    ) VALUES (
                        @OrderNo, @OrderDate, @OrderMonth, @OrderMonthYear,
                        @Product_Code, @Product_Name, @CategoryName, @ProductDescription, 
                        @Quantity, @Price, @Subtotal, @totalPrice, @discount, @grandTotal, 
                        @paymentMode, @amountReceived, @balance
                    )", conn)
                    cmd.Parameters.AddWithValue("@OrderNo", txt_OrderNo.Text)
                    cmd.Parameters.AddWithValue("@OrderDate", CDate(dtp_OrderDate.Text))
                    cmd.Parameters.AddWithValue("@OrderMonth", Date.Now.ToString("MM"))
                    cmd.Parameters.AddWithValue("@OrderMonthYear", Date.Now.ToString("MMMM-yyyy"))

                    cmd.Parameters.AddWithValue("@Product_Code", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@Product_Name", DataGridView1.Rows(j).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@CategoryName", DataGridView1.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@ProductDescription", DataGridView1.Rows(j).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@Quantity", DataGridView1.Rows(j).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@Price", DataGridView1.Rows(j).Cells(6).Value)
                    cmd.Parameters.AddWithValue("@totalPrice", DataGridView1.Rows(j).Cells(7).Value)

                    cmd.Parameters.AddWithValue("@Subtotal", CDec(lbl_subtotal.Text))
                    cmd.Parameters.AddWithValue("@discount", CDec(lbl_Discount.Text))
                    cmd.Parameters.AddWithValue("@grandTotal", CDec(lbl_GrandTotal.Text))
                    cmd.Parameters.AddWithValue("@paymentMode", cbo_paymentMode.Text)
                    cmd.Parameters.AddWithValue("@amountReceived", CDec(txt_amountReceived.Text))
                    cmd.Parameters.AddWithValue("@balance", CDec(lbl_Change.Text))

                    cmd.ExecuteNonQuery()
                End Using
            Next
            MsgBox("Transaction Saved Successfully!" & vbCrLf & "Order No: " & txt_OrderNo.Text, vbInformation)
            clear()
        Catch ex As Exception
            MsgBox("Error saving transaction: " & ex.Message, vbCritical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        txt_OrderNo.Text = GetOrderNo()
    End Sub

    Sub clear()
        txt_SearchProductCode.Clear()
        dtp_OrderDate.Text = Now
        txt_SearchProductCode.Clear()
        DataGridView1.Rows.Clear()
        lbl_Change.Text = "0.00"
        lbl_Discount.Text = "0.00"
        lbl_GrandTotal.Text = "0.00"
        lbl_noOfItems.Text = "0"
        lbl_OverAllGrandTotal.Text = "0.00"
        lbl_subtotal.Text = "0.00"
        lbl_TotalPrice.Text = "0.00"
        cbo_paymentMode.SelectedIndex = -1
        txt_amountReceived.Clear()
    End Sub
    Private Sub btn_Pay_Click(sender As Object, e As EventArgs) Handles btn_Pay.Click
        Save_Order()
        txt_SearchProductCode.Focus()
    End Sub

    Private Sub F1_New_Click(sender As Object, e As EventArgs) Handles F1_New.Click
        clear()
        txt_OrderNo.Text = GetOrderNo()
    End Sub

    Private Sub f5_remove_Click(sender As Object, e As EventArgs) Handles f5_remove.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        End If
    End Sub

    Private Sub f6_changepassword_Click(sender As Object, e As EventArgs) Handles f6_changepassword.Click
        ChangePassword.ShowDialog()
    End Sub
    Private Sub f7_logout_Click(sender As Object, e As EventArgs) Handles f7_logout.Click
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Hide()
    End Sub
End Class
