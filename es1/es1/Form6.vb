Public Class Form6

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.SelectedItems.Clear()
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(0).Text = TextBox1.Text Then
                ListView1.Items(i).Selected = True
                TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
            End If
        Next
        ListView1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class