Imports NUnit.Framework
Imports HitAndBlow
Public Class MeaningfulInputCheckTest
    <Test>
    Public Sub 渡された数字が指定桁の整数ならばTrueを返す()
        Dim mic As New MeaningfulInputCheck
        Dim actual As Boolean = mic.IsMeaningfulInput("1234", "1234", 4)
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub 渡された値がgiveupならばTrueを返す()
        Dim mic As New MeaningfulInputCheck
        Dim actual As Boolean = mic.IsMeaningfulInput("giveup", "1234", 4)
        Assert.IsTrue(actual)
    End Sub

    <TestCase("giveeup", "1234", 4)>
    <TestCase("abc", "1234", 4)>
    <TestCase("123", "1234", 4)>
    Public Sub 渡された値がgiveupでなく指定桁の整数でもない場合はFalseを返す(answerNumber As String, questionNumber As String, digitNumber As Integer)
        Dim mic As New MeaningfulInputCheck
        Dim actual As Boolean = mic.IsMeaningfulInput(answerNumber, questionNumber, digitNumber)
        Assert.IsFalse(actual)
    End Sub

End Class
