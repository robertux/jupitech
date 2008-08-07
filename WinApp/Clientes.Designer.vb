Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Clientes
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.GridTelefonos1 = New Jupitech.WinApp.GridTelefonos
            Me.GridDocumentos1 = New Jupitech.WinApp.GridDocumentos
            Me.GridClientes1 = New Jupitech.WinApp.gridClientes
            Me.ToolStrip1.SuspendLayout()
            CType(Me.GridTelefonos1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridDocumentos1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridClientes1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(630, 25)
            Me.ToolStrip1.TabIndex = 0
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'ToolStripButton1
            '
            Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
            Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton1.Name = "ToolStripButton1"
            Me.ToolStripButton1.Size = New System.Drawing.Size(66, 22)
            Me.ToolStripButton1.Text = "Agregar"
            '
            'ToolStripButton2
            '
            Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
            Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton2.Name = "ToolStripButton2"
            Me.ToolStripButton2.Size = New System.Drawing.Size(70, 22)
            Me.ToolStripButton2.Text = "Modificar"
            '
            'ToolStripButton3
            '
            Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
            Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton3.Name = "ToolStripButton3"
            Me.ToolStripButton3.Size = New System.Drawing.Size(63, 22)
            Me.ToolStripButton3.Text = "Eliminar"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(23, 42)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(61, 18)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Clientes"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(23, 283)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(94, 18)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Documentos"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(362, 283)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(74, 18)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Telefonos"
            '
            'GridTelefonos1
            '
            Me.GridTelefonos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.GridTelefonos1.Location = New System.Drawing.Point(365, 305)
            Me.GridTelefonos1.Name = "GridTelefonos1"
            Me.GridTelefonos1.Size = New System.Drawing.Size(240, 101)
            Me.GridTelefonos1.TabIndex = 4
            '
            'GridDocumentos1
            '
            Me.GridDocumentos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.GridDocumentos1.Location = New System.Drawing.Point(26, 305)
            Me.GridDocumentos1.Name = "GridDocumentos1"
            Me.GridDocumentos1.Size = New System.Drawing.Size(240, 101)
            Me.GridDocumentos1.TabIndex = 3
            '
            'GridClientes1
            '
            Me.GridClientes1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.GridClientes1.Location = New System.Drawing.Point(26, 64)
            Me.GridClientes1.Name = "GridClientes1"
            Me.GridClientes1.Size = New System.Drawing.Size(579, 205)
            Me.GridClientes1.TabIndex = 1
            '
            'Clientes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(630, 449)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.GridTelefonos1)
            Me.Controls.Add(Me.GridDocumentos1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.GridClientes1)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Name = "Clientes"
            Me.Text = "Clientes"
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.GridTelefonos1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridDocumentos1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridClientes1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
        Friend WithEvents GridClientes1 As Jupitech.WinApp.gridClientes
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GridDocumentos1 As Jupitech.WinApp.GridDocumentos
        Friend WithEvents GridTelefonos1 As Jupitech.WinApp.GridTelefonos
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
    End Class
End Namespace