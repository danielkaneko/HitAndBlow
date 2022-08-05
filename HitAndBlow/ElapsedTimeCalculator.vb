Public Class ElapsedTimeCalculator

    ''' <summary>
    ''' 経過時間を算出する
    ''' </summary>
    ''' <param name="startTime">測定開始時間</param>
    ''' <param name="finishTime">測定終了時間</param>
    ''' <returns>測定開始時間と測定時間の差分を返す</returns>
    Public Shared Function CalculateElapsedTime(startTime As TimeSpan, finishTime As TimeSpan) As TimeSpan
        If finishTime < startTime Then
            Throw New ArgumentException("startTimeにfinishTimeよりも遅い時間が設定されています")
        End If
        Return finishTime - startTime
    End Function

End Class
