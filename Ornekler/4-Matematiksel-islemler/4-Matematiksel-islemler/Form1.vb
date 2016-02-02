Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length > 0 And TextBox2.Text.Length > 0 Then

            Dim sayi1, sayi2, sonuc As Integer
            sayi1 = TextBox1.Text
            sayi2 = TextBox2.Text
            sonuc = Val(TextBox1.Text) + Val(TextBox2.Text)
            Label3.Text = sonuc

        Else
            MsgBox("Kutları doldurunuz")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text.Length > 0 And TextBox2.Text.Length > 0 Then

            Dim sayi1, sayi2, sonuc As Integer
            sayi1 = TextBox1.Text
            sayi2 = TextBox2.Text
            sonuc = Val(TextBox1.Text) - Val(TextBox2.Text)
            Label3.Text = sonuc

        Else
            MsgBox("Kutları doldurunuz")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.Length > 0 And TextBox2.Text.Length > 0 Then

            Dim sayi1, sayi2, sonuc As Integer
            sayi1 = TextBox1.Text
            sayi2 = TextBox2.Text
            sonuc = Val(TextBox1.Text) / Val(TextBox2.Text)
            Label3.Text = sonuc

        Else
            MsgBox("Kutları doldurunuz")
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text.Length > 0 And TextBox2.Text.Length > 0 Then

            Dim sayi1, sayi2, sonuc As Integer
            sayi1 = TextBox1.Text
            sayi2 = TextBox2.Text
            sonuc = Val(TextBox1.Text) * Val(TextBox2.Text)
            Label3.Text = sonuc

        Else
            MsgBox("Kutları doldurunuz")
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text.Length > 0 Then

            Dim sayi1, sonuc As Integer
            sayi1 = TextBox1.Text
            sonuc = Val(TextBox1.Text) * Val(TextBox1.Text)
            Label3.Text = sonuc

        Else
            MsgBox("1.sayıyı doldurunuz")
        End If
    End Sub
End Class
