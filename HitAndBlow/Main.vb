Module Main

    Sub Main()
        Dim qnr As New QuestionNumberGenerator
        Dim ianc As New InputAnswerNumberChecker
        Dim questionNumber As String = qnr.MakeRandomNumber
        Dim answerNumber As String

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
                Console.WriteLine("正解です。")
                Console.ReadKey()
                Exit Do
            Else
                Console.WriteLine(hit & "HIT　" & blow & "BLOW")
            End If
        Loop
    End Sub

End Module
