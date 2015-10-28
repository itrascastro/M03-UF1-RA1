Public Class Bucles
    Const NUM As Integer = 4
    Const INTENTOSMAX As Integer = 3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim intentos As Integer = 0
        Dim acertado As Boolean = False

        Do
            n = InputBox("Di un número - Te quedan " + (INTENTOSMAX - intentos).ToString() + " intentos")

            If (n = NUM) Then
                acertado = True
                Exit Do
            End If

            intentos = intentos + 1
        Loop Until (intentos = INTENTOSMAX)

        If (acertado) Then
            MessageBox.Show("Acertaste")
        Else
            MessageBox.Show("Has superado el número de intentos máximo")
        End If

    End Sub
End Class