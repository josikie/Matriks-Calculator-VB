Public Class Form5
    Dim txtBx1 As Integer = 0
    Dim txtBx2 As Integer = 0
    Dim txtBx3 As Integer = 0
    Dim txtBx4 As Integer = 0

    Private Sub Button2Back3_Click(sender As Object, e As EventArgs) Handles btn2Back3.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox1.TextChanged
        Dim txtBox1 = Me.txtBox1.Text
        txtBx1 = Val(txtBox1)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBox2.TextChanged
        Dim txtBox2 = Me.txtBox2.Text
        txtBx2 = Val(txtBox2)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtBox3.TextChanged
        Dim txtBox3 = Me.txtBox3.Text
        txtBx3 = Val(txtBox3)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtBox4.TextChanged
        Dim txtBox4 = Me.txtBox4.Text
        txtBx4 = Val(txtBox4)
    End Sub

    Private Sub ButtonLookingKofaktor2_Click(sender As Object, e As EventArgs) Handles btnLookingKofaktor2.Click
        Dim minorRow1Column1 = txtBx4
        Dim minorRow1Column2 = txtBx3
        Dim minorRow2Column1 = txtBx2
        Dim minorRow2Column2 = txtBx1

        Dim moduleTwoRow1Column1 = 2 Mod 2
        Dim moduleTwoRow1Column2 = 3 Mod 2
        Dim moduleTwoRow2Column1 = 3 Mod 2
        Dim moduleTwoRow2Column2 = 4 Mod 2

        Dim cofRow1Column1 = 0
        Dim cofRow1Column2 = 0
        Dim cofRow2Column1 = 0
        Dim cofRow2Column2 = 0

        If moduleTwoRow1Column1.Equals(1) Then
            cofRow1Column1 = -1 * minorRow1Column1
        Else
            cofRow1Column1 = 1 * minorRow1Column1
        End If

        If moduleTwoRow1Column2.Equals(1) Then
            cofRow1Column2 = -1 * minorRow1Column2
        Else
            cofRow1Column2 = 1 * minorRow1Column2
        End If

        If moduleTwoRow2Column1.Equals(1) Then
            cofRow2Column1 = -1 * minorRow2Column1
        Else
            cofRow2Column1 = 1 * minorRow2Column1
        End If

        If moduleTwoRow2Column2.Equals(1) Then
            cofRow2Column2 = -1 * minorRow2Column2
        Else
            cofRow2Column2 = 1 * minorRow2Column2
        End If

        txtBox5.Text = cofRow1Column1.ToString()
        txtBox6.Text = cofRow1Column2.ToString()
        txtBox7.Text = cofRow2Column1.ToString()
        txtBox8.Text = cofRow2Column2.ToString()

    End Sub

    Private Sub Button2clean3_Click(sender As Object, e As EventArgs) Handles btn2clean3.Click
        txtBox1.Text = ""
        txtBox2.Text = ""
        txtBox3.Text = ""
        txtBox4.Text = ""
        txtBox5.Text = ""
        txtBox6.Text = ""
        txtBox7.Text = ""
        txtBox8.Text = ""

        txtBx1 = 0
        txtBx2 = 0
        txtBx3 = 0
        txtBx4 = 0

    End Sub
End Class