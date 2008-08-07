Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class AddEditDoc
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtTipo = New System.Windows.Forms.TextBox
            Me.txtNumero = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtFormato = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.btnAceptar = New System.Windows.Forms.Button
            Me.btnCancelar = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(13, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(24, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "tipo"
            '
            'txtTipo
            '
            Me.txtTipo.Location = New System.Drawing.Point(58, 10)
            Me.txtTipo.Name = "txtTipo"
            Me.txtTipo.Size = New System.Drawing.Size(100, 20)
            Me.txtTipo.TabIndex = 1
            '
            'txtNumero
            '
            Me.txtNumero.Location = New System.Drawing.Point(58, 36)
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.Size = New System.Drawing.Size(100, 20)
            Me.txtNumero.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(13, 39)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Numero"
            '
            'txtFormato
            '
            Me.txtFormato.Location = New System.Drawing.Point(58, 62)
            Me.txtFormato.Name = "txtFormato"
            Me.txtFormato.Size = New System.Drawing.Size(100, 20)
            Me.txtFormato.TabIndex = 5
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(13, 65)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(45, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Formato"
            '
            'btnAceptar
            '
            Me.btnAceptar.Location = New System.Drawing.Point(16, 97)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
            Me.btnAceptar.TabIndex = 6
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'btnCancelar
            '
            Me.btnCancelar.Location = New System.Drawing.Point(97, 97)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
            Me.btnCancelar.TabIndex = 7
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'AddEditDoc
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(183, 132)
            Me.ControlBox = False
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.txtFormato)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtNumero)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtTipo)
            Me.Controls.Add(Me.Label1)
            Me.Name = "AddEditDoc"
            Me.Text = "AddEditDoc"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtTipo As System.Windows.Forms.TextBox
        Friend WithEvents txtNumero As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtFormato As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
    End Class
End Namespace