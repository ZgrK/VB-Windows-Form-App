Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z
        x = Val(TextBox1)
        y = Val(TextBox2)
        z = Val(TextBox3)
        If x > y And x > z Then

            Label2.text = "1. Sayı büyük"
        ElseIf y > x And y > z Then

        ElseIf z > x And z > y Then


        End If
    End Sub
End Class
