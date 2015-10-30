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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim salida As String = ""

        For cnt As Integer = 0 To 20 Step +2
            salida = salida + " - " + cnt.ToString()
        Next

        MessageBox.Show(salida)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cnt As Integer = 0
        Dim salida As String = ""

        While cnt <= 20
            salida = salida + " - " + cnt.ToString()
            cnt = cnt + 2
        End While

        MessageBox.Show(salida)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim suma As Integer = 0
        Dim cnt As Integer = 0

        While cnt <= 100
            suma = suma + cnt
            cnt = cnt + 1
        End While

        MessageBox.Show(suma.ToString())

    End Sub

    Private Sub AcumuladoFor()
        Dim suma As Integer = 0

        For cnt As Integer = 0 To 100
            suma = suma + cnt
        Next

        MessageBox.Show(suma.ToString())
    End Sub
End Class