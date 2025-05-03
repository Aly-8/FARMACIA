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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        f7_logout = New Button()
        f6_changepassword = New Button()
        f5_remove = New Button()
        f4_report = New Button()
        f3_setdiscount = New Button()
        f2_cancel = New Button()
        F1_New = New Button()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        TextBox2 = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1271, 64)
        Panel1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(623, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 20)
        Label4.TabIndex = 12
        Label4.Text = "Inventory System"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(623, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 20)
        Label3.TabIndex = 11
        Label3.Text = "Inventory System"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkCyan
        Label1.Location = New Point(47, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 31)
        Label1.TabIndex = 10
        Label1.Text = "POS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 7
        Label2.Text = "Inventory System"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 64)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1271, 70)
        Panel2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(163, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(13, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(223, 20)
        Label7.TabIndex = 15
        Label7.Text = "Product Name / Product Code :"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(623, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 20)
        Label6.TabIndex = 14
        Label6.Text = "Order Date :"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(14, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 20)
        Label5.TabIndex = 13
        Label5.Text = "Order NO :"
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
        TableLayoutPanel1.Controls.Add(f6_changepassword, 5, 0)
        TableLayoutPanel1.Controls.Add(f5_remove, 4, 0)
        TableLayoutPanel1.Controls.Add(f4_report, 3, 0)
        TableLayoutPanel1.Controls.Add(f3_setdiscount, 2, 0)
        TableLayoutPanel1.Controls.Add(f2_cancel, 1, 0)
        TableLayoutPanel1.Controls.Add(F1_New, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Bottom
        TableLayoutPanel1.Location = New Point(0, 503)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1271, 41)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' f7_logout
        ' 
        f7_logout.BackColor = Color.DarkSlateGray
        f7_logout.FlatAppearance.BorderSize = 0
        f7_logout.FlatStyle = FlatStyle.Flat
        f7_logout.ForeColor = SystemColors.ButtonHighlight
        f7_logout.Location = New Point(1089, 3)
        f7_logout.Name = "f7_logout"
        f7_logout.Size = New Size(175, 35)
        f7_logout.TabIndex = 6
        f7_logout.Text = "[ F7-Logout]"
        f7_logout.UseVisualStyleBackColor = False
        ' 
        ' f6_changepassword
        ' 
        f6_changepassword.BackColor = Color.CadetBlue
        f6_changepassword.FlatAppearance.BorderSize = 0
        f6_changepassword.FlatStyle = FlatStyle.Flat
        f6_changepassword.ForeColor = SystemColors.ButtonHighlight
        f6_changepassword.Location = New Point(908, 3)
        f6_changepassword.Name = "f6_changepassword"
        f6_changepassword.Size = New Size(175, 35)
        f6_changepassword.TabIndex = 5
        f6_changepassword.Text = "[ F6Change Passowrd]"
        f6_changepassword.UseVisualStyleBackColor = False
        ' 
        ' f5_remove
        ' 
        f5_remove.BackColor = Color.CadetBlue
        f5_remove.FlatAppearance.BorderSize = 0
        f5_remove.FlatStyle = FlatStyle.Flat
        f5_remove.ForeColor = SystemColors.ButtonHighlight
        f5_remove.Location = New Point(727, 3)
        f5_remove.Name = "f5_remove"
        f5_remove.Size = New Size(175, 35)
        f5_remove.TabIndex = 4
        f5_remove.Text = "[ F5-Remove]"
        f5_remove.UseVisualStyleBackColor = False
        ' 
        ' f4_report
        ' 
        f4_report.BackColor = Color.CadetBlue
        f4_report.FlatAppearance.BorderSize = 0
        f4_report.FlatStyle = FlatStyle.Flat
        f4_report.ForeColor = SystemColors.ButtonHighlight
        f4_report.Location = New Point(546, 3)
        f4_report.Name = "f4_report"
        f4_report.Size = New Size(175, 35)
        f4_report.TabIndex = 3
        f4_report.Text = "[ F4-Report]"
        f4_report.UseVisualStyleBackColor = False
        ' 
        ' f3_setdiscount
        ' 
        f3_setdiscount.BackColor = Color.CadetBlue
        f3_setdiscount.FlatAppearance.BorderSize = 0
        f3_setdiscount.FlatStyle = FlatStyle.Flat
        f3_setdiscount.ForeColor = SystemColors.ButtonHighlight
        f3_setdiscount.Location = New Point(365, 3)
        f3_setdiscount.Name = "f3_setdiscount"
        f3_setdiscount.Size = New Size(175, 35)
        f3_setdiscount.TabIndex = 2
        f3_setdiscount.Text = "[ F3-Set Discount]"
        f3_setdiscount.UseVisualStyleBackColor = False
        ' 
        ' f2_cancel
        ' 
        f2_cancel.BackColor = Color.CadetBlue
        f2_cancel.FlatAppearance.BorderSize = 0
        f2_cancel.FlatStyle = FlatStyle.Flat
        f2_cancel.ForeColor = SystemColors.ButtonHighlight
        f2_cancel.Location = New Point(184, 3)
        f2_cancel.Name = "f2_cancel"
        f2_cancel.Size = New Size(175, 35)
        f2_cancel.TabIndex = 1
        f2_cancel.Text = "[ F2-Cancel]"
        f2_cancel.UseVisualStyleBackColor = False
        ' 
        ' F1_New
        ' 
        F1_New.BackColor = Color.CadetBlue
        F1_New.FlatAppearance.BorderSize = 0
        F1_New.FlatStyle = FlatStyle.Flat
        F1_New.ForeColor = SystemColors.ButtonHighlight
        F1_New.Location = New Point(3, 3)
        F1_New.Name = "F1_New"
        F1_New.Size = New Size(175, 35)
        F1_New.TabIndex = 0
        F1_New.Text = "[ F1-New]"
        F1_New.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(818, 134)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(453, 369)
        Panel3.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column6, Column5, Column7, Column8})
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
        DataGridView1.Size = New Size(818, 369)
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
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Subtotal"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 95
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Total"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 71
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(242, 39)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(576, 27)
        TextBox2.TabIndex = 17
        ' 
        ' Cashier
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1271, 544)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Cashier"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POS and Inventory Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents F1_New As Button
    Friend WithEvents f7_logout As Button
    Friend WithEvents f6_changepassword As Button
    Friend WithEvents f5_remove As Button
    Friend WithEvents f4_report As Button
    Friend WithEvents f3_setdiscount As Button
    Friend WithEvents f2_cancel As Button
    Friend WithEvents TextBox2 As TextBox
End Class
