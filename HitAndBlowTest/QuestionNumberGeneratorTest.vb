Imports HitAndBlow
Imports NUnit.Framework

Public Class QuestionNumberGeneratorTest
    <Test>
    Public Sub 生成した数字に重複がないか()
        Dim qnr As New QuestionNumberGenerator
        Dim actual As String = qnr.MakeRandomNumber(4)
        Assert.That(actual.Length, [Is].EqualTo(actual.Distinct.Count))
    End Sub

    <TestCase(3, 3)>
    <TestCase(6, 6)>
    <TestCase(10, 10)>
    Public Sub 生成した数字が指定桁の数字であるか(challengeDigit As Integer, answerDigit As Integer)
        Dim qnr As New QuestionNumberGenerator
        Dim actual As String = qnr.MakeRandomNumber(challengeDigit)
        Assert.That(actual.Length, [Is].EqualTo(answerDigit))
    End Sub

    <Test>
    Public Sub 生成した数字が整数であるか()
        Dim qnr As New QuestionNumberGenerator
        Dim actual As String = qnr.MakeRandomNumber(4)
        Assert.IsTrue(IsNumeric(actual))
        Assert.That(actual, [Is].Not.StringContaining("."))
    End Sub

End Class
