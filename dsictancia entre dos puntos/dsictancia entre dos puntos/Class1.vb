Public Class Class1
    Public x1 As Double
    Public y1 As Double
    Public x2 As Double
    Public y2 As Double
    Public resultado As Double


    Public Sub datos(x1 As Double, x2 As Double, y1 As Double, y2 As Double, resultado As Double)
        Me.x1 = x1
        Me.y1 = y1
        Me.x2 = x2
        Me.y2 = y2
        Me.resultado = resultado

    End Sub
    Public Function distancia(x1 As Double, x2 As Double, y1 As Double, y2 As Double)
        Me.resultado = Math.Sqrt(((x2 - x1) ^ 2 + (y2 - y1) ^ 2))
        Return resultado
    End Function

End Class
