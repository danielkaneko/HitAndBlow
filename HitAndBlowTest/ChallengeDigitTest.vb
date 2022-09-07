Imports NUnit.Framework
Imports HitAndBlow
Public Class ChallengeDigitTest
    <Test>
    Public Sub IsInputChallegeDigitが渡された値が3から10の整数であればTrueを返す()
        Dim cd As New ChallengeDigit
        Dim actual As Boolean = cd.IsInputChallegeDigit("3")
        Assert.IsTrue(actual)
    End Sub

    <TestCase("2")>
    <TestCase("11")>
    <TestCase("3.5")>
    <TestCase("-3")>
    <TestCase("a")>
    Public Sub IsInputChallegeDigitが渡された値が3から10の整数でなければFalseを返す(inputDigit As String)
        Dim cd As New ChallengeDigit
        Dim actual As Boolean = cd.IsInputChallegeDigit(inputDigit)
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsInputChallegeDigitが渡された値がNullであればFalseを返す()
        Dim cd As New ChallengeDigit
        Dim actual As Boolean = cd.IsInputChallegeDigit(Nothing)
        Assert.IsFalse(actual)
    End Sub


    <Test>
    Public Sub 桁数入力で渡された値が大文字小文字問わずexitであればTrueを返す()
        Dim cd As New ChallengeDigit
        Dim actual As Boolean = cd.IsInputExit("exIt")
        Assert.IsTrue(actual)
    End Sub

    <TestCase("exhit")>
    <TestCase("10")>
    <TestCase("-3")>
    <TestCase("")>
    <TestCase(Nothing)>
    Public Sub 桁数入力で渡された値がexitでなければFalseを返す(inputContent As String)
        Dim cd As New ChallengeDigit
        Dim actual As Boolean = cd.IsInputExit(inputContent)
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub 桁数がゲームキャンセルを表す値であればTrueを返す()
        Dim cd As New ChallengeDigit
        Dim actual As Boolean = cd.IsInterruptedGame(-1)
        Assert.IsTrue(actual)
    End Sub

    <TestCase(1)>
    <TestCase(5)>
    Public Sub 桁数がゲームキャンセルを表す値でなければFalseを返す(digitNumber As Integer)
        Dim cd As New ChallengeDigit
        Dim actual As Boolean = cd.IsInterruptedGame(digitNumber)
        Assert.IsFalse(actual)
    End Sub
End Class
