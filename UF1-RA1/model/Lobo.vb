Public Class Lobo
    Private casa As Casa
    Private quemado As Boolean

    Public Sub New()
        Me.quemado = False
    End Sub

    Public Sub soplar()
        If casa.getMaterial <> "ladrillo" Then
            Me.casa.derribar()
        Else
            Me.quemado = True
        End If
    End Sub

    Public Sub ir(ByVal nuevaCasa As Casa)
        Me.casa = nuevaCasa
    End Sub
End Class
