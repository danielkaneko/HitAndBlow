Module Main

    Sub Main()
        Dim qnr As New QuestionNumberGenerator
        Dim dic As New DigitIntegerCheck
        Dim noc As New NumbersOnlyCheck
        Dim hc As New HitCounter
        Dim questionNumber As String = qnr.MakeRandomNumber
        Dim answerNumber As String
        Dim hit As Integer

        '数値入力
        Do
            Console.WriteLine("** 数値を入力してください **")
            answerNumber = Console.ReadLine()
        Loop While Not noc.IsNumbersOnly(answerNumber) AndAlso Not dic.IsFourDigitInteger(answerNumber)

        hit = hc.CountHit(answerNumber, questionNumber)
        Console.WriteLine(hit & "HIT　")

    End Sub

End Module
