<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePassword
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
        txt_oldpassword = New TextBox()
        txt_newpassword = New TextBox()
        txt_reenterPassword = New TextBox()
        btn_ChangePassword = New Button()
        Old_Password = New Label()
        New_Password = New Label()
        Repeat_NewPassword = New Label()
        Exit_btn = New Button()
        SuspendLayout()
        ' 
        ' txt_oldpassword
        ' 
        txt_oldpassword.Location = New Point(44, 99)
        txt_oldpassword.Multiline = True
        txt_oldpassword.Name = "txt_oldpassword"
        txt_oldpassword.Size = New Size(405, 41)
        txt_oldpassword.TabIndex = 0
        txt_oldpassword.UseSystemPasswordChar = True
        ' 
        ' txt_newpassword
        ' 
        txt_newpassword.Location = New Point(44, 169)
        txt_newpassword.Multiline = True
        txt_newpassword.Name = "txt_newpassword"
        txt_newpassword.Size = New Size(405, 41)
        txt_newpassword.TabIndex = 1
        txt_newpassword.UseSystemPasswordChar = True
        ' 
        ' txt_reenterPassword
        ' 
        txt_reenterPassword.Location = New Point(44, 242)
        txt_reenterPassword.Multiline = True
        txt_reenterPassword.Name = "txt_reenterPassword"
        txt_reenterPassword.Size = New Size(405, 41)
        txt_reenterPassword.TabIndex = 2
        txt_reenterPassword.UseSystemPasswordChar = True
        ' 
        ' btn_ChangePassword
        ' 
        btn_ChangePassword.BackColor = Color.CadetBlue
        btn_ChangePassword.Cursor = Cursors.Hand
        btn_ChangePassword.FlatAppearance.BorderColor = Color.DarkSlateGray
        btn_ChangePassword.FlatStyle = FlatStyle.Flat
        btn_ChangePassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_ChangePassword.ForeColor = Color.Snow
        btn_ChangePassword.Location = New Point(109, 303)
        btn_ChangePassword.Name = "btn_ChangePassword"
        btn_ChangePassword.Size = New Size(242, 38)
        btn_ChangePassword.TabIndex = 5
        btn_ChangePassword.Text = "Change Password"
        btn_ChangePassword.UseVisualStyleBackColor = False
        ' 
        ' Old_Password
        ' 
        Old_Password.AutoSize = True
        Old_Password.Font = New Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Old_Password.ForeColor = SystemColors.ActiveCaptionText
        Old_Password.Location = New Point(44, 77)
        Old_Password.Name = "Old_Password"
        Old_Password.Size = New Size(114, 19)
        Old_Password.TabIndex = 6
        Old_Password.Text = "OLD Password"
        ' 
        ' New_Password
        ' 
        New_Password.AutoSize = True
        New_Password.Font = New Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        New_Password.ForeColor = SystemColors.ActiveCaptionText
        New_Password.Location = New Point(44, 147)
        New_Password.Name = "New_Password"
        New_Password.Size = New Size(118, 19)
        New_Password.TabIndex = 7
        New_Password.Text = "NEW Password"
        ' 
        ' Repeat_NewPassword
        ' 
        Repeat_NewPassword.AutoSize = True
        Repeat_NewPassword.Font = New Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Repeat_NewPassword.ForeColor = SystemColors.ActiveCaptionText
        Repeat_NewPassword.Location = New Point(44, 220)
        Repeat_NewPassword.Name = "Repeat_NewPassword"
        Repeat_NewPassword.Size = New Size(174, 19)
        Repeat_NewPassword.TabIndex = 8
        Repeat_NewPassword.Text = "Repeat NEW Password"
        ' 
        ' Exit_btn
        ' 
        Exit_btn.BackColor = Color.IndianRed
        Exit_btn.FlatAppearance.BorderSize = 0
        Exit_btn.FlatStyle = FlatStyle.Flat
        Exit_btn.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Exit_btn.Location = New Point(436, 12)
        Exit_btn.Name = "Exit_btn"
        Exit_btn.Size = New Size(47, 30)
        Exit_btn.TabIndex = 9
        Exit_btn.Text = "X"
        Exit_btn.TextAlign = ContentAlignment.TopCenter
        Exit_btn.UseVisualStyleBackColor = False
        ' 
        ' ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(495, 383)
        ControlBox = False
        Controls.Add(Exit_btn)
        Controls.Add(Repeat_NewPassword)
        Controls.Add(New_Password)
        Controls.Add(Old_Password)
        Controls.Add(btn_ChangePassword)
        Controls.Add(txt_reenterPassword)
        Controls.Add(txt_newpassword)
        Controls.Add(txt_oldpassword)
        FormBorderStyle = FormBorderStyle.None
        Name = "ChangePassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Change Password"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_oldpassword As TextBox
    Friend WithEvents txt_newpassword As TextBox
    Friend WithEvents txt_reenterPassword As TextBox
    Friend WithEvents btn_ChangePassword As Button
    Friend WithEvents Old_Password As Label
    Friend WithEvents New_Password As Label
    Friend WithEvents Repeat_NewPassword As Label
    Friend WithEvents Exit_btn As Button
End Class
