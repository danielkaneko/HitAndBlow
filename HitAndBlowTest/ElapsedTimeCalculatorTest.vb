Imports NUnit.Framework
Imports HitAndBlow
Public Class ElapsedTimeCalculatorTest
    <Test>
    Public Sub 開始時間と終了時間の差分を返す()
        Dim startTime As New TimeSpan(1, 1, 10, 10, 100)
        Dim finishTime As New TimeSpan(1, 1, 11, 11, 111)
        Dim actual As TimeSpan = ElapsedTimeCalculator.CalculateElapsedTime(startTime, finishTime)
        Assert.That(actual.ToString("mm\:ss\.ff"), [Is].EqualTo("01:01.01"))
    End Sub

    <Test>
    Public Sub 一桁で入力された開始時間と終了時間の差分を返す()
        Dim startTime As New TimeSpan(1, 1, 0, 2, 100)
        Dim finishTime As New TimeSpan(1, 1, 1, 4, 111)
        Dim actual As TimeSpan = ElapsedTimeCalculator.CalculateElapsedTime(startTime, finishTime)
        Assert.That(actual.ToString("mm\:ss\.ff"), [Is].EqualTo("01:02.01"))
    End Sub

    <Test>
    Public Sub 繰り上がりが発生している開始時間と終了時間の差分を返す()
        Dim startTime As New TimeSpan(1, 1, 0, 10, 100)
        Dim finishTime As New TimeSpan(1, 1, 1, 0, 111)
        Dim actual As TimeSpan = ElapsedTimeCalculator.CalculateElapsedTime(startTime, finishTime)
        Assert.That(actual.ToString("mm\:ss\.ff"), [Is].EqualTo("00:50.01"))
    End Sub

    <Test>
    Public Sub 引数の値の大小関係が正しくない場合はエラーと返す()
        Dim startTime As New TimeSpan(1, 1, 11, 11, 111)
        Dim finishTime As New TimeSpan(1, 1, 10, 10, 100)
        Assert.That(Sub() ElapsedTimeCalculator.CalculateElapsedTime(startTime, finishTime), Throws.TypeOf(Of ArgumentException).And.Message.EqualTo("startTimeにfinishTimeよりも遅い時間が設定されています"))
    End Sub
End Class
