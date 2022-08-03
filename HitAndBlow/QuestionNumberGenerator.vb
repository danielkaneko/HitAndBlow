Public Class QuestionNumberGenerator
    ''' <summary>
    ''' 答えの４桁の数字を生成し、返す
    ''' </summary>
    ''' <returns>答えの数字</returns>
    Public Function MakeRandomNumber() As String
        Dim number As String() = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim random As New Random
        Dim temporaryRetention As String

        'numberの並び替え(ランダム)
        For i As Integer = number.Length - 1 To 0 Step -1
            Dim randomNum As Integer = random.Next(0, i)
            temporaryRetention = number(i)
            number(i) = number(randomNum)
            number(randomNum) = temporaryRetention
        Next

        Dim hbQuestion As String = ""
        '頭4つ代入
        For i As Integer = 0 To 3
            hbQuestion += number(i)
        Next

        Return hbQuestion

    End Function

End Class
