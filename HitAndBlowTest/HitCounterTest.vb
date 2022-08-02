Imports NUnit.Framework
Imports HitAndBlow
Public Class HitCounterTest
    <Test>
    Public Sub HitCounterが桁と数字が一致していた数を返すこと()
        Dim hc As New HitCounter
        Dim actual As Integer = hc.CountHit("1234", "1244")
        Assert.That(actual, [Is].EqualTo(3))
    End Sub
End Class
