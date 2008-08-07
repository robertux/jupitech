Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Ventas
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtbuscar = New System.Windows.Forms.TextBox
            Me.btnbuscar = New System.Windows.Forms.Button
            Me.lblbuscar = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.lbltotal = New System.Windows.Forms.Label
            Me.btnabonos = New System.Windows.Forms.Button
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.Griditemsventa1 = New Jupitech.griditemsventa
            Me.DataGridView1 = New Jupitech.gridventa
            Me.ToolStrip1.SuspendLayout()
            CType(Me.Griditemsventa1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 204)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(119, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Descripciòn de la venta"
            '
            'txtbuscar
            '
            Me.txtbuscar.Location = New System.Drawing.Point(635, 99)
            Me.txtbuscar.Name = "txtbuscar"
            Me.txtbuscar.Size = New System.Drawing.Size(100, 20)
            Me.txtbuscar.TabIndex = 3
            '
            'btnbuscar
            '
            Me.btnbuscar.Location = New System.Drawing.Point(647, 144)
            Me.btnbuscar.Name = "btnbuscar"
            Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
            Me.btnbuscar.TabIndex = 4
            Me.btnbuscar.Text = "Buscar"
            Me.btnbuscar.UseVisualStyleBackColor = True
            '
            'lblbuscar
            '
            Me.lblbuscar.AutoSize = True
            Me.lblbuscar.Location = New System.Drawing.Point(638, 83)
            Me.lblbuscar.Name = "lblbuscar"
            Me.lblbuscar.Size = New System.Drawing.Size(94, 13)
            Me.lblbuscar.TabIndex = 5
            Me.lblbuscar.Text = "Buscar por Codigo"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(276, 332)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(31, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "Total"
            '
            'lbltotal
            '
            Me.lbltotal.AutoSize = True
            Me.lbltotal.Location = New System.Drawing.Point(363, 332)
            Me.lbltotal.Name = "lbltotal"
            Me.lbltotal.Size = New System.Drawing.Size(0, 13)
            Me.lbltotal.TabIndex = 7
            '
            'btnabonos
            '
            Me.btnabonos.Location = New System.Drawing.Point(647, 295)
            Me.btnabonos.Name = "btnabonos"
            Me.btnabonos.Size = New System.Drawing.Size(75, 23)
            Me.btnabonos.TabIndex = 8
            Me.btnabonos.Text = "Ver abonos"
            Me.btnabonos.UseVisualStyleBackColor = True
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(744, 36)
            Me.ToolStrip1.TabIndex = 9
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'ToolStripButton1
            '
            Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
            Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton1.Name = "ToolStripButton1"
            Me.ToolStripButton1.Size = New System.Drawing.Size(50, 33)
            Me.ToolStripButton1.Text = "Agregar"
            Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.ToolStripButton1.ToolTipText = "Agregar"
            '
            'Griditemsventa1
            '
            Me.Griditemsventa1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Griditemsventa1.Location = New System.Drawing.Point(12, 220)
            Me.Griditemsventa1.Name = "Griditemsventa1"
            Me.Griditemsventa1.Size = New System.Drawing.Size(596, 109)
            Me.Griditemsventa1.TabIndex = 1
            Me.Griditemsventa1.total = 0
            '
            'DataGridView1
            '
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Location = New System.Drawing.Point(12, 54)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.Size = New System.Drawing.Size(596, 137)
            Me.DataGridView1.TabIndex = 0
            '
            'Ventas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(744, 376)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.btnabonos)
            Me.Controls.Add(Me.lbltotal)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblbuscar)
            Me.Controls.Add(Me.btnbuscar)
            Me.Controls.Add(Me.txtbuscar)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Griditemsventa1)
            Me.Controls.Add(Me.DataGridView1)
            Me.Name = "Ventas"
            Me.Text = "Ventas"
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.Griditemsventa1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents DataGridView1 As gridventa
        Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SucursalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TipopagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents FormapagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PedidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Griditemsventa1 As Jupitech.griditemsventa
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
        Friend WithEvents btnbuscar As System.Windows.Forms.Button
        Friend WithEvents lblbuscar As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lbltotal As System.Windows.Forms.Label
        Friend WithEvents btnabonos As System.Windows.Forms.Button
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    End Class
End Namespace