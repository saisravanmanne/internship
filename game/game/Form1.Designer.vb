<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ptiles = New System.Windows.Forms.PictureBox()
        CType(Me.ptiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptiles
        '
        Me.ptiles.Image = Global.game.My.Resources.Resources.cartoon_vector_ninja_155010410
        Me.ptiles.Location = New System.Drawing.Point(585, 12)
        Me.ptiles.Name = "ptiles"
        Me.ptiles.Size = New System.Drawing.Size(161, 158)
        Me.ptiles.TabIndex = 0
        Me.ptiles.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 421)
        Me.Controls.Add(Me.ptiles)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.ptiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptiles As System.Windows.Forms.PictureBox

End Class
