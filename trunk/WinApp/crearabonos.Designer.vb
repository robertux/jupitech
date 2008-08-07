Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class crearabonos
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
            Me.lblinteres = New System.Windows.Forms.Label
            Me.txtinteres = New CommonControlLib.CustomTextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtnumabonos = New CommonControlLib.CustomTextBox
            Me.lblperiodo = New System.Windows.Forms.Label
            Me.cmbperiodo = New System.Windows.Forms.ComboBox
            Me.lblinteresmora = New System.Windows.Forms.Label
            Me.txtinteresmora = New CommonControlLib.CustomTextBox
            Me.btnaceptar = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'lblinteres
            '
            Me.lblinteres.AutoSize = True
            Me.lblinteres.Location = New System.Drawing.Point(73, 100)
            Me.lblinteres.Name = "lblinteres"
            Me.lblinteres.Size = New System.Drawing.Size(50, 13)
            Me.lblinteres.TabIndex = 0
            Me.lblinteres.Text = "Interes %"
            '
            'txtinteres
            '
            Me.txtinteres.AceptarLetras = CommonControlLib.TipoLetra.Ninguno
            Me.txtinteres.AceptarNumeros = CommonControlLib.TipoNumero.EnteroSinSigno
            Me.txtinteres.Location = New System.Drawing.Point(129, 97)
            Me.txtinteres.Name = "txtinteres"
            Me.txtinteres.NumeroDeDecimales = 0
            Me.txtinteres.OtrosCaracteresPermitidos = ""
            Me.txtinteres.Size = New System.Drawing.Size(122, 20)
            Me.txtinteres.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(25, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(98, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Nùmero de Abonos"
            '
            'txtnumabonos
            '
            Me.txtnumabonos.AceptarLetras = CommonControlLib.TipoLetra.Ninguno
            Me.txtnumabonos.AceptarNumeros = CommonControlLib.TipoNumero.EnteroSinSigno
            Me.txtnumabonos.Location = New System.Drawing.Point(129, 23)
            Me.txtnumabonos.Name = "txtnumabonos"
            Me.txtnumabonos.NumeroDeDecimales = 0
            Me.txtnumabonos.OtrosCaracteresPermitidos = ""
            Me.txtnumabonos.Size = New System.Drawing.Size(122, 20)
            Me.txtnumabonos.TabIndex = 3
            '
            'lblperiodo
            '
            Me.lblperiodo.AutoSize = True
            Me.lblperiodo.Location = New System.Drawing.Point(86, 62)
            Me.lblperiodo.Name = "lblperiodo"
            Me.lblperiodo.Size = New System.Drawing.Size(37, 13)
            Me.lblperiodo.TabIndex = 4
            Me.lblperiodo.Text = "Perido"
            '
            'cmbperiodo
            '
            Me.cmbperiodo.FormattingEnabled = True
            Me.cmbperiodo.Items.AddRange(New Object() {"Semanal", "Quincenal", "Mensual", "Bimensual", "Trimestral"})
            Me.cmbperiodo.Location = New System.Drawing.Point(130, 56)
            Me.cmbperiodo.Name = "cmbperiodo"
            Me.cmbperiodo.Size = New System.Drawing.Size(121, 21)
            Me.cmbperiodo.TabIndex = 5
            '
            'lblinteresmora
            '
            Me.lblinteresmora.AutoSize = True
            Me.lblinteresmora.Location = New System.Drawing.Point(25, 139)
            Me.lblinteresmora.Name = "lblinteresmora"
            Me.lblinteresmora.Size = New System.Drawing.Size(95, 13)
            Me.lblinteresmora.TabIndex = 6
            Me.lblinteresmora.Text = "Interes por Mora %"
            '
            'txtinteresmora
            '
            Me.txtinteresmora.AceptarLetras = CommonControlLib.TipoLetra.Ninguno
            Me.txtinteresmora.AceptarNumeros = CommonControlLib.TipoNumero.EnteroSinSigno
            Me.txtinteresmora.Location = New System.Drawing.Point(129, 136)
            Me.txtinteresmora.Name = "txtinteresmora"
            Me.txtinteresmora.NumeroDeDecimales = 0
            Me.txtinteresmora.OtrosCaracteresPermitidos = ""
            Me.txtinteresmora.Size = New System.Drawing.Size(122, 20)
            Me.txtinteresmora.TabIndex = 7
            '
            'btnaceptar
            '
            Me.btnaceptar.Location = New System.Drawing.Point(48, 187)
            Me.btnaceptar.Name = "btnaceptar"
            Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
            Me.btnaceptar.TabIndex = 8
            Me.btnaceptar.Text = "Aceptar"
            Me.btnaceptar.UseVisualStyleBackColor = True
            '
            'crearabonos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(349, 231)
            Me.Controls.Add(Me.btnaceptar)
            Me.Controls.Add(Me.txtinteresmora)
            Me.Controls.Add(Me.lblinteresmora)
            Me.Controls.Add(Me.cmbperiodo)
            Me.Controls.Add(Me.lblperiodo)
            Me.Controls.Add(Me.txtnumabonos)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtinteres)
            Me.Controls.Add(Me.lblinteres)
            Me.Name = "crearabonos"
            Me.Text = "crearabonos"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblinteres As System.Windows.Forms.Label
        Friend WithEvents txtinteres As CommonControlLib.CustomTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtnumabonos As CommonControlLib.CustomTextBox
        Friend WithEvents lblperiodo As System.Windows.Forms.Label
        Friend WithEvents cmbperiodo As System.Windows.Forms.ComboBox
        Friend WithEvents lblinteresmora As System.Windows.Forms.Label
        Friend WithEvents txtinteresmora As CommonControlLib.CustomTextBox
        Friend WithEvents btnaceptar As System.Windows.Forms.Button
    End Class
End Namespace
