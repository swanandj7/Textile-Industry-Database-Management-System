Imports System.Data.OleDb


Public Class Recovery
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim i As Integer

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        con.Close()
        Me.Close()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim cnd As New OleDbCommand(quer, con)
        If recover.Text = ds.Tables(0).Rows(0).Item("recovery").ToString Then
            For Me.i = 0 To Bill.DataGridView1.Rows.Count - 1
                quer = "UPDATE quality SET quantity=quantity+" + Bill.DataGridView1.Rows(i).Cells("Quantity").Value.ToString() + " WHERE qname='" + Bill.DataGridView1.Rows(i).Cells("quality").Value.ToString() + "'"
                cnd = New OleDbCommand(quer, con)
                cnd.ExecuteNonQuery()
            Next
            quer = "delete from bill WHERE bid=" + Bill.bid.Text
            cnd = New OleDbCommand(quer, con)
            cnd.ExecuteNonQuery()
            MsgBox("Bill Recovered")
            Me.Close()
            Bill.Close()
            homeform.BillListsToolStripMenuItem.PerformClick()
        Else
            MsgBox("Incorrect Password")
        End If
    End Sub

    Private Sub Recovery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"
        con.Close()
        con.Open()
        quer = "select recovery from login"
        Dim cnd As New OleDbCommand(quer, con)
        ds = New DataSet
        da = New OleDbDataAdapter(quer, con)
        da.Fill(ds)
    End Sub
End Class