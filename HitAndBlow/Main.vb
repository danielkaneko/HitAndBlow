Module Main

    Sub Main()
        Dim dic As New DigitIntegerCheck
        Dim noc As New NumbersOnlyCheck
        Dim answerNumber As String

        '数値入力
        Do
            Console.WriteLine("** 数値を入力してください **")
            answerNumber = Console.ReadLine()
        Loop While Not noc.IsNumbersOnly(answerNumber) AndAlso Not dic.IsFourDigitInteger(answerNumber)
    End Sub

End Module
