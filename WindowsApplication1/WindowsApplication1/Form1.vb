Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 51 Then
            System.Diagnostics.Process.Start(“C:\Run345.vbs”)
        End If
    End Sub
End Class
