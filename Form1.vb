Imports GroupDocs.Merger

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim licensePath2 As String = "C:\Temp\GroupDocs.Merger.NET.lic"
        Dim lic2 As GroupDocs.Merger.License = New GroupDocs.Merger.License()
        Using merger = New Merger("c:\temp\1.pdf")
            merger.Save("C:\temp\testMerge.pdf")
        End Using
    End Sub
End Class
