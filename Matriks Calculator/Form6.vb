Public Class Form6
    Dim txtBxFirst As Integer = 0
    Dim txtBxSecond As Integer = 0
    Dim txtBxThird As Integer = 0
    Dim txtBxFourth As Integer = 0
    Dim txtBxFifth As Integer = 0
    Dim txtBxSixth As Integer = 0

    Private Sub Button2Back4_Click(sender As Object, e As EventArgs) Handles btn2Back4.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox1.TextChanged
        Dim txtBox1Value = txtBox1.Text
        txtBxFirst = Val(txtBox1Value)
    End Sub

    Private Sub txtBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBox2.TextChanged
        Dim txtBox2Value = txtBox2.Text
        txtBxSecond = Val(txtBox2Value)
    End Sub

    Private Sub txtBox3_TextChanged(sender As Object, e As EventArgs) Handles txtBox3.TextChanged
        Dim txtBox3Value = txtBox3.Text
        txtBxThird = Val(txtBox3Value)
    End Sub

    Private Sub txtBox4_TextChanged(sender As Object, e As EventArgs) Handles txtBox4.TextChanged
        Dim txtBox4Value = txtBox4.Text
        txtBxFourth = Val(txtBox4Value)
    End Sub

    Private Sub txtBox5_TextChanged(sender As Object, e As EventArgs) Handles txtBox5.TextChanged
        Dim txtBox5Value = txtBox5.Text
        txtBxFifth = Val(txtBox5Value)
    End Sub

    Private Sub txtBox6_TextChanged(sender As Object, e As EventArgs) Handles txtBox6.TextChanged
        Dim txtBox6Value = txtBox6.Text
        txtBxSixth = Val(txtBox6Value)
    End Sub

    Private Sub btnLookingValueX2_Click(sender As Object, e As EventArgs) Handles btnLookingValueX2.Click
        Dim invers = (txtBxFirst * txtBxFourth) - (txtBxSecond * txtBxThird)
        Dim firstRowFirstColumn = txtBxFourth
        Dim firstRowSecondColumn = -1 * txtBxSecond
        Dim secondRowSecondColumn = txtBxFirst
        Dim secondRowFirstColumn = -1 * txtBxThird

        Dim result1 = txtBxFifth
        Dim result2 = txtBxSixth

        Dim inversFirstRowFirstColumn As Single = firstRowFirstColumn / invers
        Dim inversFirstRowSecondColumn As Single = firstRowSecondColumn / invers
        Dim inversSecondRowFirstColumn As Single = secondRowFirstColumn / invers
        Dim inversSecondRowSecondColumn As Single = secondRowSecondColumn / invers

        Dim x As Integer = (inversFirstRowFirstColumn * result1) + (inversFirstRowSecondColumn * result2)
        Dim y As Integer = (inversSecondRowFirstColumn * result1) + (inversSecondRowSecondColumn * result2)

        txtBox7.Text = x.ToString()
        txtBox8.Text = y.ToString()
    End Sub

    Private Sub btn2Clean4_Click(sender As Object, e As EventArgs) Handles btn2Clean4.Click
        txtBox1.Text = ""
        txtBox2.Text = ""
        txtBox3.Text = ""
        txtBox4.Text = ""
        txtBox5.Text = ""
        txtBox6.Text = ""
        txtBox7.Text = ""
        txtBox8.Text = ""

        txtBxFirst = 0
        txtBxSecond = 0
        txtBxThird = 0
        txtBxFourth = 0
        txtBxFifth = 0
        txtBxSixth = 0
    End Sub
End Class