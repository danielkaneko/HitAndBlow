Imports NUnit.Framework
Imports HitAndBlow
Public Class NumbersOnlyCheckTest
    <Test>
    Public Sub IsNumbersOnlyが数字のみの入力を通すこと()
        Dim noc As New NumbersOnlyCheck
        Dim actual As Boolean = noc.IsNumbersOnly("1234")
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub IsNumbersOnlyが数字以外の入力を通さないこと()
        Dim noc As New NumbersOnlyCheck
        Dim actual As Boolean = noc.IsNumbersOnly("123a")
        Assert.IsFalse(actual)
    End Sub
End Class
