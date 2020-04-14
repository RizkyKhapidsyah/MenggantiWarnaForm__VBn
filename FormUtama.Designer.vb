<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTampilkanWarna = New System.Windows.Forms.Button()
        Me.btnKembalikanWarna = New System.Windows.Forms.Button()
        Me.dlgWarna = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'btnTampilkanWarna
        '
        Me.btnTampilkanWarna.Location = New System.Drawing.Point(12, 197)
        Me.btnTampilkanWarna.Name = "btnTampilkanWarna"
        Me.btnTampilkanWarna.Size = New System.Drawing.Size(107, 37)
        Me.btnTampilkanWarna.TabIndex = 0
        Me.btnTampilkanWarna.Text = "Button1"
        Me.btnTampilkanWarna.UseVisualStyleBackColor = True
        '
        'btnKembalikanWarna
        '
        Me.btnKembalikanWarna.Location = New System.Drawing.Point(287, 197)
        Me.btnKembalikanWarna.Name = "btnKembalikanWarna"
        Me.btnKembalikanWarna.Size = New System.Drawing.Size(107, 37)
        Me.btnKembalikanWarna.TabIndex = 1
        Me.btnKembalikanWarna.Text = "Button2"
        Me.btnKembalikanWarna.UseVisualStyleBackColor = True
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 246)
        Me.Controls.Add(Me.btnKembalikanWarna)
        Me.Controls.Add(Me.btnTampilkanWarna)
        Me.Name = "FormUtama"
        Me.Text = "Mengganti Warna Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTampilkanWarna As Button
    Friend WithEvents btnKembalikanWarna As Button
    Friend WithEvents dlgWarna As ColorDialog
End Class
