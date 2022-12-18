<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnCounting = New System.Windows.Forms.Button()
        Me.btnMinor = New System.Windows.Forms.Button()
        Me.btnXValue = New System.Windows.Forms.Button()
        Me.btnKofaktor = New System.Windows.Forms.Button()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.lbl1SecondPage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCounting
        '
        Me.btnCounting.BackColor = System.Drawing.Color.LightPink
        Me.btnCounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCounting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCounting.Location = New System.Drawing.Point(52, 98)
        Me.btnCounting.Name = "btnCounting"
        Me.btnCounting.Size = New System.Drawing.Size(186, 35)
        Me.btnCounting.TabIndex = 0
        Me.btnCounting.Text = "Perhitungan Matriks"
        Me.btnCounting.UseVisualStyleBackColor = False
        '
        'btnMinor
        '
        Me.btnMinor.BackColor = System.Drawing.Color.LightPink
        Me.btnMinor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMinor.Location = New System.Drawing.Point(52, 157)
        Me.btnMinor.Name = "btnMinor"
        Me.btnMinor.Size = New System.Drawing.Size(186, 35)
        Me.btnMinor.TabIndex = 1
        Me.btnMinor.Text = "Mencari Minor Matriks"
        Me.btnMinor.UseVisualStyleBackColor = False
        '
        'btnXValue
        '
        Me.btnXValue.BackColor = System.Drawing.Color.LightPink
        Me.btnXValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnXValue.Location = New System.Drawing.Point(272, 98)
        Me.btnXValue.Name = "btnXValue"
        Me.btnXValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnXValue.Size = New System.Drawing.Size(186, 35)
        Me.btnXValue.TabIndex = 3
        Me.btnXValue.Text = "Mencari Nilai X"
        Me.btnXValue.UseVisualStyleBackColor = False
        '
        'btnKofaktor
        '
        Me.btnKofaktor.BackColor = System.Drawing.Color.LightPink
        Me.btnKofaktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKofaktor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnKofaktor.Location = New System.Drawing.Point(272, 157)
        Me.btnKofaktor.Name = "btnKofaktor"
        Me.btnKofaktor.Size = New System.Drawing.Size(186, 35)
        Me.btnKofaktor.TabIndex = 5
        Me.btnKofaktor.Text = "Mencari Kofaktor Matriks"
        Me.btnKofaktor.UseVisualStyleBackColor = False
        '
        'btnBack2
        '
        Me.btnBack2.BackColor = System.Drawing.Color.LightPink
        Me.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack2.Location = New System.Drawing.Point(215, 247)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBack2.Size = New System.Drawing.Size(79, 35)
        Me.btnBack2.TabIndex = 6
        Me.btnBack2.Text = "Kembali"
        Me.btnBack2.UseVisualStyleBackColor = False
        '
        'lbl1SecondPage
        '
        Me.lbl1SecondPage.AutoSize = True
        Me.lbl1SecondPage.Font = New System.Drawing.Font("Tempus Sans ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1SecondPage.Location = New System.Drawing.Point(168, 18)
        Me.lbl1SecondPage.Name = "lbl1SecondPage"
        Me.lbl1SecondPage.Size = New System.Drawing.Size(187, 38)
        Me.lbl1SecondPage.TabIndex = 7
        Me.lbl1SecondPage.Text = "Matriks 2 x 2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(541, 312)
        Me.Controls.Add(Me.lbl1SecondPage)
        Me.Controls.Add(Me.btnBack2)
        Me.Controls.Add(Me.btnKofaktor)
        Me.Controls.Add(Me.btnXValue)
        Me.Controls.Add(Me.btnMinor)
        Me.Controls.Add(Me.btnCounting)
        Me.Name = "Form2"
        Me.Text = "Matriks 2 x 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCounting As Button
    Friend WithEvents btnMinor As Button
    Friend WithEvents btnXValue As Button
    Friend WithEvents btnKofaktor As Button
    Friend WithEvents btnBack2 As Button
    Friend WithEvents lbl1SecondPage As Label
End Class
