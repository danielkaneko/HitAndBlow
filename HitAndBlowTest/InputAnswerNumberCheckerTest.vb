Imports NUnit.Framework
Imports HitAndBlow
Public Class InputAnswerNumberCheckerTest
    <Test>
    Public Sub IsInputAnswerNumberが指定桁の整数を通すこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputAnswerNumber("123", "567", 3)
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub IsInputAnswerNumberが数字以外を通さないこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputAnswerNumber("123a", "5678", 4)
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsInputAnswerNumberが少数を通さないこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputAnswerNumber("1.234", "56789", 5)
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsInputAnswerNumberが指定桁の数字以外を通さないこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputAnswerNumber("123", "567890", 6)
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

    <Test>
    Public Sub IsInputGiveUpが大文字小文字関係なくgiveupを通すこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputGiveUp("gIVeuP")
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub IsInputGiveUpがgiveup以外の入力がされたらFalseを通すこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputGiveUp("giveap")
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsInputGiveUpの引数がNullの場合Falseを返すこと()
        Dim ianc As New InputAnswerNumberChecker
        Dim actual As Boolean = ianc.IsInputGiveUp(Nothing)
        Assert.IsFalse(actual)
    End Sub
End Class
