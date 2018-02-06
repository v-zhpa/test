Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As Integer
        Dim Y As Integer
        Dim S As Integer
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        S = X + Y
        Label3.Text = X & "+" & Y & "=" & S


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label4.Text = DateTime.Now.ToString()
    End Sub


    Private Sub PrintOnLabel(ByVal x)
        Dim a As String
        '转换成字符串
        a = Trim(CStr(x))
        '如果字符串为空，则不显示并退出Sub
        If a = "" Then Exit Sub
        '在Label1上显示数字！注意：这里使用了拼接字符串以及换行符vbCrLf
        Label5.Text = Label5.Text & CStr(x) & vbCrLf
        'Form_Load()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As String
        a = Label3.Text
        PrintOnLabel(a)

    End Sub

    Private Sub Form_Load()
        TextBox1.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Hello, Welcome to use Calculator!")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim X As Integer
        Dim Y As Integer
        Dim S As Integer
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        S = X - Y
        Label3.Text = X & "-" & Y & "=" & S

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim X As Integer
        Dim Y As Integer
        Dim S As Integer
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        S = X * Y
        Label3.Text = X & "*" & Y & "=" & S
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim X As Integer
        Dim Y As Integer
        Dim S As Integer
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        S = X / Y
        Label3.Text = X & "/" & Y & "=" & S
    End Sub

End Class
