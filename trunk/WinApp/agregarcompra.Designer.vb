Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class agregarcompra
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
            Me.btnproveedor = New System.Windows.Forms.Button
            Me.txtproveedor = New System.Windows.Forms.TextBox
            Me.lblcliente = New System.Windows.Forms.Label
            Me.cmbtipodoc = New System.Windows.Forms.ComboBox
            Me.lbltipodoc = New System.Windows.Forms.Label
            Me.cmbtipocomp = New System.Windows.Forms.ComboBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.lbltipoventa = New System.Windows.Forms.Label
            Me.cmbtipoventa = New System.Windows.Forms.ComboBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.lbltotal = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtcantidad = New CommonControlLib.CustomTextBox
            Me.txtproducto = New CommonControlLib.CustomTextBox
            Me.btnborraritem = New System.Windows.Forms.Button
            Me.btnagregaritem = New System.Windows.Forms.Button
            Me.lblproducto = New System.Windows.Forms.Label
            Me.grditems = New System.Windows.Forms.DataGridView
            Me.lblcantidad = New System.Windows.Forms.Label
            Me.btnproducto = New System.Windows.Forms.Button
            Me.btnguardar = New System.Windows.Forms.Button
            Me.GroupBox1.SuspendLayout()
            CType(Me.grditems, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnproveedor
            '
            Me.btnproveedor.Location = New System.Drawing.Point(262, 93)
            Me.btnproveedor.Name = "btnproveedor"
            Me.btnproveedor.Size = New System.Drawing.Size(28, 23)
            Me.btnproveedor.TabIndex = 19
            Me.btnproveedor.Text = "..."
            Me.btnproveedor.UseVisualStyleBackColor = True
            '
            'txtproveedor
            '
            Me.txtproveedor.Location = New System.Drawing.Point(159, 94)
            Me.txtproveedor.Name = "txtproveedor"
            Me.txtproveedor.Size = New System.Drawing.Size(100, 20)
            Me.txtproveedor.TabIndex = 18
            '
            'lblcliente
            '
            Me.lblcliente.AutoSize = True
            Me.lblcliente.Location = New System.Drawing.Point(41, 98)
            Me.lblcliente.Name = "lblcliente"
            Me.lblcliente.Size = New System.Drawing.Size(107, 13)
            Me.lblcliente.TabIndex = 17
            Me.lblcliente.Text = "Codigo de Proveedor"
            '
            'cmbtipodoc
            '
            Me.cmbtipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbtipodoc.FormattingEnabled = True
            Me.cmbtipodoc.Location = New System.Drawing.Point(421, 95)
            Me.cmbtipodoc.Name = "cmbtipodoc"
            Me.cmbtipodoc.Size = New System.Drawing.Size(121, 21)
            Me.cmbtipodoc.TabIndex = 16
            '
            'lbltipodoc
            '
            Me.lbltipodoc.AutoSize = True
            Me.lbltipodoc.Location = New System.Drawing.Point(314, 98)
            Me.lbltipodoc.Name = "lbltipodoc"
            Me.lbltipodoc.Size = New System.Drawing.Size(101, 13)
            Me.lbltipodoc.TabIndex = 15
            Me.lbltipodoc.Text = "Tipo de Documento"
            '
            'cmbtipocomp
            '
            Me.cmbtipocomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbtipocomp.FormattingEnabled = True
            Me.cmbtipocomp.Items.AddRange(New Object() {"Consumidor Final", "Credito Fiscal"})
            Me.cmbtipocomp.Location = New System.Drawing.Point(166, 44)
            Me.cmbtipocomp.Name = "cmbtipocomp"
            Me.cmbtipocomp.Size = New System.Drawing.Size(121, 21)
            Me.cmbtipocomp.TabIndex = 14
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(37, 44)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(109, 13)
            Me.Label1.TabIndex = 13
            Me.Label1.Text = "Tipo de Comprabante"
            '
            'lbltipoventa
            '
            Me.lbltipoventa.AutoSize = True
            Me.lbltipoventa.Location = New System.Drawing.Point(345, 47)
            Me.lbltipoventa.Name = "lbltipoventa"
            Me.lbltipoventa.Size = New System.Drawing.Size(73, 13)
            Me.lbltipoventa.TabIndex = 12
            Me.lbltipoventa.Text = "Tipo de venta"
            '
            'cmbtipoventa
            '
            Me.cmbtipoventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbtipoventa.FormattingEnabled = True
            Me.cmbtipoventa.Items.AddRange(New Object() {"Contado", "Credito"})
            Me.cmbtipoventa.Location = New System.Drawing.Point(421, 44)
            Me.cmbtipoventa.Name = "cmbtipoventa"
            Me.cmbtipoventa.Size = New System.Drawing.Size(121, 21)
            Me.cmbtipoventa.TabIndex = 11
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
            Me.GroupBox1.Location = New System.Drawing.Point(44, 139)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(498, 244)
            Me.GroupBox1.TabIndex = 20
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Agregar Items a la compra"
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
            'btnagregaritem
            '
            Me.btnagregaritem.Location = New System.Drawing.Point(122, 73)
            Me.btnagregaritem.Name = "btnagregaritem"
            Me.btnagregaritem.Size = New System.Drawing.Size(95, 23)
            Me.btnagregaritem.TabIndex = 17
            Me.btnagregaritem.Text = "Agregar Item"
            Me.btnagregaritem.UseVisualStyleBackColor = True
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
            'grditems
            '
            Me.grditems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.grditems.Location = New System.Drawing.Point(7, 102)
            Me.grditems.Name = "grditems"
            Me.grditems.Size = New System.Drawing.Size(450, 113)
            Me.grditems.TabIndex = 8
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
            'btnproducto
            '
            Me.btnproducto.Location = New System.Drawing.Point(229, 36)
            Me.btnproducto.Name = "btnproducto"
            Me.btnproducto.Size = New System.Drawing.Size(28, 23)
            Me.btnproducto.TabIndex = 14
            Me.btnproducto.Text = "..."
            Me.btnproducto.UseVisualStyleBackColor = True
            '
            'btnguardar
            '
            Me.btnguardar.Location = New System.Drawing.Point(148, 389)
            Me.btnguardar.Name = "btnguardar"
            Me.btnguardar.Size = New System.Drawing.Size(75, 23)
            Me.btnguardar.TabIndex = 21
            Me.btnguardar.Text = "Guardar"
            Me.btnguardar.UseVisualStyleBackColor = True
            '
            'agregarcompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(590, 420)
            Me.Controls.Add(Me.btnguardar)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.btnproveedor)
            Me.Controls.Add(Me.txtproveedor)
            Me.Controls.Add(Me.lblcliente)
            Me.Controls.Add(Me.cmbtipodoc)
            Me.Controls.Add(Me.lbltipodoc)
            Me.Controls.Add(Me.cmbtipocomp)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lbltipoventa)
            Me.Controls.Add(Me.cmbtipoventa)
            Me.Name = "agregarcompra"
            Me.Text = "agregarcompra"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.grditems, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnproveedor As System.Windows.Forms.Button
        Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
        Friend WithEvents lblcliente As System.Windows.Forms.Label
        Friend WithEvents cmbtipodoc As System.Windows.Forms.ComboBox
        Friend WithEvents lbltipodoc As System.Windows.Forms.Label
        Friend WithEvents cmbtipocomp As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lbltipoventa As System.Windows.Forms.Label
        Friend WithEvents cmbtipoventa As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lbltotal As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtcantidad As CommonControlLib.CustomTextBox
        Friend WithEvents txtproducto As CommonControlLib.CustomTextBox
        Friend WithEvents btnborraritem As System.Windows.Forms.Button
        Friend WithEvents btnagregaritem As System.Windows.Forms.Button
        Friend WithEvents lblproducto As System.Windows.Forms.Label
        Friend WithEvents grditems As System.Windows.Forms.DataGridView
        Friend WithEvents lblcantidad As System.Windows.Forms.Label
        Friend WithEvents btnproducto As System.Windows.Forms.Button
        Friend WithEvents btnguardar As System.Windows.Forms.Button
    End Class
End Namespace
