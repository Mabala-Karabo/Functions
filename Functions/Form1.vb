Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer
        result = addFunction(txtNum1.Text, txtNum2.Text)
        MsgBox("The sum is " & result)
    End Sub

    Private Function addFunction(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim sum As Integer
        sum = a + b
        Return sum
    End Function
End Class
