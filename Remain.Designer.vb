<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remain
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
        Me.back = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cphone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(-86, 495)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(81, 10)
        Me.print.TabIndex = 142
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(-92, -110)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(81, 10)
        Me.back.TabIndex = 140
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cname, Me.cphone, Me.tamount})
        Me.DataGridView1.Location = New System.Drawing.Point(126, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(443, 415)
        Me.DataGridView1.TabIndex = 143
        '
        'cname
        '
        Me.cname.HeaderText = "Customer"
        Me.cname.Name = "cname"
        Me.cname.ReadOnly = True
        Me.cname.Width = 200
        '
        'cphone
        '
        Me.cphone.HeaderText = "Contact"
        Me.cphone.Name = "cphone"
        Me.cphone.ReadOnly = True
        '
        'tamount
        '
        Me.tamount.HeaderText = "Remaining Amount"
        Me.tamount.Name = "tamount"
        Me.tamount.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 44)
        Me.Button1.TabIndex = 145
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 44)
        Me.Button2.TabIndex = 144
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Remain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.back)
        Me.Name = "Remain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remaining"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cphone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tamount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
