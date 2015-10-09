<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QualityEntry
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
        Me.limit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.climit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.qid = New System.Windows.Forms.Label()
        Me.Update1 = New System.Windows.Forms.Button()
        Me.addnew = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.qrate = New System.Windows.Forms.TextBox()
        Me.qname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'limit
        '
        Me.limit.Location = New System.Drawing.Point(289, 305)
        Me.limit.Multiline = True
        Me.limit.Name = "limit"
        Me.limit.Size = New System.Drawing.Size(227, 26)
        Me.limit.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 24)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Limit"
        '
        'climit
        '
        Me.climit.Location = New System.Drawing.Point(388, 383)
        Me.climit.Name = "climit"
        Me.climit.Size = New System.Drawing.Size(83, 23)
        Me.climit.TabIndex = 45
        Me.climit.Text = "Change Limit"
        Me.climit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(151, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 24)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "ID"
        '
        'qid
        '
        Me.qid.AutoSize = True
        Me.qid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qid.Location = New System.Drawing.Point(285, 160)
        Me.qid.Name = "qid"
        Me.qid.Size = New System.Drawing.Size(38, 24)
        Me.qid.TabIndex = 52
        Me.qid.Text = "qID"
        '
        'Update1
        '
        Me.Update1.Location = New System.Drawing.Point(388, 383)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(75, 23)
        Me.Update1.TabIndex = 43
        Me.Update1.Text = "Update"
        Me.Update1.UseVisualStyleBackColor = True
        '
        'addnew
        '
        Me.addnew.Location = New System.Drawing.Point(388, 383)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(75, 23)
        Me.addnew.TabIndex = 47
        Me.addnew.Text = "Add New"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(497, 383)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 46
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(388, 383)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 42
        Me.ok.Text = "Ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'qrate
        '
        Me.qrate.Location = New System.Drawing.Point(289, 257)
        Me.qrate.Multiline = True
        Me.qrate.Name = "qrate"
        Me.qrate.Size = New System.Drawing.Size(227, 26)
        Me.qrate.TabIndex = 40
        '
        'qname
        '
        Me.qname.Location = New System.Drawing.Point(289, 213)
        Me.qname.Multiline = True
        Me.qname.Name = "qname"
        Me.qname.Size = New System.Drawing.Size(227, 24)
        Me.qname.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(151, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(151, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 24)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Quality Entry"
        '
        'QualityEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.limit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.climit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.qid)
        Me.Controls.Add(Me.Update1)
        Me.Controls.Add(Me.addnew)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.qrate)
        Me.Controls.Add(Me.qname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QualityEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quality Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents limit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents climit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents qid As System.Windows.Forms.Label
    Friend WithEvents Update1 As System.Windows.Forms.Button
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents qrate As System.Windows.Forms.TextBox
    Friend WithEvents qname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
