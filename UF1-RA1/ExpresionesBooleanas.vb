Public Class ExpresionesBooleanas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim expresion As Boolean
        Dim a As Boolean = False
        Dim b As Boolean = True

        expresion = Not (2 < 6 Or (2 * 7 > (24 / 2)))
        MessageBox.Show(expresion)
    End Sub
End Class