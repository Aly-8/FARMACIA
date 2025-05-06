<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cancel_order
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        txt_Search = New TextBox()
        Search = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        OrderNo = New DataGridViewTextBoxColumn()
        OrderDate = New DataGridViewTextBoxColumn()
        totalPrice = New DataGridViewTextBoxColumn()
        ColDel = New DataGridViewButtonColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(txt_Search)
        Panel1.Controls.Add(Search)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1062, 69)
        Panel1.TabIndex = 0
        ' 
        ' txt_Search
        ' 
        txt_Search.Location = New Point(113, 24)
        txt_Search.Name = "txt_Search"
        txt_Search.Size = New Size(249, 27)
        txt_Search.TabIndex = 4
        ' 
        ' Search
        ' 
        Search.AutoSize = True
        Search.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Search.ForeColor = SystemColors.ButtonHighlight
        Search.Location = New Point(27, 24)
        Search.Name = "Search"
        Search.Size = New Size(80, 23)
        Search.TabIndex = 3
        Search.Text = "Search"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, OrderNo, OrderDate, totalPrice, ColDel})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 69)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1062, 492)
        DataGridView1.TabIndex = 1
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
        ' OrderNo
        ' 
        OrderNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        OrderNo.HeaderText = "ORDER NO"
        OrderNo.MinimumWidth = 6
        OrderNo.Name = "OrderNo"
        OrderNo.ReadOnly = True
        ' 
        ' OrderDate
        ' 
        OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        OrderDate.DefaultCellStyle = DataGridViewCellStyle1
        OrderDate.HeaderText = "ORDER DATE"
        OrderDate.MinimumWidth = 6
        OrderDate.Name = "OrderDate"
        OrderDate.ReadOnly = True
        OrderDate.Width = 126
        ' 
        ' totalPrice
        ' 
        totalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        totalPrice.HeaderText = "TOTAL PRICE"
        totalPrice.MinimumWidth = 6
        totalPrice.Name = "totalPrice"
        totalPrice.ReadOnly = True
        totalPrice.Width = 121
        ' 
        ' ColDel
        ' 
        ColDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Teal
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        ColDel.DefaultCellStyle = DataGridViewCellStyle2
        ColDel.HeaderText = "ACTION"
        ColDel.MinimumWidth = 6
        ColDel.Name = "ColDel"
        ColDel.ReadOnly = True
        ColDel.Resizable = DataGridViewTriState.True
        ColDel.SortMode = DataGridViewColumnSortMode.Automatic
        ColDel.Text = "DELETE"
        ColDel.ToolTipText = "DELETE"
        ColDel.UseColumnTextForButtonValue = True
        ColDel.Width = 91
        ' 
        ' cancel_order
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 561)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "cancel_order"
        StartPosition = FormStartPosition.CenterScreen
        Text = "cancel order"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Search As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents OrderNo As DataGridViewTextBoxColumn
    Friend WithEvents OrderDate As DataGridViewTextBoxColumn
    Friend WithEvents totalPrice As DataGridViewTextBoxColumn
    Friend WithEvents ColDel As DataGridViewButtonColumn
End Class
