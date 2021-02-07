Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Endd_Click(sender As Object, e As EventArgs) Handles Endd.Click
        End
    End Sub
    Function PrimalityFunction(ByVal p As Long) As Boolean
        Dim IsPrime As Boolean
        'Dim i As Long
        p = TextBox1.Text
        IsPrime = False
        'Dim i As Long = i
        Dim Result = Math.Pow(2, p)
        Dim Res2 = ((Result - 2) / p)
        If Res2 = Int(Res2) Then
            IsPrime = True
        Else
            IsPrime = False
            End If
            'IsPrime = False
            'Next
            'If p = Then
            '    IsPrime = False
            'End If
            Return IsPrime
    End Function

    Private Function i1Exp(p As Long) As Boolean
        Throw New NotImplementedException()
    End Function

    Private Sub PrimeFunction_Click(sender As Object, e As EventArgs) Handles PrimeFunction.Click
        'Dim IsPrime
        'Dim i As Long
        'Boolean IsPrime = False
        'If (2exp(n)) Then

        'End If
        Dim number As Long = Convert.ToInt64(TextBox1.Text)
        Dim IsPrime As Boolean
        IsPrime = PrimalityFunction(number)
        TextBox2.Text = IsPrime


    End Sub
End Class
