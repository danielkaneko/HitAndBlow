﻿Public Module Main

    Sub Main()
        Dim cd As New ChallengeDigit
        Dim digitNumber As Integer = cd.GetChallengeDigit
        If cd.IsInterruptedGame(digitNumber) Then
            Console.WriteLine("ゲームをキャンセルしました")
            Console.ReadKey()
            Return
        End If
        Dim qnr As New QuestionNumberGenerator
        Dim mic As New MeaningfulInputCheck
        Dim questionNumber As String = qnr.MakeRandomNumber(digitNumber)
        Dim answerNumber As String
        Dim startTime As TimeSpan = DateTime.Now.TimeOfDay
        Dim finishTime As TimeSpan
        Do
            answerNumber = mic.WaitForMeaningfulInput(questionNumber, digitNumber)
            If mic.IsGiveUp Then
                DisplayToScreen.ShowAnswer(questionNumber)
                Console.ReadKey()
                Exit Do
            End If

            Dim hc As New HitCounter
            Dim bc As New BlowCounter
            Dim hit As Integer = hc.CountHit(answerNumber, questionNumber)
            Dim blow As Integer = bc.CountBlow(answerNumber, questionNumber, hit)

            'ヒット数が答えの数字の桁数と同じになるまでゲームを繰り返す
            If hit = digitNumber Then
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
