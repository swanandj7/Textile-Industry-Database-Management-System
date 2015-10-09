Imports System.Data.OleDb

Public Class Stock
    Public detect As String
    Public stockflag As Integer
    Public id As String
    Dim con As New OleDbConnection
    Dim quer As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim count As Integer
    Public index As String
    Dim i, j As Integer
    Dim a As DataGridViewCellMouseEventArgs

    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=oraoledb.oracle;Data Source=ABHISHEK-PC;User ID=system;password=9422046995"

        con.Open()

        stockflag = 1
        quer = "select * from quality where quantity>0"
        Dim cnd As New OleDbCommand(quer, con)
        ds = New DataSet
        da = New OleDbDataAdapter(quer, con)
        da.Fill(ds)
        For Me.i = 0 To ds.Tables(0).Rows.Count - 1
            DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("qid"), ds.Tables(0).Rows(i).Item("qname"), ds.Tables(0).Rows(i).Item("quantity"), ds.Tables(0).Rows(i).Item("limit"))
        Next
    End Sub

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click
        con.Close()
        Me.Close()
        homeform.Enabled = True

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        id = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        stockflag = 1
        homeform.AddNewquality.PerformClick()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        DataGridView1.Rows.Clear()
        If TextBox1.Text = "" Then
            Stock_Load(sender, e)
        Else
            quer = "select * from quality where qname like '%" + TextBox1.Text.ToUpper + "%' and quantity>0"
            Dim cnd As New OleDbCommand(quer, con)
            ds = New DataSet
            da = New OleDbDataAdapter(quer, con)
            da.Fill(ds)
            For Me.i = 0 To ds.Tables(0).Rows.Count - 1
                DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("qid"), ds.Tables(0).Rows(i).Item("qname"), ds.Tables(0).Rows(i).Item("quantity"), ds.Tables(0).Rows(i).Item("limit"))
            Next
        End If

    End Sub
End Class