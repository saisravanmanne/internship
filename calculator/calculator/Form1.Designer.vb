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
        Me.datechooser = New System.Windows.Forms.DateTimePicker()
        Me.lab1 = New System.Windows.Forms.Label()
        Me.dateno = New System.Windows.Forms.TextBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'datechooser
        '
        Me.datechooser.Location = New System.Drawing.Point(89, 92)
        Me.datechooser.Name = "datechooser"
        Me.datechooser.Size = New System.Drawing.Size(200, 20)
        Me.datechooser.TabIndex = 1
        '
        'lab1
        '
        Me.lab1.AutoSize = True
        Me.lab1.Location = New System.Drawing.Point(86, 40)
        Me.lab1.Name = "lab1"
        Me.lab1.Size = New System.Drawing.Size(39, 13)
        Me.lab1.TabIndex = 2
        Me.lab1.Text = "Label1"
        '
        'dateno
        '
        Me.dateno.Location = New System.Drawing.Point(95, 147)
        Me.dateno.Name = "dateno"
        Me.dateno.Size = New System.Drawing.Size(96, 20)
        Me.dateno.TabIndex = 3
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 203)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(545, 22)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(58, 17)
        Me.ToolStripStatusLabel1.Text = "data lable"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel2.Text = "user label"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 225)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.dateno)
        Me.Controls.Add(Me.lab1)
        Me.Controls.Add(Me.datechooser)
        Me.Name = "Form1"
        Me.Text = "date calculator"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents datechooser As System.Windows.Forms.DateTimePicker





    Private Sub datechooser_ValueChanged(sender As Object, e As EventArgs) Handles datechooser.ValueChanged
        Dim data As String = 7
        If dateno.Text > 0 Then
            data = dateno.Text
            lab1.Text = datechooser.Value.AddDays(data)
        Else
            lab1.Text = datechooser.Value.AddDays(data)
            End



        End If


    End Sub
    Friend WithEvents lab1 As System.Windows.Forms.Label
    Friend WithEvents dateno As System.Windows.Forms.TextBox

    Private Sub dateno_TextChanged(sender As Object, e As EventArgs) Handles dateno.TextChanged

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub lab1_Click(sender As Object, e As EventArgs) Handles lab1.Click

    End Sub
End Class
