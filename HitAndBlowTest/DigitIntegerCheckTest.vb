Imports NUnit.Framework
Imports HitAndBlow
Public Class DigitIntegerCheckTest
    <Test>
    Public Sub 渡された数字が指定桁の整数ならばTrueを返す()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsSpecifiedDigitInteger("1234567890", 10)
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub 渡された数字が小数ならばFalseを返す()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsSpecifiedDigitInteger("12.3456789", 10)
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub 渡された数字の桁数が指定された桁数よりも大きいならばFalseを返す()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsSpecifiedDigitInteger("12345678901", 10)
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub 渡された数字の桁数が指定された桁数未満ならばFalseを返す()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsSpecifiedDigitInteger("123456789", 10)
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub 渡された数字が負の数字ならばFalseを返す()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsSpecifiedDigitInteger("-123456789", 10)
        Assert.IsFalse(actual)
    End Sub
End Class
