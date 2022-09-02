Public Class DisplayToScreen

    ''' <summary>
    ''' 答えを表示する
    ''' </summary>
    ''' <param name="answer">答えの数字</param>
    Public Shared Sub ShowAnswer(answer As String)
        Console.WriteLine("答えは" & answer)
    End Sub

    ''' <summary>
    ''' ヒット数とブロー数を表示する
    ''' </summary>
    ''' <param name="hit">ヒット数</param>
    ''' <param name="blow">ブロー数</param>
    Public Shared Sub ShowHitNumberAndBlowNumber(hit As Integer, blow As Integer)
        Console.WriteLine(hit & "HIT " & blow & "BLOW")
    End Sub

    ''' <summary>
    ''' クリア後のメッセージを表示する
    ''' </summary>
    Public Shared Sub ShowClearMessage()
        Console.WriteLine("正解です。")
    End Sub

End Class
