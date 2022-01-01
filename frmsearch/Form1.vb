Imports System.Data.SqlClient
Public Class Form1
    Dim cnx As New SqlConnection("database=GestCom2021; server=LAPTOP-2CRK3QTD;integrated security = true")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("Idclient", "ID CLIENT")
        DataGridView1.Columns.Add("nom", "Nom")
        DataGridView1.Columns.Add("prenom", "Prenom")
        DataGridView1.Columns.Add("tel", "telephone")
        DataGridView1.Columns.Add("email", "E-mail")
        DataGridView1.Columns.Add("pays", "Pays")
        DataGridView1.Columns.Add("ville", "Ville")
        DataGridView1.Columns.Add("codep", "Code Postal")
        load_client()


    End Sub
    Private Sub load_client()
        Try

            cnx.Open()
            cmd.Connection = cnx

            charger_DataGridView1()

        Catch e As Exception
            MessageBox.Show(e.Message)

        End Try
    End Sub

    Private Sub charger_DataGridView1()
        Try
            DataGridView1.Rows.Clear()
            cmd.CommandText = "SELECT * FROM client"
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub search()
        cmd.CommandText = "select * from client where nom like '" & nom.Text & "%' and
        prenom like '" & prenom.Text & "%' and
        ville like '" & ville.Text & "%'"
        dr = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        While dr.Read
            DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7))

        End While
        dr.Close()
    End Sub



    Private Sub nom_TextChanged(sender As Object, e As EventArgs) Handles nom.TextChanged
        search()
    End Sub

    Private Sub prenomr_CheckedChanged(sender As Object, e As EventArgs) Handles prenomr.CheckedChanged
        trier("prenom", "asc")
    End Sub

    Private Sub prenom_TextChanged(sender As Object, e As EventArgs) Handles prenom.TextChanged
        search()
    End Sub

    Private Sub ville_TextChanged(sender As Object, e As EventArgs) Handles ville.TextChanged
        search()
    End Sub

    Private Sub nomr_CheckedChanged(sender As Object, e As EventArgs) Handles nomr.CheckedChanged
        trier("nom", "asc")
    End Sub

    Private Sub viller_CheckedChanged(sender As Object, e As EventArgs) Handles viller.CheckedChanged
        trier("ville", "asc")

    End Sub
    Private Sub trier(c As String, g As String)
        cmd.CommandText = "select * from client where nom like '" & nom.Text & "%' and
        prenom like '" & prenom.Text & "%' and
        ville like '" & ville.Text & "%' Order by " & c & " " & g & ""
        dr = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        While dr.Read
            DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7))

        End While
        dr.Close()
    End Sub
End Class
