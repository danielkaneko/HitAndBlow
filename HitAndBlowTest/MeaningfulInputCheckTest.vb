Imports NUnit.Framework
Imports HitAndBlow
Public Class MeaningfulInputCheckTest
    <Test>
    Public Sub IsMeaningfulInputが4桁の整数の時はTrueを返す()
        Dim mic As New MeaningfulInputCheck
        Dim actual As Boolean = mic.IsMeaningfulInput("1234", "1234")
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub IsMeaningfulInputがgiveupの時はTrueを返す()
        Dim mic As New MeaningfulInputCheck
        Dim actual As Boolean = mic.IsMeaningfulInput("giveup", "1234")
        Assert.IsTrue(actual)
    End Sub

    <TestCase("giveeup", "1234")>
    <TestCase("abc", "1234")>
    <TestCase("123", "1234")>
    Public Sub IsMeaningfulInputがgiveupでなく4桁の整数でもない場合はFalseを返す(answerNumber As String, questionNumber As String)
        Dim mic As New MeaningfulInputCheck
        Dim actual As Boolean = mic.IsMeaningfulInput(answerNumber, questionNumber)
        Assert.IsFalse(actual)
    End Sub

End Class
