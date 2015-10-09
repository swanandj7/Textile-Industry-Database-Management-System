Imports System.Data.OleDb
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Remain
    Dim i, id, index As Integer
    Public remainflag As Integer
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Close()
        Me.Close()
        homeform.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 0, 0, 45, 35)
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("D:\project\print\customerlist.pdf", FileMode.Create))
        doc.Open()
        Dim para As New Paragraph
        Dim gif As Image
        gif = Image.GetInstance("D:\project\jaylaxmi1.png")
        doc.Add(gif)
        para.Add(vbCrLf)
        para.Add("                                                                                  CUSTOMER LIST        ")
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        doc.Add(para)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        Dim table As New PdfPTable(3)
        Dim cell As New PdfPCell()
        Dim arr() As Integer = {20, 10, 10}
        table.SetWidths(arr)
        table.AddCell("Customer")
        table.AddCell("Contact")
        table.AddCell("Remaining Amount")
        ' Dim j As Integer
        For Me.i = 0 To DataGridView1.RowCount - 1
            table.AddCell(DataGridView1.Rows(i).Cells(0).Value.ToString)
            table.AddCell(DataGridView1.Rows(i).Cells(1).Value.ToString)
            table.AddCell(DataGridView1.Rows(i).Cells(2).Value.ToString)
        Next
        doc.Add(table)
        para.Clear()
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        doc.Close()
        Output.AxAcroPDF1.src = "D:\project\print\customerlist.pdf"
        Output.Text = "Remaining"
        Output.Show()
    End Sub

    
   
    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        index = DataGridView1.CurrentCell.RowIndex
        quer = "select cid from customer where cname='" + DataGridView1.Rows(index).Cells(0).Value + "'"
        Dim cnd As New OleDbCommand(quer, con)
        id = cnd.ExecuteScalar()
        Report.id = id
        Transactions.Show()
    End Sub

    Private Sub Remain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"
        con.Open()
        remainflag = 1
    End Sub
End Class