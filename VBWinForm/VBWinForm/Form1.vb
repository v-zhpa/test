Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
        Label4.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As Integer
        Dim Y As Integer
        Dim S As Integer
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        S = X + Y
        Label3.Text = X & "+" & Y & "=" & S



        Label4.Text = DateTime.Now.ToString()
        Application.DoEvents()
        System.Threading.Thread.Sleep(100)


    End Sub

End Class
