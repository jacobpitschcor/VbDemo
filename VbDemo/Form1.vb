Imports System.Xml
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.   
        Me.Text = "City of Racine"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1().Items.Clear()
        Dim xr As XmlReader = XmlReader.Create("movies.xml")
        Do While xr.Read()
            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "movie" Then
                ListBox1.Items.Add(xr.GetAttribute(0))
            End If
        Loop
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2().Items.Clear()
        Dim xr As XmlReader = XmlReader.Create("movies.xml")
        Do While xr.Read()
            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "type" Then
                ListBox2.Items.Add(xr.ReadElementString)
            Else
                xr.Read()
            End If
        Loop
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox3().Items.Clear()
        Dim xr As XmlReader = XmlReader.Create("movies.xml")
        Do While xr.Read()
            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "description" Then
                ListBox3.Items.Add(xr.ReadElementString)
            Else
                xr.Read()
            End If
        Loop
    End Sub
End Class