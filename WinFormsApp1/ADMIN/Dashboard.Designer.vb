<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        fdg = New PictureBox()
        Panel2 = New Panel()
        Logout_btn = New Button()
        Label1 = New Label()
        user_btn = New Button()
        salesreport_btn = New Button()
        Categories_btn = New Button()
        stock_btn = New Button()
        inventory_btn = New Button()
        Dashboard_btn = New Button()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Panel8 = New Panel()
        No_OfUsers_lbl = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Panel6 = New Panel()
        No_MonthlySales_lbl = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel9 = New Panel()
        NumberOfProduct_lbl = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Panel5 = New Panel()
        No_TodaySales_lbl = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel7 = New Panel()
        MonthlySales_lbl = New Label()
        Label15 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        Panel4 = New Panel()
        TodaySales_lbl = New Label()
        Label14 = New Label()
        Label2 = New Label()
        Label8 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel1.SuspendLayout()
        CType(fdg, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        Panel9.SuspendLayout()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(fdg)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1500, 90)
        Panel1.TabIndex = 0
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
        fdg.TabIndex = 18
        fdg.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.CadetBlue
        Panel2.Controls.Add(Logout_btn)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(user_btn)
        Panel2.Controls.Add(salesreport_btn)
        Panel2.Controls.Add(Categories_btn)
        Panel2.Controls.Add(stock_btn)
        Panel2.Controls.Add(inventory_btn)
        Panel2.Controls.Add(Dashboard_btn)
        Panel2.Location = New Point(0, 89)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(278, 611)
        Panel2.TabIndex = 1
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
        Logout_btn.TabIndex = 9
        Logout_btn.Text = "LOGOUT"
        Logout_btn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(1, 476)
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
        user_btn.Location = New Point(24, 371)
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
        salesreport_btn.Location = New Point(24, 317)
        salesreport_btn.Name = "salesreport_btn"
        salesreport_btn.Size = New Size(226, 37)
        salesreport_btn.TabIndex = 6
        salesreport_btn.Text = "SALES REPORT"
        salesreport_btn.UseVisualStyleBackColor = True
        ' 
        ' Categories_btn
        ' 
        Categories_btn.FlatAppearance.BorderColor = Color.Teal
        Categories_btn.FlatStyle = FlatStyle.Flat
        Categories_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        Categories_btn.ForeColor = Color.Snow
        Categories_btn.Location = New Point(24, 263)
        Categories_btn.Name = "Categories_btn"
        Categories_btn.Size = New Size(226, 37)
        Categories_btn.TabIndex = 5
        Categories_btn.Text = "CATEGORIES"
        Categories_btn.UseVisualStyleBackColor = True
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
        ' inventory_btn
        ' 
        inventory_btn.Cursor = Cursors.Hand
        inventory_btn.FlatAppearance.BorderColor = Color.Teal
        inventory_btn.FlatStyle = FlatStyle.Flat
        inventory_btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold)
        inventory_btn.ForeColor = Color.Snow
        inventory_btn.Location = New Point(24, 148)
        inventory_btn.Name = "inventory_btn"
        inventory_btn.Size = New Size(226, 37)
        inventory_btn.TabIndex = 3
        inventory_btn.Text = "INVENTORY"
        inventory_btn.UseVisualStyleBackColor = True
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightBlue
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel9)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel7)
        Panel3.Controls.Add(Panel4)
        Panel3.ForeColor = Color.Teal
        Panel3.Location = New Point(372, 181)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1073, 409)
        Panel3.TabIndex = 17
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(10, 8)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(11, 12)
        DataGridView1.TabIndex = 18
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "OrderNo"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "OrderDate"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "OrderMonth"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "GrandTotal"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Azure
        Panel8.Controls.Add(No_OfUsers_lbl)
        Panel8.Controls.Add(Label10)
        Panel8.Controls.Add(Label11)
        Panel8.Location = New Point(758, 227)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(215, 104)
        Panel8.TabIndex = 8
        ' 
        ' No_OfUsers_lbl
        ' 
        No_OfUsers_lbl.AutoSize = True
        No_OfUsers_lbl.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        No_OfUsers_lbl.Location = New Point(13, 46)
        No_OfUsers_lbl.Name = "No_OfUsers_lbl"
        No_OfUsers_lbl.Size = New Size(33, 38)
        No_OfUsers_lbl.TabIndex = 15
        No_OfUsers_lbl.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(13, 10)
        Label10.Name = "Label10"
        Label10.Size = New Size(107, 23)
        Label10.TabIndex = 5
        Label10.Text = "No. of Users"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(8, 18)
        Label11.Name = "Label11"
        Label11.Size = New Size(183, 20)
        Label11.TabIndex = 1
        Label11.Text = "_____________________________"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Azure
        Panel6.Controls.Add(No_MonthlySales_lbl)
        Panel6.Controls.Add(Label5)
        Panel6.Controls.Add(Label6)
        Panel6.Location = New Point(422, 227)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(215, 104)
        Panel6.TabIndex = 8
        ' 
        ' No_MonthlySales_lbl
        ' 
        No_MonthlySales_lbl.AutoSize = True
        No_MonthlySales_lbl.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        No_MonthlySales_lbl.Location = New Point(15, 46)
        No_MonthlySales_lbl.Name = "No_MonthlySales_lbl"
        No_MonthlySales_lbl.Size = New Size(33, 38)
        No_MonthlySales_lbl.TabIndex = 14
        No_MonthlySales_lbl.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 23)
        Label5.TabIndex = 5
        Label5.Text = "No. Monthly Sales"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(8, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(183, 20)
        Label6.TabIndex = 1
        Label6.Text = "_____________________________"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Azure
        Panel9.Controls.Add(NumberOfProduct_lbl)
        Panel9.Controls.Add(Label12)
        Panel9.Controls.Add(Label13)
        Panel9.Location = New Point(758, 72)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(215, 104)
        Panel9.TabIndex = 7
        ' 
        ' NumberOfProduct_lbl
        ' 
        NumberOfProduct_lbl.AutoSize = True
        NumberOfProduct_lbl.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NumberOfProduct_lbl.Location = New Point(13, 45)
        NumberOfProduct_lbl.Name = "NumberOfProduct_lbl"
        NumberOfProduct_lbl.Size = New Size(33, 38)
        NumberOfProduct_lbl.TabIndex = 12
        NumberOfProduct_lbl.Text = "0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(13, 10)
        Label12.Name = "Label12"
        Label12.Size = New Size(135, 23)
        Label12.TabIndex = 5
        Label12.Text = "No. of Products"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(8, 18)
        Label13.Name = "Label13"
        Label13.Size = New Size(183, 20)
        Label13.TabIndex = 1
        Label13.Text = "_____________________________"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Azure
        Panel5.Controls.Add(No_TodaySales_lbl)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(91, 227)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(215, 104)
        Panel5.TabIndex = 6
        ' 
        ' No_TodaySales_lbl
        ' 
        No_TodaySales_lbl.AutoSize = True
        No_TodaySales_lbl.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        No_TodaySales_lbl.Location = New Point(15, 46)
        No_TodaySales_lbl.Name = "No_TodaySales_lbl"
        No_TodaySales_lbl.Size = New Size(33, 38)
        No_TodaySales_lbl.TabIndex = 13
        No_TodaySales_lbl.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 23)
        Label3.TabIndex = 5
        Label3.Text = "No. Today's Sales"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(8, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 20)
        Label4.TabIndex = 1
        Label4.Text = "_____________________________"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Azure
        Panel7.Controls.Add(MonthlySales_lbl)
        Panel7.Controls.Add(Label15)
        Panel7.Controls.Add(Label7)
        Panel7.Controls.Add(Label9)
        Panel7.Location = New Point(422, 72)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(215, 104)
        Panel7.TabIndex = 7
        ' 
        ' MonthlySales_lbl
        ' 
        MonthlySales_lbl.AutoSize = True
        MonthlySales_lbl.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MonthlySales_lbl.Location = New Point(54, 45)
        MonthlySales_lbl.Name = "MonthlySales_lbl"
        MonthlySales_lbl.Size = New Size(89, 38)
        MonthlySales_lbl.TabIndex = 11
        MonthlySales_lbl.Text = "00.00"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(13, 45)
        Label15.Name = "Label15"
        Label15.Size = New Size(35, 38)
        Label15.TabIndex = 10
        Label15.Text = "₱"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(13, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 23)
        Label7.TabIndex = 5
        Label7.Text = "Monthly Sales"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(8, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(183, 20)
        Label9.TabIndex = 1
        Label9.Text = "_____________________________"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Azure
        Panel4.Controls.Add(TodaySales_lbl)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(91, 72)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(215, 104)
        Panel4.TabIndex = 1
        ' 
        ' TodaySales_lbl
        ' 
        TodaySales_lbl.AutoSize = True
        TodaySales_lbl.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TodaySales_lbl.Location = New Point(54, 45)
        TodaySales_lbl.Name = "TodaySales_lbl"
        TodaySales_lbl.Size = New Size(89, 38)
        TodaySales_lbl.TabIndex = 10
        TodaySales_lbl.Text = "00.00"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(13, 45)
        Label14.Name = "Label14"
        Label14.Size = New Size(35, 38)
        Label14.TabIndex = 9
        Label14.Text = "₱"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 23)
        Label2.TabIndex = 5
        Label2.Text = "Today's Sales"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(8, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(183, 20)
        Label8.TabIndex = 1
        Label8.Text = "_____________________________"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1500, 700)
        ControlBox = False
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        CType(fdg, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dashboard_btn As Button
    Friend WithEvents stock_btn As Button
    Friend WithEvents inventory_btn As Button
    Friend WithEvents user_btn As Button
    Friend WithEvents salesreport_btn As Button
    Friend WithEvents Categories_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TodaySales_lbl As Label
    Friend WithEvents NumberOfProduct_lbl As Label
    Friend WithEvents MonthlySales_lbl As Label
    Friend WithEvents No_OfUsers_lbl As Label
    Friend WithEvents No_MonthlySales_lbl As Label
    Friend WithEvents No_TodaySales_lbl As Label
    Friend WithEvents fdg As PictureBox
    Friend WithEvents Logout_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand

End Class
