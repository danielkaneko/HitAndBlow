Public Module Main

    Sub Main()
        Dim qnr As New QuestionNumberGenerator
        Dim ianc As New InputAnswerNumberChecker
        Dim questionNumber As String = qnr.MakeRandomNumber
        Dim answerNumber As String
        Dim startTime As TimeSpan = DateTime.Now.TimeOfDay
        Dim finishTime As TimeSpan
        Do
            '数値入力
            Do
                Console.Write("数値を入力してください：")
                answerNumber = Console.ReadLine()
            Loop While Not ianc.IsInputAnswerNumber(answerNumber, questionNumber)

            Dim hc As New HitCounter
            Dim bc As New BlowCounter
            Dim hit As Integer = hc.CountHit(answerNumber, questionNumber)
            Dim blow As Integer = bc.CountBlow(answerNumber, questionNumber, hit)
            Const GAME_NUMBER As Integer = 4

            'ヒット数が４になるまでゲームを繰り返す
            If hit = GAME_NUMBER Then
                DisplayToScreen.ShowClearMessage()
                finishTime = DateTime.Now.TimeOfDay
                Console.ReadKey()
                Exit Do
            Else
                DisplayToScreen.ShowHitNumberAndBlowNumber(hit, blow)
            End If
        Loop

        Console.WriteLine("クリアタイム　" & ElapsedTimeCalculator.CalculateElapsedTime(startTime, finishTime).ToString("mm\:ss\.ff"))
        Console.ReadKey()
    End Sub

End Module
