Public Class POO_Form
    Dim operando1 As Racional
    Dim operando2 As Racional
    Dim resultado As Racional

    Private Sub POO_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.operando1 = New Racional()
        Op1NumTxtBox.Text = Me.operando1.getNumerador().ToString()
        Op1DenTxtBox.Text = Me.operando1.getDenominador().ToString()

        Me.operando2 = New Racional()
        Op2NumTxtBox.Text = Me.operando2.getNumerador().ToString()
        Op2DenTxtBox.Text = Me.operando2.getDenominador().ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resultado = New Racional(CInt(ResNumTxtBox.Text), CInt(ResDenTxtBox.Text))

        Dim resultadoReal As Racional = operando1.multiplicar(operando2)

        If resultado.esIgual(resultadoReal) Then
            Label1.Text = "Correcto"
        Else
            Label1.Text = "ERROR"
        End If
    End Sub
End Class