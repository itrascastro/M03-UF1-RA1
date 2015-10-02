Public Class Form1
    Dim op1 As Integer = 0
    Dim op2 As Integer = 0
    Dim resultado As Integer = 0

    Private Sub RestarBtn_Click(sender As Object, e As EventArgs) Handles RestarBtn.Click
        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultado = op1 - op2

        Label1.Text = resultado.ToString()
    End Sub

    Private Sub SumaBtn_Click(sender As Object, e As EventArgs) Handles SumaBtn.Click
        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultado = op1 + op2

        Label1.Text = resultado.ToString()
    End Sub



End Class
