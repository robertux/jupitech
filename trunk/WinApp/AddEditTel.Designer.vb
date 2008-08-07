Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class AddEditTel
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
            Me.txtNumero = New System.Windows.Forms.TextBox
            Me.lblNumero = New System.Windows.Forms.Label
            Me.txtTipo = New System.Windows.Forms.TextBox
            Me.lblTipo = New System.Windows.Forms.Label
            Me.btnCancelar = New System.Windows.Forms.Button
            Me.btnAceptar = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'txtNumero
            '
            Me.txtNumero.Location = New System.Drawing.Point(68, 38)
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.Size = New System.Drawing.Size(100, 20)
            Me.txtNumero.TabIndex = 7
            '
            'lblNumero
            '
            Me.lblNumero.AutoSize = True
            Me.lblNumero.Location = New System.Drawing.Point(23, 41)
            Me.lblNumero.Name = "lblNumero"
            Me.lblNumero.Size = New System.Drawing.Size(44, 13)
            Me.lblNumero.TabIndex = 6
            Me.lblNumero.Text = "Numero"
            '
            'txtTipo
            '
            Me.txtTipo.Location = New System.Drawing.Point(68, 12)
            Me.txtTipo.Name = "txtTipo"
            Me.txtTipo.Size = New System.Drawing.Size(100, 20)
            Me.txtTipo.TabIndex = 5
            '
            'lblTipo
            '
            Me.lblTipo.AutoSize = True
            Me.lblTipo.Location = New System.Drawing.Point(23, 15)
            Me.lblTipo.Name = "lblTipo"
            Me.lblTipo.Size = New System.Drawing.Size(24, 13)
            Me.lblTipo.TabIndex = 4
            Me.lblTipo.Text = "tipo"
            '
            'btnCancelar
            '
            Me.btnCancelar.Location = New System.Drawing.Point(93, 64)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
            Me.btnCancelar.TabIndex = 9
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'btnAceptar
            '
            Me.btnAceptar.Location = New System.Drawing.Point(12, 64)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
            Me.btnAceptar.TabIndex = 8
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'AddEditTel
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(183, 102)
            Me.ControlBox = False
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.txtNumero)
            Me.Controls.Add(Me.lblNumero)
            Me.Controls.Add(Me.txtTipo)
            Me.Controls.Add(Me.lblTipo)
            Me.Name = "AddEditTel"
            Me.Text = "AddEditTel"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNumero As System.Windows.Forms.TextBox
        Friend WithEvents lblNumero As System.Windows.Forms.Label
        Friend WithEvents txtTipo As System.Windows.Forms.TextBox
        Friend WithEvents lblTipo As System.Windows.Forms.Label
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
    End Class
End Namespace