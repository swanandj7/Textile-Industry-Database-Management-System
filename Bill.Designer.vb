<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.calculate = New System.Windows.Forms.Button()
        Me.addnew = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.oidcombo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tamount = New System.Windows.Forms.TextBox()
        Me.scharge = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tcharge = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lrno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.quality = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billy = New System.Windows.Forms.ComboBox()
        Me.billm = New System.Windows.Forms.ComboBox()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tname = New System.Windows.Forms.ComboBox()
        Me.bid = New System.Windows.Forms.Label()
        Me.billd = New System.Windows.Forms.ComboBox()
        Me.cnamecombo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.print = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.recover = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(667, 507)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(75, 23)
        Me.calculate.TabIndex = 10
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'addnew
        '
        Me.addnew.Location = New System.Drawing.Point(559, 580)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(75, 23)
        Me.addnew.TabIndex = 13
        Me.addnew.Text = "Add New"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(667, 580)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 12
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(559, 580)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 98
        Me.ok.Text = "Ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'oidcombo
        '
        Me.oidcombo.FormattingEnabled = True
        Me.oidcombo.Location = New System.Drawing.Point(669, 110)
        Me.oidcombo.Name = "oidcombo"
        Me.oidcombo.Size = New System.Drawing.Size(143, 21)
        Me.oidcombo.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(570, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 24)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Order ID"
        '
        'tamount
        '
        Me.tamount.Enabled = False
        Me.tamount.Location = New System.Drawing.Point(534, 504)
        Me.tamount.Multiline = True
        Me.tamount.Name = "tamount"
        Me.tamount.Size = New System.Drawing.Size(100, 24)
        Me.tamount.TabIndex = 113
        '
        'scharge
        '
        Me.scharge.Location = New System.Drawing.Point(534, 459)
        Me.scharge.Multiline = True
        Me.scharge.Name = "scharge"
        Me.scharge.Size = New System.Drawing.Size(100, 24)
        Me.scharge.TabIndex = 9
        Me.scharge.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(383, 459)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 24)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "+  Service Tax"
        '
        'tcharge
        '
        Me.tcharge.Location = New System.Drawing.Point(534, 416)
        Me.tcharge.Multiline = True
        Me.tcharge.Name = "tcharge"
        Me.tcharge.Size = New System.Drawing.Size(100, 24)
        Me.tcharge.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(340, 416)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 24)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "+ Transport charges"
        '
        'total
        '
        Me.total.Enabled = False
        Me.total.Location = New System.Drawing.Point(534, 370)
        Me.total.Multiline = True
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 24)
        Me.total.TabIndex = 95
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(465, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 24)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(392, 504)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 24)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Total Amount"
        '
        'lrno
        '
        Me.lrno.Location = New System.Drawing.Point(574, 205)
        Me.lrno.Multiline = True
        Me.lrno.Name = "lrno"
        Me.lrno.Size = New System.Drawing.Size(238, 24)
        Me.lrno.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(486, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 24)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "LR No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 24)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Transport Agency"
        '
        'quality
        '
        Me.quality.HeaderText = "Quality"
        Me.quality.Name = "quality"
        Me.quality.ReadOnly = True
        Me.quality.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.quality.Width = 300
        '
        'billy
        '
        Me.billy.FormattingEnabled = True
        Me.billy.ItemHeight = 13
        Me.billy.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.billy.Location = New System.Drawing.Point(469, 110)
        Me.billy.Name = "billy"
        Me.billy.Size = New System.Drawing.Size(61, 21)
        Me.billy.TabIndex = 3
        '
        'billm
        '
        Me.billm.FormattingEnabled = True
        Me.billm.ItemHeight = 13
        Me.billm.Items.AddRange(New Object() {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"})
        Me.billm.Location = New System.Drawing.Point(401, 110)
        Me.billm.Name = "billm"
        Me.billm.Size = New System.Drawing.Size(46, 21)
        Me.billm.TabIndex = 2
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(275, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 24)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Date"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.quality, Me.Quantity, Me.Amount})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(91, 265)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(543, 88)
        Me.DataGridView1.TabIndex = 94
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'tname
        '
        Me.tname.FormattingEnabled = True
        Me.tname.Location = New System.Drawing.Point(279, 208)
        Me.tname.Name = "tname"
        Me.tname.Size = New System.Drawing.Size(173, 21)
        Me.tname.TabIndex = 6
        '
        'bid
        '
        Me.bid.AutoSize = True
        Me.bid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bid.Location = New System.Drawing.Point(157, 110)
        Me.bid.Name = "bid"
        Me.bid.Size = New System.Drawing.Size(39, 24)
        Me.bid.TabIndex = 105
        Me.bid.Text = "BID"
        '
        'billd
        '
        Me.billd.FormattingEnabled = True
        Me.billd.ItemHeight = 13
        Me.billd.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.billd.Location = New System.Drawing.Point(344, 110)
        Me.billd.Name = "billd"
        Me.billd.Size = New System.Drawing.Size(44, 21)
        Me.billd.TabIndex = 1
        '
        'cnamecombo
        '
        Me.cnamecombo.FormattingEnabled = True
        Me.cnamecombo.Location = New System.Drawing.Point(279, 163)
        Me.cnamecombo.Name = "cnamecombo"
        Me.cnamecombo.Size = New System.Drawing.Size(533, 21)
        Me.cnamecombo.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 24)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(87, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 24)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(386, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 29)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "BILL"
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(455, 580)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(75, 23)
        Me.print.TabIndex = 11
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'recover
        '
        Me.recover.Location = New System.Drawing.Point(344, 580)
        Me.recover.Name = "recover"
        Me.recover.Size = New System.Drawing.Size(75, 23)
        Me.recover.TabIndex = 14
        Me.recover.Text = "Recover"
        Me.recover.UseVisualStyleBackColor = True
        '
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 635)
        Me.ControlBox = False
        Me.Controls.Add(Me.recover)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.addnew)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.oidcombo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tamount)
        Me.Controls.Add(Me.scharge)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tcharge)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lrno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.billy)
        Me.Controls.Add(Me.billm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tname)
        Me.Controls.Add(Me.bid)
        Me.Controls.Add(Me.billd)
        Me.Controls.Add(Me.cnamecombo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Bill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculate As System.Windows.Forms.Button
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents oidcombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tamount As System.Windows.Forms.TextBox
    Friend WithEvents scharge As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tcharge As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lrno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents quality As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billy As System.Windows.Forms.ComboBox
    Friend WithEvents billm As System.Windows.Forms.ComboBox
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tname As System.Windows.Forms.ComboBox
    Friend WithEvents bid As System.Windows.Forms.Label
    Friend WithEvents billd As System.Windows.Forms.ComboBox
    Friend WithEvents cnamecombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents recover As System.Windows.Forms.Button
End Class
