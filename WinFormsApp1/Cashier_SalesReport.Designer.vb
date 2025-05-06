<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashier_SalesReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel4 = New Panel()
        Label3 = New Label()
        btn_filter = New Button()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        rbtn_currentMonth = New RadioButton()
        rbtn_Today = New RadioButton()
        txt_search = New TextBox()
        Panel3 = New Panel()
        lbl_totalDisplay = New Label()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.LightSteelBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column6, Column5})
        DataGridView1.Location = New Point(-3, 143)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1096, 511)
        DataGridView1.TabIndex = 13
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
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Column3.DefaultCellStyle = DataGridViewCellStyle2
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
        Column4.Width = 81
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Month and Year"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Grand Total"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 106
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
        Panel4.Location = New Point(-3, 77)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1096, 228)
        Panel4.TabIndex = 12
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkSlateGray
        Panel3.Controls.Add(lbl_totalDisplay)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(-3, -14)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1096, 252)
        Panel3.TabIndex = 11
        ' 
        ' lbl_totalDisplay
        ' 
        lbl_totalDisplay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_totalDisplay.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_totalDisplay.ForeColor = Color.PaleGreen
        lbl_totalDisplay.Location = New Point(1595, 25)
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
        ' Cashier_SalesReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1091, 653)
        Controls.Add(DataGridView1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Name = "Cashier_SalesReport"
        Text = "Cashier_SalesReport"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_filter As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rbtn_currentMonth As RadioButton
    Friend WithEvents rbtn_Today As RadioButton
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_totalDisplay As Label
    Friend WithEvents Label2 As Label
End Class
