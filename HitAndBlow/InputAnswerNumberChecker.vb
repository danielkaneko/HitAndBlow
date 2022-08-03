Public Class InputAnswerNumberChecker

    Public Function IsInputShowAnswer(inputContents As String) As Boolean
        Return inputContents.Equals("ShowAnswer")
    End Function

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
