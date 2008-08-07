Namespace WinApp

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Compras
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compras))
            Me.lbl = New System.Windows.Forms.Label
            Me.btncargos = New System.Windows.Forms.Button
            Me.lbltotal = New System.Windows.Forms.Label
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.Label1 = New System.Windows.Forms.Label
            Me.Griditemscompra1 = New Jupitech.griditemscompra
            Me.Gridcompras1 = New Jupitech.gridcompras
            Me.ToolStrip1.SuspendLayout()
            CType(Me.Griditemscompra1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Gridcompras1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lbl
            '
            Me.lbl.AutoSize = True
            Me.lbl.Location = New System.Drawing.Point(274, 328)
            Me.lbl.Name = "lbl"
            Me.lbl.Size = New System.Drawing.Size(31, 13)
            Me.lbl.TabIndex = 2
            Me.lbl.Text = "Total"
            '
            'btncargos
            '
            Me.btncargos.Location = New System.Drawing.Point(535, 270)
            Me.btncargos.Name = "btncargos"
            Me.btncargos.Size = New System.Drawing.Size(75, 23)
            Me.btncargos.TabIndex = 3
            Me.btncargos.Text = "Cargos"
            Me.btncargos.UseVisualStyleBackColor = True
            '
            'lbltotal
            '
            Me.lbltotal.AutoSize = True
            Me.lbltotal.Location = New System.Drawing.Point(358, 328)
            Me.lbltotal.Name = "lbltotal"
            Me.lbltotal.Size = New System.Drawing.Size(0, 13)
            Me.lbltotal.TabIndex = 4
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(661, 25)
            Me.ToolStrip1.TabIndex = 5
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'ToolStripButton1
            '
            Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
            Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton1.Name = "ToolStripButton1"
            Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButton1.Text = "Agregar"
            Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 198)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(97, 13)
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "Items de la Compra"
            '
            'Griditemscompra1
            '
            Me.Griditemscompra1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Griditemscompra1.Location = New System.Drawing.Point(12, 214)
            Me.Griditemscompra1.Name = "Griditemscompra1"
            Me.Griditemscompra1.Size = New System.Drawing.Size(465, 102)
            Me.Griditemscompra1.TabIndex = 1
            Me.Griditemscompra1.total = 0
            '
            'Gridcompras1
            '
            Me.Gridcompras1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Gridcompras1.Location = New System.Drawing.Point(12, 59)
            Me.Gridcompras1.Name = "Gridcompras1"
            Me.Gridcompras1.Size = New System.Drawing.Size(465, 109)
            Me.Gridcompras1.TabIndex = 0
            '
            'Compras
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(661, 353)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.lbltotal)
            Me.Controls.Add(Me.btncargos)
            Me.Controls.Add(Me.lbl)
            Me.Controls.Add(Me.Griditemscompra1)
            Me.Controls.Add(Me.Gridcompras1)
            Me.Name = "Compras"
            Me.Text = "Compras"
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.Griditemscompra1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Gridcompras1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Gridcompras1 As Jupitech.gridcompras
        Friend WithEvents Griditemscompra1 As Jupitech.griditemscompra
        Friend WithEvents lbl As System.Windows.Forms.Label
        Friend WithEvents btncargos As System.Windows.Forms.Button
        Friend WithEvents lbltotal As System.Windows.Forms.Label
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace