<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Discount
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
        txt_discount = New TextBox()
        btn_updatediscount = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txt_discount
        ' 
        txt_discount.Location = New Point(59, 43)
        txt_discount.Name = "txt_discount"
        txt_discount.Size = New Size(349, 30)
        txt_discount.TabIndex = 0
        ' 
        ' btn_updatediscount
        ' 
        btn_updatediscount.BackColor = Color.CadetBlue
        btn_updatediscount.Cursor = Cursors.Hand
        btn_updatediscount.FlatAppearance.BorderColor = Color.Black
        btn_updatediscount.FlatStyle = FlatStyle.Flat
        btn_updatediscount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_updatediscount.ForeColor = SystemColors.ControlLightLight
        btn_updatediscount.Location = New Point(59, 88)
        btn_updatediscount.Name = "btn_updatediscount"
        btn_updatediscount.Size = New Size(349, 33)
        btn_updatediscount.TabIndex = 1
        btn_updatediscount.Text = "UPDATE DISCOUNT"
        btn_updatediscount.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(169, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 23)
        Label1.TabIndex = 2
        Label1.Text = "Enter Discount %"
        ' 
        ' Discount
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(472, 157)
        Controls.Add(Label1)
        Controls.Add(btn_updatediscount)
        Controls.Add(txt_discount)
        Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Discount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Discount"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_discount As TextBox
    Friend WithEvents btn_updatediscount As Button
    Friend WithEvents Label1 As Label
End Class
