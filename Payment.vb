Imports System.Data.OleDb

Public Class Payment
    Dim dd As Date
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim i, f1, f2, cflag As Integer
    Dim cnd As New OleDbCommand(quer, con)
    Dim cid As String
    Dim quer2 As String
    Dim ds1 As New DataSet
    Dim cnd1 As New OleDbCommand(quer2, con)
    Dim da1 As New OleDbDataAdapter(quer2, con)
    Dim e1 As System.Windows.Forms.KeyPressEventArgs

    Private Sub Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"

        con.Open()

        i = 0
        dd = Date.Now
        payd.Text = dd.Day
        paym.Text = paym.Items(dd.Month - 1)
        payy.Text = dd.Year
        Try

            If Report.reportflag = 1 Then
                quer = "select * from transaction where trid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                trid.Text = ds.Tables(0).Rows(0).Item("trid")
                dd = ds.Tables(0).Rows(0).Item("transdate")
                payd.Text = dd.Day
                paym.Text = paym.Items(dd.Month - 1)
                payy.Text = dd.Year
                amount.Text = ds.Tables(0).Rows(0).Item("paid")
                Dim quer2, temp As String
                Dim ds1 As New DataSet
                temp = ds.Tables(0).Rows(0).Item("cid")
                quer2 = "select cname from customer where cid=" + temp
                Dim cnd1 As New OleDbCommand(quer2, con)
                Dim da1 As New OleDbDataAdapter(quer2, con)
                da1.Fill(ds1)
                cnamecombo.Text = ds1.Tables(0).Rows(0).Item("cname")

                cnamecombo.Enabled = False
                payd.Enabled = False
                paym.Enabled = False
                payy.Enabled = False
                cancel.Visible = False
                addnew.Visible = False
                amount.Enabled = False
                da.Dispose()

            Else
                ok.Enabled = False
                ds.Clear()
                quer = "select * from transaction"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    trid.Text = 1
                Else
                    ds.Clear()
                    quer = "select max(trid) from transaction"
                    cnd = New OleDbCommand(quer, con)
                    da = New OleDbDataAdapter(quer, con)
                    da.Fill(ds)
                    trid.Text = ds.Tables(0).Rows(0).Item("max(trid)") + 1
                End If
                ds.Clear()
                Dim temp, temp1 As String
                Dim r As Integer
                quer = "select b.cid,t.tpaid,b.tamt from (select bill.cid,sum(tamount) as tamt from bill group by cid) b left join (select transaction.cid,sum(paid) as tpaid from transaction group by cid) t on b.cid=t.cid order by b.cid"
                Dim col As New DataGridViewTextBoxColumn
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                Dim da1 As OleDbDataAdapter
                Dim dS1 As New DataSet
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    temp = ds.Tables(0).Rows(i).Item("cid")
                    temp1 = Str(ds.Tables(0).Rows(i).Item("tpaid"))
                    If Val(temp1) = 0 Then
                        r = Val(ds.Tables(0).Rows(i).Item("tamt"))
                    Else
                        r = Val(ds.Tables(0).Rows(i).Item("tamt")) - Val(ds.Tables(0).Rows(i).Item("tpaid"))
                    End If
                    If r <> 0 Then
                        quer = "select cname,cphone from customer where cid=" + temp
                        dS1 = New DataSet
                        cnd = New OleDbCommand(quer, con)
                        da1 = New OleDbDataAdapter(quer, con)
                        da1.Fill(dS1)
                        cnamecombo.Items.Add(dS1.Tables(0).Rows(0).Item("cname"))

                    End If
                Next
                ds.Clear()
                da.Dispose()
                addnew.Visible = False
                ok.Visible = True
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub cnamecombo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cnamecombo.KeyDown
        cflag = 1
        cnamecombo.DroppedDown = True
    End Sub

    

    Private Sub cnamecombo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cnamecombo.KeyPress
        cflag = 0
        If Asc(e.KeyChar) = 13 Then
            cnamecombo.Text = ""
        End If
        cnamecombo.DroppedDown = True
    End Sub

    Private Sub cnamecombo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cnamecombo.MouseClick
        cflag = 1
    End Sub

    Private Sub cnamecombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnamecombo.SelectedIndexChanged
        f1 = 1
        If f2 = 1 Then
            ok.Enabled = True
        End If
        quer2 = "select cid from customer where cname='" + cnamecombo.Text.ToUpper + "'"
        cnd = New OleDbCommand(quer2, con)
        da1 = New OleDbDataAdapter(quer2, con)
        ds1 = New DataSet
        da1.Fill(ds1)
        If ds1.Tables(0).Rows.Count <> 0 Then
            cid = ds1.Tables(0).Rows(0).Item("cid")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        If Report.reportflag = 1 Then
            Report.Close()
            Me.Close()
            homeform.PaymentListToolStripMenuItem.PerformClick()
        End If
        ok.Visible = True
        addnew.Visible = False
        con.Close()
        Me.Close()
        homeform.Enabled = True
    End Sub
    Private Sub addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        Me.Close()
        homeform.AddNewpayment.PerformClick()
    End Sub

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Try
            If Report.reportflag = 1 Then
                Button2_Click(sender, e)
            Else
                quer = "select * from transaction"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                Dim dsNewRow As DataRow
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                dsNewRow = ds.Tables(0).NewRow()
                Dim trdate As String
                dsNewRow.Item("trid") = trid.Text
                trdate = payd.Text + "-" + paym.Text + "-" + payy.Text
                dsNewRow.Item("transdate") = trdate
                dsNewRow.Item("paid") = Val(amount.Text)
                dsNewRow.Item("cid") = cid
                ds.Tables(0).Rows.Add(dsNewRow)
                da.Update(ds)
                MsgBox("Payment added")
                ok.Visible = False
                addnew.Visible = True
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub cnamecombo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cnamecombo.TextChanged
        ds.Clear()

        Dim temp, temp1 As String
        Dim r, j As Integer
        If cflag <> 1 And Report.reportflag <> 1 Then
            While cnamecombo.Items.Count
                cnamecombo.Items.RemoveAt(cnamecombo.Items.Count - 1)
            End While
            quer = "select b.cid,t.tpaid,b.tamt from (select bill.cid,sum(tamount) as tamt from bill group by cid) b left join (select transaction.cid,sum(paid) as tpaid from transaction group by cid) t on b.cid=t.cid order by b.cid"
            Dim col As New DataGridViewTextBoxColumn
            cnd = New OleDbCommand(quer, con)
            da = New OleDbDataAdapter(quer, con)
            ds = New DataSet
            da.Fill(ds)
            Dim da1 As OleDbDataAdapter
            Dim dS1 As New DataSet
            If cnamecombo.Text = "" Then
                quer = "select cid,cname from customer"
            Else
                quer = "select cid,cname from customer where cname like '%" + cnamecombo.Text.ToUpper + "%'"
            End If
            dS1 = New DataSet
            cnd = New OleDbCommand(quer, con)
            da1 = New OleDbDataAdapter(quer, con)
            da1.Fill(dS1)
            For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                temp = ds.Tables(0).Rows(i).Item("cid")
                temp1 = Str(ds.Tables(0).Rows(i).Item("tpaid"))
                If Val(temp1) = 0 Then
                    r = Val(ds.Tables(0).Rows(i).Item("tamt"))
                Else
                    r = Val(ds.Tables(0).Rows(i).Item("tamt")) - Val(ds.Tables(0).Rows(i).Item("tpaid"))
                End If
                If r <> 0 Then
                    For j = 0 To dS1.Tables(0).Rows.Count - 1
                        If temp = dS1.Tables(0).Rows(j).Item("cid") Then
                            cnamecombo.Items.Add(dS1.Tables(0).Rows(j).Item("cname"))
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub amount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles amount.TextChanged
        f2 = 1
        If f1 = 1 Then
            ok.Enabled = True
        End If
    End Sub
End Class