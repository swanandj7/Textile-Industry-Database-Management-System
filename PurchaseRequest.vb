Imports System.Data.OleDb
Public Class PurchaseRequest
    Dim dd As Date
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim i, j, up, sflag As Integer

    Private Sub PurchaseRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"

        con.Open()

        up = 0
        delete.Visible = False
        Update1.Visible = False
        addnew.Visible = False
        ok.Visible = True
        dd = Date.Now
        orderd.Text = dd.Day
        orderm.Text = orderm.Items(dd.Month - 1)
        ordery.Text = dd.Year
        deld.Text = dd.Day
        delm.Text = orderm.Items(dd.Month - 1)
        dely.Text = dd.Year
        Try

            If Report.reportflag = 1 Then
                cost.Visible = False
                purchasecost.Visible = False
                If Report.detect = "purchasecomp" Then
                    recieve.Visible = False
                End If
                quer = "select * from purchase where pid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                pid.Text = ds.Tables(0).Rows(0).Item("pid")
                dd = ds.Tables(0).Rows(0).Item("porder")
                orderd.Text = dd.Day
                orderm.Text = orderm.Items(dd.Month - 1)
                ordery.Text = dd.Year
                dd = ds.Tables(0).Rows(0).Item("precieve")
                deld.Text = dd.Day
                delm.Text = orderm.Items(dd.Month - 1)
                dely.Text = dd.Year
                If Report.detect = "purchasecomp" Then
                    purchasecost.Visible = True
                    cost.Visible = True
                    cost.Text = ds.Tables(0).Rows(0).Item("expense")
                    cost.Enabled = False

                End If
                Dim quer2, temp As String
                Dim ds1 As New DataSet
                temp = ds.Tables(0).Rows(0).Item("sid")
                quer2 = "select sname from supplier where sid=" + temp
                Dim cnd1 As New OleDbCommand(quer2, con)
                Dim da1 As New OleDbDataAdapter(quer2, con)
                da1.Fill(ds1)
                snamecombo.Text = ds1.Tables(0).Rows(0).Item("sname")
                quer = "select * from purchase_quality where pid=" + Report.id
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

                snamecombo.Enabled = False
                orderd.Enabled = False
                orderm.Enabled = False
                ordery.Enabled = False
                deld.Enabled = False
                delm.Enabled = False
                dely.Enabled = False
                cancel.Visible = False
                DataGridView1.EditMode = DataGridViewEditMode.EditOnF2
                addnew.Visible = False
                If Report.detect = "purchase" Or Report.detect = "purchase1" Then
                    Update1.Visible = True
                    delete.Visible = True
                    cancel.Visible = True
                End If

            Else
                ok.Enabled = False
                recieve.Visible = False
                Dim col As New DataGridViewComboBoxColumn
                col.Items.Clear()
                col.HeaderText = "Quality"
                col.Name = "quality"
                quer = "select * from quality"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
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
                quer = "select * from supplier"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    snamecombo.Items.Add(ds.Tables(0).Rows(i).Item("sname"))
                Next
                ds.Clear()
                quer = "select * from purchase"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    pid.Text = 1
                Else
                    ds.Clear()
                    quer = "select max(pid) from purchase"
                    cnd = New OleDbCommand(quer, con)
                    da = New OleDbDataAdapter(quer, con)
                    da.Fill(ds)
                    pid.Text = ds.Tables(0).Rows(0).Item("max(pid)") + 1
                End If
                da.Dispose()
                cost.Visible = False
                purchasecost.Visible = False
            End If
            ok2.Visible = False

        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub snamecombo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles snamecombo.KeyDown
        sflag = 1
        snamecombo.DroppedDown = True

    End Sub

    Private Sub snamecombo_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles snamecombo.KeyPress
        sflag = 0
        If Asc(e.KeyChar) = 13 Then
            snamecombo.Text = ""
        End If
        snamecombo.DroppedDown = True

    End Sub


    Private Sub delete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Dim res As MsgBoxResult
        res = MsgBox("Delete Purchase Request", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.Yes Then
            quer = "delete from purchase where pid=" + Report.id
            Dim cnd As New OleDbCommand(quer, con)
            cnd.ExecuteNonQuery()
            Dim cb1 As New OleDb.OleDbCommandBuilder(da)

            res = MsgBox("Deleted")
            If res = MsgBoxResult.Ok Then
                Me.cancel_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub Update1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update1.Click
        up = up + 1
        deld.Enabled = True
        delm.Enabled = True
        dely.Enabled = True
        Dim index = Report.index
        Dim pdate As String
        Try
            If up = 2 Then
                pdate = "'" + dely.Text + "-" + delm.Text + "-" + deld.Text + "'"
                quer = "UPDATE purchase SET precieve =" + pdate + " WHERE pid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                cnd.ExecuteNonQuery()
                Dim res As MsgBoxResult
                res = MsgBox("Updated")
                If res = MsgBoxResult.Ok Then
                    Me.cancel_Click(sender, e)
                End If
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        If Report.reportflag = 1 Then
            If Report.detect = "purchase" Then
                Report.Close()
                Me.Close()
                homeform.Pendingpurchase.PerformClick()
            ElseIf Report.detect = "purchasecomp" Then
                Report.Close()
                Me.Close()
                homeform.Completedpurchase.PerformClick()
            ElseIf Report.detect = "purchase1" Then
                Report.Close()
                Me.Close()
                homeform.opButton_Click(sender, e)
            End If
        End If
        ok.Visible = True
        addnew.Visible = False
        con.Close()

        Me.Close()
        homeform.Enabled = True

    End Sub

    Private Sub addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        Me.Close()
        homeform.addnewpurchase.PerformClick()
    End Sub

    Private Sub ok_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Try
            If Report.reportflag = 1 Then
                cancel_Click(sender, e)
            Else
                quer = "select * from purchase"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                Dim dsNewRow As DataRow
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                dsNewRow = ds.Tables(0).NewRow()
                Dim odate, pdate As String
                dsNewRow.Item("pid") = pid.Text
                dsNewRow.Item("pstatus") = 0
                odate = orderd.Text + "-" + orderm.Text + "-" + ordery.Text
                dsNewRow.Item("porder") = odate
                pdate = deld.Text + "-" + delm.Text + "-" + dely.Text
                dsNewRow.Item("precieve") = pdate
                dsNewRow.Item("Expense") = 0
                Dim quer2 As String
                Dim ds1 As New DataSet
                quer2 = "select sid from supplier where sname='" + snamecombo.Text + "'"
                Dim cnd1 As New OleDbCommand(quer2, con)
                Dim da1 As New OleDbDataAdapter(quer2, con)
                da1.Fill(ds1)
                dsNewRow.Item("sid") = ds1.Tables(0).Rows(0).Item("sid")
                da1.Dispose()
                ds1.Clear()
                ds.Tables(0).Rows.Add(dsNewRow)
                da.Update(ds)
                da.Dispose()
                ds.Clear()
                quer = "select * from purchase_quality"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                Dim cb1 As New OleDb.OleDbCommandBuilder(da)


                For Me.i = 0 To DataGridView1.Rows.Count - 2
                    dsNewRow = ds.Tables(0).NewRow()
                    dsNewRow.Item("pid") = pid.Text
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
                MsgBox("Purchase request added")
                ok.Visible = False

                addnew.Visible = True
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub recieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recieve.Click
        Update1.Visible = False
        delete.Visible = False
        cancel.Visible = False
        ok.Visible = False
        recieve.Visible = False
        ok2.Visible = True
        purchasecost.Visible = True
        cost.Visible = True
        dd = Date.Now
        deld.Text = dd.Day
        delm.Text = orderm.Items(dd.Month - 1)
        dely.Text = dd.Year
        deld.Enabled = True
        delm.Enabled = True
        dely.Enabled = True
        MsgBox("Enter Purchase Cost")
    End Sub

    Private Sub ok2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok2.Click
        Dim index = Report.index
        Dim quan, quan1, temp, temp1, recieve As String
        Try
            recieve = "'" + dely.Text + "-" + delm.Text + "-" + deld.Text + "'"
            quer = "UPDATE purchase SET pstatus=1,expense=" + cost.Text + ",precieve=" + recieve + " WHERE pid=" + Report.id
            Dim cnd As New OleDbCommand(quer, con)
            cnd.ExecuteNonQuery()
            Dim quer3 As String
            Dim ds2 As New DataSet
            quer3 = "select * from quality"
            Dim cnd1 As New OleDbCommand(quer3, con)
            Dim da1 As New OleDbDataAdapter(quer3, con)
            da1.Fill(ds2)
            Dim quer2 As String
            Dim ds1 As New DataSet
            quer2 = "select * from purchase_quality where pid=" + Report.id
            cnd1 = New OleDbCommand(quer2, con)
            da1 = New OleDbDataAdapter(quer2, con)
            da1.Fill(ds1)
            For Me.i = 0 To ds1.Tables(0).Rows.Count - 1
                temp = ds1.Tables(0).Rows(i).Item("qid")
                For Me.j = 0 To ds2.Tables(0).Rows.Count - 1
                    temp1 = ds2.Tables(0).Rows(j).Item("qid")
                    If Val(temp) = Val(temp1) Then
                        quan = ds1.Tables(0).Rows(i).Item("quantity")
                        quan1 = ds2.Tables(0).Rows(j).Item("quantity")
                        quan = Val(quan) + Val(quan1)
                        quer = "UPDATE quality SET quantity =" + quan + " WHERE qid=" + temp
                        cnd = New OleDbCommand(quer, con)
                        cnd.ExecuteNonQuery()
                    End If
                Next
            Next
            Dim res As MsgBoxResult
            res = MsgBox("Purchase Completed")
            If res = MsgBoxResult.Ok Then
                cancel_Click(sender, e)
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub snamecombo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles snamecombo.MouseClick
        sflag = 1
    End Sub

    Private Sub snamecombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles snamecombo.SelectedIndexChanged
        ok.Enabled = True
    End Sub

    Private Sub snamecombo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles snamecombo.TextChanged
        If sflag <> 1 And Report.reportflag <> 1 Then
            If snamecombo.Text = "" Then
                quer = "select * from supplier"
            Else
                quer = "select * from supplier where sname like '%" + snamecombo.Text.ToUpper + "%'"
            End If
            While snamecombo.Items.Count
                snamecombo.Items.RemoveAt(snamecombo.Items.Count - 1)
            End While
            Dim cnd As New OleDbCommand(quer, con)
            ds = New DataSet
            da = New OleDbDataAdapter(quer, con)
            da.Fill(ds)
            For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                snamecombo.Items.Add(ds.Tables(0).Rows(i).Item("sname"))
            Next
            DataGridView1.Columns(0).SortMode = True
        End If
    End Sub
End Class