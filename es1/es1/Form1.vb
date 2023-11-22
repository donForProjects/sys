Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click
        If sender Is Button1 Then
            Me.Hide()
            Form2.Show()
        ElseIf sender Is Button2 Then
            Me.Hide()
            Form4.Show()
        ElseIf sender Is Button3 Then
            Me.Hide()
            Form6.Show()
        End If
    End Sub

End Class
