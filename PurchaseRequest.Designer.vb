<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseRequest
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.recieve = New System.Windows.Forms.Button()
        Me.ok2 = New System.Windows.Forms.Button()
        Me.cost = New System.Windows.Forms.TextBox()
        Me.purchasecost = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Button()
        Me.Update1 = New System.Windows.Forms.Button()
        Me.addnew = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.snamecombo = New System.Windows.Forms.ComboBox()
        Me.pid = New System.Windows.Forms.Label()
        Me.dely = New System.Windows.Forms.ComboBox()
        Me.delm = New System.Windows.Forms.ComboBox()
        Me.deld = New System.Windows.Forms.ComboBox()
        Me.ordery = New System.Windows.Forms.ComboBox()
        Me.orderm = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.orderd = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'recieve
        '
        Me.recieve.Location = New System.Drawing.Point(302, 465)
        Me.recieve.Name = "recieve"
        Me.recieve.Size = New System.Drawing.Size(75, 23)
        Me.recieve.TabIndex = 70
        Me.recieve.Text = "Recieved"
        Me.recieve.UseVisualStyleBackColor = True
        '
        'ok2
        '
        Me.ok2.Location = New System.Drawing.Point(523, 465)
        Me.ok2.Name = "ok2"
        Me.ok2.Size = New System.Drawing.Size(75, 23)
        Me.ok2.TabIndex = 77
        Me.ok2.Text = "Ok"
        Me.ok2.UseVisualStyleBackColor = True
        '
        'cost
        '
        Me.cost.Location = New System.Drawing.Point(674, 267)
        Me.cost.Multiline = True
        Me.cost.Name = "cost"
        Me.cost.Size = New System.Drawing.Size(127, 27)
        Me.cost.TabIndex = 76
        '
        'purchasecost
        '
        Me.purchasecost.AutoSize = True
        Me.purchasecost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchasecost.Location = New System.Drawing.Point(519, 270)
        Me.purchasecost.Name = "purchasecost"
        Me.purchasecost.Size = New System.Drawing.Size(132, 24)
        Me.purchasecost.TabIndex = 83
        Me.purchasecost.Text = "Purchase Cost"
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(523, 465)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 23)
        Me.delete.TabIndex = 73
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Update1
        '
        Me.Update1.Location = New System.Drawing.Point(413, 465)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(75, 23)
        Me.Update1.TabIndex = 72
        Me.Update1.Text = "Update"
        Me.Update1.UseVisualStyleBackColor = True
        '
        'addnew
        '
        Me.addnew.Location = New System.Drawing.Point(523, 465)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(75, 23)
        Me.addnew.TabIndex = 75
        Me.addnew.Text = "Add New"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(629, 465)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 74
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(523, 465)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 71
        Me.ok.Text = "Ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(110, 270)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(300, 125)
        Me.DataGridView1.TabIndex = 69
        '
        'snamecombo
        '
        Me.snamecombo.FormattingEnabled = True
        Me.snamecombo.Location = New System.Drawing.Point(302, 212)
        Me.snamecombo.Name = "snamecombo"
        Me.snamecombo.Size = New System.Drawing.Size(499, 21)
        Me.snamecombo.TabIndex = 68
        '
        'pid
        '
        Me.pid.AutoSize = True
        Me.pid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Location = New System.Drawing.Point(305, 93)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(36, 24)
        Me.pid.TabIndex = 82
        Me.pid.Text = "pid"
        '
        'dely
        '
        Me.dely.FormattingEnabled = True
        Me.dely.ItemHeight = 13
        Me.dely.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.dely.Location = New System.Drawing.Point(427, 173)
        Me.dely.Name = "dely"
        Me.dely.Size = New System.Drawing.Size(61, 21)
        Me.dely.TabIndex = 67
        '
        'delm
        '
        Me.delm.FormattingEnabled = True
        Me.delm.ItemHeight = 13
        Me.delm.Items.AddRange(New Object() {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"})
        Me.delm.Location = New System.Drawing.Point(359, 173)
        Me.delm.Name = "delm"
        Me.delm.Size = New System.Drawing.Size(51, 21)
        Me.delm.TabIndex = 66
        '
        'deld
        '
        Me.deld.FormattingEnabled = True
        Me.deld.ItemHeight = 13
        Me.deld.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.deld.Location = New System.Drawing.Point(302, 173)
        Me.deld.Name = "deld"
        Me.deld.Size = New System.Drawing.Size(44, 21)
        Me.deld.TabIndex = 65
        '
        'ordery
        '
        Me.ordery.FormattingEnabled = True
        Me.ordery.ItemHeight = 13
        Me.ordery.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.ordery.Location = New System.Drawing.Point(427, 135)
        Me.ordery.Name = "ordery"
        Me.ordery.Size = New System.Drawing.Size(61, 21)
        Me.ordery.TabIndex = 64
        '
        'orderm
        '
        Me.orderm.FormattingEnabled = True
        Me.orderm.ItemHeight = 13
        Me.orderm.Items.AddRange(New Object() {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"})
        Me.orderm.Location = New System.Drawing.Point(359, 135)
        Me.orderm.Name = "orderm"
        Me.orderm.Size = New System.Drawing.Size(51, 21)
        Me.orderm.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Order Date"
        '
        'orderd
        '
        Me.orderd.FormattingEnabled = True
        Me.orderd.ItemHeight = 13
        Me.orderd.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.orderd.Location = New System.Drawing.Point(302, 135)
        Me.orderd.Name = "orderd"
        Me.orderd.Size = New System.Drawing.Size(44, 21)
        Me.orderd.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(106, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 24)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Delivery Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Supplier Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(399, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 29)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Purchase Request"
        '
        'PurchaseRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.recieve)
        Me.Controls.Add(Me.ok2)
        Me.Controls.Add(Me.cost)
        Me.Controls.Add(Me.purchasecost)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Update1)
        Me.Controls.Add(Me.addnew)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.snamecombo)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.dely)
        Me.Controls.Add(Me.delm)
        Me.Controls.Add(Me.deld)
        Me.Controls.Add(Me.ordery)
        Me.Controls.Add(Me.orderm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.orderd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PurchaseRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Request"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents recieve As System.Windows.Forms.Button
    Friend WithEvents ok2 As System.Windows.Forms.Button
    Friend WithEvents cost As System.Windows.Forms.TextBox
    Friend WithEvents purchasecost As System.Windows.Forms.Label
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents Update1 As System.Windows.Forms.Button
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents snamecombo As System.Windows.Forms.ComboBox
    Friend WithEvents pid As System.Windows.Forms.Label
    Friend WithEvents dely As System.Windows.Forms.ComboBox
    Friend WithEvents delm As System.Windows.Forms.ComboBox
    Friend WithEvents deld As System.Windows.Forms.ComboBox
    Friend WithEvents ordery As System.Windows.Forms.ComboBox
    Friend WithEvents orderm As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents orderd As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
