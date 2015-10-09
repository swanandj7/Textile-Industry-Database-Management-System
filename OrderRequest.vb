Imports System.Data.OleDb

Public Class OrderRequest
    Dim dd As Date
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim i, cflag As Integer
    Private Sub OrderRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"

        con.Open()

        i = 0
        Try
            dd = Date.Now
            orderd.Text = dd.Day
            orderm.Text = orderm.Items(dd.Month - 1)
            ordery.Text = dd.Year

            delete.Visible = False
            If Report.reportflag = 1 Then
                quer = "select * from orders where oid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                If Report.detect = "orders" Then
                    delete.Visible = True
                End If
                da.Fill(ds)
                oid.Text = ds.Tables(0).Rows(0).Item("oid")
                dd = ds.Tables(0).Rows(0).Item("orderdate")
                orderd.Text = dd.Day
                orderm.Text = orderm.Items(dd.Month - 1)
                ordery.Text = dd.Year
                Dim quer2, temp As String
                Dim ds1 As New DataSet
                temp = ds.Tables(0).Rows(0).Item("cid")
                quer2 = "select cname from customer where cid=" + temp
                Dim cnd1 As New OleDbCommand(quer2, con)
                Dim da1 As New OleDbDataAdapter(quer2, con)
                da1.Fill(ds1)
                cnamecombo.Text = ds1.Tables(0).Rows(0).Item("cname")
                quer = "select * from order_quality where oid=" + Report.id
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                Dim col, col1 As New DataGridViewTextBoxColumn
                col.HeaderText = "Quality"
                col.Name = "quality"
                DataGridView1.Columns.Add(col)
                DataGridView1.Columns(0).Width = 200
                col1.HeaderText = "Quantity"
                col1.Name = "quantity"
                DataGridView1.Columns.Add(col1)
                DataGridView1.Columns(1).Width = 57
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    temp = ds.Tables(0).Rows(i).Item("qid")
                    quer = "select * from quality where qid=" + temp
                    ds1 = New DataSet
                    cnd = New OleDbCommand(quer, con)
                    da1 = New OleDbDataAdapter(quer, con)
                    da1.Fill(ds1)
                    DataGridView1.Rows.Add(ds1.Tables(0).Rows(0).Item("qname"), ds.Tables(0).Rows(i).Item("quantity"))
                Next
                cnamecombo.Enabled = False
                orderd.Enabled = False
                orderm.Enabled = False
                ordery.Enabled = False
                DataGridView1.EditMode = DataGridViewEditMode.EditOnF2
                cancel.Visible = False
                addnew.Visible = False
                da.Dispose()
            Else
                ok.Enabled = False
                Dim col As New DataGridViewComboBoxColumn
                col.Items.Clear()
                col.HeaderText = "Quality"
                col.Name = "quality"
                quer = "select * from quality"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    col.Items.Add(ds.Tables(0).Rows(i).Item("qname"))
                Next
                DataGridView1.Columns.Add(col)
                DataGridView1.Columns(0).Width = 200
                Dim col1 As New DataGridViewTextBoxColumn
                col1.HeaderText = "Quantity"
                col1.Name = "quantity"
                DataGridView1.Columns.Add(col1)
                DataGridView1.Columns(1).Width = 57
                ds.Clear()
                quer = "select * from customer"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    cnamecombo.Items.Add(ds.Tables(0).Rows(i).Item("cname"))
                Next
                ds.Clear()
                quer = "select * from orders"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    oid.Text = 1
                Else
                    ds.Clear()
                    quer = "select max(oid) from orders"
                    cnd = New OleDbCommand(quer, con)
                    da = New OleDbDataAdapter(quer, con)
                    da.Fill(ds)
                    oid.Text = ds.Tables(0).Rows(0).Item("max(oid)") + 1
                End If
                da.Dispose()
                addnew.Visible = False
                ok.Visible = True
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Try
            If Report.reportflag = 1 Then
                Button2_Click(sender, e)
            Else
                quer = "select * from orders"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                Dim dsNewRow As DataRow
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                dsNewRow = ds.Tables(0).NewRow()
                Dim odate As String
                dsNewRow.Item("oid") = oid.Text
                odate = orderd.Text + "-" + orderm.Text + "-" + ordery.Text
                dsNewRow.Item("orderdate") = odate
                dsNewRow.Item("ostatus") = 0
                Dim quer2 As String
                Dim ds1 As New DataSet
                quer2 = "select cid from customer where cname='" + cnamecombo.Text + "'"
                Dim cnd1 As New OleDbCommand(quer2, con)
                Dim da1 As New OleDbDataAdapter(quer2, con)
                da1.Fill(ds1)
                dsNewRow.Item("cid") = ds1.Tables(0).Rows(0).Item("cid")
                da1.Dispose()
                ds1.Clear()
                ds.Tables(0).Rows.Add(dsNewRow)
                da.Update(ds)
                da.Dispose()
                ds.Clear()
                quer = "select * from order_quality"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                Dim cb1 As New OleDb.OleDbCommandBuilder(da)


                For Me.i = 0 To DataGridView1.Rows.Count - 2
                    dsNewRow = ds.Tables(0).NewRow()
                    dsNewRow.Item("oid") = oid.Text
                    quer2 = "select qid from quality where qname='" + DataGridView1.Rows(i).Cells(0).Value + "'"
                    cnd1 = New OleDbCommand(quer2, con)
                    ds1 = New DataSet
                    da1 = New OleDbDataAdapter(quer2, con)
                    da1.Fill(ds1)
                    dsNewRow.Item("qid") = ds1.Tables(0).Rows(0).Item("qid")
                    da1.Dispose()
                    ds1.Clear()
                    dsNewRow.Item("quantity") = DataGridView1.Rows(i).Cells(1).Value
                    ds.Tables(0).Rows.Add(dsNewRow)
                Next
                da.Update(ds)
                MsgBox("Order added")
                ok.Visible = False
                addnew.Visible = True
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        If Report.reportflag = 1 Then
            If Report.detect = "orders" Then
                Report.Close()
                Me.Close()
                homeform.Pendingorder.PerformClick()
            ElseIf Report.detect = "orderscomp" Then
                Report.Close()
                Me.Close()
                homeform.Completedorder.PerformClick()
            End If
        End If
        ok.Visible = True
        addnew.Visible = False
        con.Close()
        Me.Close()
        homeform.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        Me.Close()
        homeform.NewOrderToolStripMenuItem.PerformClick()
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

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Dim res As MsgBoxResult
        res = MsgBox("Delete Order", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.Yes Then
            quer = "delete from orders where oid=" + Report.id
            Dim cnd As New OleDbCommand(quer, con)
            cnd.ExecuteNonQuery()
            Dim cb1 As New OleDb.OleDbCommandBuilder(da)
            res = MsgBox("Order Deleted")
            If res = MsgBoxResult.Ok Then
                Me.Button2_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub cnamecombo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cnamecombo.MouseClick
        cflag = 1
    End Sub

   Private Sub cnamecombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnamecombo.SelectedIndexChanged
        ok.Enabled = True
    End Sub

    Private Sub cnamecombo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cnamecombo.TextChanged
        If cflag <> 1 And Report.reportflag <> 1 Then
            If cnamecombo.Text = "" Then
                quer = "select * from customer"
            Else
                quer = "select * from customer where cname like '%" + cnamecombo.Text.ToUpper + "%'"
            End If
            While cnamecombo.Items.Count
                cnamecombo.Items.RemoveAt(cnamecombo.Items.Count - 1)
            End While
            Dim cnd As New OleDbCommand(quer, con)
            ds = New DataSet
            da = New OleDbDataAdapter(quer, con)
            da.Fill(ds)
            For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                cnamecombo.Items.Add(ds.Tables(0).Rows(i).Item("cname"))
            Next
        End If
    End Sub
End Class