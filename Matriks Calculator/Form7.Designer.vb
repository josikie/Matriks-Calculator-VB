<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label1SecondPage = New System.Windows.Forms.Label()
        Me.ButtonBack2 = New System.Windows.Forms.Button()
        Me.ButtonKofaktor = New System.Windows.Forms.Button()
        Me.ButtonXValue = New System.Windows.Forms.Button()
        Me.ButtonMinor = New System.Windows.Forms.Button()
        Me.ButtonCounting = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1SecondPage
        '
        Me.Label1SecondPage.AutoSize = True
        Me.Label1SecondPage.Font = New System.Drawing.Font("Tempus Sans ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1SecondPage.Location = New System.Drawing.Point(171, 29)
        Me.Label1SecondPage.Name = "Label1SecondPage"
        Me.Label1SecondPage.Size = New System.Drawing.Size(183, 38)
        Me.Label1SecondPage.TabIndex = 13
        Me.Label1SecondPage.Text = "Matriks 3 x 3"
        '
        'ButtonBack2
        '
        Me.ButtonBack2.BackColor = System.Drawing.Color.LightPink
        Me.ButtonBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBack2.Location = New System.Drawing.Point(218, 258)
        Me.ButtonBack2.Name = "ButtonBack2"
        Me.ButtonBack2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonBack2.Size = New System.Drawing.Size(79, 35)
        Me.ButtonBack2.TabIndex = 12
        Me.ButtonBack2.Text = "Kembali"
        Me.ButtonBack2.UseVisualStyleBackColor = False
        '
        'ButtonKofaktor
        '
        Me.ButtonKofaktor.BackColor = System.Drawing.Color.LightPink
        Me.ButtonKofaktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonKofaktor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonKofaktor.Location = New System.Drawing.Point(275, 168)
        Me.ButtonKofaktor.Name = "ButtonKofaktor"
        Me.ButtonKofaktor.Size = New System.Drawing.Size(186, 35)
        Me.ButtonKofaktor.TabIndex = 11
        Me.ButtonKofaktor.Text = "Mencari Kofaktor Matriks"
        Me.ButtonKofaktor.UseVisualStyleBackColor = False
        '
        'ButtonXValue
        '
        Me.ButtonXValue.BackColor = System.Drawing.Color.LightPink
        Me.ButtonXValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonXValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonXValue.Location = New System.Drawing.Point(275, 109)
        Me.ButtonXValue.Name = "ButtonXValue"
        Me.ButtonXValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonXValue.Size = New System.Drawing.Size(186, 35)
        Me.ButtonXValue.TabIndex = 10
        Me.ButtonXValue.Text = "Mencari Nilai X"
        Me.ButtonXValue.UseVisualStyleBackColor = False
        '
        'ButtonMinor
        '
        Me.ButtonMinor.BackColor = System.Drawing.Color.LightPink
        Me.ButtonMinor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMinor.Location = New System.Drawing.Point(55, 168)
        Me.ButtonMinor.Name = "ButtonMinor"
        Me.ButtonMinor.Size = New System.Drawing.Size(186, 35)
        Me.ButtonMinor.TabIndex = 9
        Me.ButtonMinor.Text = "Mencari Minor Matriks"
        Me.ButtonMinor.UseVisualStyleBackColor = False
        '
        'ButtonCounting
        '
        Me.ButtonCounting.BackColor = System.Drawing.Color.LightPink
        Me.ButtonCounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCounting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonCounting.Location = New System.Drawing.Point(55, 109)
        Me.ButtonCounting.Name = "ButtonCounting"
        Me.ButtonCounting.Size = New System.Drawing.Size(186, 35)
        Me.ButtonCounting.TabIndex = 8
        Me.ButtonCounting.Text = "Penjumlahan Matriks"
        Me.ButtonCounting.UseVisualStyleBackColor = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(516, 323)
        Me.Controls.Add(Me.Label1SecondPage)
        Me.Controls.Add(Me.ButtonBack2)
        Me.Controls.Add(Me.ButtonKofaktor)
        Me.Controls.Add(Me.ButtonXValue)
        Me.Controls.Add(Me.ButtonMinor)
        Me.Controls.Add(Me.ButtonCounting)
        Me.Name = "Form7"
        Me.Text = "Matriks 3 x 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1SecondPage As Label
    Friend WithEvents ButtonBack2 As Button
    Friend WithEvents ButtonKofaktor As Button
    Friend WithEvents ButtonXValue As Button
    Friend WithEvents ButtonMinor As Button
    Friend WithEvents ButtonCounting As Button
End Class
