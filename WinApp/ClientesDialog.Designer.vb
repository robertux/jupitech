Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ClientesDialog
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
            Me.TextBox1 = New System.Windows.Forms.TextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.TextBox2 = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.TextBox4 = New System.Windows.Forms.TextBox
            Me.btnagregar = New System.Windows.Forms.Button
            Me.btncancelar = New System.Windows.Forms.Button
            Me.ComboBox1 = New System.Windows.Forms.ComboBox
            Me.btnmodificar = New System.Windows.Forms.Button
            Me.btneliminar = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(114, 36)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(298, 20)
            Me.TextBox1.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(59, 39)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Nombre:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(59, 92)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(52, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Apellidos:"
            '
            'TextBox2
            '
            Me.TextBox2.Location = New System.Drawing.Point(114, 89)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(298, 20)
            Me.TextBox2.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(59, 144)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(43, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Estado:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(59, 197)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(55, 13)
            Me.Label4.TabIndex = 7
            Me.Label4.Text = "Direccion:"
            '
            'TextBox4
            '
            Me.TextBox4.Location = New System.Drawing.Point(114, 194)
            Me.TextBox4.Multiline = True
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Size = New System.Drawing.Size(298, 80)
            Me.TextBox4.TabIndex = 6
            '
            'btnagregar
            '
            Me.btnagregar.Location = New System.Drawing.Point(114, 280)
            Me.btnagregar.Name = "btnagregar"
            Me.btnagregar.Size = New System.Drawing.Size(75, 23)
            Me.btnagregar.TabIndex = 8
            Me.btnagregar.Text = "Agregar"
            Me.btnagregar.UseVisualStyleBackColor = True
            '
            'btncancelar
            '
            Me.btncancelar.Location = New System.Drawing.Point(337, 280)
            Me.btncancelar.Name = "btncancelar"
            Me.btncancelar.Size = New System.Drawing.Size(75, 23)
            Me.btncancelar.TabIndex = 9
            Me.btncancelar.Text = "Cancelar"
            Me.btncancelar.UseVisualStyleBackColor = True
            '
            'ComboBox1
            '
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Items.AddRange(New Object() {"A tiempo", "Inactivo", "Moroso"})
            Me.ComboBox1.Location = New System.Drawing.Point(114, 141)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(134, 21)
            Me.ComboBox1.TabIndex = 10
            '
            'btnmodificar
            '
            Me.btnmodificar.Location = New System.Drawing.Point(114, 280)
            Me.btnmodificar.Name = "btnmodificar"
            Me.btnmodificar.Size = New System.Drawing.Size(114, 23)
            Me.btnmodificar.TabIndex = 11
            Me.btnmodificar.Text = "Aceptar"
            Me.btnmodificar.UseVisualStyleBackColor = True
            '
            'btneliminar
            '
            Me.btneliminar.Location = New System.Drawing.Point(114, 280)
            Me.btneliminar.Name = "btneliminar"
            Me.btneliminar.Size = New System.Drawing.Size(124, 23)
            Me.btneliminar.TabIndex = 14
            Me.btneliminar.Text = "Aceptar"
            Me.btneliminar.UseVisualStyleBackColor = True
            '
            'ClientesDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(489, 335)
            Me.Controls.Add(Me.btneliminar)
            Me.Controls.Add(Me.btnmodificar)
            Me.Controls.Add(Me.ComboBox1)
            Me.Controls.Add(Me.btncancelar)
            Me.Controls.Add(Me.btnagregar)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.TextBox4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TextBox2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TextBox1)
            Me.Name = "ClientesDialog"
            Me.Text = "ClientesDialog"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
        Friend WithEvents btnagregar As System.Windows.Forms.Button
        Friend WithEvents btncancelar As System.Windows.Forms.Button
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
        Friend WithEvents btnmodificar As System.Windows.Forms.Button
        Friend WithEvents btneliminar As System.Windows.Forms.Button
    End Class
End Namespace