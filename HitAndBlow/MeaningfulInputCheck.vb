Public Class MeaningfulInputCheck

    ''' <summary>
    ''' 入力された数字がgiveupかどうか調べる入力チェックの変数化
    ''' </summary>
    Public IsGiveUp As Boolean = False

    ''' <summary>
    ''' 意味のある入力内容かどうかチェックする
    ''' </summary>
    ''' <param name="answerNumber">入力された数字</param>
    ''' <param name="questionNumber">答えの数字</param>
    ''' <returns>入力内容が正しければTrue、そうでなければFalse</returns>
    Public Function IsMeaningfulInput(answerNumber As String, questionNumber As String, digitNumber As Integer) As Boolean
        Dim ianc As New InputAnswerNumberChecker
        IsGiveUp = ianc.IsInputGiveUp(answerNumber)
        Dim isAnswerNumber As Boolean = ianc.IsInputAnswerNumber(answerNumber, questionNumber, digitNumber)
        Return IsGiveUp OrElse isAnswerNumber
    End Function

    ''' <summary>
    ''' 意味のある入力がされるまで待機する
    ''' </summary>
    ''' <param name="questionNumber">答えの数字</param>
    ''' <returns>入力した文字列を返す</returns>
    Public Function WaitForMeaningfulInput(questionNumber As String, digitNumber As Integer) As String
        Dim answerNumber As String
        Do
            Console.Write("数値を入力してください：")
            answerNumber = Console.ReadLine()
        Loop While Not IsMeaningfulInput(answerNumber, questionNumber, digitNumber)
        Return answerNumber
    End Function
End Class
