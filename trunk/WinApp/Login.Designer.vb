Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
        Partial Class Login
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
            Me.lblUsuario = New System.Windows.Forms.Label
            Me.lblClave = New System.Windows.Forms.Label
            Me.txtUsuario = New System.Windows.Forms.TextBox
            Me.txtClave = New System.Windows.Forms.TextBox
            Me.btnIngresar = New System.Windows.Forms.Button
            Me.lblIncorrecto = New System.Windows.Forms.Label
            Me.btnCancelar = New System.Windows.Forms.Button
            Me.Cmbsucursales1 = New Jupitech.cmbsucursales
            Me.SuspendLayout()
            '
            'lblUsuario
            '
            Me.lblUsuario.AutoSize = True
            Me.lblUsuario.Location = New System.Drawing.Point(22, 21)
            Me.lblUsuario.Name = "lblUsuario"
            Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
            Me.lblUsuario.TabIndex = 0
            Me.lblUsuario.Text = "Usuario:"
            '
            'lblClave
            '
            Me.lblClave.AutoSize = True
            Me.lblClave.Location = New System.Drawing.Point(31, 43)
            Me.lblClave.Name = "lblClave"
            Me.lblClave.Size = New System.Drawing.Size(37, 13)
            Me.lblClave.TabIndex = 1
            Me.lblClave.Text = "Clave:"
            '
            'txtUsuario
            '
            Me.txtUsuario.Location = New System.Drawing.Point(74, 14)
            Me.txtUsuario.MaxLength = 15
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.Size = New System.Drawing.Size(145, 20)
            Me.txtUsuario.TabIndex = 2
            '
            'txtClave
            '
            Me.txtClave.Location = New System.Drawing.Point(74, 43)
            Me.txtClave.MaxLength = 15
            Me.txtClave.Name = "txtClave"
            Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtClave.Size = New System.Drawing.Size(145, 20)
            Me.txtClave.TabIndex = 3
            '
            'btnIngresar
            '
            Me.btnIngresar.Location = New System.Drawing.Point(242, 16)
            Me.btnIngresar.Name = "btnIngresar"
            Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
            Me.btnIngresar.TabIndex = 4
            Me.btnIngresar.Text = "Aceptar"
            Me.btnIngresar.UseVisualStyleBackColor = True
            '
            'lblIncorrecto
            '
            Me.lblIncorrecto.AutoSize = True
            Me.lblIncorrecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIncorrecto.ForeColor = System.Drawing.Color.Red
            Me.lblIncorrecto.Location = New System.Drawing.Point(71, 133)
            Me.lblIncorrecto.Name = "lblIncorrecto"
            Me.lblIncorrecto.Size = New System.Drawing.Size(183, 13)
            Me.lblIncorrecto.TabIndex = 5
            Me.lblIncorrecto.Text = "Nombre y / o clave incorrectos"
            Me.lblIncorrecto.Visible = False
            '
            'btnCancelar
            '
            Me.btnCancelar.Location = New System.Drawing.Point(242, 46)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
            Me.btnCancelar.TabIndex = 6
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'Cmbsucursales1
            '
            Me.Cmbsucursales1.Location = New System.Drawing.Point(25, 75)
            Me.Cmbsucursales1.Name = "Cmbsucursales1"
            Me.Cmbsucursales1.Size = New System.Drawing.Size(220, 29)
            Me.Cmbsucursales1.TabIndex = 7
            '
            'Login
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(331, 155)
            Me.ControlBox = False
            Me.Controls.Add(Me.Cmbsucursales1)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.lblIncorrecto)
            Me.Controls.Add(Me.btnIngresar)
            Me.Controls.Add(Me.txtClave)
            Me.Controls.Add(Me.txtUsuario)
            Me.Controls.Add(Me.lblClave)
            Me.Controls.Add(Me.lblUsuario)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Login"
            Me.Text = "Login"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblUsuario As System.Windows.Forms.Label
        Friend WithEvents lblClave As System.Windows.Forms.Label
        Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
        Friend WithEvents txtClave As System.Windows.Forms.TextBox
        Friend WithEvents btnIngresar As System.Windows.Forms.Button
        Friend WithEvents lblIncorrecto As System.Windows.Forms.Label
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents Cmbsucursales1 As Jupitech.cmbsucursales
    End Class
End Namespace