Public Class DigitIntegerCheck
    ''' <summary>
    ''' 4桁整数のみを通す入力チェック
    ''' </summary>
    ''' <param name="answerNumber">入力した数字</param>
    ''' <returns>4桁の整数であればTrueそうでなければFalse</returns>
    Public Function IsFourDigitInteger(answerNumber As String) As Boolean
        '入力チェック(4桁の整数)
        If answerNumber.Length = 4 AndAlso Not answerNumber.Contains(".") Then
            Return True
        Else
            Console.WriteLine("4桁の整数を入力してください")
            Return False
        End If

    End Function

End Class
