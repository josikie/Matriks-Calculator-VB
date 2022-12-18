Public Class Form2
    Private Sub ButtonCounting_Click(sender As Object, e As EventArgs) Handles btnCounting.Click
        Me.Visible = False
        Form3.Visible = True
    End Sub

    Private Sub ButtonXValue_Click(sender As Object, e As EventArgs) Handles btnXValue.Click
        Me.Visible = False
        Form6.Visible = True
    End Sub

    Private Sub ButtonMinor_Click(sender As Object, e As EventArgs) Handles btnMinor.Click
        Me.Visible = False
        Form4.Visible = True
    End Sub

    Private Sub ButtonKofaktor_Click(sender As Object, e As EventArgs) Handles btnKofaktor.Click
        Me.Visible = False
        Form5.Visible = True
    End Sub

    Private Sub ButtonBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

End Class