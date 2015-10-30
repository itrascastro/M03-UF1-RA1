Public Class TablaMultiplicar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim salida As String = ""
        Dim cnt As Integer
        Dim parcial As Integer

        num = TextBox1.Text

        For cnt = 0 To 10
            parcial = num * cnt
            salida = salida + num.ToString() + " x " + cnt.ToString() + " = " +
                     parcial.ToString() + Environment.NewLine
        Next

        MessageBox.Show(salida)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim salida As String = ""

        For cnt As Integer = 0 To 20 Step +2
            salida = salida + " - " + cnt.ToString()
        Next

        MessageBox.Show(salida)
    End Sub
End Class