Imports System.Data.OleDb

Public Class Report
    Dim dd As Date
    Public detect As String
    Public reportflag, stockflag As Integer
    Public id As String
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim count, temp As Integer
    Public index As Integer
    Dim i, j As Integer
    Dim a As DataGridViewCellMouseEventArgs

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"
        con.Open()
        reportflag = 1
        temp = 0
    End Sub



    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Home.Enabled = True

        index = DataGridView1.CurrentCell.RowIndex
        If index <> DataGridView1.Rows.Count Then
            index = index - temp
        End If
        id = DataGridView1.Rows(index).Cells(0).Value
        Stock.id = id
     
        reportflag = 1
        If detect = "customer" Then
            homeform.AddNewcustomer.PerformClick()
        ElseIf detect = "quality" Then
            homeform.AddNewquality.PerformClick()
        ElseIf detect = "supplier" Then
            homeform.AddNewsupplier.PerformClick()
        ElseIf detect = "transport" Then
            homeform.AddNewtransport.PerformClick()
        ElseIf detect = "orders" Then
            homeform.NewOrderToolStripMenuItem.PerformClick()
        ElseIf detect = "orderscomp" Then
            homeform.NewOrderToolStripMenuItem.PerformClick()
        ElseIf detect = "purchase" Then
            homeform.addnewpurchase.PerformClick()
        ElseIf detect = "purchasecomp" Then
            homeform.addnewpurchase.PerformClick()
        ElseIf detect = "bill" Then
            homeform.addnewbill.PerformClick()
        ElseIf detect = "payment" Then
            homeform.AddNewpayment.PerformClick()
        ElseIf detect = "transaction" Or detect = "transaction1" Then
            Transactions.Show()
        ElseIf detect = "purchase1" Then
            homeform.addnewpurchase.PerformClick()
        ElseIf detect = "stock" Then
            reportflag = 0
            Stock.stockflag = 1
            stockflag = 1
            homeform.AddNewquality.PerformClick()
        End If

End Sub



    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click
        con.Close()
        Me.Close()
        homeform.Enabled = True
    End Sub

    Private Sub DataGridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress

        If Asc(e.KeyChar) = 13 Then
            temp = 1
            index = DataGridView1.CurrentCell.RowIndex
            DataGridView1_CellMouseDoubleClick(sender, a)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            If detect = "customer" Then
                homeform.CustomerLIstToolStripMenuItem.PerformClick()
            ElseIf detect = "quality" Then
                homeform.qualitylist.PerformClick()
            ElseIf detect = "supplier" Then
                homeform.SupplierListToolStripMenuItem.PerformClick()
            ElseIf detect = "transport" Then
                homeform.AgencyListsToolStripMenuItem.PerformClick()
            ElseIf detect = "orders" Then
                homeform.Pendingorder.PerformClick()
            ElseIf detect = "orderscomp" Then
                homeform.Completedorder.PerformClick()
            ElseIf detect = "purchase" Then
                homeform.Pendingpurchase.PerformClick()
            ElseIf detect = "purchasecomp" Then
                homeform.Completedpurchase.PerformClick()
            ElseIf detect = "bill" Then
                homeform.BillListsToolStripMenuItem.PerformClick()
            ElseIf detect = "payment" Then
                homeform.PaymentListToolStripMenuItem.PerformClick()
            ElseIf detect = "transaction" Then
                homeform.IndividualToolStripMenuItem.PerformClick()
            ElseIf detect = "stock" Then
                homeform.oqButton_Click(sender, e)
            ElseIf detect = "transaction1" Then
                homeform.ocButton_Click(sender, e)
            ElseIf detect = "purchase1" Then
                homeform.opButton_Click(sender, e)
            End If
        Else
            DataGridView1.Rows.Clear()
            If detect = "customer" Then
                quer = "select * from customer where cname like '%" + TextBox1.Text.ToUpper + "%'"
                Dim cnd As New OleDbCommand(quer, con)
                ds = New DataSet
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("cid"), ds.Tables(0).Rows(i).Item("cname"), ds.Tables(0).Rows(i).Item("cphone"))
                Next
            ElseIf detect = "transaction" Then
                quer = "select distinct bill.cid,cname,cphone from customer inner join bill on bill.cid=customer.cid where cname like '%" + TextBox1.Text.ToUpper + "%'"
                Dim cnd As New OleDbCommand(quer, con)
                ds = New DataSet
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("cid"), ds.Tables(0).Rows(i).Item("cname"), ds.Tables(0).Rows(i).Item("cphone"))
                Next
            ElseIf detect = "quality" Then
                quer = "select * from quality where qname like '%" + TextBox1.Text.ToUpper + "%'"
                Dim cnd As New OleDbCommand(quer, con)
                ds = New DataSet
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("qid"), ds.Tables(0).Rows(i).Item("qname"), ds.Tables(0).Rows(i).Item("qrate"))
                Next

            ElseIf detect = "supplier" Then
                quer = "select * from supplier where sname like '%" + TextBox1.Text.ToUpper + "%'"
                Dim cnd As New OleDbCommand(quer, con)
                ds = New DataSet
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("sid"), ds.Tables(0).Rows(i).Item("sname"), ds.Tables(0).Rows(i).Item("sphone"))
                Next

            ElseIf detect = "transport" Then
                quer = "select * from transport where tname like '%" + TextBox1.Text.ToUpper + "%'"

                Dim cnd As New OleDbCommand(quer, con)
                ds = New DataSet
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("tid"), ds.Tables(0).Rows(i).Item("tname"), ds.Tables(0).Rows(i).Item("tphone"))
                Next

            ElseIf detect = "orders" Or detect = "orderscomp" Then
                If detect = "orders" Then
                    quer = "select * from orders where ostatus=0"
                ElseIf detect = "orderscomp" Then
                    quer = "select * from orders where ostatus=1"
                End If
                Dim cnd As New OleDbCommand(quer, con)
                Dim temp, temp1 As String
                ds = New DataSet
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                Dim da1, da2 As OleDbDataAdapter
                Dim dS1, dS2 As DataSet
                quer = "select cname,cid from customer where cname like '%" + TextBox1.Text.ToUpper + "%'"
                dS1 = New DataSet
                cnd = New OleDbCommand(quer, con)
                da1 = New OleDbDataAdapter(quer, con)
                da1.Fill(dS1)
                For Me.j = 0 To dS1.Tables(0).Rows.Count - 1
                    temp1 = dS1.Tables(0).Rows(j).Item("cid")
                    For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                        temp = ds.Tables(0).Rows(i).Item("cid")
                        If Val(temp1) = Val(temp) Then
                            quer = "select cname from customer where cid=" + temp
                            cnd = New OleDbCommand(quer, con)
                            dS2 = New DataSet
                            cnd = New OleDbCommand(quer, con)
                            da2 = New OleDbDataAdapter(quer, con)
                            da2.Fill(dS2)
                            If dS2.Tables(0).Rows.Count <> 0 Then
                                DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("oid"), dS2.Tables(0).Rows(0).Item("cname"), "" + ds.Tables(0).Rows(i).Item("orderdate") + "")
                            End If
                        End If
                    Next
                Next
            ElseIf detect = "purchase" Or detect = "purchasecomp" Then
                If detect = "purchase" Then
                    quer = "select * from purchase where pstatus=0"
                ElseIf detect = "purchasecomp" Then
                    quer = "select * from purchase where pstatus=1"
                End If
                Dim cnd As New OleDbCommand(quer, con)
                Dim temp, temp1 As String
                ds = New DataSet
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                Dim da1, da2 As OleDbDataAdapter
                Dim dS1, dS2 As DataSet
                quer = "select sname,sid from supplier where sname like '%" + TextBox1.Text.ToUpper + "%'"
                dS1 = New DataSet
                cnd = New OleDbCommand(quer, con)
                da1 = New OleDbDataAdapter(quer, con)
                da1.Fill(dS1)
                For Me.j = 0 To dS1.Tables(0).Rows.Count - 1
                    temp1 = dS1.Tables(0).Rows(j).Item("sid")
                    For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                        temp = ds.Tables(0).Rows(i).Item("sid")
                        If Val(temp1) = Val(temp) Then
                            quer = "select sname from supplier where sid=" + temp
                            cnd = New OleDbCommand(quer, con)
                            dS2 = New DataSet
                            cnd = New OleDbCommand(quer, con)
                            da2 = New OleDbDataAdapter(quer, con)
                            da2.Fill(dS2)
                            If dS2.Tables(0).Rows.Count <> 0 Then
                                DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("pid"), dS2.Tables(0).Rows(0).Item("sname"), "" + ds.Tables(0).Rows(i).Item("porder") + "", "" + ds.Tables(0).Rows(i).Item("precieve") + "")
                            End If
                        End If
                    Next
                Next

            ElseIf detect = "bill" Then

                quer = "select * from bill"
                Dim cnd As New OleDbCommand(quer, con)
                Dim temp, temp1 As String
                ds = New DataSet
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                Dim da1, da2 As OleDbDataAdapter
                Dim dS1, dS2 As DataSet
                quer = "select cname,cid from customer where cname like '%" + TextBox1.Text.ToUpper + "%'"
                dS1 = New DataSet
                cnd = New OleDbCommand(quer, con)
                da1 = New OleDbDataAdapter(quer, con)
                da1.Fill(dS1)
                For Me.j = 0 To dS1.Tables(0).Rows.Count - 1
                    temp1 = dS1.Tables(0).Rows(j).Item("cid")
                    For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                        temp = ds.Tables(0).Rows(i).Item("cid")
                        If Val(temp1) = Val(temp) Then
                            quer = "select cname from customer where cid=" + temp
                            cnd = New OleDbCommand(quer, con)
                            dS2 = New DataSet
                            cnd = New OleDbCommand(quer, con)
                            da2 = New OleDbDataAdapter(quer, con)
                            da2.Fill(dS2)
                            If dS2.Tables(0).Rows.Count <> 0 Then
                                DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("bid"), dS2.Tables(0).Rows(0).Item("cname"), "" + ds.Tables(0).Rows(i).Item("bdate") + "", ds.Tables(0).Rows(i).Item("tamount"))
                            End If
                        End If
                    Next
                Next

            ElseIf detect = "payment" Then

                quer = "select * from transaction"
                Dim cnd As New OleDbCommand(quer, con)
                Dim temp, temp1 As String
                ds = New DataSet
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                Dim da1, da2 As OleDbDataAdapter
                Dim dS1, dS2 As DataSet
                quer = "select cname,cid from customer where cname like '%" + TextBox1.Text.ToUpper + "%'"
                dS1 = New DataSet
                cnd = New OleDbCommand(quer, con)
                da1 = New OleDbDataAdapter(quer, con)
                da1.Fill(dS1)
                For Me.j = 0 To dS1.Tables(0).Rows.Count - 1
                    temp1 = dS1.Tables(0).Rows(j).Item("cid")
                    For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                        temp = ds.Tables(0).Rows(i).Item("cid")
                        If Val(temp1) = Val(temp) Then
                            quer = "select cname from customer where cid=" + temp
                            cnd = New OleDbCommand(quer, con)
                            dS2 = New DataSet
                            cnd = New OleDbCommand(quer, con)
                            da2 = New OleDbDataAdapter(quer, con)
                            da2.Fill(dS2)
                            If dS2.Tables(0).Rows.Count <> 0 Then
                                DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("trid"), dS2.Tables(0).Rows(0).Item("cname"), "" + ds.Tables(0).Rows(i).Item("transdate") + "", ds.Tables(0).Rows(i).Item("paid"))
                            End If
                        End If
                    Next
                Next
            ElseIf detect = "stock" Then
                ds = New DataSet
                quer = "select qid,qname,quantity,limit from quality where quantity<limit and qname like '%" + TextBox1.Text.ToUpper + "%'"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("qid"), ds.Tables(0).Rows(i).Item("qname"), ds.Tables(0).Rows(i).Item("quantity"), ds.Tables(0).Rows(i).Item("limit"))
                Next

            ElseIf detect = "transaction1" Then
                Dim month, year, noti As String
                ds = New DataSet
                dd = Date.Now
                month = dd.Month - 3
                year = dd.Year
                If month < 0 Then
                    year = Val(year) - 1
                    month = month + 12
                End If
                noti = dd.Day
                year = year + "-" + month + "-" + noti
                quer = "select distinct customer.cid,cname,cphone from transaction inner join customer on transaction.cid=customer.cid where transaction.transdate<='" + year + "' and cname like '%" + TextBox1.Text.ToUpper + "%'"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("cid"), ds.Tables(0).Rows(i).Item("cname"), ds.Tables(0).Rows(i).Item("cphone"))
                Next
            ElseIf detect = "purchase1" Then
                Dim month, year, noti As String
                ds = New DataSet
                dd = Date.Now
                month = dd.Month
                year = dd.Year
                noti = dd.Day
                year = year + "-" + month + "-" + noti
                quer = "select pid,sname,porder,precieve from purchase inner join supplier on purchase.sid=supplier.sid where pstatus=0 and purchase.precieve<='" + year + "'and sname like '%" + TextBox1.Text.ToUpper + "%'"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("pid"), ds.Tables(0).Rows(i).Item("sname"), "" + ds.Tables(0).Rows(i).Item("porder") + "", "" + ds.Tables(0).Rows(i).Item("precieve") + "")
                Next
            End If
        End If
    End Sub
End Class