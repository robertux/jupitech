Namespace WinApp
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class abonos
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
            Me.Gridabonos1 = New Jupitech.gridabonos
            Me.Label1 = New System.Windows.Forms.Label
            CType(Me.Gridabonos1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Gridabonos1
            '
            Me.Gridabonos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Gridabonos1.Location = New System.Drawing.Point(12, 63)
            Me.Gridabonos1.Name = "Gridabonos1"
            Me.Gridabonos1.Size = New System.Drawing.Size(608, 140)
            Me.Gridabonos1.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 47)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(46, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Abonos "
            '
            'abonos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(654, 266)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Gridabonos1)
            Me.Name = "abonos"
            Me.Text = "abonos"
            CType(Me.Gridabonos1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Gridabonos1 As Jupitech.gridabonos
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace
