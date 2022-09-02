Imports NUnit.Framework
Imports HitAndBlow
<TestFixture>
Public MustInherit Class InputAnswerNumberCheckerTest
    Private ianc As InputAnswerNumberChecker
    <SetUp>
    Public Sub Setup()
        ianc = New InputAnswerNumberChecker
    End Sub

    Public Class IsInputAnswerNumberTest : Inherits InputAnswerNumberCheckerTest
        <Test>
        Public Sub 渡された内容が指定桁の整数であればTrueを返すこと()
            Dim actual As Boolean = ianc.IsInputAnswerNumber("123", "567", 3)
            Assert.IsTrue(actual)
        End Sub

        <Test>
        Public Sub 渡された内容文字列が含まれていればFalseを返すこと()
            Dim actual As Boolean = ianc.IsInputAnswerNumber("123a", "5678", 4)
            Assert.IsFalse(actual)
        End Sub

        <Test>
        Public Sub 渡された内容が小数であればFalseを返すこと()
            Dim actual As Boolean = ianc.IsInputAnswerNumber("1.234", "56789", 5)
            Assert.IsFalse(actual)
        End Sub

        <Test>
        Public Sub 渡された内容が指定桁の整数でなければFalseを返すこと()
            Dim actual As Boolean = ianc.IsInputAnswerNumber("123", "567890", 6)
            Assert.IsFalse(actual)
        End Sub
    End Class

    Public Class IsInputShowAnswerTest : Inherits InputAnswerNumberCheckerTest
        <Test>
        Public Sub 渡された内容がShowAnswerであればTrueを返すこと()
            Dim actual As Boolean = ianc.IsInputShowAnswer("ShowAnswer")
            Assert.IsTrue(actual)
        End Sub

        <Test>
        Public Sub 渡された内容がShowAnswer以外の文字列であればFalseを返すこと()
            Dim actual As Boolean = ianc.IsInputShowAnswer("showanswer")
            Assert.IsFalse(actual)
        End Sub
    End Class

    Public Class IsInputGiveUp : Inherits InputAnswerNumberCheckerTest
        <Test>
        Public Sub 渡された内容が大文字小文字関係なくgiveupであればTrueを返すこと()
            Dim actual As Boolean = ianc.IsInputGiveUp("gIVeuP")
            Assert.IsTrue(actual)
        End Sub

        <Test>
        Public Sub 渡された内容がgiveupでなければFalseを返すこと()
            Dim actual As Boolean = ianc.IsInputGiveUp("giveap")
            Assert.IsFalse(actual)
        End Sub

        <Test>
        Public Sub 渡された内容がNullであればFalseを返すこと()
            Dim actual As Boolean = ianc.IsInputGiveUp(Nothing)
            Assert.IsFalse(actual)
        End Sub
    End Class
End Class
