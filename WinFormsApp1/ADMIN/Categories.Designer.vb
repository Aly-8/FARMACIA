<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Categories
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
        fdg = New PictureBox()
        AddCategory_lbl = New Label()
        ProductID = New Label()
        Txt_CategoryName = New TextBox()
        Add_btn = New Button()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Logout_btn = New Button()
        Label1 = New Label()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        additem_btn = New Button()
        Inventory_btn = New Button()
        Dashboard_btn = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(fdg, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(fdg)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1500, 90)
        Panel1.TabIndex = 3
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
        fdg.TabIndex = 3
        fdg.TabStop = False
        ' 
        ' AddCategory_lbl
        ' 
        AddCategory_lbl.AutoSize = True
        AddCategory_lbl.Font = New Font("Palatino Linotype", 25.8F, FontStyle.Bold)
        AddCategory_lbl.ForeColor = Color.Teal
        AddCategory_lbl.Location = New Point(761, 93)
        AddCategory_lbl.Name = "AddCategory_lbl"
        AddCategory_lbl.Size = New Size(299, 58)
        AddCategory_lbl.TabIndex = 5
        AddCategory_lbl.Text = "Add Category"
        ' 
        ' ProductID
        ' 
        ProductID.AutoSize = True
        ProductID.Font = New Font("Century Schoolbook", 10.2F, FontStyle.Bold)
        ProductID.ForeColor = Color.Teal
        ProductID.Location = New Point(566, 171)
        ProductID.Name = "ProductID"
        ProductID.Size = New Size(144, 21)
        ProductID.TabIndex = 7
        ProductID.Text = "Category Name"
        ' 
        ' Txt_CategoryName
        ' 
        Txt_CategoryName.Location = New Point(728, 168)
        Txt_CategoryName.Name = "Txt_CategoryName"
        Txt_CategoryName.Size = New Size(316, 27)
        Txt_CategoryName.TabIndex = 8
        ' 
        ' Add_btn
        ' 
        Add_btn.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold)
        Add_btn.ForeColor = Color.SteelBlue
        Add_btn.Location = New Point(1059, 168)
        Add_btn.Name = "Add_btn"
        Add_btn.Size = New Size(67, 27)
        Add_btn.TabIndex = 9
        Add_btn.Text = "ADD"
        Add_btn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold)
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(284, 252)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 32)
        Label2.TabIndex = 10
        Label2.Text = "Category List"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei", 12.0F, FontStyle.Bold)
        Label3.ForeColor = Color.Teal
        Label3.Location = New Point(1170, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 27)
        Label3.TabIndex = 11
        Label3.Text = "Search:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(1277, 252)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(203, 27)
        TextBox2.TabIndex = 12
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightSteelBlue
        Panel3.Location = New Point(287, 227)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1199, 16)
        Panel3.TabIndex = 13
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.CadetBlue
        Panel4.Controls.Add(Logout_btn)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Button6)
        Panel4.Controls.Add(Button7)
        Panel4.Controls.Add(Button8)
        Panel4.Controls.Add(additem_btn)
        Panel4.Controls.Add(Inventory_btn)
        Panel4.Controls.Add(Dashboard_btn)
        Panel4.Location = New Point(0, 89)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(278, 611)
        Panel4.TabIndex = 15
        ' 
        ' Logout_btn
        ' 
        Logout_btn.FlatAppearance.BorderColor = Color.Teal
        Logout_btn.FlatStyle = FlatStyle.Flat
        Logout_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        Logout_btn.ForeColor = Color.Snow
        Logout_btn.Location = New Point(24, 529)
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
        Label1.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(1, 476)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 25)
        Label1.TabIndex = 8
        Label1.Text = "________________________"
        ' 
        ' Button6
        ' 
        Button6.FlatAppearance.BorderColor = Color.Teal
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        Button6.ForeColor = Color.Snow
        Button6.Location = New Point(24, 371)
        Button6.Name = "Button6"
        Button6.Size = New Size(226, 37)
        Button6.TabIndex = 7
        Button6.Text = "USER"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.FlatAppearance.BorderColor = Color.Teal
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        Button7.ForeColor = Color.Snow
        Button7.Location = New Point(24, 317)
        Button7.Name = "Button7"
        Button7.Size = New Size(226, 37)
        Button7.TabIndex = 6
        Button7.Text = "SALES REPORT"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.FlatAppearance.BorderColor = Color.Teal
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        Button8.ForeColor = Color.Snow
        Button8.Location = New Point(24, 263)
        Button8.Name = "Button8"
        Button8.Size = New Size(226, 37)
        Button8.TabIndex = 5
        Button8.Text = "CATEGORIES"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' additem_btn
        ' 
        additem_btn.FlatAppearance.BorderColor = Color.Teal
        additem_btn.FlatStyle = FlatStyle.Flat
        additem_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        additem_btn.ForeColor = Color.Snow
        additem_btn.Location = New Point(24, 207)
        additem_btn.Name = "additem_btn"
        additem_btn.Size = New Size(226, 37)
        additem_btn.TabIndex = 4
        additem_btn.Text = "STOCK"
        additem_btn.UseVisualStyleBackColor = True
        ' 
        ' Inventory_btn
        ' 
        Inventory_btn.Cursor = Cursors.Hand
        Inventory_btn.FlatAppearance.BorderColor = Color.Teal
        Inventory_btn.FlatStyle = FlatStyle.Flat
        Inventory_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        Inventory_btn.ForeColor = Color.Snow
        Inventory_btn.Location = New Point(24, 148)
        Inventory_btn.Name = "Inventory_btn"
        Inventory_btn.Size = New Size(226, 37)
        Inventory_btn.TabIndex = 3
        Inventory_btn.Text = "INVENTORY"
        Inventory_btn.UseVisualStyleBackColor = True
        ' 
        ' Dashboard_btn
        ' 
        Dashboard_btn.Cursor = Cursors.Hand
        Dashboard_btn.FlatAppearance.BorderColor = Color.Teal
        Dashboard_btn.FlatStyle = FlatStyle.Flat
        Dashboard_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        Dashboard_btn.ForeColor = Color.Snow
        Dashboard_btn.Location = New Point(24, 88)
        Dashboard_btn.Name = "Dashboard_btn"
        Dashboard_btn.Size = New Size(226, 37)
        Dashboard_btn.TabIndex = 2
        Dashboard_btn.Text = "DASHBOARD"
        Dashboard_btn.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column4})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Info
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(296, 314)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1184, 341)
        DataGridView1.TabIndex = 12
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
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "CATEGORY NAME"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold)
        Button1.ForeColor = Color.SteelBlue
        Button1.Location = New Point(1142, 168)
        Button1.Name = "Button1"
        Button1.Size = New Size(67, 27)
        Button1.TabIndex = 16
        Button1.Text = "DELETE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Categories
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(1500, 700)
        ControlBox = False
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Add_btn)
        Controls.Add(Txt_CategoryName)
        Controls.Add(ProductID)
        Controls.Add(AddCategory_lbl)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Categories"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Categories"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(fdg, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddCategory_lbl As Label
    Friend WithEvents ProductID As Label
    Friend WithEvents Txt_CategoryName As TextBox
    Friend WithEvents Add_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents additem_btn As Button
    Friend WithEvents Inventory_btn As Button
    Friend WithEvents Dashboard_btn As Button
    Friend WithEvents fdg As PictureBox
    Friend WithEvents Logout_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
