Public Class InputAnswerNumberChecker

    ''' <summary>
    ''' 入力された数字がShowAnswerかどうか調べる入力チェック
    ''' </summary>
    ''' <param name="inputContent">入力した数字</param>
    ''' <returns>入力された数字がShowAnswerであればTrue、そうでなければFalse</returns>
    Public Function IsInputShowAnswer(inputContent As String) As Boolean
        Return "ShowAnswer".Equals(inputContent)
    End Function

    ''' <summary>
    ''' 入力された数字がgiveupかどうか調べる入力チェック
    ''' </summary>
    ''' <param name="inputContent">入力した数字</param>
    ''' <returns>入力された数字がgiveupであればTrue、そうでなければFalse</returns>
    Public Function IsInputGiveUp(inputContent As String) As Boolean
        Return Not String.Empty.Equals(inputContent) AndAlso "giveup".Equals(inputContent, StringComparison.OrdinalIgnoreCase)
    End Function

    ''' <summary>
    ''' 入力された数字が回答として適切かどうか調べる入力チェック
    ''' </summary>
    ''' <param name="inputContent">入力した数字</param>
    ''' <param name="questionNumber">答えの数字</param>
    ''' <returns>回答として適切であればTrue、そうでなければFalse </returns>
    Public Function IsInputAnswerNumber(inputContent As String, questionNumber As String, answerDigit As Integer) As Boolean
        Dim dic As New DigitIntegerCheck
        Dim noc As New NumbersOnlyCheck

        If IsInputShowAnswer(inputContent) Then
            DisplayToScreen.ShowAnswer(questionNumber)
            Return False
        End If

        Return noc.IsNumbersOnly(inputContent) AndAlso dic.IsSpecifiedDigitInteger(inputContent, answerDigit)
    End Function

End Class
