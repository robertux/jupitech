Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Vendedores
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendedores))
            Me.Label3 = New System.Windows.Forms.Label
            Me.Gridvendedores1 = New Jupitech.WinApp.gridvendedores
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
            CType(Me.Gridvendedores1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(27, 31)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(96, 20)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Vendedores"
            '
            'Gridvendedores1
            '
            Me.Gridvendedores1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Gridvendedores1.Location = New System.Drawing.Point(12, 56)
            Me.Gridvendedores1.Name = "Gridvendedores1"
            Me.Gridvendedores1.Size = New System.Drawing.Size(601, 449)
            Me.Gridvendedores1.TabIndex = 0
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(624, 25)
            Me.ToolStrip1.TabIndex = 21
            Me.ToolStrip1.Text = "Eliminar"
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
            'Vendedores
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 517)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Gridvendedores1)
            Me.Name = "Vendedores"
            Me.Text = "Vendedores"
            CType(Me.Gridvendedores1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Gridvendedores1 As Jupitech.WinApp.gridvendedores
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    End Class
End Namespace