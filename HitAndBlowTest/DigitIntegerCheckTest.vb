Imports NUnit.Framework
Imports HitAndBlow
Public Class DigitIntegerCheckTest
    <Test>
    Public Sub IsFourDigitIntegerが4桁の整数を通すこと()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsFourDigitInteger("1234")
        Assert.IsTrue(actual)
    End Sub

    <Test>
    Public Sub DIsFourDigitIntegerが少数を通さないこと()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsFourDigitInteger("12.3")
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsFourDigitIntegerが4桁以上の数字を通さないこと()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsFourDigitInteger("12345")
        Assert.IsFalse(actual)
    End Sub

    <Test>
    Public Sub IsFourDigitIntegerが4桁以下の数字を通さないこと()
        Dim dic As New DigitIntegerCheck
        Dim actual As Boolean = dic.IsFourDigitInteger("123")
        Assert.IsFalse(actual)
    End Sub
End Class
