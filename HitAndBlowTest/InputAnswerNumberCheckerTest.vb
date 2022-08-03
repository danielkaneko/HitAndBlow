Imports NUnit.Framework
Imports HitAndBlow
Public Class InputAnswerNumberCheckerTest
    <Test>
    Public Sub IsInputAppropriateが4桁の整数を通すこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputAnswerNumber("1234", "5678")
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub IsInputAppropriateが数字以外を通さないこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputAnswerNumber("123a", "5678")
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsInputAppropriateが少数を通さないこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputAnswerNumber("1.23", "5678")
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsInputAppropriateが4桁の数字以外を通さないこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputAnswerNumber("123", "5678")
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsInputShowAnswerがShowAnswerを通すこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputShowAnswer("ShowAnswer")
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub IsInputShowAnswerがShowAnswer以外を通さないこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputShowAnswer("showanswer")
        Assert.IsFalse(actual)
    End Sub
End Class
