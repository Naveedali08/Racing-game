Public Class Form2




    Private Sub Start_MouseClick(sender As Object, e As EventArgs) Handles Start.MouseClick


        Me.Visible = False
        Form1.Visible = True



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Form1.Dispose()
        Me.Dispose()

    End Sub


End Class