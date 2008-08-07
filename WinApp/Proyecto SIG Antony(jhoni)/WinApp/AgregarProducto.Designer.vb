Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class AgregarProducto
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
            Me.lblNombre = New System.Windows.Forms.Label
            Me.lblDescripcion = New System.Windows.Forms.Label
            Me.lblTipo = New System.Windows.Forms.Label
            Me.lblImagen = New System.Windows.Forms.Label
            Me.lblMarca = New System.Windows.Forms.Label
            Me.lblModelo = New System.Windows.Forms.Label
            Me.txtNombre = New System.Windows.Forms.TextBox
            Me.txtDescripcion = New System.Windows.Forms.TextBox
            Me.txtMarca = New System.Windows.Forms.TextBox
            Me.txtModelo = New System.Windows.Forms.TextBox
            Me.cmbtipo = New System.Windows.Forms.ComboBox
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.txtImagen = New System.Windows.Forms.TextBox
            Me.btnImagen = New System.Windows.Forms.Button
            Me.btnAceptar = New System.Windows.Forms.Button
            Me.btnCancelar = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Location = New System.Drawing.Point(33, 26)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(47, 13)
            Me.lblNombre.TabIndex = 0
            Me.lblNombre.Text = "Nombre:"
            '
            'lblDescripcion
            '
            Me.lblDescripcion.AutoSize = True
            Me.lblDescripcion.Location = New System.Drawing.Point(33, 55)
            Me.lblDescripcion.Name = "lblDescripcion"
            Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
            Me.lblDescripcion.TabIndex = 1
            Me.lblDescripcion.Text = "Descripción:"
            '
            'lblTipo
            '
            Me.lblTipo.AutoSize = True
            Me.lblTipo.Location = New System.Drawing.Point(33, 81)
            Me.lblTipo.Name = "lblTipo"
            Me.lblTipo.Size = New System.Drawing.Size(31, 13)
            Me.lblTipo.TabIndex = 2
            Me.lblTipo.Text = "Tipo:"
            '
            'lblImagen
            '
            Me.lblImagen.AutoSize = True
            Me.lblImagen.Location = New System.Drawing.Point(33, 107)
            Me.lblImagen.Name = "lblImagen"
            Me.lblImagen.Size = New System.Drawing.Size(45, 13)
            Me.lblImagen.TabIndex = 3
            Me.lblImagen.Text = "Imagen:"
            '
            'lblMarca
            '
            Me.lblMarca.AutoSize = True
            Me.lblMarca.Location = New System.Drawing.Point(36, 133)
            Me.lblMarca.Name = "lblMarca"
            Me.lblMarca.Size = New System.Drawing.Size(40, 13)
            Me.lblMarca.TabIndex = 4
            Me.lblMarca.Text = "Marca:"
            '
            'lblModelo
            '
            Me.lblModelo.AutoSize = True
            Me.lblModelo.Location = New System.Drawing.Point(39, 161)
            Me.lblModelo.Name = "lblModelo"
            Me.lblModelo.Size = New System.Drawing.Size(45, 13)
            Me.lblModelo.TabIndex = 5
            Me.lblModelo.Text = "Modelo:"
            '
            'txtNombre
            '
            Me.txtNombre.Location = New System.Drawing.Point(121, 26)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(210, 20)
            Me.txtNombre.TabIndex = 6
            '
            'txtDescripcion
            '
            Me.txtDescripcion.Location = New System.Drawing.Point(121, 52)
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.Size = New System.Drawing.Size(210, 20)
            Me.txtDescripcion.TabIndex = 7
            '
            'txtMarca
            '
            Me.txtMarca.Location = New System.Drawing.Point(121, 126)
            Me.txtMarca.Name = "txtMarca"
            Me.txtMarca.Size = New System.Drawing.Size(210, 20)
            Me.txtMarca.TabIndex = 8
            '
            'txtModelo
            '
            Me.txtModelo.Location = New System.Drawing.Point(121, 158)
            Me.txtModelo.Name = "txtModelo"
            Me.txtModelo.Size = New System.Drawing.Size(210, 20)
            Me.txtModelo.TabIndex = 9
            '
            'cmbtipo
            '
            Me.cmbtipo.FormattingEnabled = True
            Me.cmbtipo.Location = New System.Drawing.Point(121, 78)
            Me.cmbtipo.Name = "cmbtipo"
            Me.cmbtipo.Size = New System.Drawing.Size(121, 21)
            Me.cmbtipo.TabIndex = 10
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Me.OpenFileDialog1.Filter = "Imagenes|*.jpg;*.bmp;*.gif;*.png"
            '
            'txtImagen
            '
            Me.txtImagen.Location = New System.Drawing.Point(121, 104)
            Me.txtImagen.Name = "txtImagen"
            Me.txtImagen.Size = New System.Drawing.Size(121, 20)
            Me.txtImagen.TabIndex = 11
            '
            'btnImagen
            '
            Me.btnImagen.Location = New System.Drawing.Point(248, 101)
            Me.btnImagen.Name = "btnImagen"
            Me.btnImagen.Size = New System.Drawing.Size(27, 23)
            Me.btnImagen.TabIndex = 12
            Me.btnImagen.Text = "..."
            Me.btnImagen.UseVisualStyleBackColor = True
            '
            'btnAceptar
            '
            Me.btnAceptar.Location = New System.Drawing.Point(108, 217)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
            Me.btnAceptar.TabIndex = 13
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'btnCancelar
            '
            Me.btnCancelar.Location = New System.Drawing.Point(189, 217)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
            Me.btnCancelar.TabIndex = 14
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'AgregarProducto
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(387, 256)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.btnImagen)
            Me.Controls.Add(Me.txtImagen)
            Me.Controls.Add(Me.cmbtipo)
            Me.Controls.Add(Me.txtModelo)
            Me.Controls.Add(Me.txtMarca)
            Me.Controls.Add(Me.txtDescripcion)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblModelo)
            Me.Controls.Add(Me.lblMarca)
            Me.Controls.Add(Me.lblImagen)
            Me.Controls.Add(Me.lblTipo)
            Me.Controls.Add(Me.lblDescripcion)
            Me.Controls.Add(Me.lblNombre)
            Me.Name = "AgregarProducto"
            Me.Text = "AgregarProducto"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents lblDescripcion As System.Windows.Forms.Label
        Friend WithEvents lblTipo As System.Windows.Forms.Label
        Friend WithEvents lblImagen As System.Windows.Forms.Label
        Friend WithEvents lblMarca As System.Windows.Forms.Label
        Friend WithEvents lblModelo As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
        Friend WithEvents txtMarca As System.Windows.Forms.TextBox
        Friend WithEvents txtModelo As System.Windows.Forms.TextBox
        Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents txtImagen As System.Windows.Forms.TextBox
        Friend WithEvents btnImagen As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
    End Class
End Namespace