Public Class Form3
    Dim txtBxFirstFirstMatriks As Integer = 0
    Dim txtBxSecondFirstMatriks As Integer = 0
    Dim txtBxThirdFirstMatriks As Integer = 0
    Dim txtBxFourthFirstMatriks As Integer = 0
    Dim arithmeticSign = ""
    Dim txtBxFirstSecondMatriks As Integer = 0
    Dim txtBxSecondSecondMatriks As Integer = 0
    Dim txtBxThirdSecondMatriks As Integer = 0
    Dim txtBxFourthSecondMatriks As Integer = 0

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBx1.TextChanged
        Dim fstBox = txtBx1.Text
        txtBxFirstFirstMatriks = Val(fstBox)
    End Sub

    Private Sub TxtBx2_TextChanged(sender As Object, e As EventArgs) Handles txtBx2.TextChanged
        Dim scdBox = txtBx2.Text
        txtBxSecondFirstMatriks = Val(scdBox)
    End Sub

    Private Sub TxtBx3_TextChanged(sender As Object, e As EventArgs) Handles txtBx3.TextChanged
        Dim thrdBox = txtBx3.Text
        txtBxThirdFirstMatriks = Val(thrdBox)
    End Sub

    Private Sub TxtBx4_TextChanged(sender As Object, e As EventArgs) Handles txtBx4.TextChanged
        Dim frthBox = txtBx4.Text
        txtBxFourthFirstMatriks = Val(frthBox)
    End Sub

    Private Sub TxtBx5_TextChanged(sender As Object, e As EventArgs) Handles txtBx5.TextChanged
        Dim fifthBox = txtBx5.Text
        txtBxFirstSecondMatriks = Val(fifthBox)
    End Sub

    Private Sub TxtBx6_TextChanged(sender As Object, e As EventArgs) Handles txtBx6.TextChanged
        Dim sixthBox = txtBx6.Text
        txtBxSecondSecondMatriks = Val(sixthBox)
    End Sub

    Private Sub TxtBx7_TextChanged(sender As Object, e As EventArgs) Handles txtBx7.TextChanged
        Dim seventhBox = txtBx7.Text
        txtBxThirdSecondMatriks = Val(seventhBox)
    End Sub

    Private Sub TxtBx8_TextChanged(sender As Object, e As EventArgs) Handles txtBx8.TextChanged
        Dim eightBox = txtBx8.Text
        txtBxFourthSecondMatriks = Val(eightBox)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBox1.SelectedIndexChanged
        arithmeticSign = cmbBox1.SelectedItem.ToString()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If arithmeticSign.Equals("+") Then
            Dim txtBxResult1 = txtBxFirstFirstMatriks + txtBxFirstSecondMatriks
            Dim txtBxResult2 = txtBxSecondFirstMatriks + txtBxSecondSecondMatriks
            Dim txtBxResult3 = txtBxThirdFirstMatriks + txtBxThirdSecondMatriks
            Dim txtBxResult4 = txtBxFourthFirstMatriks + txtBxFourthSecondMatriks
            txtBx9.Text = txtBxResult1.ToString()
            txtBx10.Text = txtBxResult2.ToString()
            txtBx11.Text = txtBxResult3.ToString()
            txtBx12.Text = txtBxResult4.ToString()
        End If

        If arithmeticSign.Equals("-") Then
            Dim txtBxResult1 = txtBxFirstFirstMatriks - txtBxFirstSecondMatriks
            Dim txtBxResult2 = txtBxSecondFirstMatriks - txtBxSecondSecondMatriks
            Dim txtBxResult3 = txtBxThirdFirstMatriks - txtBxThirdSecondMatriks
            Dim txtBxResult4 = txtBxFourthFirstMatriks - txtBxFourthSecondMatriks
            txtBx9.Text = txtBxResult1.ToString()
            txtBx10.Text = txtBxResult2.ToString()
            txtBx11.Text = txtBxResult3.ToString()
            txtBx12.Text = txtBxResult4.ToString()
        End If

        If arithmeticSign.Equals("x") Then
            Dim stRowStColumn1 As Integer = txtBxFirstFirstMatriks * txtBxFirstSecondMatriks
            Dim stRowStColumn2 As Integer = txtBxSecondFirstMatriks * txtBxThirdSecondMatriks
            Dim stRowSndColumn1 As Integer = txtBxFirstFirstMatriks * txtBxSecondSecondMatriks
            Dim stRowSndColumn2 As Integer = txtBxSecondFirstMatriks * txtBxFourthSecondMatriks
            Dim sndRowStColumn1 As Integer = txtBxThirdFirstMatriks * txtBxFirstSecondMatriks
            Dim sndRowStColumn2 As Integer = txtBxFourthFirstMatriks * txtBxThirdSecondMatriks
            Dim sndRowSndColumn1 As Integer = txtBxThirdFirstMatriks * txtBxSecondSecondMatriks
            Dim sndRowSndColumn2 As Integer = txtBxFourthFirstMatriks * txtBxFourthSecondMatriks

            Dim txtBxResult1 = stRowStColumn1 + stRowStColumn2
            Dim txtBxResult2 = stRowSndColumn1 + stRowSndColumn2
            Dim txtBxResult3 = sndRowStColumn1 + sndRowStColumn2
            Dim txtBxResult4 = sndRowSndColumn1 + sndRowSndColumn2
            txtBx9.Text = txtBxResult1.ToString()
            txtBx10.Text = txtBxResult2.ToString()
            txtBx11.Text = txtBxResult3.ToString()
            txtBx12.Text = txtBxResult4.ToString()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn2Clean1.Click
        txtBxFirstFirstMatriks = 0
        txtBxFirstSecondMatriks = 0
        txtBxSecondSecondMatriks = 0
        txtBxSecondFirstMatriks = 0
        txtBxThirdFirstMatriks = 0
        txtBxThirdSecondMatriks = 0
        txtBxFourthSecondMatriks = 0
        txtBxFourthFirstMatriks = 0

        txtBx1.Text = ""
        txtBx2.Text = ""
        txtBx3.Text = ""
        txtBx4.Text = ""
        txtBx5.Text = ""
        txtBx6.Text = ""
        txtBx7.Text = ""
        txtBx8.Text = ""
        txtBx9.Text = ""
        txtBx10.Text = ""
        txtBx11.Text = ""
        txtBx12.Text = ""
    End Sub

    Private Sub Button2Back1_Click(sender As Object, e As EventArgs) Handles btn2Back1.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

End Class