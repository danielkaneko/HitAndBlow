Public Class BlowCounter
    ''' <summary>
    ''' 入力された数字のブロー数を計算しブロー数を返す
    ''' </summary>
    ''' <param name="answerNumber">入力した数字</param>
    ''' <param name="questionNumber">答えの数字</param>
    ''' <param name="hit">ヒット数</param>
    ''' <returns>ブロー数</returns>
    Public Function CountBlow(answerNumber As String, questionNumber As String, hit As Integer) As Integer
        Dim blow As Integer = 0
        'ブロー数の計算
        For Each answerBeeline As Char In answerNumber.ToCharArray()
            For Each questionBeeline As Char In questionNumber.ToCharArray()
                If answerBeeline.Equals(questionBeeline) Then
                    blow += 1
                End If
            Next
        Next

        blow -= hit
        Return blow

    End Function

End Class
