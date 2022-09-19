Imports NUnit.Framework
Imports HitAndBlow
Public Class BlowCounterTest
    <Test>
    Public Sub 二つの数字を比較し桁が不一致_数字が一致している数を返す()
        Dim bc As New BlowCounter
        Dim actual As Integer = bc.CountBlow("1234", "3524", 1)
        Assert.That(actual, [Is].EqualTo(2))
    End Sub
End Class