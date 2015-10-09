Imports System.Data.OleDb
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Transactions
    Public detect As String
    Public reportflag As Integer
    Public id As String
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim count, temp As Integer
    Public index As Integer
    Dim i, j As Integer
    Dim d1, d2 As Date
    Dim a As DataGridViewCellMouseEventArgs

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        con.Close()
        If Remain.remainflag = 1 Then
            Me.Close()
            Remain.Show()
        Else
            If Report.detect = "transaction1" Then
                Me.Close()
                homeform.ocButton_Click(sender, e)
            Else
                Me.Close()
                homeform.TransactionsToolStripMenuItem.PerformClick()
            End If
        End If
    End Sub


    Private Sub Transactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"
        con.Open()
        quer = "select * from transaction where cid=" + Report.id + " order by transdate"
        Dim col As New DataGridViewTextBoxColumn
        Dim cnd As New OleDbCommand(quer, con)
        da = New OleDbDataAdapter(quer, con)
        ds = New DataSet
        da.Fill(ds)

        Dim da1, da2 As OleDbDataAdapter
        Dim dS1, ds2 As DataSet

        quer = "select cname from customer where cid=" + Report.id
        dS1 = New DataSet
        cnd = New OleDbCommand(quer, con)
        da1 = New OleDbDataAdapter(quer, con)
        da1.Fill(dS1)
        customer.Text = dS1.Tables(0).Rows(0).Item("cname")
        dS1.Clear()

        quer = "select * from bill where cid=" + Report.id + " order by bdate"
        dS1 = New DataSet
        cnd = New OleDbCommand(quer, con)
        da1 = New OleDbDataAdapter(quer, con)
        da1.Fill(dS1)
        Dim billc, tranc, flag2, flag1 As Integer
        billc = 0
        tranc = 0

        For Me.i = 0 To ds.Tables(0).Rows.Count + dS1.Tables(0).Rows.Count - 1
            flag1 = 0
            flag2 = 0
            If tranc < ds.Tables(0).Rows.Count Then
                d1 = ds.Tables(0).Rows(tranc).Item("transdate")
                flag1 = 1
            End If
            If billc < dS1.Tables(0).Rows.Count Then
                d2 = dS1.Tables(0).Rows(billc).Item("bdate")
                flag2 = 1
            End If
            If d1 < d2 Or flag2 = 0 Then
                If flag1 = 1 Then
                    DataGridView1.Rows.Add("", "", "", ds.Tables(0).Rows(tranc).Item("trid"), "" + ds.Tables(0).Rows(tranc).Item("transdate") + "", ds.Tables(0).Rows(tranc).Item("paid"))
                    tranc = tranc + 1
                End If
            End If
            If d1 >= d2 Or flag1 = 0 Then
                If flag2 = 1 Then
                    DataGridView1.Rows.Add(dS1.Tables(0).Rows(billc).Item("bid"), "" + dS1.Tables(0).Rows(billc).Item("bdate") + "", dS1.Tables(0).Rows(billc).Item("tamount"))
                    billc = billc + 1
                End If
            End If
        Next
        flag1 = 0
        flag2 = 0
        If dS1.Tables(0).Rows.Count <> 0 Then
            quer = "select sum(tamount) from bill where cid=" + Report.id
            ds2 = New DataSet
            cnd = New OleDbCommand(quer, con)
            da2 = New OleDbDataAdapter(quer, con)
            da2.Fill(ds2)
            billamt.Text = ds2.Tables(0).Rows(0).Item("sum(tamount)")
            flag2 = 1
        End If
        If ds.Tables(0).Rows.Count <> 0 Then
            quer = "select sum(paid) from transaction where cid=" + Report.id
            ds2 = New DataSet
            cnd = New OleDbCommand(quer, con)
            da2 = New OleDbDataAdapter(quer, con)
            da2.Fill(ds2)
            TextBox1.Text = ds2.Tables(0).Rows(0).Item("sum(paid)")
            ds2.Clear()
            flag1 = 1
        End If
        If flag1 = 1 Or flag2 = 1 Then
            TextBox2.Text = Val(billamt.Text) - Val(TextBox1.Text)
        End If

    End Sub


    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 0, 0, 45, 35)
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("D:\project\print\transaction\" + customer.Text + ".pdf", FileMode.Create))
        doc.Open()
        Dim para As New Paragraph
        para.Add(vbCrLf)
        para.Add("                                                                      " + customer.Text)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        doc.Add(para)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        Dim table As New PdfPTable(6)
        Dim cell As New PdfPCell()
        Dim arr() As Integer = {5, 5, 5, 5, 5, 5}
        table.SetWidths(arr)
        table.AddCell("Bill No")
        table.AddCell("Date")
        table.AddCell("Amount")
        table.AddCell("Trans.ID")
        table.AddCell("Date")
        table.AddCell("Amount")
        Dim j As Integer
        For Me.i = 0 To DataGridView1.RowCount - 1
            For j = 0 To 5
                If DataGridView1.Rows(i).Cells(j).Value <> Nothing Then
                    table.AddCell(DataGridView1.Rows(i).Cells(j).Value.ToString)
                Else
                    table.AddCell("             ")
                End If
            Next
        Next
        doc.Add(table)
        para.Clear()
        para.Add(vbCrLf)
        para.Add("                                      " + tbillamt.Text + " : " + billamt.Text + "                               " + Label1.Text + " : " + TextBox1.Text)

        para.Add(vbCrLf)
        para.Add("                                                                                                            " + Label2.Text + " : " + TextBox2.Text)
        doc.Add(para)
        doc.Close()
        Output.AxAcroPDF1.src = "D:\project\print\transaction\" + customer.Text + ".pdf"
        Output.Text = "Customer Transaction"
        Output.Show()
    End Sub
End Class