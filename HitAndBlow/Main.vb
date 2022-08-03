Module Main

    Sub Main()
        Dim qnr As New QuestionNumberGenerator
        Dim dic As New DigitIntegerCheck
        Dim noc As New NumbersOnlyCheck
        Dim hc As New HitCounter
        Dim bc As New BlowCounter
        Dim questionNumber As String = qnr.MakeRandomNumber
        Dim answerNumber As String
        Const GAME_NUMBER As Integer = 4
        Dim hit As Integer
        Dim blow As Integer

        Do
            '数値入力
            Do
                Console.WriteLine("** 数値を入力してください **")
                answerNumber = Console.ReadLine()
            Loop While Not noc.IsNumbersOnly(answerNumber) AndAlso Not dic.IsFourDigitInteger(answerNumber)

            hit = hc.CountHit(answerNumber, questionNumber)
            blow = bc.CountBlow(answerNumber, questionNumber, hit)

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
