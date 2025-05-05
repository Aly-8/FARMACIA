<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        txt_Search = New TextBox()
        Label1 = New Label()
        TabPage2 = New TabPage()
        txt_totalPrice = New TextBox()
        lbl_TotalPrice = New Label()
        clear_btn = New Button()
        delete_btn = New Button()
        update_btn = New Button()
        save_btn = New Button()
        search_btn = New Button()
        txt_productname = New TextBox()
        cbo_category = New ComboBox()
        txt_price = New TextBox()
        txt_productdescription = New TextBox()
        PDescription = New Label()
        PExpDate = New Label()
        PPrice = New Label()
        txt_stock = New TextBox()
        txt_productcode = New TextBox()
        PQuantity = New Label()
        PCategory = New Label()
        PName = New Label()
        txt_SearchProductCode = New TextBox()
        ProductID = New Label()
        Panel4 = New Panel()
        Logout_btn = New Button()
        Label3 = New Label()
        Button6 = New Button()
        Button7 = New Button()
        categories_btn = New Button()
        stock_btn = New Button()
        Inventory_btn = New Button()
        Dashboard_btn = New Button()
        CType(fdg, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1500, 90)
        Panel1.TabIndex = 2
        ' 
        ' fdg
        ' 
        fdg.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        fdg.BackColor = SystemColors.ActiveCaption
        fdg.BackgroundImageLayout = ImageLayout.None
        fdg.ErrorImage = Nothing
        fdg.Location = New Point(40, 7)
        fdg.Name = "fdg"
        fdg.Size = New Size(160, 59)
        fdg.SizeMode = PictureBoxSizeMode.AutoSize
        fdg.TabIndex = 10
        fdg.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(298, 105)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(8, 15)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1187, 583)
        TabControl1.TabIndex = 11
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Controls.Add(Panel3)
        TabPage1.Location = New Point(4, 50)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1179, 529)
        TabPage1.TabIndex = 0
        TabPage1.Text = "INVENTORY LIST"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Info
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(4, 56)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1173, 452)
        DataGridView1.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 45
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "CODE"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 72
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "NAME"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "CATEGORY"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 103
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "DESCRIPTION"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "STOCK"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Resizable = DataGridViewTriState.True
        Column6.Visible = False
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "PRICE"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 72
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "TOTAL PRICE"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 116
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(txt_Search)
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1173, 49)
        Panel3.TabIndex = 0
        ' 
        ' txt_Search
        ' 
        txt_Search.Location = New Point(85, 17)
        txt_Search.Name = "txt_Search"
        txt_Search.Size = New Size(366, 25)
        txt_Search.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 19)
        Label1.TabIndex = 24
        Label1.Text = "Search "
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(txt_totalPrice)
        TabPage2.Controls.Add(lbl_TotalPrice)
        TabPage2.Controls.Add(clear_btn)
        TabPage2.Controls.Add(delete_btn)
        TabPage2.Controls.Add(update_btn)
        TabPage2.Controls.Add(save_btn)
        TabPage2.Controls.Add(search_btn)
        TabPage2.Controls.Add(txt_productname)
        TabPage2.Controls.Add(cbo_category)
        TabPage2.Controls.Add(txt_price)
        TabPage2.Controls.Add(txt_productdescription)
        TabPage2.Controls.Add(PDescription)
        TabPage2.Controls.Add(PExpDate)
        TabPage2.Controls.Add(PPrice)
        TabPage2.Controls.Add(txt_stock)
        TabPage2.Controls.Add(txt_productcode)
        TabPage2.Controls.Add(PQuantity)
        TabPage2.Controls.Add(PCategory)
        TabPage2.Controls.Add(PName)
        TabPage2.Controls.Add(txt_SearchProductCode)
        TabPage2.Controls.Add(ProductID)
        TabPage2.Location = New Point(4, 50)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1179, 529)
        TabPage2.TabIndex = 1
        TabPage2.Text = "MANAGE INVENTORY"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txt_totalPrice
        ' 
        txt_totalPrice.Location = New Point(754, 272)
        txt_totalPrice.Name = "txt_totalPrice"
        txt_totalPrice.ReadOnly = True
        txt_totalPrice.Size = New Size(223, 25)
        txt_totalPrice.TabIndex = 42
        ' 
        ' lbl_TotalPrice
        ' 
        lbl_TotalPrice.AutoSize = True
        lbl_TotalPrice.Font = New Font("Century Schoolbook", 10.2F, FontStyle.Bold)
        lbl_TotalPrice.ForeColor = Color.Teal
        lbl_TotalPrice.Location = New Point(599, 275)
        lbl_TotalPrice.Name = "lbl_TotalPrice"
        lbl_TotalPrice.Size = New Size(107, 21)
        lbl_TotalPrice.TabIndex = 41
        lbl_TotalPrice.Text = "Total Price"
        ' 
        ' clear_btn
        ' 
        clear_btn.BackColor = Color.DarkCyan
        clear_btn.Cursor = Cursors.Hand
        clear_btn.FlatAppearance.BorderColor = Color.CadetBlue
        clear_btn.FlatStyle = FlatStyle.Flat
        clear_btn.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clear_btn.ForeColor = Color.White
        clear_btn.Location = New Point(803, 386)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(174, 30)
        clear_btn.TabIndex = 40
        clear_btn.Text = "CLEAR"
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' delete_btn
        ' 
        delete_btn.BackColor = Color.RoyalBlue
        delete_btn.Cursor = Cursors.Hand
        delete_btn.FlatAppearance.BorderColor = Color.CadetBlue
        delete_btn.FlatStyle = FlatStyle.Flat
        delete_btn.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        delete_btn.ForeColor = Color.White
        delete_btn.Location = New Point(599, 386)
        delete_btn.Name = "delete_btn"
        delete_btn.Size = New Size(174, 30)
        delete_btn.TabIndex = 39
        delete_btn.Text = "DELETE"
        delete_btn.UseVisualStyleBackColor = False
        ' 
        ' update_btn
        ' 
        update_btn.BackColor = Color.CadetBlue
        update_btn.Cursor = Cursors.Hand
        update_btn.FlatAppearance.BorderColor = Color.CadetBlue
        update_btn.FlatStyle = FlatStyle.Flat
        update_btn.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        update_btn.ForeColor = Color.White
        update_btn.Location = New Point(388, 386)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(174, 30)
        update_btn.TabIndex = 38
        update_btn.Text = "UPDATE"
        update_btn.UseVisualStyleBackColor = False
        ' 
        ' save_btn
        ' 
        save_btn.BackColor = Color.SteelBlue
        save_btn.Cursor = Cursors.Hand
        save_btn.FlatAppearance.BorderColor = Color.CadetBlue
        save_btn.FlatStyle = FlatStyle.Flat
        save_btn.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        save_btn.ForeColor = Color.White
        save_btn.Location = New Point(185, 386)
        save_btn.Name = "save_btn"
        save_btn.Size = New Size(174, 30)
        save_btn.TabIndex = 37
        save_btn.Text = "SAVE"
        save_btn.UseVisualStyleBackColor = False
        ' 
        ' search_btn
        ' 
        search_btn.BackColor = Color.SteelBlue
        search_btn.Cursor = Cursors.Hand
        search_btn.FlatAppearance.BorderColor = Color.CadetBlue
        search_btn.FlatStyle = FlatStyle.Flat
        search_btn.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        search_btn.ForeColor = Color.White
        search_btn.Location = New Point(886, 118)
        search_btn.Name = "search_btn"
        search_btn.Size = New Size(79, 30)
        search_btn.TabIndex = 36
        search_btn.Text = "Search"
        search_btn.UseVisualStyleBackColor = False
        ' 
        ' txt_productname
        ' 
        txt_productname.Location = New Point(349, 221)
        txt_productname.Name = "txt_productname"
        txt_productname.Size = New Size(223, 25)
        txt_productname.TabIndex = 35
        ' 
        ' cbo_category
        ' 
        cbo_category.FormattingEnabled = True
        cbo_category.Location = New Point(349, 272)
        cbo_category.Name = "cbo_category"
        cbo_category.Size = New Size(223, 25)
        cbo_category.TabIndex = 34
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(754, 217)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(223, 25)
        txt_price.TabIndex = 33
        ' 
        ' txt_productdescription
        ' 
        txt_productdescription.Location = New Point(349, 317)
        txt_productdescription.Name = "txt_productdescription"
        txt_productdescription.Size = New Size(223, 25)
        txt_productdescription.TabIndex = 32
        ' 
        ' PDescription
        ' 
        PDescription.AutoSize = True
        PDescription.Font = New Font("Century Schoolbook", 10.2F, FontStyle.Bold)
        PDescription.ForeColor = Color.Teal
        PDescription.Location = New Point(185, 317)
        PDescription.Name = "PDescription"
        PDescription.Size = New Size(112, 21)
        PDescription.TabIndex = 31
        PDescription.Text = "Description"
        ' 
        ' PExpDate
        ' 
        PExpDate.AutoSize = True
        PExpDate.Font = New Font("Century Schoolbook", 10.2F, FontStyle.Bold)
        PExpDate.ForeColor = Color.Teal
        PExpDate.Location = New Point(185, 169)
        PExpDate.Name = "PExpDate"
        PExpDate.Size = New Size(130, 21)
        PExpDate.TabIndex = 30
        PExpDate.Text = "Product Code"
        ' 
        ' PPrice
        ' 
        PPrice.AutoSize = True
        PPrice.Font = New Font("Century Schoolbook", 10.2F, FontStyle.Bold)
        PPrice.ForeColor = Color.Teal
        PPrice.Location = New Point(599, 220)
        PPrice.Name = "PPrice"
        PPrice.Size = New Size(57, 21)
        PPrice.TabIndex = 29
        PPrice.Text = "Price"
        ' 
        ' txt_stock
        ' 
        txt_stock.Location = New Point(754, 169)
        txt_stock.Name = "txt_stock"
        txt_stock.Size = New Size(223, 25)
        txt_stock.TabIndex = 28
        ' 
        ' txt_productcode
        ' 
        txt_productcode.Location = New Point(349, 166)
        txt_productcode.Name = "txt_productcode"
        txt_productcode.Size = New Size(223, 25)
        txt_productcode.TabIndex = 27
        ' 
        ' PQuantity
        ' 
        PQuantity.AutoSize = True
        PQuantity.Font = New Font("Century Schoolbook", 10.2F, FontStyle.Bold)
        PQuantity.ForeColor = Color.Teal
        PQuantity.Location = New Point(599, 168)
        PQuantity.Name = "PQuantity"
        PQuantity.Size = New Size(58, 21)
        PQuantity.TabIndex = 26
        PQuantity.Text = "Stock"
        ' 
        ' PCategory
        ' 
        PCategory.AutoSize = True
        PCategory.Font = New Font("Century Schoolbook", 10.2F, FontStyle.Bold)
        PCategory.ForeColor = Color.Teal
        PCategory.Location = New Point(185, 270)
        PCategory.Name = "PCategory"
        PCategory.Size = New Size(89, 21)
        PCategory.TabIndex = 25
        PCategory.Text = "Category"
        ' 
        ' PName
        ' 
        PName.AutoSize = True
        PName.Font = New Font("Century Schoolbook", 10.2F, FontStyle.Bold)
        PName.ForeColor = Color.Teal
        PName.Location = New Point(185, 221)
        PName.Name = "PName"
        PName.Size = New Size(136, 21)
        PName.TabIndex = 24
        PName.Text = "Product Name"
        ' 
        ' txt_SearchProductCode
        ' 
        txt_SearchProductCode.Location = New Point(185, 115)
        txt_SearchProductCode.Multiline = True
        txt_SearchProductCode.Name = "txt_SearchProductCode"
        txt_SearchProductCode.Size = New Size(685, 35)
        txt_SearchProductCode.TabIndex = 23
        ' 
        ' ProductID
        ' 
        ProductID.AutoSize = True
        ProductID.Font = New Font("Century Schoolbook", 10.2F, FontStyle.Bold)
        ProductID.ForeColor = Color.Teal
        ProductID.Location = New Point(185, 87)
        ProductID.Name = "ProductID"
        ProductID.Size = New Size(196, 21)
        ProductID.TabIndex = 22
        ProductID.Text = "Search Product Code"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.CadetBlue
        Panel4.Controls.Add(Logout_btn)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Button6)
        Panel4.Controls.Add(Button7)
        Panel4.Controls.Add(categories_btn)
        Panel4.Controls.Add(stock_btn)
        Panel4.Controls.Add(Inventory_btn)
        Panel4.Controls.Add(Dashboard_btn)
        Panel4.Location = New Point(0, 89)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(278, 611)
        Panel4.TabIndex = 12
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
        Logout_btn.TabIndex = 10
        Logout_btn.Text = "LOGOUT"
        Logout_btn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(1, 476)
        Label3.Name = "Label3"
        Label3.Size = New Size(276, 25)
        Label3.TabIndex = 8
        Label3.Text = "________________________"
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
        ' categories_btn
        ' 
        categories_btn.FlatAppearance.BorderColor = Color.Teal
        categories_btn.FlatStyle = FlatStyle.Flat
        categories_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        categories_btn.ForeColor = Color.Snow
        categories_btn.Location = New Point(24, 263)
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
        stock_btn.Location = New Point(24, 207)
        stock_btn.Name = "stock_btn"
        stock_btn.Size = New Size(226, 37)
        stock_btn.TabIndex = 4
        stock_btn.Text = "STOCK"
        stock_btn.UseVisualStyleBackColor = True
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
        ' Inventory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1500, 700)
        ControlBox = False
        Controls.Add(Panel4)
        Controls.Add(TabControl1)
        Controls.Add(fdg)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory"
        CType(fdg, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents fdg As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents search_btn As Button
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents cbo_category As ComboBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_productdescription As TextBox
    Friend WithEvents PDescription As Label
    Friend WithEvents PExpDate As Label
    Friend WithEvents PPrice As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents txt_productcode As TextBox
    Friend WithEvents PQuantity As Label
    Friend WithEvents PCategory As Label
    Friend WithEvents PName As Label
    Friend WithEvents txt_SearchProductCode As TextBox
    Friend WithEvents ProductID As Label
    Friend WithEvents clear_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents categories_btn As Button
    Friend WithEvents stock_btn As Button
    Friend WithEvents Inventory_btn As Button
    Friend WithEvents Dashboard_btn As Button
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Logout_btn As Button
    Friend WithEvents txt_totalPrice As TextBox
    Friend WithEvents lbl_TotalPrice As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
