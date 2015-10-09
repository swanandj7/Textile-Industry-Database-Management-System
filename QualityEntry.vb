Imports System.Data.OleDb

Public Class QualityEntry
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim i As Integer


    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Try
            quer = "select * from quality"
            Dim cnd As New OleDbCommand(quer, con)
            da = New OleDbDataAdapter(quer, con)
            da.Fill(ds)
            Dim dsNewRow As DataRow
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            dsNewRow = ds.Tables(0).NewRow()
            dsNewRow.Item("qid") = qid.Text
            dsNewRow.Item("qname") = qname.Text
            dsNewRow.Item("qrate") = qrate.Text
            dsNewRow.Item("quantity") = 0
            dsNewRow.Item("limit") = 0
            ds.Tables(0).Rows.Add(dsNewRow)
            da.Update(ds)
            MsgBox("New Quality added")
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
            homeform.qualitylist.PerformClick()
        ElseIf Stock.stockflag = 1 And Report.stockflag = 1 Then
            Stock.Close()
            Me.Close()
            homeform.oqButton_Click(sender, e)
        ElseIf Stock.stockflag = 1 Then
            Stock.Close()
            Me.Close()
            homeform.ViewStockToolStripMenuItem.PerformClick()
        End If
        ok.Visible = True
        addnew.Visible = False
        con.Close()
        Me.Close()
        homeform.Enabled = True
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        Me.Close()
        homeform.AddNewquality.PerformClick()

    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update1.Click
        i = i + 1
        qname.Enabled = True
        qrate.Enabled = True
        Dim index = Report.index
        Try
            If i = 2 Then
                quer = "UPDATE quality SET qname ='" + qname.Text + "',qrate =" + qrate.Text + "  WHERE qid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                cnd.ExecuteNonQuery()
                Dim cb1 As New OleDb.OleDbCommandBuilder(da)
                Dim res As MsgBoxResult
                res = MsgBox("Quality Updated")
                If res = MsgBoxResult.Ok Then
                    Me.Button2_Click(sender, e)
                End If
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try

    End Sub

   Private Sub QualityEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"

        con.Open()

        i = 0
        Try

            If Report.reportflag = 1 Or Stock.stockflag = 1 Then
                ds.Clear()
                If Report.reportflag = 1 Then
                    quer = "select * from quality where qid=" + Report.id
                ElseIf Stock.stockflag = 1 Then
                    quer = "select * from quality where qid=" + Stock.id

                End If
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                qid.Text = ds.Tables(0).Rows(0).Item("qid")
                qname.Text = ds.Tables(0).Rows(0).Item("qname")
                qrate.Text = ds.Tables(0).Rows(0).Item("qrate")
                addnew.Visible = False
                qname.Enabled = False
                qrate.Enabled = False
                Update1.Visible = True
                Label3.Visible = False
                limit.Visible = False
                climit.Visible = False
                If Stock.stockflag = 1 Then
                    climit.TabIndex = 1
                    limit.TabIndex = 2
                    cancel.TabIndex = 3
                    Update1.Visible = False
                    climit.Visible = True
                    Label3.Visible = True
                    limit.Visible = True
                    limit.Text = ds.Tables(0).Rows(0).Item("limit")
                    limit.Enabled = False
                End If
                da.Dispose()
            Else
                climit.Visible = False
                Label3.Visible = False
                limit.Visible = False
                ds.Clear()
                quer = "select * from quality"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    qid.Text = 1
                Else
                    quer = "select max(qid) from quality"
                    cnd = New OleDbCommand(quer, con)
                    da = New OleDbDataAdapter(quer, con)
                    ds.Clear()
                    da.Fill(ds)
                    qid.Text = ds.Tables(0).Rows(0).Item("max(qid)") + 1
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

    Private Sub climit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles climit.Click
        limit.Enabled = True
        i = i + 1
        qname.Enabled = False
        qrate.Enabled = False
        Dim index = Report.index
        Try
            If i = 2 Then
                quer = "UPDATE quality SET limit=" + limit.Text + "  WHERE qid=" + Stock.id
                Dim cnd As New OleDbCommand(quer, con)
                cnd.ExecuteNonQuery()
                Dim cb1 As New OleDb.OleDbCommandBuilder(da)
                Dim res As MsgBoxResult
                res = MsgBox("Limit Updated")
                If res = MsgBoxResult.Ok Then
                    Me.Button2_Click(sender, e)
                End If
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub


End Class