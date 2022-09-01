Imports NUnit.Framework
Imports HitAndBlow
Public Class HitCounterTest
    <Test>
    Public Sub HitCounterが桁と数字が一致していた数を返すこと()
        Dim hc As New HitCounter
        Dim actual As Integer = hc.CountHit("1234", "1244")
        Assert.That(actual, [Is].EqualTo(3))
    End Sub

    <Test>
    Public Sub 入力した数字と答えの数字の桁数が違った場合はエラーと返す()
        Dim hc As New HitCounter
        Assert.That(Sub() hc.CountHit("1234", "123"), Throws.TypeOf(Of ArgumentException).And.Message.EqualTo("answerNumberとquestionNumberの数値の桁数が一致しません"))
    End Sub

End Class
