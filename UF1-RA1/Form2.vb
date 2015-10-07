Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim menor As Integer

        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())
        n3 = CInt(TextBox3.Text())

        If n1 < n2 And n1 < n3 Then
            menor = n1
        ElseIf n2 < n1 And n2 < n3 Then
            menor = n2
        Else
            menor = n3
        End If

        TextBox4.Text = menor.ToString()
    End Sub
End Class