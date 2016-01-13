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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numeros() As Integer = {4, 20, 10, 12, 0, 7}
        Dim cnt As Integer
        Dim menor As Integer = numeros(0)
        Dim posMenor As Integer = 0

        For cnt = 1 To 5
            If numeros(cnt) < menor Then
                menor = numeros(cnt)
                posMenor = cnt
            End If
        Next

        MessageBox.Show(posMenor.ToString())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tabla(2, 2) As Integer
        tabla = {
            {2, 3, 4},
            {1, 5, 0},
            {2, 4, 1}
        }

        Dim i, j As Integer
        Dim suma As Integer = 0
        Dim media As Double

        For i = 0 To 2
            For j = 0 To 2
                suma = suma + tabla(i, j)
            Next
            'fin de fila
        Next

        media = suma / (3 * 3)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tabla(2, 2) As Integer
        tabla = {
            {2, 3, 4},
            {1, 5, 0},
            {2, 4, 1}
        }

        Dim i, j As Integer
        Dim salida As String = ""

        For i = 0 To 2
            For j = 0 To 2
                salida = salida + tabla(i, j).ToString + " "
            Next
            salida = salida + vbNewLine
        Next

        MessageBox.Show(salida)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim tabla(2, 2) As Integer
        tabla = {
            {2, 3, 4},
            {1, 5, 0},
            {2, 4, 1}
        }

        Dim i, j As Integer
        Dim r As New Random()

        For i = 0 To 2
            For j = 0 To 2
                tabla(i, j) = r.Next(0, 100)
            Next
        Next

        For i = 0 To 2
            For j = 0 To 2
                If i = j Then 'diagonal
                    tabla(i, j) = 0
                End If
            Next
        Next

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim myControls(10, 10)
        Dim i, j As Integer

        For i = 0 To 10
            For j = 0 To 10
                Dim b As Button
                b = New Button
                b.Name = "buton" + i.ToString + j.ToString

                myControls(i, j) = b
                Me.Controls.Add(b)
            Next
        Next
        MessageBox.Show(myControls(7, 7).Name)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim tabla(4, 4) As Integer
        Dim i, j As Integer

        For i = 0 To 4
            For j = 0 To 4
                If (i = 2 Or j = 2) Then
                    tabla(i, j) = 1
                Else
                    tabla(i, j) = 0
                End If
            Next
        Next

        Dim salida As String = ""

        For i = 0 To 4
            For j = 0 To 4
                salida += tabla(i, j).ToString + "  "
            Next
            salida += vbNewLine
        Next

        MessageBox.Show(salida)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim tabla(4, 4) As Integer
        Dim i, j As Integer

        For i = 0 To 4
            For j = 0 To 4
                If (i = 2 Or j = 2) Then
                    tabla(i, j) = 1
                Else
                    tabla(i, j) = 0
                End If
            Next
        Next

        Me.Imprimir(tabla, 4, 4)

    End Sub

    Private Sub Imprimir(ByVal tabla(,) As Integer, ByVal filas As Integer, ByVal cols As Integer)
        Dim salida As String = ""
        Dim i, j As Integer

        For i = 0 To filas
            For j = 0 To cols
                salida += tabla(i, j).ToString + "  "
            Next
            salida += vbNewLine
        Next

        MessageBox.Show(salida)
    End Sub
End Class