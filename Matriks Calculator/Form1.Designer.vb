<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMatriks2 = New System.Windows.Forms.Button()
        Me.btnMatriks3 = New System.Windows.Forms.Button()
        Me.lbl1FirstPage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMatriks2
        '
        Me.btnMatriks2.BackColor = System.Drawing.Color.LightPink
        Me.btnMatriks2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatriks2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMatriks2.Location = New System.Drawing.Point(212, 147)
        Me.btnMatriks2.Name = "btnMatriks2"
        Me.btnMatriks2.Size = New System.Drawing.Size(167, 37)
        Me.btnMatriks2.TabIndex = 0
        Me.btnMatriks2.Text = "Matriks 2 x 2"
        Me.btnMatriks2.UseVisualStyleBackColor = False
        '
        'btnMatriks3
        '
        Me.btnMatriks3.BackColor = System.Drawing.Color.LightPink
        Me.btnMatriks3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatriks3.Location = New System.Drawing.Point(212, 213)
        Me.btnMatriks3.Name = "btnMatriks3"
        Me.btnMatriks3.Size = New System.Drawing.Size(167, 36)
        Me.btnMatriks3.TabIndex = 1
        Me.btnMatriks3.Text = "Matriks 3 x 3"
        Me.btnMatriks3.UseVisualStyleBackColor = False
        '
        'lbl1FirstPage
        '
        Me.lbl1FirstPage.AutoSize = True
        Me.lbl1FirstPage.Font = New System.Drawing.Font("Tempus Sans ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1FirstPage.Location = New System.Drawing.Point(171, 57)
        Me.lbl1FirstPage.Name = "lbl1FirstPage"
        Me.lbl1FirstPage.Size = New System.Drawing.Size(256, 38)
        Me.lbl1FirstPage.TabIndex = 2
        Me.lbl1FirstPage.Text = "Matriks Calculator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(616, 351)
        Me.Controls.Add(Me.lbl1FirstPage)
        Me.Controls.Add(Me.btnMatriks3)
        Me.Controls.Add(Me.btnMatriks2)
        Me.Name = "Form1"
        Me.Text = "Matriks Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMatriks2 As Button
    Friend WithEvents btnMatriks3 As Button
    Friend WithEvents lbl1FirstPage As Label

    Private Sub ButtonMatriks2_Click(sender As Object, e As EventArgs) Handles btnMatriks2.Click
        Me.Visible = False
        Form2.Visible = True

    End Sub

    Private Sub ButtonMatriks3_Click(sender As Object, e As EventArgs) Handles btnMatriks3.Click
        Me.Visible = False
        Form7.Visible = True
    End Sub
End Class
