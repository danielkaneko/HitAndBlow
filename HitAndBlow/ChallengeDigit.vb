Imports System.Text.RegularExpressions
Imports Fhi.Fw

Public Class ChallengeDigit

    ''' <summary>
    ''' ゲームをキャンセルしたことを表す値
    ''' </summary>
    Private Const CANCEL_GAME As Integer = -1

    ''' <summary>
    ''' 挑戦桁数を入力
    ''' </summary>
    ''' <returns>挑戦する桁数を返す</returns>
    Public Function GetChallengeDigit() As Integer
        Dim inputDigit As String
        Do
            Console.WriteLine("挑戦する問題の桁数を入力してください")
            inputDigit = Console.ReadLine()
            If IsInputExit(inputDigit) Then
                Return CANCEL_GAME
            End If
        Loop While Not IsInputChallegeDigit(inputDigit)
        Return CType(inputDigit, Integer)
    End Function

    ''' <summary>
    ''' 挑戦する桁数として適切かチェックする
    ''' </summary>
    ''' <param name="inputDigit">入力された桁数</param>
    ''' <returns>挑戦する桁数として正しければTrue、そうでなければFalseを返す</returns>
    Public Function IsInputChallegeDigit(inputDigit As String) As Boolean
        If StringUtil.IsNotEmpty(inputDigit) AndAlso Regex.IsMatch(inputDigit, "^[3-9]{1}$|^1[0]{1}$") Then
            Return True
        End If
        Console.WriteLine("3～10までの数字を入力してください")
        Return False
    End Function

    ''' <summary>
    ''' exitと入力されているかチェックする
    ''' </summary>
    ''' <param name="inputContent">入力した文字</param>
    ''' <returns>大文字小文字問わずexitと入力されればTrue、そうでなければFalseを返す</returns>
    Public Function IsInputExit(inputContent As String) As Boolean
        Return StringUtil.IsNotEmpty(inputContent) AndAlso "exit".Equals(inputContent.ToLower)
    End Function

    ''' <summary>
    ''' ゲームがキャンセルされたかチェックする
    ''' </summary>
    ''' <param name="digitNumber">桁数</param>
    ''' <returns>キャンセルされていればTrue、そうでなければFalseを返す</returns>
    Public Function IsInterruptedGame(digitNumber As Integer) As Boolean
        Return digitNumber = CANCEL_GAME
    End Function
End Class
