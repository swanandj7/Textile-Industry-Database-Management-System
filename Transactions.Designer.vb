<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.billamt = New System.Windows.Forms.TextBox()
        Me.tbillamt = New System.Windows.Forms.Label()
        Me.customer = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.billid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.print = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(620, 479)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(99, 27)
        Me.TextBox2.TabIndex = 76
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(620, 424)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(99, 27)
        Me.TextBox1.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(446, 427)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Total Paid Amount"
        '
        'billamt
        '
        Me.billamt.Enabled = False
        Me.billamt.Location = New System.Drawing.Point(316, 424)
        Me.billamt.Multiline = True
        Me.billamt.Name = "billamt"
        Me.billamt.Size = New System.Drawing.Size(99, 27)
        Me.billamt.TabIndex = 72
        '
        'tbillamt
        '
        Me.tbillamt.AutoSize = True
        Me.tbillamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbillamt.Location = New System.Drawing.Point(149, 427)
        Me.tbillamt.Name = "tbillamt"
        Me.tbillamt.Size = New System.Drawing.Size(151, 24)
        Me.tbillamt.TabIndex = 71
        Me.tbillamt.Text = "Total Bill Amount"
        '
        'customer
        '
        Me.customer.AutoSize = True
        Me.customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer.Location = New System.Drawing.Point(300, 34)
        Me.customer.Name = "customer"
        Me.customer.Size = New System.Drawing.Size(139, 24)
        Me.customer.TabIndex = 70
        Me.customer.Text = "Customername"
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(24, 14)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(81, 44)
        Me.back.TabIndex = 68
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.billid, Me.bdate, Me.amount, Me.trid, Me.tdate, Me.tamount})
        Me.DataGridView1.Location = New System.Drawing.Point(75, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(643, 298)
        Me.DataGridView1.TabIndex = 69
        '
        'billid
        '
        Me.billid.HeaderText = "Bill No"
        Me.billid.Name = "billid"
        Me.billid.ReadOnly = True
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
        'trid
        '
        Me.trid.HeaderText = "Trans. ID"
        Me.trid.Name = "trid"
        Me.trid.ReadOnly = True
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
        Me.Label2.Location = New System.Drawing.Point(446, 482)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 24)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Remaining Amount"
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(24, 474)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(81, 44)
        Me.print.TabIndex = 116
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.billamt)
        Me.Controls.Add(Me.tbillamt)
        Me.Controls.Add(Me.customer)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transactions"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents billamt As System.Windows.Forms.TextBox
    Friend WithEvents tbillamt As System.Windows.Forms.Label
    Friend WithEvents customer As System.Windows.Forms.Label
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents billid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tamount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
