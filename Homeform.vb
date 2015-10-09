Imports System.Data.OleDb
Public Class homeform

    Dim a As PopupEventArgs
    Dim con As New OleDbConnection
    Dim query, noti, month, year As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim col As New DataGridViewTextBoxColumn
    Dim i, j, flag, temp, count, trflag, timerflag As Integer
    Dim dd, dd2 As Date
    Public homeflag As Integer


    Private Sub ViewListsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnewpurchase.Click
        PurchaseRequest.Show()
        Me.Enabled = False
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewquality.Click
        QualityEntry.Show()
        Me.Enabled = False
    End Sub

    Private Sub NewOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderToolStripMenuItem.Click
        OrderRequest.Show()
        Me.Enabled = False
    End Sub

    Private Sub NewBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnewbill.Click
        Bill.Show()
        Me.Enabled = False
    End Sub

    Private Sub AddNewToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewpayment.Click
        Payment.Show()
        Me.Enabled = False
    End Sub

    Private Sub AddNewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewtransport.Click
        TransportEntry.Show()
        Me.Enabled = False
    End Sub

    Private Sub AddNewToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewsupplier.Click
        SupplierEntry.Show()
        Me.Enabled = False
    End Sub

    Private Sub AddNewToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewcustomer.Click
        CustomerEntry.Show()
        '  Me.Enabled = False
    End Sub

    Public Sub HomeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Timer9.Enabled = True
        homeflag = 0
        flag = 0

        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"

        con.Open()
        ds.Clear()
        query = "select * from quality where quantity<limit"
        Dim cnd As New OleDbCommand(query, con)
        da = New OleDbDataAdapter(query, con)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count Then
            Label2.Visible = True
            oqButton.Visible = True
            oqButton.ForeColor = Color.Crimson
        End If
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
        query = "select cname from transaction inner join customer on transaction.cid=customer.cid where transaction.transdate<='" + year + "'"
        cnd = New OleDbCommand(query, con)
        da = New OleDbDataAdapter(query, con)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count Then
            Label2.Visible = True
            ocButton.Visible = True
            ocButton.ForeColor = Color.Crimson
        End If
        ds = New DataSet
        dd = Date.Now
        month = dd.Month
        year = dd.Year
        noti = dd.Day
        year = year + "-" + month + "-" + noti
        query = "select sname from purchase inner join supplier on purchase.sid=supplier.sid where pstatus=0 and purchase.precieve<='" + year + "'"
        cnd = New OleDbCommand(query, con)
        da = New OleDbDataAdapter(query, con)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count Then
            Label2.Visible = True
            opButton.Visible = True
            opButton.ForeColor = Color.Crimson
        End If
    End Sub

    Private Sub ViewListsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qualitylist.Click
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        Report.detect = "quality"
        col.HeaderText = "SrNo"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn

        col1.HeaderText = "Quality"
        col1.Name = "column2"

        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Rate"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 50
        Report.DataGridView1.Width = 343

        Try
            ds.Clear()
            query = "select * from quality"
            Dim cnd As New OleDbCommand(query, con)
            da = New OleDbDataAdapter(query, con)
            da.Fill(ds)
            For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("qid"), ds.Tables(0).Rows(i).Item("qname"), ds.Tables(0).Rows(i).Item("qrate"))
            Next

        Catch ex As OleDbException
            MsgBox(ex.Message)
        End Try
        Report.Label2.Text = "Quality List"
        Report.Show()
        Me.Enabled = False
    End Sub

    Private Sub CustomerLIstToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerLIstToolStripMenuItem.Click
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        If trflag = 1 Then
            Report.detect = "transaction"
            trflag = 0
        Else
            Report.detect = "customer"
        End If
        col.HeaderText = "CId"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn

        col1.HeaderText = "Cname"
        col1.Name = "column2"

        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Cphone"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 100
        Report.DataGridView1.Width = 393

        Try
            query = "select * from customer"
            ds.Clear()
            Dim cnd As New OleDbCommand(query, con)

            da = New OleDbDataAdapter(query, con)
            da.Fill(ds)
            For Me.i = 0 To Report.DataGridView1.Rows.Count - 1
                Report.DataGridView1.Rows.RemoveAt(i)
            Next

            For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("cid"), ds.Tables(0).Rows(i).Item("cname"), ds.Tables(0).Rows(i).Item("cphone"))
            Next
            da.Dispose()
        Catch ex As OleDbException
            MsgBox(ex.Message)
        End Try
        Report.Label2.Text = "Customer List"
        Report.Show()
        Me.Enabled = False

    End Sub

    Private Sub SupplierListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierListToolStripMenuItem.Click
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        Report.detect = "supplier"
        col.HeaderText = "SrNo"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn

        col1.HeaderText = "Supplier"
        col1.Name = "column2"

        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Phone No."
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 50
        Report.DataGridView1.Width = 343

        Try
            ds.Clear()
            query = "select * from supplier"
            Dim cnd As New OleDbCommand(query, con)
            da = New OleDbDataAdapter(query, con)
            da.Fill(ds)
            For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("sid"), ds.Tables(0).Rows(i).Item("sname"), ds.Tables(0).Rows(i).Item("sphone"))
            Next

        Catch ex As OleDbException
            MsgBox(ex.Message)
        End Try
        Report.Label2.Text = "Supplier List"
        Report.Show()
        Me.Enabled = False
    End Sub

    Private Sub AgencyListsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgencyListsToolStripMenuItem.Click
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        Report.detect = "transport"
        col.HeaderText = "SrNo"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn

        col1.HeaderText = "Transport Agency"
        col1.Name = "column2"

        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Contact"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 50
        Report.DataGridView1.Width = 343

        Try
            ds.Clear()
            query = "select * from transport"
            Dim cnd As New OleDbCommand(query, con)
            da = New OleDbDataAdapter(query, con)
            da.Fill(ds)
            For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("tid"), ds.Tables(0).Rows(i).Item("tname"), ds.Tables(0).Rows(i).Item("tphone"))
            Next

        Catch ex As OleDbException
            MsgBox(ex.Message)
        End Try
        Report.Label2.Text = "Transport Agency List"
        Report.Show()
        Me.Enabled = False
    End Sub

    Private Sub Pendingorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pendingorder.Click
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        If flag = 0 Then
            Report.detect = "orders"
            query = "select * from orders where ostatus=0"
            Report.Label2.Text = "Pending Order List"
        ElseIf flag = 1 Then
            Report.detect = "orderscomp"
            query = "select * from orders where ostatus=1"
            flag = 0
            Report.Label2.Text = "Completed Order List"
        End If
        Dim cnd As New OleDbCommand(query, con)
        da = New OleDbDataAdapter(query, con)
        ds = New DataSet
        da.Fill(ds)
        col.HeaderText = "Id"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn
        col1.HeaderText = "Customer Name"
        col1.Name = "column2"
        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Date"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 50
        Report.DataGridView1.Width = 343
        Dim da1 As OleDbDataAdapter
        Dim dS1 As DataSet
        Dim temp As String
        For Me.i = 0 To ds.Tables(0).Rows.Count - 1
            temp = ds.Tables(0).Rows(i).Item("cid")
            query = "select cname from customer where cid=" + temp
            dS1 = New DataSet
            cnd = New OleDbCommand(query, con)
            da1 = New OleDbDataAdapter(query, con)
            da1.Fill(dS1)
            dd = ds.Tables(0).Rows(i).Item("orderdate")
            Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("oid"), dS1.Tables(0).Rows(0).Item("cname"), "" + dd + "")
        Next

        Report.Show()
        Me.Enabled = False
    End Sub

    Private Sub Completedorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Completedorder.Click
        flag = 1
        Pendingorder_Click(sender, e)
    End Sub

    Private Sub Pendingpurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pendingpurchase.Click
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        If flag = 0 Then
            Report.detect = "purchase"
            query = "select * from purchase where pstatus=0"
            Report.Label2.Text = "Pending Purchase List"
        ElseIf flag = 1 Then
            Report.detect = "purchasecomp"
            query = "select * from purchase where pstatus=1"
            Report.Label2.Text = "Recieved Purchase List"
            flag = 0
        End If
        Dim cnd As New OleDbCommand(query, con)
        da = New OleDbDataAdapter(query, con)
        ds = New DataSet
        da.Fill(ds)
        col.HeaderText = "Id"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn
        col1.HeaderText = "Supplier Name"
        col1.Name = "column2"
        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Order Date"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col3 As New DataGridViewTextBoxColumn
        col3.HeaderText = "Delivery"
        col3.Name = "column4"
        Report.DataGridView1.Columns.Add(col3)
        Report.DataGridView1.Columns(0).Width = 50
        Report.DataGridView1.Width = 443
        Dim da1 As OleDbDataAdapter
        Dim dS1 As DataSet
        Dim temp As String
        For Me.i = 0 To ds.Tables(0).Rows.Count - 1
            temp = ds.Tables(0).Rows(i).Item("sid")
            query = "select sname from supplier where sid=" + temp
            dS1 = New DataSet
            cnd = New OleDbCommand(query, con)
            da1 = New OleDbDataAdapter(query, con)
            da1.Fill(dS1)
            Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("pid"), dS1.Tables(0).Rows(0).Item("sname"), "" + ds.Tables(0).Rows(i).Item("porder") + "", "" + ds.Tables(0).Rows(i).Item("precieve") + "")
        Next

        Report.Show()
        Me.Enabled = False
    End Sub

    Private Sub Completedpurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Completedpurchase.Click
        flag = 1
        Pendingpurchase_Click(sender, e)
    End Sub

    Private Sub BillListsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillListsToolStripMenuItem.Click
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        Report.detect = "bill"
        query = "select * from bill"
        Dim cnd As New OleDbCommand(query, con)
        da = New OleDbDataAdapter(query, con)
        ds = New DataSet
        da.Fill(ds)
        col.HeaderText = "BillNO."
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn
        col1.HeaderText = "Customer Name"
        col1.Name = "column2"
        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Date"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col3 As New DataGridViewTextBoxColumn
        col3.HeaderText = "Amount"
        col3.Name = "column4"
        Report.DataGridView1.Columns.Add(col3)
        Report.DataGridView1.Columns(0).Width = 50
        Report.DataGridView1.Width = 443
        Dim da1 As OleDbDataAdapter
        Dim dS1 As DataSet
        Dim temp As String

        For Me.j = 0 To ds.Tables(0).Rows.Count - 1
            temp = ds.Tables(0).Rows(j).Item("cid")
            query = "select cname from customer where cid=" + temp
            dS1 = New DataSet
            cnd = New OleDbCommand(query, con)
            da1 = New OleDbDataAdapter(query, con)
            da1.Fill(dS1)
            Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(j).Item("bid"), dS1.Tables(0).Rows(0).Item("cname"), "" + ds.Tables(0).Rows(j).Item("bdate") + "", ds.Tables(0).Rows(j).Item("tamount"))

        Next
        Report.Label2.Text = "Bill List"
        Report.Show()
        Me.Enabled = False
    End Sub

    Private Sub PaymentListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentListToolStripMenuItem.Click
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        Report.detect = "payment"
        query = "select * from transaction "
        Dim cnd As New OleDbCommand(query, con)
        da = New OleDbDataAdapter(query, con)
        ds = New DataSet
        da.Fill(ds)
        col.HeaderText = "Id"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn
        col1.HeaderText = "Customer Name"
        col1.Name = "column2"
        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Date"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col3 As New DataGridViewTextBoxColumn
        col3.HeaderText = "Amount"
        col3.Name = "column4"
        Report.DataGridView1.Columns.Add(col3)
        Report.DataGridView1.Columns(0).Width = 50
        Report.DataGridView1.Width = 443
        Dim da1 As OleDbDataAdapter
        Dim dS1 As DataSet
        Dim temp As String
        For Me.i = 0 To ds.Tables(0).Rows.Count - 1
            temp = ds.Tables(0).Rows(i).Item("cid")
            query = "select cname from customer where cid=" + temp
            dS1 = New DataSet
            cnd = New OleDbCommand(query, con)
            da1 = New OleDbDataAdapter(query, con)
            da1.Fill(dS1)
            Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("trid"), dS1.Tables(0).Rows(0).Item("cname"), "" + ds.Tables(0).Rows(i).Item("transdate") + "", ds.Tables(0).Rows(i).Item("paid"))
        Next
        Report.Label2.Text = "Payment List"
        Report.Show()
        Me.Enabled = False
    End Sub

    Private Sub ViewStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStockToolStripMenuItem.Click
        Stock.Show()
        Me.Enabled = False
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        LoginForm.Close()
    End Sub

   

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        homeflag = 1
        LoginForm.UsernameTextBox.TabIndex = 0
        LoginForm.UsernameTextBox.Text = ""
        LoginForm.confirmu.Visible = True
        LoginForm.newuser.Visible = True
        LoginForm.OK.Visible = False
        LoginForm.confirmb.Visible = False
        LoginForm.confirm.Visible = False
        LoginForm.Label1.Visible = False
        LoginForm.PasswordTextBox.Visible = False
        LoginForm.PasswordLabel.Text = "&New Username"
        LoginForm.UsernameLabel.Text = "&Old Username"
        LoginForm.Show()
        Me.Enabled = False

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        homeflag = 1
        LoginForm.UsernameTextBox.TabIndex = 0
        LoginForm.UsernameTextBox.Text = ""
        LoginForm.UsernameTextBox.PasswordChar = "*"
        LoginForm.PasswordTextBox.Text = ""
        LoginForm.confirm.Visible = True
        LoginForm.confirmb.Visible = True
        LoginForm.confirm.Visible = True
        LoginForm.confirmu.Visible = False
        LoginForm.newuser.Visible = False
        LoginForm.OK.Visible = False
        LoginForm.Label1.Visible = True
        LoginForm.PasswordTextBox.Visible = True
        LoginForm.PasswordLabel.Text = "&New Password"
        LoginForm.UsernameLabel.Text = "&Old Password"
        LoginForm.Show()
        Me.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        drag.Width = drag.Width + 10
        drag.Left = drag.Left - 10
        If drag.Width = 728 Then
            Timer1.Enabled = False
            Button2.Visible = True
        End If

    End Sub


    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.Visible = False
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.Visible = False
        Timer2.Enabled = True

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        drag.Width = drag.Width - 10
        drag.Left = drag.Left + 10
        If drag.Width = 488 Then
            Timer2.Enabled = False
            Button1.Visible = True
        End If
    End Sub

    Public Sub oqButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oqButton.Click
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        oqButton.ForeColor = Color.Black
        Report.detect = "stock"
        col.HeaderText = "Qid"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn

        col1.HeaderText = "Quality"
        col1.Name = "column2"

        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Quantity"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col3 As New DataGridViewTextBoxColumn
        col3.HeaderText = "Limit"
        col3.Name = "column4"
        Report.DataGridView1.Columns.Add(col3)
        Report.DataGridView1.Columns(0).Width = 50
        Report.DataGridView1.Width = 443
        ds = New DataSet
        query = "select qid,qname,quantity,limit from quality where quantity<limit"
        Dim cnd As New OleDbCommand(query, con)
        da = New OleDbDataAdapter(query, con)
        da.Fill(ds)
        For Me.i = 0 To ds.Tables(0).Rows.Count - 1
            Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("qid"), ds.Tables(0).Rows(i).Item("qname"), ds.Tables(0).Rows(i).Item("quantity"), ds.Tables(0).Rows(i).Item("limit"))
        Next
        Report.Label2.Text = "Qualities Below Limit"
        Report.Show()
        Me.Enabled = False

    End Sub

   Public Sub ocButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ocButton.Click
        ocButton.ForeColor = Color.Black
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        Report.detect = "transaction1"
        col.HeaderText = "CId"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn
        col1.HeaderText = "CName"
        col1.Name = "column2"
        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Contact"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 100
        Report.DataGridView1.Width = 393
        ds = New DataSet
        dd = Date.Now
        month = dd.Month - 3
        year = dd.Year
        If month < 0 Then
            year = Val(year) - 1
            month = month + 12
        End If
        Dim quer, day As String
        day = dd.Day
        quer = "select customer.cid,cname,cphone,transdate from transaction inner join customer on transaction.cid=customer.cid order by customer.cid,transdate desc"
        Dim cnd As New OleDbCommand(quer, con)
        da = New OleDbDataAdapter(quer, con)
        da.Fill(ds)
        For Me.i = 0 To ds.Tables(0).Rows.Count - 1
            If temp <> ds.Tables(0).Rows(i).Item("cid") Then
                dd2 = ds.Tables(0).Rows(i).Item("transdate")
                If dd2.Year <= year Then
                    If dd2.Year = year Then
                        If dd2.Month <= month Then
                            If dd2.Month = month Then
                                If dd2.Day <= day Then
                                    Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("cid"), ds.Tables(0).Rows(i).Item("cname"), ds.Tables(0).Rows(i).Item("cphone"))
                                End If
                            Else
                                Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("cid"), ds.Tables(0).Rows(i).Item("cname"), ds.Tables(0).Rows(i).Item("cphone"))
                            End If
                        End If
                    Else
                        Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("cid"), ds.Tables(0).Rows(i).Item("cname"), ds.Tables(0).Rows(i).Item("cphone"))
                    End If
                End If
            End If
            temp = ds.Tables(0).Rows(i).Item("cid")

        Next
        Report.Label2.Text = "Customer List"
        Report.Show()
        Me.Enabled = False
    End Sub

    Public Sub opButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opButton.Click
        opButton.ForeColor = Color.Black
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        Report.detect = "purchase1"
        col.HeaderText = "PId"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn
        col1.HeaderText = "Supplier Name"
        col1.Name = "column2"
        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Order Date"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col3 As New DataGridViewTextBoxColumn
        col3.HeaderText = "Delivery"
        col3.Name = "column4"
        Report.DataGridView1.Columns.Add(col3)
        Report.DataGridView1.Columns(0).Width = 50
        Report.DataGridView1.Width = 443
        ds = New DataSet
        dd = Date.Now
        month = dd.Month
        year = dd.Year
        noti = dd.Day
        year = year + "-" + month + "-" + noti
        query = "select pid,sname,porder,precieve from purchase inner join supplier on purchase.sid=supplier.sid where pstatus=0 and purchase.precieve<='" + year + "'"
        Dim cnd As New OleDbCommand(query, con)
        da = New OleDbDataAdapter(query, con)
        da.Fill(ds)
        For Me.i = 0 To ds.Tables(0).Rows.Count - 1
            Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("pid"), ds.Tables(0).Rows(i).Item("sname"), "" + ds.Tables(0).Rows(i).Item("porder") + "", "" + ds.Tables(0).Rows(i).Item("precieve") + "")
        Next
        Report.Label2.Text = "Purchase List"
        Report.Show()
        Me.Enabled = False
    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        timerflag = ((timerflag + 1) Mod 3)
        PictureBox2.Image = ImageList1.Images(timerflag)
    End Sub


    Private Sub OverallTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OverallTransactionsToolStripMenuItem.Click
        Overall.Show()
        Me.Enabled = False
    End Sub

    Private Sub IndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualToolStripMenuItem.Click
        trflag = 1
        'CustomerLIstToolStripMenuItem.PerformClick()
        Report.DataGridView1.Columns.Clear()
        Report.DataGridView1.Rows.Clear()
        If trflag = 1 Then
            Report.detect = "transaction"
            trflag = 0
        Else
            Report.detect = "customer"
        End If
        col.HeaderText = "CId"
        col.Name = "column1"
        Report.DataGridView1.Columns.Add(col)
        Report.DataGridView1.Columns(0).Width = 50
        Dim col1 As New DataGridViewTextBoxColumn

        col1.HeaderText = "Cname"
        col1.Name = "column2"

        Report.DataGridView1.Columns.Add(col1)
        Report.DataGridView1.Columns(1).Width = 150
        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Cphone"
        col2.Name = "column3"
        Report.DataGridView1.Columns.Add(col2)
        Report.DataGridView1.Columns(0).Width = 100
        Report.DataGridView1.Width = 393

        Try
            query = "select distinct bill.cid,cname,cphone from customer inner join bill on bill.cid=customer.cid"
            ds = New DataSet
            Dim cnd As New OleDbCommand(query, con)

            da = New OleDbDataAdapter(query, con)
            da.Fill(ds)
            For Me.i = 0 To Report.DataGridView1.Rows.Count - 1
                Report.DataGridView1.Rows.RemoveAt(i)
            Next

            For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                Report.DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("cid"), ds.Tables(0).Rows(i).Item("cname"), ds.Tables(0).Rows(i).Item("cphone"))
            Next
            da.Dispose()
        Catch ex As OleDbException
            MsgBox(ex.Message)
        End Try
        Report.Label2.Text = "Customer List"
        Report.Show()
        Me.Enabled = False
    End Sub

    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click
        Dim temp, temp1 As String
        Dim r As Integer
        query = "select b.cid,t.tpaid,b.tamt from (select bill.cid,sum(tamount) as tamt from bill group by cid) b left join (select transaction.cid,sum(paid) as tpaid from transaction group by cid) t on b.cid=t.cid order by b.cid"
        Dim col As New DataGridViewTextBoxColumn
        Dim cnd As New OleDbCommand(query, con)
        da = New OleDbDataAdapter(query, con)
        ds = New DataSet
        da.Fill(ds)
        Dim da1 As OleDbDataAdapter
        Dim dS1 As DataSet
        For Me.i = 0 To ds.Tables(0).Rows.Count - 1
            temp = ds.Tables(0).Rows(i).Item("cid")
            temp1 = Str(ds.Tables(0).Rows(i).Item("tpaid"))
            If Val(temp1) = 0 Then
                r = Val(ds.Tables(0).Rows(i).Item("tamt"))
            Else
                r = Val(ds.Tables(0).Rows(i).Item("tamt")) - Val(ds.Tables(0).Rows(i).Item("tpaid"))
            End If
            If r <> 0 Then
                query = "select cname,cphone from customer where cid=" + temp
                dS1 = New DataSet
                cnd = New OleDbCommand(query, con)
                da1 = New OleDbDataAdapter(query, con)
                da1.Fill(dS1)
                Remain.DataGridView1.Rows.Add(dS1.Tables(0).Rows(0).Item("cname"), dS1.Tables(0).Rows(0).Item("cphone"), r)
            End If
        Next
        Remain.Show()
        Me.Enabled = False
    End Sub

End Class