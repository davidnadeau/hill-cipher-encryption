Public Class Form1
    Dim BLOCKSIZE
    Dim msg As New ArrayList
    Dim key
    Dim invkey
    Dim cipherText As ArrayList

    Private Sub encode_Click(sender As Object, e As EventArgs) Handles encode.Click
        Dim u = -1

        If RadioButton1.Checked = True Then
            BLOCKSIZE = 2
            key = New Matrix(BLOCKSIZE, BLOCKSIZE)
            While u = -1
                key.data = {Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0)}
                u = key.inverse()(0)
                invkey = New Matrix(BLOCKSIZE, BLOCKSIZE)
            End While
        Else
            BLOCKSIZE = 3
            key = New Matrix(BLOCKSIZE, BLOCKSIZE)
            invkey = New Matrix(BLOCKSIZE, BLOCKSIZE)
            While u = -1
                key.data = {Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0), Math.Round(Rnd() * 26.0)}
                u = key.inverse()(0)
                invkey = New Matrix(BLOCKSIZE, BLOCKSIZE)
            End While
        End If
        msg = encodeMsg(plaintextInput.Text)
        encodedInput.Text = listToString(msg)
    End Sub

    Private Function listToString(l As ArrayList) As String
        Dim str As String = ""
        For i = 0 To l.Count - 1
            For j = 0 To BLOCKSIZE - 1
                str = str + Convert.ToString(l(i)(j))
            Next
        Next
        Return str
    End Function
    Private Function listlistToString(l As ArrayList) As String
        Dim str As String = ""
        For i = 0 To l.Count - 1
            For k = 0 To BLOCKSIZE - 1
                str = str + Convert.ToString(l(i)(0, k))
            Next
        Next
        Return str
    End Function
    Public Function encodeMsg(msg As String) As ArrayList
        Dim m As New ArrayList
        Dim chars = msg.ToCharArray
        For i = 0 To chars.Length - 1 Step 0
            Dim a(BLOCKSIZE - 1) As String
            For j = 0 To BLOCKSIZE - 1
                If i > chars.Length - 1 Then
                    a(j) = "-1"
                Else
                    a(j) = toNumbers(chars(i))
                    If Convert.ToDouble(a(j)) < 10 Then
                        a(j) = "0" & a(j)
                    End If
                End If
                i = i + 1
            Next
            m.Add(a)
        Next
        Return m
    End Function

    Public Function decodeMsg() As ArrayList
        Dim m As New ArrayList
        For i = 0 To msg.Count - 1
            Dim a(BLOCKSIZE - 1) As String
            For j = 0 To BLOCKSIZE - 1
                m.Add(toLetters(msg(i)(0, j)))
            Next
        Next
        Return m
    End Function
    Private Function formatKey(k As Array) As String
        Dim s = ""
        For i = 0 To k.Length - 1
            If i Mod BLOCKSIZE = 0 Then
                s = s & vbNewLine
            End If
            s = s & k(i)
        Next
        Return s
    End Function
    Private Sub encrypt_Click(sender As Object, e As EventArgs) Handles encrypt.Click
        keyBox.Text = formatKey(key.data)
        Dim m As New ArrayList
        For i = 0 To msg.Count - 1
            Dim block = New Matrix(msg(i).length - 1, 1)
            For j = 0 To msg(i).length - 1
                block.data(j) = msg(i)(j)
            Next
            m.Add(key.mult(block))
        Next

        msg.Clear()
        For i = 0 To m.Count - 1
            msg.Add(m(i))
        Next
        cipherInput.Text = listlistToString(msg)
        encrypt.Enabled = False
    End Sub

    Private Sub decrypt_Click(sender As Object, e As EventArgs) Handles decrypt.Click
        invkey.data = key.inverse()
        invkeyBox.Text = formatKey(invkey.data)

        Dim m As New ArrayList
        For i = 0 To msg.Count - 1
            Dim block = New Matrix(msg(i).length - 1, 1)
            For j = 0 To msg(i).length - 1
                block.data(j) = msg(i)(0, j)
            Next
            m.Add(invkey.mult(block))
        Next
        msg.Clear()
        For i = 0 To m.Count - 1
            msg.Add(m(i))
        Next
        encodedInput2.Text = listlistToString(msg)
        encrypt.Enabled = True
        decrypt.Enabled = False
    End Sub
    Private Sub decode_Click(sender As Object, e As EventArgs) Handles decode.Click
        msg = decodeMsg()
        Dim t = ""
        For i = 0 To msg.Count - 1
            t = t & msg(i)
        Next
        plaintextInput2.Text = t
        decrypt.Enabled = True
    End Sub

    Private Function toNumbers(c As String) As String
        Select Case c
            Case "a"
                Return "0"
            Case "b"
                Return "1"
            Case "c"
                Return "2"
            Case "d"
                Return "3"
            Case "e"
                Return "4"
            Case "f"
                Return "5"
            Case "g"
                Return "6"
            Case "h"
                Return "7"
            Case "i"
                Return "8"
            Case "j"
                Return "9"
            Case "k"
                Return "10"
            Case "l"
                Return "11"
            Case "m"
                Return "12"
            Case "n"
                Return "13"
            Case "o"
                Return "14"
            Case "p"
                Return "15"
            Case "q"
                Return "16"
            Case "r"
                Return "17"
            Case "s"
                Return "18"
            Case "t"
                Return "19"
            Case "u"
                Return "20"
            Case "v"
                Return "21"
            Case "w"
                Return "22"
            Case "x"
                Return "23"
            Case "y"
                Return "24"
            Case "z"
                Return "25"
            Case " "
                Return "26"
            Case Else
                Return "-1"
        End Select
    End Function
    Private Function toLetters(d As Integer) As String
        Select Case d
            Case 0
                Return "a"
            Case 1
                Return "b"
            Case 2
                Return "c"
            Case 3
                Return "d"
            Case 4
                Return "e"
            Case 5
                Return "f"
            Case 6
                Return "g"
            Case 7
                Return "h"
            Case 8
                Return "i"
            Case 9
                Return "j"
            Case 10
                Return "k"
            Case 11
                Return "l"
            Case 12
                Return "m"
            Case 13
                Return "n"
            Case 14
                Return "o"
            Case 15
                Return "p"
            Case 16
                Return "q"
            Case 17
                Return "r"
            Case 18
                Return "s"
            Case 19
                Return "t"
            Case 20
                Return "u"
            Case 21
                Return "v"
            Case 22
                Return "w"
            Case 23
                Return "x"
            Case 24
                Return "y"
            Case 25
                Return "z"
            Case 26
                Return " "
            Case Else
                Return ""
        End Select
    End Function

    Private Sub clearAll_Click(sender As Object, e As EventArgs) Handles clearAll.Click
        msg = New ArrayList
        cipherText = New ArrayList

        plaintextInput.Text = ""
        encodedInput.Text = ""
        cipherInput.Text = ""
        encodedInput2.Text = ""
        plaintextInput2.Text = ""

        keyBox.Text = ""
        invkeyBox.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
