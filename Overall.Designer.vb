<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Overall
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
        Me.print = New System.Windows.Forms.Button()
        Me.profit = New System.Windows.Forms.TextBox()
        Me.texp = New System.Windows.Forms.TextBox()
        Me.texp1 = New System.Windows.Forms.Label()
        Me.tincome = New System.Windows.Forms.TextBox()
        Me.tincomel = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.customer = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(33, 645)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(81, 44)
        Me.print.TabIndex = 139
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'profit
        '
        Me.profit.Enabled = False
        Me.profit.Location = New System.Drawing.Point(847, 650)
        Me.profit.Multiline = True
        Me.profit.Name = "profit"
        Me.profit.Size = New System.Drawing.Size(99, 27)
        Me.profit.TabIndex = 138
        '
        'texp
        '
        Me.texp.Enabled = False
        Me.texp.Location = New System.Drawing.Point(847, 595)
        Me.texp.Multiline = True
        Me.texp.Name = "texp"
        Me.texp.Size = New System.Drawing.Size(99, 27)
        Me.texp.TabIndex = 136
        '
        'texp1
        '
        Me.texp1.AutoSize = True
        Me.texp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texp1.Location = New System.Drawing.Point(688, 598)
        Me.texp1.Name = "texp1"
        Me.texp1.Size = New System.Drawing.Size(141, 24)
        Me.texp1.TabIndex = 135
        Me.texp1.Text = "Total Expenses"
        '
        'tincome
        '
        Me.tincome.Enabled = False
        Me.tincome.Location = New System.Drawing.Point(443, 595)
        Me.tincome.Multiline = True
        Me.tincome.Name = "tincome"
        Me.tincome.Size = New System.Drawing.Size(99, 27)
        Me.tincome.TabIndex = 134
        '
        'tincomel
        '
        Me.tincomel.AutoSize = True
        Me.tincomel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tincomel.Location = New System.Drawing.Point(276, 598)
        Me.tincomel.Name = "tincomel"
        Me.tincomel.Size = New System.Drawing.Size(119, 24)
        Me.tincomel.TabIndex = 133
        Me.tincomel.Text = "Total Income"
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(27, 40)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(81, 44)
        Me.back.TabIndex = 131
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cname, Me.bdate, Me.amount, Me.sname, Me.tdate, Me.tamount})
        Me.DataGridView1.Location = New System.Drawing.Point(106, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(843, 445)
        Me.DataGridView1.TabIndex = 132
        '
        'cname
        '
        Me.cname.HeaderText = "Customer"
        Me.cname.Name = "cname"
        Me.cname.ReadOnly = True
        Me.cname.Width = 200
        '
        'bdate
        '
        Me.bdate.HeaderText = "Date"
        Me.bdate.Name = "bdate"
        Me.bdate.ReadOnly = True
        '
        'amount
        '
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'sname
        '
        Me.sname.HeaderText = "Supplier"
        Me.sname.Name = "sname"
        Me.sname.ReadOnly = True
        Me.sname.Width = 200
        '
        'tdate
        '
        Me.tdate.HeaderText = "Date"
        Me.tdate.Name = "tdate"
        Me.tdate.ReadOnly = True
        '
        'tamount
        '
        Me.tamount.HeaderText = "Amount"
        Me.tamount.Name = "tamount"
        Me.tamount.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(734, 653)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Difference"
        '
        'customer
        '
        Me.customer.AutoSize = True
        Me.customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer.Location = New System.Drawing.Point(428, 48)
        Me.customer.Name = "customer"
        Me.customer.Size = New System.Drawing.Size(152, 24)
        Me.customer.TabIndex = 140
        Me.customer.Text = "Jaylaxmi Textiles"
        '
        'Overall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.customer)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.profit)
        Me.Controls.Add(Me.texp)
        Me.Controls.Add(Me.texp1)
        Me.Controls.Add(Me.tincome)
        Me.Controls.Add(Me.tincomel)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Overall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Transactions"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents profit As System.Windows.Forms.TextBox
    Friend WithEvents texp As System.Windows.Forms.TextBox
    Friend WithEvents texp1 As System.Windows.Forms.Label
    Friend WithEvents tincome As System.Windows.Forms.TextBox
    Friend WithEvents tincomel As System.Windows.Forms.Label
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents customer As System.Windows.Forms.Label
End Class
