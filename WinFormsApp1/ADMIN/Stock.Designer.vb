<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stock
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
        Exit_btn = New Button()
        Panel1 = New Panel()
        fdg = New PictureBox()
        Panel2 = New Panel()
        Logout_btn = New Button()
        Label1 = New Label()
        user_btn = New Button()
        salesreport_btn = New Button()
        categories_btn = New Button()
        stock_btn = New Button()
        inventory_btn = New Button()
        Dashboard_btn = New Button()
        AddItem_bttn = New Button()
        DataGridView1 = New DataGridView()
        txt_Search = New TextBox()
        Label2 = New Label()
        AddCategory_lbl = New Label()
        UpdateStock_btn = New Button()
        Label3 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(fdg, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(fdg)
        Panel1.Controls.Add(Exit_btn)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1500, 90)
        Panel1.TabIndex = 1
        ' 
        ' fdg
        ' 
        fdg.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        fdg.BackgroundImageLayout = ImageLayout.None
        fdg.ErrorImage = Nothing
        fdg.Location = New Point(40, 7)
        fdg.Name = "fdg"
        fdg.Size = New Size(160, 59)
        fdg.SizeMode = PictureBoxSizeMode.AutoSize
        fdg.TabIndex = 21
        fdg.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.CadetBlue
        Panel2.Controls.Add(Logout_btn)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(user_btn)
        Panel2.Controls.Add(salesreport_btn)
        Panel2.Controls.Add(categories_btn)
        Panel2.Controls.Add(stock_btn)
        Panel2.Controls.Add(inventory_btn)
        Panel2.Controls.Add(Dashboard_btn)
        Panel2.Location = New Point(0, 89)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(278, 511)
        Panel2.TabIndex = 2
        ' 
        ' Logout_btn
        ' 
        Logout_btn.FlatAppearance.BorderColor = Color.Teal
        Logout_btn.FlatStyle = FlatStyle.Flat
        Logout_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        Logout_btn.ForeColor = Color.Snow
        Logout_btn.Location = New Point(30, 462)
        Logout_btn.Name = "Logout_btn"
        Logout_btn.Size = New Size(226, 37)
        Logout_btn.TabIndex = 11
        Logout_btn.Text = "LOGOUT"
        Logout_btn.UseVisualStyleBackColor = True
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
        ' stock_btn
        ' 
        stock_btn.FlatAppearance.BorderColor = Color.Teal
        stock_btn.FlatStyle = FlatStyle.Flat
        stock_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        stock_btn.ForeColor = Color.Snow
        stock_btn.Location = New Point(30, 171)
        stock_btn.Name = "stock_btn"
        stock_btn.Size = New Size(226, 37)
        stock_btn.TabIndex = 4
        stock_btn.Text = "STOCK"
        stock_btn.UseVisualStyleBackColor = True
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
        ' AddItem_bttn
        ' 
        AddItem_bttn.BackColor = Color.CadetBlue
        AddItem_bttn.FlatAppearance.BorderSize = 0
        AddItem_bttn.FlatStyle = FlatStyle.Flat
        AddItem_bttn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddItem_bttn.ForeColor = SystemColors.ButtonHighlight
        AddItem_bttn.Location = New Point(854, -84)
        AddItem_bttn.Name = "AddItem_bttn"
        AddItem_bttn.Size = New Size(116, 48)
        AddItem_bttn.TabIndex = 20
        AddItem_bttn.Text = "ADD"
        AddItem_bttn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column9})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Info
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(293, 201)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1195, 343)
        DataGridView1.TabIndex = 21
        ' 
        ' txt_Search
        ' 
        txt_Search.Location = New Point(370, 156)
        txt_Search.Name = "txt_Search"
        txt_Search.Size = New Size(366, 27)
        txt_Search.TabIndex = 27
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(297, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 19)
        Label2.TabIndex = 26
        Label2.Text = "Search "
        ' 
        ' AddCategory_lbl
        ' 
        AddCategory_lbl.AutoSize = True
        AddCategory_lbl.Font = New Font("Palatino Linotype", 25.8F, FontStyle.Bold)
        AddCategory_lbl.ForeColor = Color.Teal
        AddCategory_lbl.Location = New Point(794, 93)
        AddCategory_lbl.Name = "AddCategory_lbl"
        AddCategory_lbl.Size = New Size(180, 58)
        AddCategory_lbl.TabIndex = 28
        AddCategory_lbl.Text = "STOCK"
        ' 
        ' UpdateStock_btn
        ' 
        UpdateStock_btn.BackColor = Color.DarkCyan
        UpdateStock_btn.FlatAppearance.BorderSize = 0
        UpdateStock_btn.FlatStyle = FlatStyle.Popup
        UpdateStock_btn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateStock_btn.ForeColor = SystemColors.ButtonHighlight
        UpdateStock_btn.Location = New Point(1345, 156)
        UpdateStock_btn.Name = "UpdateStock_btn"
        UpdateStock_btn.Size = New Size(142, 31)
        UpdateStock_btn.TabIndex = 29
        UpdateStock_btn.Text = "UPDATE STOCK"
        UpdateStock_btn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.IndianRed
        Label3.Location = New Point(811, 561)
        Label3.Name = "Label3"
        Label3.Size = New Size(677, 20)
        Label3.TabIndex = 30
        Label3.Text = "NOTE: Do not leave the stock blank, as it will invalidate the data you inserted when updating."
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.False
        Column1.Width = 47
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "CODE"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Resizable = DataGridViewTriState.False
        Column2.Width = 77
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "NAME"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Resizable = DataGridViewTriState.False
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "CATEGORY"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Resizable = DataGridViewTriState.False
        Column4.Width = 110
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "DESCRIPTION"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.False
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "STOCK"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Resizable = DataGridViewTriState.False
        Column6.Width = 82
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "PRICE"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Resizable = DataGridViewTriState.False
        Column7.Width = 76
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "TOTAL PRICE"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 125
        ' 
        ' Stock
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1500, 600)
        ControlBox = False
        Controls.Add(Label3)
        Controls.Add(UpdateStock_btn)
        Controls.Add(AddCategory_lbl)
        Controls.Add(txt_Search)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(AddItem_bttn)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Stock"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddItem"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(fdg, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Exit_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents user_btn As Button
    Friend WithEvents salesreport_btn As Button
    Friend WithEvents categories_btn As Button
    Friend WithEvents stock_btn As Button
    Friend WithEvents inventory_btn As Button
    Friend WithEvents Dashboard_btn As Button
    Friend WithEvents AddItem_bttn As Button
    Friend WithEvents fdg As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AddCategory_lbl As Label
    Friend WithEvents Logout_btn As Button
    Friend WithEvents UpdateStock_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
