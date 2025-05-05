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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReport))
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        AddCategory_lbl = New Label()
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
        Label2 = New Label()
        txt_Search = New TextBox()
        rdbtn_today = New RadioButton()
        rbtn_currentmonth = New RadioButton()
        btn_Filter = New Panel()
        DateTimePicker2 = New DateTimePicker()
        Button1 = New Button()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewButtonColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        DateTimePicker1 = New DateTimePicker()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(fdg, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        btn_Filter.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AddCategory_lbl
        ' 
        AddCategory_lbl.AutoSize = True
        AddCategory_lbl.Font = New Font("Palatino Linotype", 25.8F, FontStyle.Bold)
        AddCategory_lbl.ForeColor = Color.Teal
        AddCategory_lbl.Location = New Point(318, 105)
        AddCategory_lbl.Name = "AddCategory_lbl"
        AddCategory_lbl.Size = New Size(273, 58)
        AddCategory_lbl.TabIndex = 8
        AddCategory_lbl.Text = "Sales Report"
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
        Panel3.BackColor = SystemColors.GradientInactiveCaption
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(DateTimePicker2)
        Panel3.Controls.Add(rbtn_currentmonth)
        Panel3.Controls.Add(rdbtn_today)
        Panel3.Controls.Add(txt_Search)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(320, 168)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1140, 79)
        Panel3.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(26, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 19)
        Label2.TabIndex = 0
        Label2.Text = "Search"
        ' 
        ' txt_Search
        ' 
        txt_Search.Location = New Point(99, 25)
        txt_Search.Name = "txt_Search"
        txt_Search.Size = New Size(366, 27)
        txt_Search.TabIndex = 26
        ' 
        ' rdbtn_today
        ' 
        rdbtn_today.AutoSize = True
        rdbtn_today.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdbtn_today.Location = New Point(492, 26)
        rdbtn_today.Name = "rdbtn_today"
        rdbtn_today.Size = New Size(71, 24)
        rdbtn_today.TabIndex = 27
        rdbtn_today.TabStop = True
        rdbtn_today.Text = "Today"
        rdbtn_today.UseVisualStyleBackColor = True
        ' 
        ' rbtn_currentmonth
        ' 
        rbtn_currentmonth.AutoSize = True
        rbtn_currentmonth.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbtn_currentmonth.Location = New Point(580, 26)
        rbtn_currentmonth.Name = "rbtn_currentmonth"
        rbtn_currentmonth.Size = New Size(132, 24)
        rbtn_currentmonth.TabIndex = 28
        rbtn_currentmonth.TabStop = True
        rbtn_currentmonth.Text = "Current Month"
        rbtn_currentmonth.UseVisualStyleBackColor = True
        ' 
        ' btn_Filter
        ' 
        btn_Filter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_Filter.AutoSize = True
        btn_Filter.BackColor = SystemColors.ControlLight
        btn_Filter.Controls.Add(DataGridView1)
        btn_Filter.Location = New Point(320, 253)
        btn_Filter.Margin = New Padding(2)
        btn_Filter.Name = "btn_Filter"
        btn_Filter.Size = New Size(1140, 328)
        btn_Filter.TabIndex = 10
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(883, 24)
        DateTimePicker2.Margin = New Padding(0)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(137, 27)
        DateTimePicker2.TabIndex = 30
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkCyan
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(1036, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 31
        Button1.Text = "Filter"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.Font = New Font("Century Schoolbook", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkSlateGray
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(1167, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(293, 58)
        Label3.TabIndex = 0
        Label3.Text = "0.00"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column6, Column5})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.GridColor = SystemColors.ButtonShadow
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1140, 328)
        DataGridView1.TabIndex = 0
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
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Transaction No."
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Column3.DefaultCellStyle = DataGridViewCellStyle4
        Column3.HeaderText = "Date"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Resizable = DataGridViewTriState.True
        Column3.SortMode = DataGridViewColumnSortMode.Automatic
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
        Column6.HeaderText = "Month & Year"
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
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarTrailingForeColor = Color.Gray
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(730, 24)
        DateTimePicker1.Margin = New Padding(0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(137, 27)
        DateTimePicker1.TabIndex = 32
        DateTimePicker1.Value = New Date(2025, 5, 5, 0, 0, 0, 0)
        ' 
        ' SalesReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(1500, 600)
        ControlBox = False
        Controls.Add(Label3)
        Controls.Add(btn_Filter)
        Controls.Add(Panel3)
        Controls.Add(AddCategory_lbl)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SalesReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SalesReport"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(fdg, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        btn_Filter.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddCategory_lbl As Label
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
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents rbtn_currentmonth As RadioButton
    Friend WithEvents rdbtn_today As RadioButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btn_Filter As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
