Imports System.Text.RegularExpressions
Public Class DigitIntegerCheck
    ''' <summary>
    ''' 指定桁整数のみを通す入力チェック
    ''' </summary>
    ''' <param name="answerNumber">入力した数字</param>
    ''' <returns>指定桁の整数であればTrueそうでなければFalse</returns>
    Public Function IsSpecifiedDigitInteger(answerNumber As String, answerDigit As Integer) As Boolean
        '入力チェック(指定桁の整数)
        If Regex.IsMatch(answerNumber, String.Format("^[0-9]{{{0}}}$", answerDigit)) Then
            Return True
        Else
            Console.WriteLine(answerDigit & "桁の整数を入力してください")
            Return False
        End If

    End Function

End Class
