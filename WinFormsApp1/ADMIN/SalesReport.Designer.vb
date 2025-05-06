<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReport))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel2 = New Panel()
        LOGOUT = New Label()
        Label1 = New Label()
        user_btn = New Button()
        salesreport_btn = New Button()
        categories_btn = New Button()
        additem_btn = New Button()
        inventory_btn = New Button()
        Dashboard_btn = New Button()
        Panel1 = New Panel()
        fdg = New PictureBox()
        Exit_btn = New Button()
        Panel3 = New Panel()
        lbl_totalDisplay = New Label()
        Label2 = New Label()
        Panel4 = New Panel()
        Label3 = New Label()
        btn_filter = New Button()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        rbtn_currentMonth = New RadioButton()
        rbtn_Today = New RadioButton()
        txt_search = New TextBox()
        DataGridView1 = New DataGridView()
        Timer1 = New Timer(components)
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(fdg, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.CadetBlue
        Panel2.Controls.Add(LOGOUT)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(user_btn)
        Panel2.Controls.Add(salesreport_btn)
        Panel2.Controls.Add(categories_btn)
        Panel2.Controls.Add(additem_btn)
        Panel2.Controls.Add(inventory_btn)
        Panel2.Controls.Add(Dashboard_btn)
        Panel2.Location = New Point(0, 89)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(278, 511)
        Panel2.TabIndex = 7
        ' 
        ' LOGOUT
        ' 
        LOGOUT.AutoSize = True
        LOGOUT.FlatStyle = FlatStyle.Flat
        LOGOUT.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        LOGOUT.ForeColor = Color.MintCream
        LOGOUT.Location = New Point(84, 456)
        LOGOUT.Name = "LOGOUT"
        LOGOUT.Size = New Size(116, 26)
        LOGOUT.TabIndex = 2
        LOGOUT.Text = "LOGOUT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(1, 409)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 25)
        Label1.TabIndex = 8
        Label1.Text = "________________________"
        ' 
        ' user_btn
        ' 
        user_btn.FlatAppearance.BorderColor = Color.Teal
        user_btn.FlatStyle = FlatStyle.Flat
        user_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        user_btn.ForeColor = Color.Snow
        user_btn.Location = New Point(30, 335)
        user_btn.Name = "user_btn"
        user_btn.Size = New Size(226, 37)
        user_btn.TabIndex = 7
        user_btn.Text = "USER"
        user_btn.UseVisualStyleBackColor = True
        ' 
        ' salesreport_btn
        ' 
        salesreport_btn.FlatAppearance.BorderColor = Color.Teal
        salesreport_btn.FlatStyle = FlatStyle.Flat
        salesreport_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        salesreport_btn.ForeColor = Color.Snow
        salesreport_btn.Location = New Point(30, 281)
        salesreport_btn.Name = "salesreport_btn"
        salesreport_btn.Size = New Size(226, 37)
        salesreport_btn.TabIndex = 6
        salesreport_btn.Text = "SALES REPORT"
        salesreport_btn.UseVisualStyleBackColor = True
        ' 
        ' categories_btn
        ' 
        categories_btn.FlatAppearance.BorderColor = Color.Teal
        categories_btn.FlatStyle = FlatStyle.Flat
        categories_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        categories_btn.ForeColor = Color.Snow
        categories_btn.Location = New Point(30, 227)
        categories_btn.Name = "categories_btn"
        categories_btn.Size = New Size(226, 37)
        categories_btn.TabIndex = 5
        categories_btn.Text = "CATEGORIES"
        categories_btn.UseVisualStyleBackColor = True
        ' 
        ' additem_btn
        ' 
        additem_btn.FlatAppearance.BorderColor = Color.Teal
        additem_btn.FlatStyle = FlatStyle.Flat
        additem_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        additem_btn.ForeColor = Color.Snow
        additem_btn.Location = New Point(30, 171)
        additem_btn.Name = "additem_btn"
        additem_btn.Size = New Size(226, 37)
        additem_btn.TabIndex = 4
        additem_btn.Text = "STOCK"
        additem_btn.UseVisualStyleBackColor = True
        ' 
        ' inventory_btn
        ' 
        inventory_btn.FlatAppearance.BorderColor = Color.Teal
        inventory_btn.FlatStyle = FlatStyle.Flat
        inventory_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        inventory_btn.ForeColor = Color.Snow
        inventory_btn.Location = New Point(30, 112)
        inventory_btn.Name = "inventory_btn"
        inventory_btn.Size = New Size(226, 37)
        inventory_btn.TabIndex = 3
        inventory_btn.Text = "INVENTORY"
        inventory_btn.UseVisualStyleBackColor = True
        ' 
        ' Dashboard_btn
        ' 
        Dashboard_btn.FlatAppearance.BorderColor = Color.Teal
        Dashboard_btn.FlatStyle = FlatStyle.Flat
        Dashboard_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        Dashboard_btn.ForeColor = Color.Snow
        Dashboard_btn.Location = New Point(30, 52)
        Dashboard_btn.Name = "Dashboard_btn"
        Dashboard_btn.Size = New Size(226, 37)
        Dashboard_btn.TabIndex = 2
        Dashboard_btn.Text = "DASHBOARD"
        Dashboard_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(fdg)
        Panel1.Controls.Add(Exit_btn)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1500, 90)
        Panel1.TabIndex = 6
        ' 
        ' fdg
        ' 
        fdg.BackgroundImageLayout = ImageLayout.None
        fdg.Dock = DockStyle.Left
        fdg.ErrorImage = Nothing
        fdg.Image = CType(resources.GetObject("fdg.Image"), Image)
        fdg.Location = New Point(0, 0)
        fdg.Name = "fdg"
        fdg.Size = New Size(278, 90)
        fdg.SizeMode = PictureBoxSizeMode.Zoom
        fdg.TabIndex = 19
        fdg.TabStop = False
        ' 
        ' Exit_btn
        ' 
        Exit_btn.BackColor = Color.IndianRed
        Exit_btn.FlatAppearance.BorderSize = 0
        Exit_btn.FlatStyle = FlatStyle.Flat
        Exit_btn.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Exit_btn.Location = New Point(1448, 12)
        Exit_btn.Name = "Exit_btn"
        Exit_btn.Size = New Size(40, 30)
        Exit_btn.TabIndex = 2
        Exit_btn.Text = "X"
        Exit_btn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkSlateGray
        Panel3.Controls.Add(lbl_totalDisplay)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(276, 89)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1212, 95)
        Panel3.TabIndex = 8
        ' 
        ' lbl_totalDisplay
        ' 
        lbl_totalDisplay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_totalDisplay.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_totalDisplay.ForeColor = Color.PaleGreen
        lbl_totalDisplay.Location = New Point(965, 25)
        lbl_totalDisplay.Name = "lbl_totalDisplay"
        lbl_totalDisplay.Size = New Size(244, 63)
        lbl_totalDisplay.TabIndex = 1
        lbl_totalDisplay.Text = "0.00"
        lbl_totalDisplay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Honeydew
        Label2.Location = New Point(33, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 38)
        Label2.TabIndex = 0
        Label2.Text = "Sales Report"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(btn_filter)
        Panel4.Controls.Add(DateTimePicker2)
        Panel4.Controls.Add(DateTimePicker1)
        Panel4.Controls.Add(rbtn_currentMonth)
        Panel4.Controls.Add(rbtn_Today)
        Panel4.Controls.Add(txt_search)
        Panel4.Location = New Point(276, 180)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1212, 71)
        Panel4.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(29, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 23)
        Label3.TabIndex = 10
        Label3.Text = "Search"
        ' 
        ' btn_filter
        ' 
        btn_filter.BackColor = Color.CadetBlue
        btn_filter.FlatAppearance.BorderSize = 0
        btn_filter.FlatStyle = FlatStyle.Flat
        btn_filter.Location = New Point(815, 20)
        btn_filter.Name = "btn_filter"
        btn_filter.Size = New Size(94, 29)
        btn_filter.TabIndex = 14
        btn_filter.Text = "Filter"
        btn_filter.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(535, 21)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(127, 27)
        DateTimePicker2.TabIndex = 13
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(666, 21)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(127, 27)
        DateTimePicker1.TabIndex = 12
        ' 
        ' rbtn_currentMonth
        ' 
        rbtn_currentMonth.AutoSize = True
        rbtn_currentMonth.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbtn_currentMonth.Location = New Point(370, 21)
        rbtn_currentMonth.Name = "rbtn_currentMonth"
        rbtn_currentMonth.Size = New Size(146, 27)
        rbtn_currentMonth.TabIndex = 11
        rbtn_currentMonth.TabStop = True
        rbtn_currentMonth.Text = "Current Month"
        rbtn_currentMonth.UseVisualStyleBackColor = True
        ' 
        ' rbtn_Today
        ' 
        rbtn_Today.AutoSize = True
        rbtn_Today.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbtn_Today.Location = New Point(279, 21)
        rbtn_Today.Name = "rbtn_Today"
        rbtn_Today.Size = New Size(76, 27)
        rbtn_Today.TabIndex = 0
        rbtn_Today.TabStop = True
        rbtn_Today.Text = "Today"
        rbtn_Today.UseVisualStyleBackColor = True
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(93, 20)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(167, 27)
        txt_search.TabIndex = 10
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.LightSteelBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column6, Column5})
        DataGridView1.Location = New Point(276, 246)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1212, 354)
        DataGridView1.TabIndex = 10
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.Frozen = True
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 47
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Transaction No."
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Column3.DefaultCellStyle = DataGridViewCellStyle1
        Column3.HeaderText = "Date"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Month"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Visible = False
        Column4.Width = 81
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Month and Year"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Visible = False
        Column6.Width = 125
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Grand Total"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 115
        ' 
        ' SalesReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(1500, 600)
        ControlBox = False
        Controls.Add(DataGridView1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "SalesReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SalesReport"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(fdg, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LOGOUT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents user_btn As Button
    Friend WithEvents salesreport_btn As Button
    Friend WithEvents categories_btn As Button
    Friend WithEvents additem_btn As Button
    Friend WithEvents inventory_btn As Button
    Friend WithEvents Dashboard_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Exit_btn As Button
    Friend WithEvents fdg As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rbtn_currentMonth As RadioButton
    Friend WithEvents rbtn_Today As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_filter As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lbl_totalDisplay As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
