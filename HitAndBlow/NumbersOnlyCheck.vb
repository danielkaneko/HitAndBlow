Public Class NumbersOnlyCheck
    ''' <summary>
    ''' 数字のみを通す入力チェック
    ''' </summary>
    ''' <param name="answerNumber">入力した数字</param>
    ''' <returns>数字のみであればTrueそうでなければFalse</returns>
    Public Function IsNumbersOnly(answerNumber As String) As Boolean
        '入力チェック(数字のみ)
        If IsNumeric(answerNumber) Then
            Return True
        Else
            Console.WriteLine("数字以外の文字があります")
            Return False
        End If

    End Function
End Class
