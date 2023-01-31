Imports System.Numerics


Public Class Form1
    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        Try
            Dim llamar As Class1 = New Class1
            txt_resultados.Text = llamar.distancia(txtx1.Text, txt_x2.Text, txt_y1.Text, txt_y2.Text)
        Catch ex As Exception
            MessageBox.Show("llena todo pendejo")
        End Try
    End Sub
End Class
