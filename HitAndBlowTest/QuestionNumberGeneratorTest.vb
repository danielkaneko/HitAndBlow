Imports HitAndBlow
Imports NUnit.Framework

Public Class QuestionNumberGeneratorTest
    <Test>
    Public Sub QuestionNumberGeneratorが重複しないこと()
        Dim qnr As New QuestionNumberGenerator
        Dim actual As String = qnr.MakeRandomNumber
        Assert.That(actual.Length, [Is].EqualTo(actual.Distinct.Count))
    End Sub

    <Test>
    Public Sub QuestionNumberGeneratorが４桁の数字を返すこと()
        Dim qnr As New QuestionNumberGenerator
        Dim actual As String = qnr.MakeRandomNumber
        Assert.That(actual.Length, [Is].EqualTo(4))
    End Sub

    <Test>
    Public Sub QuestionNumberGeneratorが整数を返すこと()
        Dim qnr As New QuestionNumberGenerator
        Dim actual As String = qnr.MakeRandomNumber
        Assert.IsTrue(IsNumeric(actual))
        Assert.That(actual, [Is].Not.StringContaining("."))
    End Sub

End Class
