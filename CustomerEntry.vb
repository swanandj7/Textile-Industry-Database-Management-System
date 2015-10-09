Imports System.Data.OleDb

Public Class CustomerEntry
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim i As Integer

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"

        con.Open()

        i = 0
        Try

            If Report.reportflag = 1 Then
                quer = "select * from customer where cid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                cid.Text = ds.Tables(0).Rows(0).Item("cid")
                cname.Text = ds.Tables(0).Rows(0).Item("cname")
                cadd.Text = ds.Tables(0).Rows(0).Item("cadd")
                cphone.Text = ds.Tables(0).Rows(0).Item("cphone")
                cname.Enabled = False
                cadd.Enabled = False
                cphone.Enabled = False
                addnew.Visible = False
                ok.Visible = False
                Update1.Visible = True
                cancel.TabIndex = 0
                da.Dispose()

            Else
                ds.Clear()
                quer = "select * from customer"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    cid.Text = 1
                Else
                    quer = "select max(cid) from customer"
                    cnd = New OleDbCommand(quer, con)
                    da = New OleDbDataAdapter(quer, con)
                    ds.Clear()
                    da.Fill(ds)
                    cid.Text = ds.Tables(0).Rows(0).Item("max(cid)") + 1
                End If
                da.Dispose()
                Update1.Visible = False
                addnew.Visible = False
                ok.Visible = True
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Try
            quer = "select * from customer"
            Dim cnd As New OleDbCommand(quer, con)
            da = New OleDbDataAdapter(quer, con)
            da.Fill(ds)
            Dim dsNewRow As DataRow
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            dsNewRow = ds.Tables(0).NewRow()
            dsNewRow.Item("cid") = cid.Text
            dsNewRow.Item("cname") = cname.Text
            dsNewRow.Item("cadd") = cadd.Text
            dsNewRow.Item("cphone") = cphone.Text
            ds.Tables(0).Rows.Add(dsNewRow)
            da.Update(ds)
            MsgBox("New Record added")
            ok.Visible = False
            cname.Enabled = False
            cadd.Enabled = False
            cphone.Enabled = False
            addnew.Visible = True
            da.Dispose()
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        If Report.reportflag = 1 Then
            Report.Close()
            Me.Close()
            homeform.CustomerLIstToolStripMenuItem.PerformClick()
        End If
        ok.Visible = True
        addnew.Visible = False
        con.Close()
        Me.Close()
        homeform.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        Me.Close()
        homeform.AddNewcustomer.PerformClick()
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update1.Click
        i = i + 1
        cname.Enabled = True
        cadd.Enabled = True
        cphone.Enabled = True
        Dim index = Report.index

        Try

            If i = 2 Then
                quer = "UPDATE customer SET cname ='" + cname.Text + "',cphone ='" + cphone.Text + "',cadd ='" + cadd.Text + "  WHERE cid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                cnd.ExecuteNonQuery()
                Dim cb1 As New OleDb.OleDbCommandBuilder(da)
                Dim res As MsgBoxResult
                res = MsgBox("Details Updated")
                If res = MsgBoxResult.Ok Then
                    Me.Button2_Click(sender, e)
                End If
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub cphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cphone.TextChanged
        ok.Enabled = False
        If IsNumeric(cphone.Text) And cphone.Text.Length = 10 Then
            ok.Enabled = True
        Else
        End If
    End Sub
End Class