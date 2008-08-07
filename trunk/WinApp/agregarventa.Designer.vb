Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class agregarventa
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
            Me.cmbtipoventa = New System.Windows.Forms.ComboBox
            Me.lbltipoventa = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.cmbtipocomp = New System.Windows.Forms.ComboBox
            Me.lbltipodoc = New System.Windows.Forms.Label
            Me.cmbtipodoc = New System.Windows.Forms.ComboBox
            Me.lblcliente = New System.Windows.Forms.Label
            Me.grditems = New System.Windows.Forms.DataGridView
            Me.txtcliente = New System.Windows.Forms.TextBox
            Me.btncliente = New System.Windows.Forms.Button
            Me.lblproducto = New System.Windows.Forms.Label
            Me.btnproducto = New System.Windows.Forms.Button
            Me.lblcantidad = New System.Windows.Forms.Label
            Me.btnagregaritem = New System.Windows.Forms.Button
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.lbltotal = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtcantidad = New CommonControlLib.CustomTextBox
            Me.txtproducto = New CommonControlLib.CustomTextBox
            Me.btnborraritem = New System.Windows.Forms.Button
            Me.btnguardar = New System.Windows.Forms.Button
            CType(Me.grditems, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmbtipoventa
            '
            Me.cmbtipoventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbtipoventa.FormattingEnabled = True
            Me.cmbtipoventa.Items.AddRange(New Object() {"Contado", "Credito"})
            Me.cmbtipoventa.Location = New System.Drawing.Point(405, 39)
            Me.cmbtipoventa.Name = "cmbtipoventa"
            Me.cmbtipoventa.Size = New System.Drawing.Size(121, 21)
            Me.cmbtipoventa.TabIndex = 0
            '
            'lbltipoventa
            '
            Me.lbltipoventa.AutoSize = True
            Me.lbltipoventa.Location = New System.Drawing.Point(329, 42)
            Me.lbltipoventa.Name = "lbltipoventa"
            Me.lbltipoventa.Size = New System.Drawing.Size(73, 13)
            Me.lbltipoventa.TabIndex = 1
            Me.lbltipoventa.Text = "Tipo de venta"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(21, 39)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(109, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Tipo de Comprabante"
            '
            'cmbtipocomp
            '
            Me.cmbtipocomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbtipocomp.FormattingEnabled = True
            Me.cmbtipocomp.Items.AddRange(New Object() {"Consumidor Final", "Credito Fiscal"})
            Me.cmbtipocomp.Location = New System.Drawing.Point(150, 39)
            Me.cmbtipocomp.Name = "cmbtipocomp"
            Me.cmbtipocomp.Size = New System.Drawing.Size(121, 21)
            Me.cmbtipocomp.TabIndex = 3
            '
            'lbltipodoc
            '
            Me.lbltipodoc.AutoSize = True
            Me.lbltipodoc.Location = New System.Drawing.Point(298, 93)
            Me.lbltipodoc.Name = "lbltipodoc"
            Me.lbltipodoc.Size = New System.Drawing.Size(101, 13)
            Me.lbltipodoc.TabIndex = 4
            Me.lbltipodoc.Text = "Tipo de Documento"
            '
            'cmbtipodoc
            '
            Me.cmbtipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbtipodoc.FormattingEnabled = True
            Me.cmbtipodoc.Location = New System.Drawing.Point(405, 90)
            Me.cmbtipodoc.Name = "cmbtipodoc"
            Me.cmbtipodoc.Size = New System.Drawing.Size(121, 21)
            Me.cmbtipodoc.TabIndex = 5
            '
            'lblcliente
            '
            Me.lblcliente.AutoSize = True
            Me.lblcliente.Location = New System.Drawing.Point(25, 93)
            Me.lblcliente.Name = "lblcliente"
            Me.lblcliente.Size = New System.Drawing.Size(90, 13)
            Me.lblcliente.TabIndex = 7
            Me.lblcliente.Text = "Codigo de Cliente"
            '
            'grditems
            '
            Me.grditems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.grditems.Location = New System.Drawing.Point(7, 102)
            Me.grditems.Name = "grditems"
            Me.grditems.Size = New System.Drawing.Size(450, 113)
            Me.grditems.TabIndex = 8
            '
            'txtcliente
            '
            Me.txtcliente.Location = New System.Drawing.Point(125, 89)
            Me.txtcliente.Name = "txtcliente"
            Me.txtcliente.Size = New System.Drawing.Size(100, 20)
            Me.txtcliente.TabIndex = 9
            '
            'btncliente
            '
            Me.btncliente.Location = New System.Drawing.Point(228, 88)
            Me.btncliente.Name = "btncliente"
            Me.btncliente.Size = New System.Drawing.Size(28, 23)
            Me.btncliente.TabIndex = 10
            Me.btncliente.Text = "..."
            Me.btncliente.UseVisualStyleBackColor = True
            '
            'lblproducto
            '
            Me.lblproducto.AutoSize = True
            Me.lblproducto.Location = New System.Drawing.Point(17, 38)
            Me.lblproducto.Name = "lblproducto"
            Me.lblproducto.Size = New System.Drawing.Size(100, 13)
            Me.lblproducto.TabIndex = 12
            Me.lblproducto.Text = "Codigo de producto"
            '
            'btnproducto
            '
            Me.btnproducto.Location = New System.Drawing.Point(229, 36)
            Me.btnproducto.Name = "btnproducto"
            Me.btnproducto.Size = New System.Drawing.Size(28, 23)
            Me.btnproducto.TabIndex = 14
            Me.btnproducto.Text = "..."
            Me.btnproducto.UseVisualStyleBackColor = True
            '
            'lblcantidad
            '
            Me.lblcantidad.AutoSize = True
            Me.lblcantidad.Location = New System.Drawing.Point(293, 39)
            Me.lblcantidad.Name = "lblcantidad"
            Me.lblcantidad.Size = New System.Drawing.Size(49, 13)
            Me.lblcantidad.TabIndex = 15
            Me.lblcantidad.Text = "Cantidad"
            '
            'btnagregaritem
            '
            Me.btnagregaritem.Location = New System.Drawing.Point(122, 73)
            Me.btnagregaritem.Name = "btnagregaritem"
            Me.btnagregaritem.Size = New System.Drawing.Size(95, 23)
            Me.btnagregaritem.TabIndex = 17
            Me.btnagregaritem.Text = "Agregar Item"
            Me.btnagregaritem.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lbltotal)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtcantidad)
            Me.GroupBox1.Controls.Add(Me.txtproducto)
            Me.GroupBox1.Controls.Add(Me.btnborraritem)
            Me.GroupBox1.Controls.Add(Me.btnagregaritem)
            Me.GroupBox1.Controls.Add(Me.lblproducto)
            Me.GroupBox1.Controls.Add(Me.grditems)
            Me.GroupBox1.Controls.Add(Me.lblcantidad)
            Me.GroupBox1.Controls.Add(Me.btnproducto)
            Me.GroupBox1.Location = New System.Drawing.Point(28, 136)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(498, 244)
            Me.GroupBox1.TabIndex = 18
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Agregar Items a la venta"
            '
            'lbltotal
            '
            Me.lbltotal.AutoSize = True
            Me.lbltotal.Location = New System.Drawing.Point(344, 224)
            Me.lbltotal.Name = "lbltotal"
            Me.lbltotal.Size = New System.Drawing.Size(0, 13)
            Me.lbltotal.TabIndex = 22
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(287, 224)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(31, 13)
            Me.Label2.TabIndex = 21
            Me.Label2.Text = "Total"
            '
            'txtcantidad
            '
            Me.txtcantidad.AceptarLetras = CommonControlLib.TipoLetra.Ninguno
            Me.txtcantidad.AceptarNumeros = CommonControlLib.TipoNumero.EnteroSinSigno
            Me.txtcantidad.Location = New System.Drawing.Point(357, 35)
            Me.txtcantidad.Name = "txtcantidad"
            Me.txtcantidad.NumeroDeDecimales = 0
            Me.txtcantidad.OtrosCaracteresPermitidos = ""
            Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
            Me.txtcantidad.TabIndex = 20
            '
            'txtproducto
            '
            Me.txtproducto.AceptarLetras = CommonControlLib.TipoLetra.Ninguno
            Me.txtproducto.AceptarNumeros = CommonControlLib.TipoNumero.EnteroSinSigno
            Me.txtproducto.Location = New System.Drawing.Point(122, 35)
            Me.txtproducto.Name = "txtproducto"
            Me.txtproducto.NumeroDeDecimales = 0
            Me.txtproducto.OtrosCaracteresPermitidos = ""
            Me.txtproducto.Size = New System.Drawing.Size(100, 20)
            Me.txtproducto.TabIndex = 19
            '
            'btnborraritem
            '
            Me.btnborraritem.Location = New System.Drawing.Point(264, 73)
            Me.btnborraritem.Name = "btnborraritem"
            Me.btnborraritem.Size = New System.Drawing.Size(95, 23)
            Me.btnborraritem.TabIndex = 18
            Me.btnborraritem.Text = "Borrar Item"
            Me.btnborraritem.UseVisualStyleBackColor = True
            '
            'btnguardar
            '
            Me.btnguardar.Location = New System.Drawing.Point(150, 386)
            Me.btnguardar.Name = "btnguardar"
            Me.btnguardar.Size = New System.Drawing.Size(75, 23)
            Me.btnguardar.TabIndex = 19
            Me.btnguardar.Text = "Guardar"
            Me.btnguardar.UseVisualStyleBackColor = True
            '
            'agregarventa
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(604, 421)
            Me.Controls.Add(Me.btnguardar)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.btncliente)
            Me.Controls.Add(Me.txtcliente)
            Me.Controls.Add(Me.lblcliente)
            Me.Controls.Add(Me.cmbtipodoc)
            Me.Controls.Add(Me.lbltipodoc)
            Me.Controls.Add(Me.cmbtipocomp)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lbltipoventa)
            Me.Controls.Add(Me.cmbtipoventa)
            Me.Name = "agregarventa"
            Me.Text = "agregarventa"
            CType(Me.grditems, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cmbtipoventa As System.Windows.Forms.ComboBox
        Friend WithEvents lbltipoventa As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cmbtipocomp As System.Windows.Forms.ComboBox
        Friend WithEvents lbltipodoc As System.Windows.Forms.Label
        Friend WithEvents cmbtipodoc As System.Windows.Forms.ComboBox
        Friend WithEvents lblcliente As System.Windows.Forms.Label
        Friend WithEvents grditems As System.Windows.Forms.DataGridView
        Friend WithEvents txtcliente As System.Windows.Forms.TextBox
        Friend WithEvents btncliente As System.Windows.Forms.Button
        Friend WithEvents lblproducto As System.Windows.Forms.Label
        Friend WithEvents btnproducto As System.Windows.Forms.Button
        Friend WithEvents lblcantidad As System.Windows.Forms.Label
        Friend WithEvents btnagregaritem As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnguardar As System.Windows.Forms.Button
        Friend WithEvents btnborraritem As System.Windows.Forms.Button
        Friend WithEvents txtproducto As CommonControlLib.CustomTextBox
        Friend WithEvents txtcantidad As CommonControlLib.CustomTextBox
        Friend WithEvents lbltotal As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label

    End Class
End Namespace
