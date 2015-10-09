
Imports System.Data.OleDb
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Overall
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
        Me.Close()
        homeform.Enabled = True
    End Sub

    Private Sub Overall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"
        con.Open()
        Dim quer2 As String
        quer2 = "select cname,transdate,paid from transaction inner join customer on transaction.cid=customer.cid order by transdate"
        Dim col As New DataGridViewTextBoxColumn
        Dim cnd As New OleDbCommand(quer2, con)
        da = New OleDbDataAdapter(quer2, con)
        ds = New DataSet
        da.Fill(ds)

        Dim da1, da2 As OleDbDataAdapter
        Dim dS1, ds2 As DataSet

        quer = "select sname,precieve,expense from purchase inner join supplier on purchase.sid=supplier.sid where pstatus=1 order by precieve"
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
            If tranc < dS1.Tables(0).Rows.Count Then
                d1 = dS1.Tables(0).Rows(tranc).Item("precieve")
                flag1 = 1
            End If
            If billc < ds.Tables(0).Rows.Count Then
                d2 = ds.Tables(0).Rows(billc).Item("transdate")
                flag2 = 1
            End If
            If d1 < d2 Or flag2 = 0 Then
                If flag1 = 1 Then
                    DataGridView1.Rows.Add("", "", "", dS1.Tables(0).Rows(tranc).Item("sname"), "" + dS1.Tables(0).Rows(tranc).Item("precieve") + "", dS1.Tables(0).Rows(tranc).Item("expense"))
                    tranc = tranc + 1
                End If
            End If
            If d1 >= d2 Or flag1 = 0 Then
                If flag2 = 1 Then
                    DataGridView1.Rows.Add(ds.Tables(0).Rows(billc).Item("cname"), "" + ds.Tables(0).Rows(billc).Item("transdate") + "", ds.Tables(0).Rows(billc).Item("paid"))
                    billc = billc + 1
                End If
            End If
        Next
        flag1 = 0
        flag2 = 0
        If dS1.Tables(0).Rows.Count <> 0 Then
            quer = "select sum(paid) from transaction "
            ds2 = New DataSet
            cnd = New OleDbCommand(quer, con)
            da2 = New OleDbDataAdapter(quer, con)
            da2.Fill(ds2)
            tincome.Text = ds2.Tables(0).Rows(0).Item("sum(paid)")
            flag2 = 1
        End If
        If ds.Tables(0).Rows.Count <> 0 Then
            quer = "select sum(expense) from purchase where pstatus=1"
            ds2 = New DataSet
            cnd = New OleDbCommand(quer, con)
            da2 = New OleDbDataAdapter(quer, con)
            da2.Fill(ds2)
            texp.Text = ds2.Tables(0).Rows(0).Item("sum(expense)")
            ds2.Clear()
            flag1 = 1
        End If
        If flag1 = 1 Or flag2 = 1 Then
            profit.Text = Val(tincome.Text) - Val(texp.Text)
        End If
    End Sub

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 0, 0, 45, 35)
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("D:\project\print\overall.pdf", FileMode.Create))
        doc.Open()
        Dim para As New Paragraph
        Dim gif As Image
        gif = Image.GetInstance("D:\project\jaylaxmi1.png")
        doc.Add(gif)
        para.Add(vbCrLf)
        para.Add("                                                                          Overall Transactions        ")
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        doc.Add(para)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        Dim table As New PdfPTable(6)
        Dim cell As New PdfPCell()
        Dim arr() As Integer = {13, 8, 5, 13, 8, 5}
        table.SetWidths(arr)
        table.AddCell("Customer")
        table.AddCell("Date")
        table.AddCell("Amount")
        table.AddCell("Supplier")
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
        para.Add("                                                        " + tincomel.Text + " : " + tincome.Text + "                                 " + texp1.Text + " : " + texp.Text)

        para.Add(vbCrLf)
        para.Add("                                                                                                                                          " + Label2.Text + " : " + profit.Text)
        doc.Add(para)
        doc.Close()
        Output.AxAcroPDF1.src = "D:\project\print\overall.pdf"
        Output.Text = "Customer Transaction"
        Output.Show()
    End Sub

End Class