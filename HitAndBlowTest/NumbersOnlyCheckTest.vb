Imports NUnit.Framework
Imports HitAndBlow
Public Class NumbersOnlyCheckTest
    <Test>
    Public Sub 渡された値が数字のみならばTrueを返す()
        Dim noc As New NumbersOnlyCheck
        Dim actual As Boolean = noc.IsNumbersOnly("1234")
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub 渡された値に数字以外が含まれている場合はFalseを返す()
        Dim noc As New NumbersOnlyCheck
        Dim actual As Boolean = noc.IsNumbersOnly("123a")
        Assert.IsFalse(actual)
    End Sub
End Class
