<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User
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
        Panel1 = New Panel()
        Exit_btn = New Button()
        fdg = New PictureBox()
        Panel3 = New Panel()
        add_btn = New Button()
        Label6 = New Label()
        Label5 = New Label()
        cbo_usertype = New ComboBox()
        Label4 = New Label()
        Txt_Password = New TextBox()
        Txt_Username = New TextBox()
        Label2 = New Label()
        Panel4 = New Panel()
        Logout_btn = New Button()
        Label1 = New Label()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        additem_btn = New Button()
        Inventory_btn = New Button()
        Dashboard_btn = New Button()
        Panel1.SuspendLayout()
        CType(fdg, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Exit_btn)
        Panel1.Controls.Add(fdg)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1500, 90)
        Panel1.TabIndex = 10
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
        ' fdg
        ' 
        fdg.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        fdg.BackgroundImageLayout = ImageLayout.None
        fdg.ErrorImage = Nothing
        fdg.Location = New Point(40, 7)
        fdg.Name = "fdg"
        fdg.Size = New Size(160, 59)
        fdg.SizeMode = PictureBoxSizeMode.AutoSize
        fdg.TabIndex = 0
        fdg.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientInactiveCaption
        Panel3.Controls.Add(add_btn)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(cbo_usertype)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Txt_Password)
        Panel3.Controls.Add(Txt_Username)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(278, 89)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1222, 611)
        Panel3.TabIndex = 12
        ' 
        ' add_btn
        ' 
        add_btn.BackColor = Color.DarkCyan
        add_btn.FlatAppearance.BorderSize = 0
        add_btn.FlatStyle = FlatStyle.Flat
        add_btn.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        add_btn.ForeColor = Color.Snow
        add_btn.Location = New Point(545, 334)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(116, 35)
        add_btn.TabIndex = 8
        add_btn.Text = "ADD"
        add_btn.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkCyan
        Label6.Location = New Point(335, 283)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 20)
        Label6.TabIndex = 7
        Label6.Text = "USER TYPE:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkCyan
        Label5.Location = New Point(335, 228)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 20)
        Label5.TabIndex = 6
        Label5.Text = "PASSWORD:"
        ' 
        ' cbo_usertype
        ' 
        cbo_usertype.Items.AddRange(New Object() {"ADMIN", "CASHIER"})
        cbo_usertype.Location = New Point(460, 280)
        cbo_usertype.Name = "cbo_usertype"
        cbo_usertype.Size = New Size(310, 28)
        cbo_usertype.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkCyan
        Label4.Location = New Point(335, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 5
        Label4.Text = "USERNAME:"
        ' 
        ' Txt_Password
        ' 
        Txt_Password.Location = New Point(460, 226)
        Txt_Password.Name = "Txt_Password"
        Txt_Password.PasswordChar = "•"c
        Txt_Password.Size = New Size(310, 27)
        Txt_Password.TabIndex = 2
        ' 
        ' Txt_Username
        ' 
        Txt_Username.Location = New Point(460, 169)
        Txt_Username.Name = "Txt_Username"
        Txt_Username.Size = New Size(310, 27)
        Txt_Username.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(364, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(392, 50)
        Label2.TabIndex = 0
        Label2.Text = "USER MANAGEMENT"
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
        Panel4.TabIndex = 16
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
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
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
        ' User
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(1500, 700)
        ControlBox = False
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        ForeColor = SystemColors.GradientInactiveCaption
        FormBorderStyle = FormBorderStyle.None
        Name = "User"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(fdg, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Exit_btn As Button
    Friend WithEvents fdg As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents Txt_Username As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbo_usertype As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents add_btn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Logout_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents additem_btn As Button
    Friend WithEvents Inventory_btn As Button
    Friend WithEvents Dashboard_btn As Button
End Class
