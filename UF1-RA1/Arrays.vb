Public Class Arrays
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim notas() As Double = {6.5, 4, 7, 9.75}
        Dim notas(3) As Double
        Dim cnt As Integer
        Dim menor As Double
        Dim mayor As Double
        Dim total As Double
        Dim media As Double

        For cnt = 0 To 3
            notas(cnt) = InputBox("Introduce una nota")
        Next

        menor = notas(0)
        mayor = notas(0)
        total = notas(0)

        For cnt = 1 To 3
            If notas(cnt) < menor Then
                menor = notas(cnt)
            End If
            If notas(cnt) > mayor Then
                mayor = notas(cnt)
            End If
            total = total + notas(cnt)
        Next

        media = total / notas.Length()
        MessageBox.Show(menor.ToString() + ", " + mayor.ToString() + ", " + media.ToString())
    End Sub
End Class