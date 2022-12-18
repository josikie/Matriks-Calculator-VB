Public Class Form4
    Dim txtBx1 As Integer = 0
    Dim txtBx2 As Integer = 0
    Dim txtBx3 As Integer = 0
    Dim txtBx4 As Integer = 0

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

    Private Sub ButtonLookingMinor2_Click(sender As Object, e As EventArgs) Handles btnLookingMinor2.Click
        txtBox5.Text = txtBx4.ToString()
        txtBox6.Text = txtBx3.ToString()
        txtBox7.Text = txtBx2.ToString()
        txtBox8.Text = txtBx1.ToString()
    End Sub

    Private Sub Button2Clean2_Click(sender As Object, e As EventArgs) Handles btn2Clean2.Click
        txtBx1 = 0
        txtBx2 = 0
        txtBx3 = 0
        txtBx4 = 0

        txtBox1.Text = ""
        txtBox2.Text = ""
        txtBox3.Text = ""
        txtBox4.Text = ""
        txtBox5.Text = ""
        txtBox6.Text = ""
        txtBox7.Text = ""
        txtBox8.Text = ""

    End Sub

    Private Sub Button2Back2_Click(sender As Object, e As EventArgs) Handles btn2Back2.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

End Class