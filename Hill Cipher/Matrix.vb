Public Class Matrix
    Public data As Double()
    Private size As Integer
    Private ALPHABITSIZE As Integer = 26

    Public Function getValue(x As Integer, y As Integer) As Double
        Return data(size * x + y)
    End Function
    Public Sub setValue(val As Double, x As Integer, y As Integer)
        Me.data(size * x + y) = val
    End Sub
    Public Function rowCount()
        Return data.Length / size
    End Function

    Public Function transpose() As Array
        Dim tmp(size - 1, size - 1) As Double

        For i = 0 To size - 1
            For j = 0 To size - 1
                tmp(i, j) = Me.getValue(j, i)
            Next
        Next
        Return tmp
    End Function

    Public Function inverse() As Array
        If size = 2 Then
            Return inverse2()
        ElseIf size = 3 Then
            Return inverse3()
        Else
            Return {-1}
        End If
    End Function
    Private Function inverse2() As Array
        Dim a, b, c, d, det As Double
        a = Me.getValue(1, 1)
        b = Me.getValue(1, 0) * -1
        c = Me.getValue(0, 1) * -1
        d = Me.getValue(0, 0)

        det = multInv(Me.determinant2(a, b, c, d), ALPHABITSIZE)


        If det = 0 Then
            Return {-1}
        ElseIf gcd(det, ALPHABITSIZE) <> 1 Then
            Return {-1}
        End If

        a = modd(a * det, 26)
        b = modd(b * det, 26)
        c = modd(c * det, 26)
        d = modd(d * det, 26)
        Return {a, c, b, d}

    End Function

    Private Function gcd(ByVal n As Long, ByVal m As Long) As Long
        Dim p As Long = If(n > m, n, m)
        Dim q As Long = If(n < m, n, m)
        Dim r As Long = p Mod q

        While r > 0
            p = q
            q = r
            r = p Mod q
        End While

        Return q
    End Function
    Private Function multInv(a As Double, m As Double) As Double
        For i = 0 To m - 1
            If (a * i) Mod m = 1 Then
                Return i
            End If
        Next
        Return 0
    End Function
    Private Function modd(x As Double, m As Double) As Double
        Dim r = x Mod m
        Return If(r < 0, r + m, r)
    End Function
    Private Function determinant2(a As Double, b As Double, c As Double, d As Double) As Double
        Return (a * d) - (b * c)
    End Function

    Private Function inverse3() As Array
        Dim tdata = Me.transpose

        Dim da, db, dc, dd, de, df, dg, dh, di, det As Double

        da = determinant2(tdata(1, 1), tdata(1, 2), tdata(2, 1), tdata(2, 2))
        db = determinant2(tdata(0, 2), tdata(0, 1), tdata(2, 2), tdata(2, 1))
        dc = determinant2(tdata(0, 1), tdata(0, 2), tdata(1, 1), tdata(1, 2))
        dd = determinant2(tdata(1, 2), tdata(1, 0), tdata(2, 2), tdata(2, 0))
        de = determinant2(tdata(0, 0), tdata(0, 2), tdata(2, 0), tdata(2, 2))
        df = determinant2(tdata(0, 2), tdata(0, 0), tdata(1, 2), tdata(1, 0))
        dg = determinant2(tdata(1, 0), tdata(1, 1), tdata(2, 0), tdata(2, 1))
        dh = determinant2(tdata(0, 1), tdata(0, 0), tdata(2, 1), tdata(2, 0))
        di = determinant2(tdata(0, 0), tdata(0, 1), tdata(1, 0), tdata(1, 1))

        Dim tmp As New Matrix(size, size)
        tmp.data = {da, db, dc, dd, de, df, dg, dh, di}
        det = multInv(determinant3(), ALPHABITSIZE)
        If det = 0 Then
            Return {-1}
        ElseIf gcd(det, ALPHABITSIZE) <> 1 Then
            Return {-1}
        End If

        Dim t As New Matrix(size, size)

        For i = 0 To size - 1
            For j = 0 To size - 1
                tmp.setValue(modd(tmp.getValue(i, j) * det, ALPHABITSIZE), i, j)
                t.setValue(tmp.getValue(i, j), j, i)
            Next
        Next
        Return t.data
    End Function

    Private Function determinant3() As Double
        Dim a, b, c, d, e, f, g, h, i As Double
        Dim tdata = Me.transpose

        a = tdata(0, 0)
        b = tdata(1, 0)
        c = tdata(2, 0)
        d = tdata(0, 1)
        e = tdata(1, 1)
        f = tdata(2, 1)
        g = tdata(0, 2)
        h = tdata(1, 2)
        i = tdata(2, 2)

        Return (a * e * i) + (b * f * g) + (c * d * h) - (c * e * g) - (b * d * i) - (a * f * h)
    End Function

    Public Function mult(m As Matrix) As Array
        If size = 2 Then
            Return mult2(m)
        ElseIf size = 3 Then
            Return mult3(m)
        Else
            Return {-1}
        End If
    End Function


    Private Function mult2(m As Matrix) As Array
        Dim a, b, c, d, x, y As Double

        a = getValue(0, 0)
        b = getValue(0, 1)
        c = getValue(1, 0)
        d = getValue(1, 1)

        x = m.getValue(0, 0)
        y = m.getValue(0, 1)

        Console.WriteLine(a & " : " & b & " : " & c & " : " & d & " : " & x & " : " & y)

        Dim result(0, 1) As Double
        result(0, 0) = modd(Math.Round(((a * x) + (b * y))), ALPHABITSIZE)
        result(0, 1) = modd(Math.Round(((c * x) + (d * y))), ALPHABITSIZE)
        Return result
    End Function
    Private Function mult3(m As Matrix) As Array
        Dim a, b, c, d, e, f, g, h, i, x, y, z As Double

        a = getValue(0, 0)
        b = getValue(0, 1)
        c = getValue(0, 2)
        d = getValue(1, 0)
        e = getValue(1, 1)
        f = getValue(1, 2)
        g = getValue(2, 0)
        h = getValue(2, 1)
        i = getValue(2, 2)

        x = m.getValue(0, 0)
        y = m.getValue(0, 1)
        z = m.getValue(0, 2)

        Console.WriteLine(a & " : " & b & " : " & c & " : " & d & " : " & e & " : " & f & " : " & g & " : " & h & " : " & i & " : " & x & " : " & y & " : " & z)

        Dim result(0, 2) As Double
        result(0, 0) = ((x * a) + (y * b) + (z * c)) Mod ALPHABITSIZE
        result(0, 1) = ((x * d) + (y * e) + (z * f)) Mod ALPHABITSIZE
        result(0, 2) = ((x * g) + (y * h) + (z * i)) Mod ALPHABITSIZE
        Return result
    End Function

    Sub New(w As Integer, h As Integer)
        size = w
        ReDim Me.data(w * h)
    End Sub


End Class