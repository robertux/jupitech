Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Proveedores
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.btnAddDoc = New System.Windows.Forms.Button
            Me.btnDelDoc = New System.Windows.Forms.Button
            Me.btnDelTel = New System.Windows.Forms.Button
            Me.btnAddTel = New System.Windows.Forms.Button
            Me.GridTelefonos1 = New Jupitech.WinApp.GridTelefonos
            Me.GridDocumentos1 = New Jupitech.WinApp.GridDocumentos
            Me.Gridproveedores1 = New Jupitech.WinApp.gridproveedores
            Me.ToolStrip1.SuspendLayout()
            CType(Me.GridTelefonos1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridDocumentos1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Gridproveedores1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(728, 25)
            Me.ToolStrip1.TabIndex = 1
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
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(60, 283)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(100, 20)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Documentos"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(418, 283)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(79, 20)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Teléfonos"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(60, 31)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(98, 20)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Proveedores"
            '
            'btnAddDoc
            '
            Me.btnAddDoc.Location = New System.Drawing.Point(64, 459)
            Me.btnAddDoc.Name = "btnAddDoc"
            Me.btnAddDoc.Size = New System.Drawing.Size(75, 23)
            Me.btnAddDoc.TabIndex = 7
            Me.btnAddDoc.Text = "Agregar"
            Me.btnAddDoc.UseVisualStyleBackColor = True
            '
            'btnDelDoc
            '
            Me.btnDelDoc.Location = New System.Drawing.Point(145, 459)
            Me.btnDelDoc.Name = "btnDelDoc"
            Me.btnDelDoc.Size = New System.Drawing.Size(75, 23)
            Me.btnDelDoc.TabIndex = 9
            Me.btnDelDoc.Text = "Eliminar"
            Me.btnDelDoc.UseVisualStyleBackColor = True
            '
            'btnDelTel
            '
            Me.btnDelTel.Location = New System.Drawing.Point(503, 463)
            Me.btnDelTel.Name = "btnDelTel"
            Me.btnDelTel.Size = New System.Drawing.Size(75, 23)
            Me.btnDelTel.TabIndex = 12
            Me.btnDelTel.Text = "Eliminar"
            Me.btnDelTel.UseVisualStyleBackColor = True
            '
            'btnAddTel
            '
            Me.btnAddTel.Location = New System.Drawing.Point(422, 463)
            Me.btnAddTel.Name = "btnAddTel"
            Me.btnAddTel.Size = New System.Drawing.Size(75, 23)
            Me.btnAddTel.TabIndex = 10
            Me.btnAddTel.Text = "Agregar"
            Me.btnAddTel.UseVisualStyleBackColor = True
            '
            'GridTelefonos1
            '
            Me.GridTelefonos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.GridTelefonos1.Location = New System.Drawing.Point(422, 307)
            Me.GridTelefonos1.Name = "GridTelefonos1"
            Me.GridTelefonos1.Size = New System.Drawing.Size(240, 150)
            Me.GridTelefonos1.TabIndex = 3
            '
            'GridDocumentos1
            '
            Me.GridDocumentos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.GridDocumentos1.Location = New System.Drawing.Point(64, 307)
            Me.GridDocumentos1.Name = "GridDocumentos1"
            Me.GridDocumentos1.Size = New System.Drawing.Size(247, 150)
            Me.GridDocumentos1.TabIndex = 2
            '
            'Gridproveedores1
            '
            Me.Gridproveedores1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Gridproveedores1.Location = New System.Drawing.Point(64, 55)
            Me.Gridproveedores1.Name = "Gridproveedores1"
            Me.Gridproveedores1.Size = New System.Drawing.Size(598, 169)
            Me.Gridproveedores1.TabIndex = 0
            '
            'Proveedores
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(728, 494)
            Me.Controls.Add(Me.btnDelTel)
            Me.Controls.Add(Me.btnAddTel)
            Me.Controls.Add(Me.btnDelDoc)
            Me.Controls.Add(Me.btnAddDoc)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.GridTelefonos1)
            Me.Controls.Add(Me.GridDocumentos1)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.Gridproveedores1)
            Me.Name = "Proveedores"
            Me.Text = "Proveedores"
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.GridTelefonos1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridDocumentos1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Gridproveedores1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Gridproveedores1 As Jupitech.WinApp.gridproveedores
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
        Friend WithEvents GridDocumentos1 As Jupitech.WinApp.GridDocumentos
        Friend WithEvents GridTelefonos1 As Jupitech.WinApp.GridTelefonos
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnAddDoc As System.Windows.Forms.Button
        Friend WithEvents btnDelDoc As System.Windows.Forms.Button
        Friend WithEvents btnDelTel As System.Windows.Forms.Button
        Friend WithEvents btnAddTel As System.Windows.Forms.Button
    End Class
End Namespace
