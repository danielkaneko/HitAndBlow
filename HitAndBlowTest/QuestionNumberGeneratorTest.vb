Imports HitAndBlow
Imports NUnit.Framework

Public Class QuestionNumberGeneratorTest
    <Test>
    Public Sub QuestionNumberGeneratorが重複しないこと()
        Dim qnr As New QuestionNumberGenerator
        Dim actual As String = qnr.MakeRandomNumber(4)
        Assert.That(actual.Length, [Is].EqualTo(actual.Distinct.Count))
    End Sub

    <Testcase(3, 3)>
    <Testcase(6, 6)>
    <Testcase(10, 10)>
    Public Sub QuestionNumberGeneratorが指定桁の数字を返すこと(challengeDigit As Integer, answerDigit As Integer)
        Dim qnr As New QuestionNumberGenerator
        Dim actual As String = qnr.MakeRandomNumber(challengeDigit)
        Assert.That(actual.Length, [Is].EqualTo(answerDigit))
    End Sub

    <Test>
    Public Sub QuestionNumberGeneratorが整数を返すこと()
        Dim qnr As New QuestionNumberGenerator
        Dim actual As String = qnr.MakeRandomNumber(4)
        Assert.IsTrue(IsNumeric(actual))
        Assert.That(actual, [Is].Not.StringContaining("."))
    End Sub

End Class
