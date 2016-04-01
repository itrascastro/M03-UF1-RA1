<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POO_Form
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Op1NumTxtBox = New System.Windows.Forms.TextBox()
        Me.Op1DenTxtBox = New System.Windows.Forms.TextBox()
        Me.Op2NumTxtBox = New System.Windows.Forms.TextBox()
        Me.Op2DenTxtBox = New System.Windows.Forms.TextBox()
        Me.ResNumTxtBox = New System.Windows.Forms.TextBox()
        Me.ResDenTxtBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Op1NumTxtBox
        '
        Me.Op1NumTxtBox.Location = New System.Drawing.Point(12, 12)
        Me.Op1NumTxtBox.Name = "Op1NumTxtBox"
        Me.Op1NumTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.Op1NumTxtBox.TabIndex = 0
        '
        'Op1DenTxtBox
        '
        Me.Op1DenTxtBox.Location = New System.Drawing.Point(12, 38)
        Me.Op1DenTxtBox.Name = "Op1DenTxtBox"
        Me.Op1DenTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.Op1DenTxtBox.TabIndex = 1
        '
        'Op2NumTxtBox
        '
        Me.Op2NumTxtBox.Location = New System.Drawing.Point(170, 12)
        Me.Op2NumTxtBox.Name = "Op2NumTxtBox"
        Me.Op2NumTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.Op2NumTxtBox.TabIndex = 2
        '
        'Op2DenTxtBox
        '
        Me.Op2DenTxtBox.Location = New System.Drawing.Point(170, 38)
        Me.Op2DenTxtBox.Name = "Op2DenTxtBox"
        Me.Op2DenTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.Op2DenTxtBox.TabIndex = 3
        '
        'ResNumTxtBox
        '
        Me.ResNumTxtBox.Location = New System.Drawing.Point(335, 12)
        Me.ResNumTxtBox.Name = "ResNumTxtBox"
        Me.ResNumTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.ResNumTxtBox.TabIndex = 4
        '
        'ResDenTxtBox
        '
        Me.ResDenTxtBox.Location = New System.Drawing.Point(335, 38)
        Me.ResDenTxtBox.Name = "ResDenTxtBox"
        Me.ResDenTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.ResDenTxtBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(473, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Comprobar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(258, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 7
        '
        'POO_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ResDenTxtBox)
        Me.Controls.Add(Me.ResNumTxtBox)
        Me.Controls.Add(Me.Op2DenTxtBox)
        Me.Controls.Add(Me.Op2NumTxtBox)
        Me.Controls.Add(Me.Op1DenTxtBox)
        Me.Controls.Add(Me.Op1NumTxtBox)
        Me.Name = "POO_Form"
        Me.Text = "POO_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Op1NumTxtBox As TextBox
    Friend WithEvents Op1DenTxtBox As TextBox
    Friend WithEvents Op2NumTxtBox As TextBox
    Friend WithEvents Op2DenTxtBox As TextBox
    Friend WithEvents ResNumTxtBox As TextBox
    Friend WithEvents ResDenTxtBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
