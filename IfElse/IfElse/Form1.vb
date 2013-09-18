Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, LargerNum As Double
        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)
        If (num1 > num2) Then

            txtResult.Text = "The larger number is " & num1


        ElseIf (num2 > num1) Then

            txtResult.Text = "The larger number is " & num2
        Else
            txtResult.Text = "The two are equal"
        End If


    End Sub
End Class
