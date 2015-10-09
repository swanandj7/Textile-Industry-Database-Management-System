<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerEntry
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
        Me.Update1 = New System.Windows.Forms.Button()
        Me.addnew = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cid = New System.Windows.Forms.Label()
        Me.cancel = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.cphone = New System.Windows.Forms.TextBox()
        Me.cadd = New System.Windows.Forms.TextBox()
        Me.cname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Location = New System.Drawing.Point(448, 441)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(75, 23)
        Me.Update1.TabIndex = 33
        Me.Update1.Text = "Update"
        Me.Update1.UseVisualStyleBackColor = True
        '
        'addnew
        '
        Me.addnew.Location = New System.Drawing.Point(448, 441)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(75, 23)
        Me.addnew.TabIndex = 36
        Me.addnew.Text = "Add New"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 24)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "ID"
        '
        'cid
        '
        Me.cid.AutoSize = True
        Me.cid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cid.Location = New System.Drawing.Point(272, 160)
        Me.cid.Name = "cid"
        Me.cid.Size = New System.Drawing.Size(40, 24)
        Me.cid.TabIndex = 37
        Me.cid.Text = "CID"
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(545, 441)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 35
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(448, 441)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 32
        Me.ok.Text = "Ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'cphone
        '
        Me.cphone.Location = New System.Drawing.Point(274, 329)
        Me.cphone.Multiline = True
        Me.cphone.Name = "cphone"
        Me.cphone.Size = New System.Drawing.Size(227, 24)
        Me.cphone.TabIndex = 30
        '
        'cadd
        '
        Me.cadd.Location = New System.Drawing.Point(275, 234)
        Me.cadd.Multiline = True
        Me.cadd.Name = "cadd"
        Me.cadd.Size = New System.Drawing.Size(555, 75)
        Me.cadd.TabIndex = 28
        '
        'cname
        '
        Me.cname.Location = New System.Drawing.Point(274, 194)
        Me.cname.Multiline = True
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(555, 24)
        Me.cname.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(399, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 29)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Customer Entry"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Contact No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Name"
        '
        'CustomerEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.Update1)
        Me.Controls.Add(Me.addnew)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cid)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.cphone)
        Me.Controls.Add(Me.cadd)
        Me.Controls.Add(Me.cname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CustomerEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Update1 As System.Windows.Forms.Button
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cid As System.Windows.Forms.Label
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents cphone As System.Windows.Forms.TextBox
    Friend WithEvents cadd As System.Windows.Forms.TextBox
    Friend WithEvents cname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
