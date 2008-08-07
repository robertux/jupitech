Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ProveedorDialog
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
            Me.Button1 = New System.Windows.Forms.Button
            Me.btncancelar = New System.Windows.Forms.Button
            Me.Label1 = New System.Windows.Forms.Label
            Me.TextBox1 = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.TextBox2 = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.TextBox3 = New System.Windows.Forms.TextBox
            Me.ComboBox1 = New System.Windows.Forms.ComboBox
            Me.Button3 = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(130, 308)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Agregar"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'btncancelar
            '
            Me.btncancelar.Location = New System.Drawing.Point(326, 308)
            Me.btncancelar.Name = "btncancelar"
            Me.btncancelar.Size = New System.Drawing.Size(75, 23)
            Me.btncancelar.TabIndex = 1
            Me.btncancelar.Text = "Cancelar"
            Me.btncancelar.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(69, 30)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Nombre:"
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(132, 23)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(269, 20)
            Me.TextBox1.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(69, 80)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(52, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Apellidos:"
            '
            'TextBox2
            '
            Me.TextBox2.Location = New System.Drawing.Point(132, 73)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(269, 20)
            Me.TextBox2.TabIndex = 5
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(69, 129)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(31, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Tipo:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(69, 177)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(55, 13)
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "Dirección:"
            '
            'TextBox3
            '
            Me.TextBox3.Location = New System.Drawing.Point(132, 170)
            Me.TextBox3.Multiline = True
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(269, 117)
            Me.TextBox3.TabIndex = 10
            '
            'ComboBox1
            '
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Items.AddRange(New Object() {"Nacional", "Extranjero"})
            Me.ComboBox1.Location = New System.Drawing.Point(132, 121)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
            Me.ComboBox1.TabIndex = 11
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(130, 308)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(124, 23)
            Me.Button3.TabIndex = 12
            Me.Button3.Text = "Aceptar"
            Me.Button3.UseVisualStyleBackColor = True
            '
            'ProveedorDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(481, 346)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.ComboBox1)
            Me.Controls.Add(Me.TextBox3)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TextBox2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btncancelar)
            Me.Controls.Add(Me.Button1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ProveedorDialog"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents btncancelar As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
        Friend WithEvents Button3 As System.Windows.Forms.Button
    End Class
End Namespace
