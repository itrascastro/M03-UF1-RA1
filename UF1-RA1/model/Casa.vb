Public Class Casa
    Private material As String
    Private derribada As Boolean

    Public Sub New(ByVal material As String)
        Me.material = material
        Me.derribada = False
    End Sub

    Public Sub derribar()
        Me.derribada = True
    End Sub

    Public Function getMaterial() As String
        Return Me.material
    End Function
End Class
