Public Class Form7
    Private Sub ButtonBack2_Click(sender As Object, e As EventArgs) Handles ButtonBack2.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub ButtonCounting_Click(sender As Object, e As EventArgs) Handles ButtonCounting.Click
        Me.Visible = False
        Form8.Visible = True
    End Sub

    Private Sub ButtonXValue_Click(sender As Object, e As EventArgs) Handles ButtonXValue.Click
        Me.Visible = False
        Form11.Visible = True
    End Sub

    Private Sub ButtonMinor_Click(sender As Object, e As EventArgs) Handles ButtonMinor.Click
        Me.Visible = False
        Form9.Visible = True
    End Sub

    Private Sub ButtonKofaktor_Click(sender As Object, e As EventArgs) Handles ButtonKofaktor.Click
        Me.Visible = False
        Form10.Visible = True
    End Sub
End Class