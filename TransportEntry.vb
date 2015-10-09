Imports System.Data.OleDb

Public Class TransportEntry
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub TransportEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"

        con.Open()

        i = 0
        Try

            If Report.reportflag = 1 Then
                ds.Clear()
                quer = "select * from transport where tid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                tid.Text = ds.Tables(0).Rows(0).Item("tid")
                tname.Text = ds.Tables(0).Rows(0).Item("tname")
                tphone.Text = ds.Tables(0).Rows(0).Item("tphone")
                tname.Enabled = False
                tphone.Enabled = False
                Update1.Visible = True
                delete.Visible = True
                da.Dispose()
            Else
                ds.Clear()
                quer = "select * from transport"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    tid.Text = 1
                Else
                    ds.Clear()
                    quer = "select max(tid) from transport"
                    cnd = New OleDbCommand(quer, con)
                    da = New OleDbDataAdapter(quer, con)
                    da.Fill(ds)
                    tid.Text = ds.Tables(0).Rows(0).Item("max(tid)") + 1
                End If
                da.Dispose()
                delete.Visible = False
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
            quer = "select * from transport"
            Dim cnd As New OleDbCommand(quer, con)
            da = New OleDbDataAdapter(quer, con)
            da.Fill(ds)
            Dim dsNewRow As DataRow
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            dsNewRow = ds.Tables(0).NewRow()
            dsNewRow.Item("tid") = tid.Text
            dsNewRow.Item("tname") = tname.Text
            dsNewRow.Item("tphone") = tphone.Text
            ds.Tables(0).Rows.Add(dsNewRow)
            da.Update(ds)
            MsgBox("Transport added")
            ok.Visible = False
            addnew.Visible = True
            da.Dispose()
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        con.Close()
        If Report.reportflag = 1 Then
            Report.Close()
            homeform.AgencyListsToolStripMenuItem.PerformClick()
        End If
        ok.Visible = True
        addnew.Visible = False
        Me.Close()
        homeform.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        Me.Close()
        homeform.AddNewtransport.PerformClick()

    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update1.Click
        i = i + 1
        tname.Enabled = True
        tphone.Enabled = True
        delete.Visible = False
        Dim index = Report.index

        Try

            If i = 2 Then

                quer = "UPDATE transport SET tname ='" + tname.Text + "',tstate ='" + tphone.Text + "'  WHERE tid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                cnd.ExecuteNonQuery()
                Dim cb1 As New OleDb.OleDbCommandBuilder(da)
                Dim res As MsgBoxResult
                res = MsgBox("Updated")
                If res = MsgBoxResult.Ok Then
                    Me.Button2_Click(sender, e)
                End If
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Dim res As MsgBoxResult
        res = MsgBox("Delete Transport Agency", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.Yes Then
            quer = "delete from transport where tid=" + Report.id
            Dim cnd As New OleDbCommand(quer, con)
            cnd.ExecuteNonQuery()
            Dim cb1 As New OleDb.OleDbCommandBuilder(da)
            res = MsgBox("Deleted")
            If res = MsgBoxResult.Ok Then
                Me.Button2_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub tphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tphone.TextChanged
        ok.Enabled = False
        If IsNumeric(tphone.Text) And tphone.Text.Length = 10 Then
            ok.Enabled = True
        Else
        End If
    End Sub
End Class