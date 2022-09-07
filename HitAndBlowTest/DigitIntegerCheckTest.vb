Imports NUnit.Framework
Imports HitAndBlow
Public Class DigitIntegerCheckTest
    <Test>
    Public Sub IsSpecifiedDigitIntegerが指定桁の整数を通すこと()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsSpecifiedDigitInteger("1234567890", 10)
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub IsSpecifiedDigitIntegerが少数を通さないこと()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsSpecifiedDigitInteger("12.3456789", 10)
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsSpecifiedDigitIntegerが指定桁以上の数字を通さないこと()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsSpecifiedDigitInteger("12345678901", 10)
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsSpecifiedDigitIntegerが指定桁以下の数字を通さないこと()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsSpecifiedDigitInteger("123456789", 10)
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsSpecifiedDigitIntegerが負の数字を通さないこと()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsSpecifiedDigitInteger("-123456789", 10)
        Assert.IsFalse(actual)
    End Sub
End Class
