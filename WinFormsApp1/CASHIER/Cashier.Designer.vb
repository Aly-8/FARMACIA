<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        f7_logout = New Button()
        F1_New = New Button()
        f6_changepassword = New Button()
        f5_remove = New Button()
        f4_report = New Button()
        f3_setdiscount = New Button()
        f2_cancel = New Button()
        lbl_time = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        lbl_date = New Label()
        dtp_OrderDate = New DateTimePicker()
        txt_SearchProductCode = New TextBox()
        txt_OrderNo = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Panel3 = New Panel()
        lbl_subtotal = New Label()
        Label16 = New Label()
        cbo_paymentMode = New ComboBox()
        txt_amountReceived = New TextBox()
        lbl_Change = New Label()
        lbl_GrandTotal = New Label()
        lbl_Discount = New Label()
        lbl_TotalPrice = New Label()
        lbl_noOfItems = New Label()
        btn_Pay = New Button()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        txt_discount = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        lbl_OverAllGrandTotal = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1271, 64)
        Panel1.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.Controls.Add(f7_logout, 6, 0)
        TableLayoutPanel1.Controls.Add(F1_New, 0, 0)
        TableLayoutPanel1.Controls.Add(f6_changepassword, 5, 0)
        TableLayoutPanel1.Controls.Add(f5_remove, 4, 0)
        TableLayoutPanel1.Controls.Add(f4_report, 3, 0)
        TableLayoutPanel1.Controls.Add(f3_setdiscount, 2, 0)
        TableLayoutPanel1.Controls.Add(f2_cancel, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1271, 58)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' f7_logout
        ' 
        f7_logout.BackColor = Color.DarkSlateGray
        f7_logout.Dock = DockStyle.Fill
        f7_logout.FlatAppearance.BorderSize = 0
        f7_logout.FlatStyle = FlatStyle.Flat
        f7_logout.ForeColor = SystemColors.ButtonHighlight
        f7_logout.Location = New Point(1089, 3)
        f7_logout.Name = "f7_logout"
        f7_logout.Size = New Size(179, 52)
        f7_logout.TabIndex = 6
        f7_logout.Text = "[ F7-Logout ]"
        f7_logout.UseVisualStyleBackColor = False
        ' 
        ' F1_New
        ' 
        F1_New.BackColor = Color.CadetBlue
        F1_New.Dock = DockStyle.Fill
        F1_New.FlatAppearance.BorderSize = 0
        F1_New.FlatStyle = FlatStyle.Flat
        F1_New.ForeColor = SystemColors.ButtonHighlight
        F1_New.Location = New Point(3, 3)
        F1_New.Name = "F1_New"
        F1_New.Size = New Size(175, 52)
        F1_New.TabIndex = 0
        F1_New.Text = "[ F1-New ]"
        F1_New.UseVisualStyleBackColor = False
        ' 
        ' f6_changepassword
        ' 
        f6_changepassword.BackColor = Color.CadetBlue
        f6_changepassword.Dock = DockStyle.Fill
        f6_changepassword.FlatAppearance.BorderSize = 0
        f6_changepassword.FlatStyle = FlatStyle.Flat
        f6_changepassword.ForeColor = SystemColors.ButtonHighlight
        f6_changepassword.Location = New Point(908, 3)
        f6_changepassword.Name = "f6_changepassword"
        f6_changepassword.Size = New Size(175, 52)
        f6_changepassword.TabIndex = 5
        f6_changepassword.Text = "[F6-Change Password]"
        f6_changepassword.UseVisualStyleBackColor = False
        ' 
        ' f5_remove
        ' 
        f5_remove.BackColor = Color.CadetBlue
        f5_remove.Dock = DockStyle.Fill
        f5_remove.FlatAppearance.BorderSize = 0
        f5_remove.FlatStyle = FlatStyle.Flat
        f5_remove.ForeColor = SystemColors.ButtonHighlight
        f5_remove.Location = New Point(727, 3)
        f5_remove.Name = "f5_remove"
        f5_remove.Size = New Size(175, 52)
        f5_remove.TabIndex = 4
        f5_remove.Text = "[ F5-Remove ]"
        f5_remove.UseVisualStyleBackColor = False
        ' 
        ' f4_report
        ' 
        f4_report.BackColor = Color.CadetBlue
        f4_report.Dock = DockStyle.Fill
        f4_report.FlatAppearance.BorderSize = 0
        f4_report.FlatStyle = FlatStyle.Flat
        f4_report.ForeColor = SystemColors.ButtonHighlight
        f4_report.Location = New Point(546, 3)
        f4_report.Name = "f4_report"
        f4_report.Size = New Size(175, 52)
        f4_report.TabIndex = 3
        f4_report.Text = "[ F4-Report ]"
        f4_report.UseVisualStyleBackColor = False
        ' 
        ' f3_setdiscount
        ' 
        f3_setdiscount.BackColor = Color.CadetBlue
        f3_setdiscount.Dock = DockStyle.Fill
        f3_setdiscount.FlatAppearance.BorderSize = 0
        f3_setdiscount.FlatStyle = FlatStyle.Flat
        f3_setdiscount.ForeColor = SystemColors.ButtonHighlight
        f3_setdiscount.Location = New Point(365, 3)
        f3_setdiscount.Name = "f3_setdiscount"
        f3_setdiscount.Size = New Size(175, 52)
        f3_setdiscount.TabIndex = 2
        f3_setdiscount.Text = "[ F3-Set Discount ]"
        f3_setdiscount.UseVisualStyleBackColor = False
        ' 
        ' f2_cancel
        ' 
        f2_cancel.BackColor = Color.CadetBlue
        f2_cancel.Dock = DockStyle.Fill
        f2_cancel.FlatAppearance.BorderSize = 0
        f2_cancel.FlatStyle = FlatStyle.Flat
        f2_cancel.ForeColor = SystemColors.ButtonHighlight
        f2_cancel.Location = New Point(184, 3)
        f2_cancel.Name = "f2_cancel"
        f2_cancel.Size = New Size(175, 52)
        f2_cancel.TabIndex = 1
        f2_cancel.Text = "[ F2-Cancel ]"
        f2_cancel.UseVisualStyleBackColor = False
        ' 
        ' lbl_time
        ' 
        lbl_time.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_time.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_time.ForeColor = Color.MidnightBlue
        lbl_time.Location = New Point(670, 3)
        lbl_time.Name = "lbl_time"
        lbl_time.Size = New Size(252, 41)
        lbl_time.TabIndex = 37
        lbl_time.Text = "00.00"
        lbl_time.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkCyan
        Label1.Location = New Point(1183, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 41)
        Label1.TabIndex = 10
        Label1.Text = "POS"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(1131, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 7
        Label2.Text = "Inventory System"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightSteelBlue
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(lbl_time)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(lbl_date)
        Panel2.Controls.Add(dtp_OrderDate)
        Panel2.Controls.Add(txt_SearchProductCode)
        Panel2.Controls.Add(txt_OrderNo)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 64)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1271, 70)
        Panel2.TabIndex = 2
        ' 
        ' lbl_date
        ' 
        lbl_date.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_date.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_date.ForeColor = Color.MidnightBlue
        lbl_date.Location = New Point(670, 44)
        lbl_date.Name = "lbl_date"
        lbl_date.Size = New Size(252, 27)
        lbl_date.TabIndex = 37
        lbl_date.Text = "00.00"
        lbl_date.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' dtp_OrderDate
        ' 
        dtp_OrderDate.Format = DateTimePickerFormat.Short
        dtp_OrderDate.Location = New Point(494, 7)
        dtp_OrderDate.Name = "dtp_OrderDate"
        dtp_OrderDate.Size = New Size(170, 27)
        dtp_OrderDate.TabIndex = 18
        ' 
        ' txt_SearchProductCode
        ' 
        txt_SearchProductCode.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        txt_SearchProductCode.BorderStyle = BorderStyle.None
        txt_SearchProductCode.ForeColor = Color.Black
        txt_SearchProductCode.Location = New Point(242, 42)
        txt_SearchProductCode.Name = "txt_SearchProductCode"
        txt_SearchProductCode.Size = New Size(422, 20)
        txt_SearchProductCode.TabIndex = 17
        ' 
        ' txt_OrderNo
        ' 
        txt_OrderNo.Location = New Point(104, 7)
        txt_OrderNo.Name = "txt_OrderNo"
        txt_OrderNo.Size = New Size(264, 27)
        txt_OrderNo.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(13, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(223, 20)
        Label7.TabIndex = 15
        Label7.Text = "Product Name / Product Code :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(395, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 20)
        Label6.TabIndex = 14
        Label6.Text = "Order Date :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 20)
        Label5.TabIndex = 13
        Label5.Text = "Order NO :"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lbl_subtotal)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(cbo_paymentMode)
        Panel3.Controls.Add(txt_amountReceived)
        Panel3.Controls.Add(lbl_Change)
        Panel3.Controls.Add(lbl_GrandTotal)
        Panel3.Controls.Add(lbl_Discount)
        Panel3.Controls.Add(lbl_TotalPrice)
        Panel3.Controls.Add(lbl_noOfItems)
        Panel3.Controls.Add(btn_Pay)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(txt_discount)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(lbl_OverAllGrandTotal)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(922, 134)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(349, 446)
        Panel3.TabIndex = 4
        ' 
        ' lbl_subtotal
        ' 
        lbl_subtotal.Anchor = AnchorStyles.Right
        lbl_subtotal.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_subtotal.Location = New Point(189, 110)
        lbl_subtotal.Name = "lbl_subtotal"
        lbl_subtotal.Size = New Size(148, 30)
        lbl_subtotal.TabIndex = 36
        lbl_subtotal.Text = "00.00"
        lbl_subtotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Location = New Point(97, 116)
        Label16.Name = "Label16"
        Label16.Size = New Size(72, 20)
        Label16.TabIndex = 35
        Label16.Text = "Sub Total"
        ' 
        ' cbo_paymentMode
        ' 
        cbo_paymentMode.Anchor = AnchorStyles.Right
        cbo_paymentMode.FormattingEnabled = True
        cbo_paymentMode.Items.AddRange(New Object() {"CASH", "DEBIT CARD"})
        cbo_paymentMode.Location = New Point(189, 268)
        cbo_paymentMode.Name = "cbo_paymentMode"
        cbo_paymentMode.Size = New Size(148, 28)
        cbo_paymentMode.TabIndex = 34
        ' 
        ' txt_amountReceived
        ' 
        txt_amountReceived.Anchor = AnchorStyles.Right
        txt_amountReceived.Location = New Point(189, 312)
        txt_amountReceived.Name = "txt_amountReceived"
        txt_amountReceived.Size = New Size(148, 27)
        txt_amountReceived.TabIndex = 33
        ' 
        ' lbl_Change
        ' 
        lbl_Change.Anchor = AnchorStyles.Right
        lbl_Change.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Change.Location = New Point(189, 350)
        lbl_Change.Name = "lbl_Change"
        lbl_Change.Size = New Size(148, 30)
        lbl_Change.TabIndex = 32
        lbl_Change.Text = "00.00"
        lbl_Change.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_GrandTotal
        ' 
        lbl_GrandTotal.Anchor = AnchorStyles.Right
        lbl_GrandTotal.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_GrandTotal.ForeColor = Color.SteelBlue
        lbl_GrandTotal.Location = New Point(189, 225)
        lbl_GrandTotal.Name = "lbl_GrandTotal"
        lbl_GrandTotal.Size = New Size(148, 30)
        lbl_GrandTotal.TabIndex = 30
        lbl_GrandTotal.Text = "00.00"
        lbl_GrandTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_Discount
        ' 
        lbl_Discount.Anchor = AnchorStyles.Right
        lbl_Discount.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Discount.Location = New Point(189, 184)
        lbl_Discount.Name = "lbl_Discount"
        lbl_Discount.Size = New Size(148, 30)
        lbl_Discount.TabIndex = 29
        lbl_Discount.Text = "00.00"
        lbl_Discount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_TotalPrice
        ' 
        lbl_TotalPrice.Anchor = AnchorStyles.Right
        lbl_TotalPrice.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_TotalPrice.Location = New Point(189, 146)
        lbl_TotalPrice.Name = "lbl_TotalPrice"
        lbl_TotalPrice.Size = New Size(148, 30)
        lbl_TotalPrice.TabIndex = 28
        lbl_TotalPrice.Text = "00.00"
        lbl_TotalPrice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_noOfItems
        ' 
        lbl_noOfItems.Anchor = AnchorStyles.Right
        lbl_noOfItems.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_noOfItems.Location = New Point(189, 74)
        lbl_noOfItems.Name = "lbl_noOfItems"
        lbl_noOfItems.Size = New Size(148, 30)
        lbl_noOfItems.TabIndex = 27
        lbl_noOfItems.Text = "00.00"
        lbl_noOfItems.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btn_Pay
        ' 
        btn_Pay.BackColor = Color.CadetBlue
        btn_Pay.Dock = DockStyle.Bottom
        btn_Pay.FlatAppearance.BorderSize = 0
        btn_Pay.FlatStyle = FlatStyle.Flat
        btn_Pay.ForeColor = SystemColors.ButtonHighlight
        btn_Pay.Location = New Point(0, 412)
        btn_Pay.Name = "btn_Pay"
        btn_Pay.Size = New Size(349, 34)
        btn_Pay.TabIndex = 26
        btn_Pay.Text = "[ F9 - PAY]"
        btn_Pay.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Location = New Point(108, 356)
        Label15.Name = "Label15"
        Label15.Size = New Size(61, 20)
        Label15.TabIndex = 25
        Label15.Text = "Change"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Location = New Point(40, 315)
        Label14.Name = "Label14"
        Label14.Size = New Size(129, 20)
        Label14.TabIndex = 24
        Label14.Text = "Amount Received"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Location = New Point(56, 271)
        Label13.Name = "Label13"
        Label13.Size = New Size(113, 20)
        Label13.TabIndex = 23
        Label13.Text = "Payment Mode"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Location = New Point(81, 231)
        Label12.Name = "Label12"
        Label12.Size = New Size(88, 20)
        Label12.TabIndex = 22
        Label12.Text = "Grand Total"
        ' 
        ' txt_discount
        ' 
        txt_discount.Anchor = AnchorStyles.Right
        txt_discount.BorderStyle = BorderStyle.None
        txt_discount.Location = New Point(121, 190)
        txt_discount.Name = "txt_discount"
        txt_discount.ReadOnly = True
        txt_discount.Size = New Size(48, 20)
        txt_discount.TabIndex = 19
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New Point(29, 190)
        Label11.Name = "Label11"
        Label11.Size = New Size(86, 20)
        Label11.TabIndex = 21
        Label11.Text = "Discount %"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(89, 152)
        Label10.Name = "Label10"
        Label10.Size = New Size(80, 20)
        Label10.TabIndex = 20
        Label10.Text = "Total Price"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(77, 80)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 20)
        Label9.TabIndex = 19
        Label9.Text = "No. of Items"
        ' 
        ' lbl_OverAllGrandTotal
        ' 
        lbl_OverAllGrandTotal.Anchor = AnchorStyles.Right
        lbl_OverAllGrandTotal.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_OverAllGrandTotal.ForeColor = Color.Teal
        lbl_OverAllGrandTotal.Location = New Point(11, 23)
        lbl_OverAllGrandTotal.Name = "lbl_OverAllGrandTotal"
        lbl_OverAllGrandTotal.Size = New Size(326, 38)
        lbl_OverAllGrandTotal.TabIndex = 7
        lbl_OverAllGrandTotal.Text = "00.00"
        lbl_OverAllGrandTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column9, Column6, Column5, Column8})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 134)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(922, 446)
        DataGridView1.TabIndex = 5
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 47
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Product Code"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 131
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Product Name"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Category"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 101
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "ProductDescription"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 170
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Quantity"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 97
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Price"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 72
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Total Price"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Resizable = DataGridViewTriState.False
        Column8.Width = 109
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        ' 
        ' Cashier
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1271, 580)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Cashier"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POS and Inventory Management System"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_OrderNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents F1_New As Button
    Friend WithEvents f7_logout As Button
    Friend WithEvents f6_changepassword As Button
    Friend WithEvents f5_remove As Button
    Friend WithEvents f4_report As Button
    Friend WithEvents f3_setdiscount As Button
    Friend WithEvents f2_cancel As Button
    Friend WithEvents txt_SearchProductCode As TextBox
    Friend WithEvents dtp_OrderDate As DateTimePicker
    Friend WithEvents lbl_OverAllGrandTotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_Pay As Button
    Friend WithEvents lbl_noOfItems As Label
    Friend WithEvents lbl_Change As Label
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents lbl_Discount As Label
    Friend WithEvents lbl_TotalPrice As Label
    Friend WithEvents txt_amountReceived As TextBox
    Friend WithEvents cbo_paymentMode As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Timer2 As Timer
End Class
