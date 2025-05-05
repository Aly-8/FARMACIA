<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Exit_btn = New Button()
        fdg = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        login_bttn = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Txt_Password = New TextBox()
        Txt_Username = New TextBox()
        CType(fdg, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Exit_btn
        ' 
        Exit_btn.BackColor = Color.IndianRed
        Exit_btn.FlatAppearance.BorderSize = 0
        Exit_btn.FlatStyle = FlatStyle.Flat
        Exit_btn.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Exit_btn.Location = New Point(408, 14)
        Exit_btn.Name = "Exit_btn"
        Exit_btn.Size = New Size(47, 30)
        Exit_btn.TabIndex = 4
        Exit_btn.Text = "X"
        Exit_btn.UseVisualStyleBackColor = False
        ' 
        ' fdg
        ' 
        fdg.BackgroundImageLayout = ImageLayout.None
        fdg.ErrorImage = Nothing
        fdg.Location = New Point(12, 0)
        fdg.Name = "fdg"
        fdg.Size = New Size(100, 85)
        fdg.TabIndex = 5
        fdg.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(fdg)
        Panel1.Controls.Add(Exit_btn)
        Panel1.Location = New Point(0, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(467, 82)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(login_bttn)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Txt_Password)
        Panel2.Controls.Add(Txt_Username)
        Panel2.Location = New Point(80, 138)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(298, 266)
        Panel2.TabIndex = 7
        ' 
        ' login_bttn
        ' 
        login_bttn.BackColor = Color.DarkCyan
        login_bttn.FlatAppearance.BorderSize = 0
        login_bttn.FlatStyle = FlatStyle.Flat
        login_bttn.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        login_bttn.ForeColor = Color.Snow
        login_bttn.Location = New Point(79, 180)
        login_bttn.Name = "login_bttn"
        login_bttn.Size = New Size(137, 42)
        login_bttn.TabIndex = 4
        login_bttn.Text = "LOGIN"
        login_bttn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkSlateGray
        Label3.Location = New Point(40, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 19)
        Label3.TabIndex = 3
        Label3.Text = "PASSWORD:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(40, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 19)
        Label2.TabIndex = 2
        Label2.Text = "USERNAME:"
        ' 
        ' Txt_Password
        ' 
        Txt_Password.Location = New Point(40, 122)
        Txt_Password.Name = "Txt_Password"
        Txt_Password.PasswordChar = "•"c
        Txt_Password.Size = New Size(217, 27)
        Txt_Password.TabIndex = 1
        Txt_Password.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txt_Username
        ' 
        Txt_Username.Location = New Point(40, 63)
        Txt_Username.Name = "Txt_Username"
        Txt_Username.Size = New Size(217, 27)
        Txt_Username.TabIndex = 0
        Txt_Username.TextAlign = HorizontalAlignment.Center
        ' 
        ' Login
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.CadetBlue
        ClientSize = New Size(467, 464)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        ForeColor = Color.LightSeaGreen
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(fdg, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Exit_btn As Button
    Friend WithEvents fdg As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents Txt_Username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents login_bttn As Button
End Class
