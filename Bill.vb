Imports System.Data.OleDb
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO



Public Class Bill
    Dim dd As Date
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim qds As New DataSet
    Dim i, j, cflag, tflag As Integer
    Dim cnd As New OleDbCommand(quer, con)
    Dim cid As String
    Dim qid As String
    Dim tid As String
    Dim amt As Integer
    Dim sum As Integer
    Dim quer2 As String
    Dim ds1 As New DataSet
    Dim cnd1 As New OleDbCommand(quer2, con)
    Dim da1 As New OleDbDataAdapter(quer2, con)

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"
        con.Open()

        i = 0
        Try
            dd = Date.Now
            billd.Text = dd.Day
            billm.Text = billm.Items(dd.Month - 1)
            billy.Text = dd.Year

            If Report.reportflag = 1 Then
                quer = "select * from bill where bid=" + Report.id
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                bid.Text = ds.Tables(0).Rows(0).Item("bid")
                dd = ds.Tables(0).Rows(0).Item("bdate")
                billd.Text = dd.Day
                billm.Text = billm.Items(dd.Month - 1)
                billy.Text = dd.Year
                tcharge.Text = ds.Tables(0).Rows(0).Item("tcharge")
                scharge.Text = ds.Tables(0).Rows(0).Item("scharge")
                tamount.Text = ds.Tables(0).Rows(0).Item("tamount")
                total.Text = Val(tamount.Text) - Val(tcharge.Text) - Val(scharge.Text)
                Dim quer2, temp As String
                Dim ds1 As New DataSet
                temp = ds.Tables(0).Rows(0).Item("cid")
                quer2 = "select cname from customer where cid=" + temp
                Dim cnd1 As New OleDbCommand(quer2, con)
                Dim da1 As New OleDbDataAdapter(quer2, con)
                da1.Fill(ds1)
                cnamecombo.Text = ds1.Tables(0).Rows(0).Item("cname")
                quer = "select * from bill_quality where bid=" + Report.id
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    temp = ds.Tables(0).Rows(i).Item("qid")
                    quer = "select * from quality where qid=" + temp
                    ds1 = New DataSet
                    cnd = New OleDbCommand(quer, con)
                    da1 = New OleDbDataAdapter(quer, con)
                    da1.Fill(ds1)
                    DataGridView1.Rows.Add(ds1.Tables(0).Rows(0).Item("qname"), ds.Tables(0).Rows(i).Item("quantity"), ds.Tables(0).Rows(i).Item("amount"))
                Next
                quer = "select * from bill_transport where bid=" + Report.id
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                temp = ds.Tables(0).Rows(0).Item("tid")
                quer = "select * from transport where tid=" + temp
                ds1 = New DataSet
                cnd = New OleDbCommand(quer, con)
                da1 = New OleDbDataAdapter(quer, con)
                da1.Fill(ds1)
                tname.Text = ds1.Tables(0).Rows(0).Item("tname")
                lrno.Text = ds.Tables(0).Rows(0).Item("lrno")
                cnamecombo.Enabled = False
                billd.Enabled = False
                billm.Enabled = False
                billy.Enabled = False
                cancel.Visible = False
                addnew.Visible = False
                da.Dispose()
                oidcombo.Visible = False
                Label12.Visible = False
                calculate.Visible = False

            Else
                recover.Visible = False
                print.Visible = False
                ds.Clear()
                quer = "select * from bill"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    bid.Text = 1
                Else
                    ds.Clear()
                    quer = "select max(bid) from bill"
                    cnd = New OleDbCommand(quer, con)
                    da = New OleDbDataAdapter(quer, con)
                    da.Fill(ds)
                    bid.Text = ds.Tables(0).Rows(0).Item("max(bid)") + 1
                End If
                ds.Clear()
                quer = "select * from customer inner join orders on customer.cid=orders.cid where orders.ostatus=0"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    cnamecombo.Items.Add(ds.Tables(0).Rows(i).Item("cname"))
                Next
                ds.Clear()
                quer = "select * from transport"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                da.Fill(ds)
                For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                    tname.Items.Add(ds.Tables(0).Rows(i).Item("tname"))
                Next
                ds.Clear()
                da.Dispose()
                addnew.Visible = False
                ok.Visible = True
                ok.Enabled = False
            End If
            tcharge.Enabled = False
            scharge.Enabled = False
            tname.Enabled = False
            lrno.Enabled = False
            oidcombo.Enabled = False
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
        oidcombo.Items.Clear()
        DataGridView1.Rows.Clear()
        oidcombo.Text = " "
        tamount.Text = ""
        total.Text = ""
        tcharge.Enabled = False
        scharge.Enabled = False
        tname.Enabled = False
        lrno.Enabled = False
        oidcombo.Enabled = False
       
        quer2 = "select cid from customer where cname='" + cnamecombo.Text.ToUpper + "'"
        cnd = New OleDbCommand(quer2, con)
        da1 = New OleDbDataAdapter(quer2, con)
        ds1 = New DataSet
        da1.Fill(ds1)
        If ds1.Tables(0).Rows.Count <> 0 Then
            cid = ds1.Tables(0).Rows(0).Item("cid")
        End If
        quer = "select * from orders where cid=" + cid + "and ostatus=0"
        cnd = New OleDbCommand(quer, con)
        da = New OleDbDataAdapter(quer, con)
        ds = New DataSet
        da.Fill(ds)
        For Me.i = 0 To ds.Tables(0).Rows.Count - 1
            oidcombo.Items.Add(ds.Tables(0).Rows(i).Item("oid"))
        Next
        oidcombo.Enabled = True

    End Sub

    Private Sub oidcombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oidcombo.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        Dim temp, temp1, quan, quan1 As String
        tcharge.Enabled = True
        scharge.Enabled = True
        tname.Enabled = True
        lrno.Enabled = True
        quer = "select * from order_quality where oid=" + oidcombo.Text
        cnd = New OleDbCommand(quer, con)
        da = New OleDbDataAdapter(quer, con)
        qds = New DataSet
        da.Fill(qds)
        amt = 0
        sum = 0
        Dim str As String
        For Me.i = 0 To qds.Tables(0).Rows.Count - 1
            qid = qds.Tables(0).Rows(i).Item("qid")
            str = "select qname,qrate from quality where qid=" + qid
            cnd1 = New OleDbCommand(str, con)
            ds1 = New DataSet
            da1 = New OleDbDataAdapter(str, con)
            da1.Fill(ds1)
            amt = ds1.Tables(0).Rows(0).Item("qrate") * qds.Tables(0).Rows(i).Item("quantity")
            DataGridView1.Rows.Add(ds1.Tables(0).Rows(0).Item("qname"), qds.Tables(0).Rows(i).Item("quantity"), amt)
            sum = sum + amt
        Next
        total.Text = sum
        tamount.Text = sum
        ds1 = New DataSet
        quer2 = "select * from quality "
        cnd1 = New OleDbCommand(quer2, con)
        da1 = New OleDbDataAdapter(quer2, con)
        da1.Fill(ds1)
        For Me.i = 0 To qds.Tables(0).Rows.Count - 1
            temp = qds.Tables(0).Rows(i).Item("qid")
            For Me.j = 0 To ds1.Tables(0).Rows.Count - 1
                temp1 = ds1.Tables(0).Rows(j).Item("qid")
                If Val(temp) = Val(temp1) Then
                    quan = qds.Tables(0).Rows(i).Item("quantity")
                    quan1 = ds1.Tables(0).Rows(j).Item("quantity")
                    If Val(quan) > Val(quan1) Then
                        Dim res As MsgBoxResult
                        res = MsgBox("Insufficient Stock:  Unable to process Bill")
                        If res = MsgBoxResult.Ok Then
                            Me.Close()
                            homeform.addnewbill.PerformClick()
                        End If
                    End If
                End If
            Next
        Next
    End Sub


    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Try
            If Report.reportflag = 1 Then
                Button2_Click(sender, e)
            Else
                Dim temp, temp1, quan, quan1 As String
                quer = "select * from bill"
                Dim cnd As New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                Dim dsNewRow As DataRow
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                dsNewRow = ds.Tables(0).NewRow()
                Dim bdate As String
                dsNewRow.Item("bid") = bid.Text
                bdate = billd.Text + "-" + billm.Text + "-" + billy.Text
                dsNewRow.Item("bdate") = bdate
                dsNewRow.Item("cid") = cid
                dsNewRow.Item("tcharge") = Val(tcharge.Text)
                dsNewRow.Item("scharge") = Val(scharge.Text)
                dsNewRow.Item("tamount") = Val(tamount.Text)
                dsNewRow.Item("oid") = oidcombo.Text
                ds.Tables(0).Rows.Add(dsNewRow)
                da.Update(ds)

                quer = "select * from bill_quality"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                cb = New OleDb.OleDbCommandBuilder(da)

                For Me.i = 0 To DataGridView1.Rows.Count - 1
                    dsNewRow = ds.Tables(0).NewRow()
                    dsNewRow.Item("bid") = bid.Text
                    dsNewRow.Item("qid") = qds.Tables(0).Rows(i).Item("qid")
                    dsNewRow.Item("quantity") = qds.Tables(0).Rows(i).Item("quantity")
                    dsNewRow.Item("amount") = DataGridView1.Rows(i).Cells(2).Value
                    ds.Tables(0).Rows.Add(dsNewRow)
                Next

                da.Update(ds)

                quer = "select * from bill_transport"
                cnd = New OleDbCommand(quer, con)
                da = New OleDbDataAdapter(quer, con)
                ds = New DataSet
                da.Fill(ds)
                cb = New OleDb.OleDbCommandBuilder(da)
                dsNewRow = ds.Tables(0).NewRow()
                dsNewRow.Item("bid") = bid.Text
                dsNewRow.Item("lrno") = lrno.Text
                dsNewRow.Item("tid") = tid
                ds.Tables(0).Rows.Add(dsNewRow)
                da.Update(ds)
                ds1 = New DataSet
                quer2 = "select * from quality "
                cnd1 = New OleDbCommand(quer2, con)
                da1 = New OleDbDataAdapter(quer2, con)
                da1.Fill(ds1)
                For Me.i = 0 To qds.Tables(0).Rows.Count - 1
                    temp = qds.Tables(0).Rows(i).Item("qid")
                    For Me.j = 0 To ds1.Tables(0).Rows.Count - 1
                        temp1 = ds1.Tables(0).Rows(j).Item("qid")
                        If Val(temp) = Val(temp1) Then
                            quan = qds.Tables(0).Rows(i).Item("quantity")
                            quan1 = ds1.Tables(0).Rows(j).Item("quantity")
                            quan = Val(quan1) - Val(quan)
                            quer = "UPDATE quality SET quantity =" + quan + " WHERE qid=" + temp
                            cnd = New OleDbCommand(quer, con)
                            cnd.ExecuteNonQuery()
                        End If
                    Next
                Next

                MsgBox("Bill added")
                ok.Visible = False
                print.Visible = True
                addnew.Visible = True
            End If
        Catch ex As OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub tname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tname.KeyDown
        tflag = 1
        tname.DroppedDown = True
    End Sub

    Private Sub tname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tname.KeyPress
        tflag = 0
        If Asc(e.KeyChar) = 1 Then
            tname.Text = ""
        End If
        tname.DroppedDown = True
    End Sub

    Private Sub tname_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tname.MouseClick
        tflag = 1
    End Sub

    Private Sub tname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tname.SelectedIndexChanged
        quer2 = "select tid from transport where tname='" + tname.Text.ToUpper + "'"
        cnd = New OleDbCommand(quer2, con)
        da1 = New OleDbDataAdapter(quer2, con)
        ds1 = New DataSet
        da1.Fill(ds1)
        If ds1.Tables(0).Rows.Count <> 0 Then
            tid = ds1.Tables(0).Rows(0).Item("tid")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        If Report.reportflag = 1 Then
            Report.Close()
            Me.Close()
            homeform.BillListsToolStripMenuItem.PerformClick()

        End If
        ok.Visible = True
        addnew.Visible = False
        con.Close()
        Me.Close()
        homeform.Enabled = True
    End Sub

    Private Sub calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate.Click
        tamount.Text = Val(tamount.Text) + Val(tcharge.Text) + Val(scharge.Text)
        ok.Enabled = True
    End Sub

    Private Sub addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        Me.Close()
        homeform.addnewbill.PerformClick()
    End Sub

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 0, 0, 45, 35)
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("D:\project\print\bill\" + bid.Text + ".pdf", FileMode.Create))
        doc.Open()
        Dim para As New Paragraph
        Dim gif As Image
        gif = Image.GetInstance("D:\project\jaylaxmi1.png")
        doc.Add(gif)
        para.Add(vbCrLf)
        para.Add("                                                                                             BILL      ")
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        para.Add("                  Bill Number: " + bid.Text + "                    Date: " + billd.Text + "/" + billm.Text + "/" + billy.Text)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        para.Add("                  Customer Name: " + cnamecombo.Text)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        para.Add("                  Transport Agency: " + tname.Text + "       LrNo: " + lrno.Text)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        doc.Add(para)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        Dim table As New PdfPTable(3)
        Dim cell As New PdfPCell()
        cell.Colspan = 5
        Dim arr() As Integer = {5, 5, 5}
        table.SetWidths(arr)
        table.AddCell(cell)
        table.AddCell("Quality")
        table.AddCell("Quantity")
        table.AddCell("Amount")
        For Me.i = 0 To DataGridView1.RowCount - 1
            table.AddCell(DataGridView1.Rows(i).Cells(0).Value.ToString)
            table.AddCell(DataGridView1.Rows(i).Cells(1).Value.ToString)
            table.AddCell(DataGridView1.Rows(i).Cells(2).Value.ToString)
        Next
        doc.Add(table)
        para.Clear()
        para.Add("                                                                                                          Total : " + total.Text)
        para.Add(vbCrLf)
        para.Add("                                                                                  +Transport Charges : " + tcharge.Text)
        para.Add(vbCrLf)
        para.Add("                                                                                     +Service Charges : " + scharge.Text)
        para.Add(vbCrLf)
        para.Add("                                                                                                              _________")
        para.Add(vbCrLf)
        para.Add("                                                                                            Total Amount : " + tamount.Text)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        para.Add("                  Contact:")
        para.Add(vbCrLf)
        para.Add("                              Gourishankar Khandelwal (9823346995) ")
        para.Add(vbCrLf)
        para.Add(vbCrLf)
        doc.Add(para)
        doc.Close()
        Output.AxAcroPDF1.src = "D:\project\print\bill\" + bid.Text + ".pdf"
        Output.Text = "Jaylaxmi Textile Bill"
        Output.Show()
        
    End Sub

    Private Sub recover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recover.Click
        Recovery.Show()
    End Sub

    Private Sub cnamecombo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cnamecombo.TextChanged
        If cflag <> 1 And Report.reportflag <> 1 Then
            If cnamecombo.Text.ToUpper = "" Then
                quer = "select * from customer inner join orders on customer.cid=orders.cid where orders.ostatus=0"
            Else
                quer = "select * from customer inner join orders on customer.cid=orders.cid where orders.ostatus=0 and cname like '%" + cnamecombo.Text.ToUpper + "%'"
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

    Private Sub tname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tname.TextChanged
        If tflag <> 1 And Report.reportflag <> 1 Then
            If tname.Text = "" Then
                quer = "select * from transport"
            Else
                quer = "select * from transport where tname like '%" + tname.Text.ToUpper + "%'"
            End If
            While tname.Items.Count
                tname.Items.RemoveAt(tname.Items.Count - 1)
            End While
            Dim cnd As New OleDbCommand(quer, con)
            ds = New DataSet
            da = New OleDbDataAdapter(quer, con)
            da.Fill(ds)
            For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                tname.Items.Add(ds.Tables(0).Rows(i).Item("tname"))
            Next
        End If
    End Sub
End Class