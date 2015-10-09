Imports System.Data.OleDb

Public Class SupplierEntry
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim i As Integer

    Private Sub SupplierEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"

        con.Open()

        i = 0
        Try

            If Report.reportflag = 1 Then
                ds.Clear()
                quer = "select * from supplier where sid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                sid.Text = ds.Tables(0).Rows(0).Item("sid")
                sname.Text = ds.Tables(0).Rows(0).Item("sname")
                sphone.Text = ds.Tables(0).Rows(0).Item("sphone")
                sname.Enabled = False
                sphone.Enabled = False
                Update1.Visible = True
                da.Dispose()
            Else
                ds.Clear()
                quer = "select * from supplier"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    sid.Text = 1
                Else
                    ds.Clear()
                    quer = "select max(sid) from supplier"
                    cnd = New OleDbCommand(quer, con)
                    da = New OleDbDataAdapter(quer, con)
                    da.Fill(ds)
                    sid.Text = ds.Tables(0).Rows(0).Item("max(sid)") + 1
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
            quer = "select * from supplier"
            Dim cnd As New OleDbCommand(quer, con)
            da = New OleDbDataAdapter(quer, con)
            da.Fill(ds)
            Dim dsNewRow As DataRow
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            dsNewRow = ds.Tables(0).NewRow()
            dsNewRow.Item("sid") = sid.Text
            dsNewRow.Item("sname") = sname.Text
            dsNewRow.Item("sphone") = sphone.Text
            ds.Tables(0).Rows.Add(dsNewRow)
            da.Update(ds)
            MsgBox("Supplier added")
            ok.Visible = False
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
            homeform.SupplierListToolStripMenuItem.PerformClick()
        End If
        ok.Visible = True
        addnew.Visible = False
        con.Close()
        Me.Close()
        homeform.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        Me.Close()
        homeform.AddNewsupplier.PerformClick()

    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update1.Click
        i = i + 1
        sname.Enabled = True
        sphone.Enabled = True
        Dim index = Report.index

        Try

            If i = 2 Then
                quer = "UPDATE supplier SET sname ='" + sname.Text + "',sphone ='" + sphone.Text + "'  WHERE sid=" + Report.id
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

    

    Private Sub sphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sphone.TextChanged
        ok.Enabled = False
        If IsNumeric(sphone.Text) And sphone.Text.Length = 10 Then
            ok.Enabled = True
        Else
        End If
    End Sub
End Class