Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Productos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
            Me.lblProductos = New System.Windows.Forms.Label
            Me.lblCostos = New System.Windows.Forms.Label
            Me.lblTipos = New System.Windows.Forms.Label
            Me.lblPrecios = New System.Windows.Forms.Label
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
            Me.tbAgregar = New System.Windows.Forms.ToolStripButton
            Me.tbModificar = New System.Windows.Forms.ToolStripButton
            Me.tbEliminar = New System.Windows.Forms.ToolStripButton
            Me.btnAgregarTipo = New System.Windows.Forms.Button
            Me.btnAgregarSubTipo = New System.Windows.Forms.Button
            Me.btnBorrar = New System.Windows.Forms.Button
            Me.btnEditar = New System.Windows.Forms.Button
            Me.Gridprecios1 = New Jupitech.WinApp.gridprecios
            Me.Gridcostos1 = New Jupitech.WinApp.gridcostos
            Me.ArbolProductos1 = New Jupitech.WinApp.arbolProductos
            Me.Gridproducto1 = New Jupitech.WinApp.gridproducto
            Me.ToolStrip1.SuspendLayout()
            CType(Me.Gridprecios1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Gridcostos1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Gridproducto1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblProductos
            '
            Me.lblProductos.AutoSize = True
            Me.lblProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProductos.Location = New System.Drawing.Point(226, 7)
            Me.lblProductos.Name = "lblProductos"
            Me.lblProductos.Size = New System.Drawing.Size(90, 20)
            Me.lblProductos.TabIndex = 3
            Me.lblProductos.Text = "Productos"
            '
            'lblCostos
            '
            Me.lblCostos.AutoSize = True
            Me.lblCostos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCostos.Location = New System.Drawing.Point(12, 393)
            Me.lblCostos.Name = "lblCostos"
            Me.lblCostos.Size = New System.Drawing.Size(65, 20)
            Me.lblCostos.TabIndex = 4
            Me.lblCostos.Text = "Costos"
            '
            'lblTipos
            '
            Me.lblTipos.AutoSize = True
            Me.lblTipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipos.Location = New System.Drawing.Point(12, 7)
            Me.lblTipos.Name = "lblTipos"
            Me.lblTipos.Size = New System.Drawing.Size(52, 20)
            Me.lblTipos.TabIndex = 5
            Me.lblTipos.Text = "Tipos"
            '
            'lblPrecios
            '
            Me.lblPrecios.AutoSize = True
            Me.lblPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrecios.Location = New System.Drawing.Point(229, 393)
            Me.lblPrecios.Name = "lblPrecios"
            Me.lblPrecios.Size = New System.Drawing.Size(68, 20)
            Me.lblPrecios.TabIndex = 7
            Me.lblPrecios.Text = "Precios"
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbAgregar, Me.tbModificar, Me.tbEliminar})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(956, 36)
            Me.ToolStrip1.TabIndex = 9
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'tbAgregar
            '
            Me.tbAgregar.Image = CType(resources.GetObject("tbAgregar.Image"), System.Drawing.Image)
            Me.tbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbAgregar.Name = "tbAgregar"
            Me.tbAgregar.Size = New System.Drawing.Size(50, 33)
            Me.tbAgregar.Text = "Agregar"
            Me.tbAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'tbModificar
            '
            Me.tbModificar.Image = CType(resources.GetObject("tbModificar.Image"), System.Drawing.Image)
            Me.tbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbModificar.Name = "tbModificar"
            Me.tbModificar.Size = New System.Drawing.Size(54, 33)
            Me.tbModificar.Text = "Modificar"
            Me.tbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'tbEliminar
            '
            Me.tbEliminar.Image = CType(resources.GetObject("tbEliminar.Image"), System.Drawing.Image)
            Me.tbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbEliminar.Name = "tbEliminar"
            Me.tbEliminar.Size = New System.Drawing.Size(47, 33)
            Me.tbEliminar.Text = "Eliminar"
            Me.tbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'btnAgregarTipo
            '
            Me.btnAgregarTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarTipo.Location = New System.Drawing.Point(2, 300)
            Me.btnAgregarTipo.Name = "btnAgregarTipo"
            Me.btnAgregarTipo.Size = New System.Drawing.Size(79, 29)
            Me.btnAgregarTipo.TabIndex = 10
            Me.btnAgregarTipo.Text = "Agregar Tipo"
            Me.btnAgregarTipo.UseVisualStyleBackColor = True
            '
            'btnAgregarSubTipo
            '
            Me.btnAgregarSubTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarSubTipo.Location = New System.Drawing.Point(87, 300)
            Me.btnAgregarSubTipo.Name = "btnAgregarSubTipo"
            Me.btnAgregarSubTipo.Size = New System.Drawing.Size(104, 29)
            Me.btnAgregarSubTipo.TabIndex = 11
            Me.btnAgregarSubTipo.Text = "Agregar Sub Tipo"
            Me.btnAgregarSubTipo.UseVisualStyleBackColor = True
            '
            'btnBorrar
            '
            Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBorrar.Location = New System.Drawing.Point(87, 335)
            Me.btnBorrar.Name = "btnBorrar"
            Me.btnBorrar.Size = New System.Drawing.Size(104, 29)
            Me.btnBorrar.TabIndex = 12
            Me.btnBorrar.Text = "Borrar"
            Me.btnBorrar.UseVisualStyleBackColor = True
            '
            'btnEditar
            '
            Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditar.Location = New System.Drawing.Point(2, 335)
            Me.btnEditar.Name = "btnEditar"
            Me.btnEditar.Size = New System.Drawing.Size(79, 29)
            Me.btnEditar.TabIndex = 13
            Me.btnEditar.Text = "Editar"
            Me.btnEditar.UseVisualStyleBackColor = True
            '
            'Gridprecios1
            '
            Me.Gridprecios1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Gridprecios1.Location = New System.Drawing.Point(230, 417)
            Me.Gridprecios1.Name = "Gridprecios1"
            Me.Gridprecios1.Size = New System.Drawing.Size(240, 71)
            Me.Gridprecios1.TabIndex = 8
            '
            'Gridcostos1
            '
            Me.Gridcostos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Gridcostos1.Location = New System.Drawing.Point(2, 417)
            Me.Gridcostos1.Name = "Gridcostos1"
            Me.Gridcostos1.Size = New System.Drawing.Size(221, 71)
            Me.Gridcostos1.TabIndex = 2
            '
            'ArbolProductos1
            '
            Me.ArbolProductos1.Location = New System.Drawing.Point(2, 33)
            Me.ArbolProductos1.Name = "ArbolProductos1"
            Me.ArbolProductos1.Size = New System.Drawing.Size(221, 272)
            Me.ArbolProductos1.TabIndex = 1
            '
            'Gridproducto1
            '
            Me.Gridproducto1.AllowUserToAddRows = False
            Me.Gridproducto1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
            Me.Gridproducto1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Gridproducto1.Location = New System.Drawing.Point(230, 33)
            Me.Gridproducto1.Name = "Gridproducto1"
            Me.Gridproducto1.Size = New System.Drawing.Size(723, 264)
            Me.Gridproducto1.TabIndex = 0
            '
            'Productos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(956, 531)
            Me.Controls.Add(Me.btnEditar)
            Me.Controls.Add(Me.btnBorrar)
            Me.Controls.Add(Me.btnAgregarSubTipo)
            Me.Controls.Add(Me.btnAgregarTipo)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.Gridprecios1)
            Me.Controls.Add(Me.lblPrecios)
            Me.Controls.Add(Me.lblTipos)
            Me.Controls.Add(Me.lblCostos)
            Me.Controls.Add(Me.lblProductos)
            Me.Controls.Add(Me.Gridcostos1)
            Me.Controls.Add(Me.ArbolProductos1)
            Me.Controls.Add(Me.Gridproducto1)
            Me.Name = "Productos"
            Me.Text = "Productos"
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.Gridprecios1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Gridcostos1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Gridproducto1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Gridproducto1 As Jupitech.WinApp.gridproducto
        Friend WithEvents ArbolProductos1 As Jupitech.WinApp.arbolProductos
        Friend WithEvents Gridcostos1 As Jupitech.WinApp.gridcostos
        Friend WithEvents lblProductos As System.Windows.Forms.Label
        Friend WithEvents lblCostos As System.Windows.Forms.Label
        Friend WithEvents lblTipos As System.Windows.Forms.Label
        Friend WithEvents lblPrecios As System.Windows.Forms.Label
        Friend WithEvents Gridprecios1 As Jupitech.WinApp.gridprecios
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents tbAgregar As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbModificar As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbEliminar As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnAgregarTipo As System.Windows.Forms.Button
        Friend WithEvents btnAgregarSubTipo As System.Windows.Forms.Button
        Friend WithEvents btnBorrar As System.Windows.Forms.Button
        Friend WithEvents btnEditar As System.Windows.Forms.Button

    End Class
End Namespace