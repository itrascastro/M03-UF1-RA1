Public Class Cerdito
    Private casa As Casa
    Private nombre As String

    Public Sub New(ByVal nombre As String)
        Me.setNombre(nombre)
    End Sub

    Public Function getNombre() As String
        Return Me.nombre
    End Function

    Public Sub setNombre(ByVal nombre As String)
        If nombre <> "small" And nombre <> "medium" And nombre <> "big" Then
            Throw New Exception("Nombre no válido")
        End If

        Me.nombre = nombre
    End Sub

    Public Function construir(ByVal material As String) As Casa
        Me.casa = New Casa(material)

        Return Me.casa
    End Function

    Public Sub ir(ByVal casaNueva As Casa)
        Me.casa = casaNueva
    End Sub

End Class
