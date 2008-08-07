Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class seleccionarcliente
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
            Me.btncancelar = New System.Windows.Forms.Button
            Me.btnaceptar = New System.Windows.Forms.Button
            Me.Gridcliente1 = New Jupitech.WinApp.gridcliente
            Me.txtbuscar = New CommonControlLib.CustomTextBox
            Me.lblbuscar = New System.Windows.Forms.Label
            Me.btnbuscar = New System.Windows.Forms.Button
            CType(Me.Gridcliente1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btncancelar
            '
            Me.btncancelar.Location = New System.Drawing.Point(111, 201)
            Me.btncancelar.Name = "btncancelar"
            Me.btncancelar.Size = New System.Drawing.Size(75, 23)
            Me.btncancelar.TabIndex = 1
            Me.btncancelar.Text = "Cancelar"
            Me.btncancelar.UseVisualStyleBackColor = True
            '
            'btnaceptar
            '
            Me.btnaceptar.Location = New System.Drawing.Point(12, 201)
            Me.btnaceptar.Name = "btnaceptar"
            Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
            Me.btnaceptar.TabIndex = 2
            Me.btnaceptar.Text = "Aceptar"
            Me.btnaceptar.UseVisualStyleBackColor = True
            '
            'Gridcliente1
            '
            Me.Gridcliente1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Gridcliente1.Location = New System.Drawing.Point(12, 44)
            Me.Gridcliente1.Name = "Gridcliente1"
            Me.Gridcliente1.Size = New System.Drawing.Size(529, 119)
            Me.Gridcliente1.TabIndex = 0
            '
            'txtbuscar
            '
            Me.txtbuscar.AceptarLetras = CommonControlLib.TipoLetra.Todos
            Me.txtbuscar.AceptarNumeros = CommonControlLib.TipoNumero.Ninguno
            Me.txtbuscar.Location = New System.Drawing.Point(292, 216)
            Me.txtbuscar.Name = "txtbuscar"
            Me.txtbuscar.NumeroDeDecimales = 0
            Me.txtbuscar.OtrosCaracteresPermitidos = ""
            Me.txtbuscar.Size = New System.Drawing.Size(100, 20)
            Me.txtbuscar.TabIndex = 3
            '
            'lblbuscar
            '
            Me.lblbuscar.AutoSize = True
            Me.lblbuscar.Location = New System.Drawing.Point(289, 190)
            Me.lblbuscar.Name = "lblbuscar"
            Me.lblbuscar.Size = New System.Drawing.Size(98, 13)
            Me.lblbuscar.TabIndex = 4
            Me.lblbuscar.Text = "Buscar por Nombre"
            '
            'btnbuscar
            '
            Me.btnbuscar.Location = New System.Drawing.Point(415, 216)
            Me.btnbuscar.Name = "btnbuscar"
            Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
            Me.btnbuscar.TabIndex = 5
            Me.btnbuscar.Text = "Buscar"
            Me.btnbuscar.UseVisualStyleBackColor = True
            '
            'seleccionarcliente
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(572, 266)
            Me.ControlBox = False
            Me.Controls.Add(Me.btnbuscar)
            Me.Controls.Add(Me.lblbuscar)
            Me.Controls.Add(Me.txtbuscar)
            Me.Controls.Add(Me.btnaceptar)
            Me.Controls.Add(Me.btncancelar)
            Me.Controls.Add(Me.Gridcliente1)
            Me.Name = "seleccionarcliente"
            Me.Text = "seleccionarcliente"
            CType(Me.Gridcliente1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Gridcliente1 As Jupitech.WinApp.gridcliente
        Friend WithEvents btncancelar As System.Windows.Forms.Button
        Friend WithEvents btnaceptar As System.Windows.Forms.Button
        Friend WithEvents txtbuscar As CommonControlLib.CustomTextBox
        Friend WithEvents lblbuscar As System.Windows.Forms.Label
        Friend WithEvents btnbuscar As System.Windows.Forms.Button
    End Class
End Namespace
