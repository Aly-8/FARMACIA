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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(fdg, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' AddCategory_lbl
        ' 
        AddCategory_lbl.AutoSize = True
        AddCategory_lbl.Font = New Font("Palatino Linotype", 25.8F, FontStyle.Bold)
        AddCategory_lbl.ForeColor = Color.Teal
        AddCategory_lbl.Location = New Point(761, 93)
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
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(314, 183)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1151, 388)
        TabControl1.TabIndex = 9
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1143, 355)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1143, 355)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' SalesReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(1500, 600)
        ControlBox = False
        Controls.Add(TabControl1)
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
        TabControl1.ResumeLayout(False)
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents fdg As PictureBox
End Class
