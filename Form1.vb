Public Class Form1


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1, s2 As Integer
        Dim s As Double


        s1 = Val(TextBox1.Text)
        s2 = Val(TextBox2.Text)
        If RadioButton1.Checked = True Then
            s = s1 + s2
        ElseIf RadioButton2.Checked = True Then
            s = s1 - s2
        ElseIf RadioButton3.Checked = True Then
            s = s1 * s2
        ElseIf RadioButton4.Checked = True And s2 <> 0 Then
            s = s1 / s2
        End If
        Label1.Text = Str(s)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
