Public Class HitCounter
    ''' <summary>
    ''' 入力された数字のヒット数を計算しヒット数を返す
    ''' </summary>
    ''' <param name="answerNumber">入力した数字</param>
    ''' <param name="questionNumber">答えの数字</param>
    ''' <returns>ヒット数</returns>
    Public Function CountHit(answerNumber As String, questionNumber As String) As Integer
        If Not questionNumber.Length.Equals(answerNumber.Length) Then
            Throw New ArgumentException("answerNumberとquestionNumberの数値の桁数が一致しません")
        End If
        Dim hit As Integer = 0
        'ヒット数の計算
        For i As Integer = 0 To questionNumber.Length - 1
            If questionNumber.Substring(i, 1).Equals(answerNumber.Substring(i, 1)) Then
                hit += 1
            End If
        Next

        Return hit

    End Function

End Class
