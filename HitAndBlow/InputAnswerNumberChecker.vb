Public Class InputAnswerNumberChecker

    ''' <summary>
    ''' 入力された数字がShowAnswerかどうか調べる入力チェック
    ''' </summary>
    ''' <param name="inputContents">入力した数字</param>
    ''' <returns>入力された数字がShowAnswerであればTrue、そうでなければFalse</returns>
    Public Function IsInputShowAnswer(inputContents As String) As Boolean
        Return inputContents.Equals("ShowAnswer")
    End Function

    ''' <summary>
    ''' 入力された数字が回答として適切かどうか調べる入力チェック
    ''' </summary>
    ''' <param name="inputContents">入力した数字</param>
    ''' <param name="questionNumber">答えの数字</param>
    ''' <returns>回答として適切であればTrue、そうでなければFalse </returns>
    Public Function IsInputAnswerNumber(inputContents As String, questionNumber As String) As Boolean
        Dim dic As New DigitIntegerCheck
        Dim noc As New NumbersOnlyCheck

        If IsInputShowAnswer(inputContents) Then
            Console.WriteLine("答えは" & questionNumber)
        ElseIf noc.IsNumbersOnly(inputContents) AndAlso dic.IsFourDigitInteger(inputContents) Then
            Return True
        End If

        Return False
    End Function

End Class
