Public Class Racional
    Private numerador As Integer
    Private denominador As Integer

    Public Sub New(ByVal numerador As Integer, ByVal denominador As Integer)
        Me.setNumerador(numerador)
        Me.setDenominador(denominador)
    End Sub

    Public Sub New()
        Static r As New Random(System.DateTime.Now.Millisecond)

        Me.setNumerador(r.Next(0, 10))
        Me.setDenominador(r.Next(1, 10))
    End Sub

    Public Function getNumerador() As Integer
        Return Me.numerador
    End Function

    Public Sub setNumerador(ByVal numerador As Integer)
        Me.numerador = numerador
    End Sub

    Public Function getDenominador() As Integer
        Return Me.denominador
    End Function

    Public Sub setDenominador(ByVal denominador As Integer)
        If denominador = 0 Then
            Throw New Exception("Denominador no válido")
        End If
        Me.denominador = denominador
    End Sub

    Public Function multiplicar(ByVal r2 As Racional) As Racional
        Dim resultado As Racional
        Dim num As Integer
        Dim den As Integer

        num = Me.getNumerador() * r2.getNumerador()
        den = Me.getDenominador() * r2.getDenominador()

        resultado = New Racional(num, den)

        Return resultado
    End Function

    Public Function esIgual(ByVal r2 As Racional) As Boolean
        If Me.getNumerador() = r2.getNumerador() And
            Me.getDenominador = r2.getDenominador Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
