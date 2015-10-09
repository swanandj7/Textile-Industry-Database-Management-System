Imports System.Data.OleDb

Public Class LoginForm
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = ds.Tables(0).Rows(0).Item("username") Then
            If PasswordTextBox.Text = ds.Tables(0).Rows(0).Item("password") Then
                Me.Hide()
                Homeform.login.Text = UsernameTextBox.Text
                Homeform.Enabled = True
                Homeform.Show()
            Else
                MsgBox("Incorrect Password")
            End If
        Else
            MsgBox("Incorrect Username")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        con.Close()
        If homeform.homeflag = 1 Then
            Me.Hide()
            homeform.Enabled = True
            homeform.Show()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"
        con.Close()
        con.Open()
        quer = "select * from login"
        Dim cnd As New OleDbCommand(quer, con)
        ds = New DataSet
        da = New OleDbDataAdapter(quer, con)
        da.Fill(ds)
        Homeform.Show()
        Homeform.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmb.Click
        If UsernameTextBox.Text = ds.Tables(0).Rows(0).Item("password") Then
            If PasswordTextBox.Text = confirm.Text Then
                quer = "Update  login set password='" + PasswordTextBox.Text + "'"
                Dim cnd As New OleDbCommand(quer, con)
                cnd.ExecuteNonQuery()
                MsgBox("Password Changed")
                Me.Hide()
                Homeform.Enabled = True
                Homeform.Show()
            Else
                MsgBox("Incorrect Retyped Password")
                confirm.Text = ""
            End If
        Else
            MsgBox("Incorrect Old Password")
        End If
    End Sub

    Private Sub confirmu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmu.Click
        If UsernameTextBox.Text = ds.Tables(0).Rows(0).Item("username") Then
            MsgBox("Username Changed")
            quer = "Update  login set username='" + newuser.Text + "'"
            Dim cnd As New OleDbCommand(quer, con)
            cnd.ExecuteNonQuery()
            Me.Hide()
            Homeform.Enabled = True
            Homeform.login.Text = newuser.Text
            Homeform.Show()
        Else
            MsgBox("Incorrect Old Username")
        End If
    End Sub
End Class
