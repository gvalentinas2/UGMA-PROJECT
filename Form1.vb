Public Class Form1
    Dim operando1 As Double = 0
    Dim operacion As String = ""
    Dim esNuevoNumero As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click,
                                                                        Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        Dim botonPresionado As Button = CType(sender, Button)

        If esNuevoNumero Then
            TextBox1.Text = botonPresionado.Text
            esNuevoNumero = False
        Else
            TextBox1.Text &= botonPresionado.Text
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If esNuevoNumero Then
            TextBox1.Text = "0,"
            esNuevoNumero = False
        ElseIf Not TextBox1.Text.Contains(",") Then
            TextBox1.Text &= ","
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = "0"
        operando1 = 0
        operacion = ""
        esNuevoNumero = True
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox1.Text = "0" Or TextBox1.Text = "" Then
            Exit Sub
        End If

        Dim valorActual As Double = Convert.ToDouble(TextBox1.Text)
        Dim resultado As Double = valorActual * -1

        TextBox1.Text = resultado.ToString()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click, Button13.Click, Button14.Click, Button15.Click
        Dim botonPresionado As Button = CType(sender, Button)

        operando1 = Convert.ToDouble(TextBox1.Text)
        operacion = botonPresionado.Text
        esNuevoNumero = True
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim operando2 As Double = Convert.ToDouble(TextBox1.Text)
        Dim resultado As Double = 0

        Select Case operacion
            Case "+"
                resultado = operando1 + operando2
            Case "-"
                resultado = operando1 - operando2
            Case "*"
                resultado = operando1 * operando2
            Case "/"
                If operando2 = 0 Then
                    MsgBox("Error Matemático: No se puede dividir entre cero.", MsgBoxStyle.Critical, "Aviso")
                    esNuevoNumero = True
                    Exit Sub
                End If
                resultado = operando1 / operando2
        End Select

        TextBox1.Text = resultado.ToString()
        esNuevoNumero = True
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If esNuevoNumero Or TextBox1.Text.Length <= 1 Then
            TextBox1.Text = "0"
            esNuevoNumero = True
        Else
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox1.Text = "" Or TextBox1.Text = "0" Then Exit Sub

        Dim valorActual As Double = Convert.ToDouble(TextBox1.Text)
        Dim resultado As Double = Math.Abs(valorActual)

        TextBox1.Text = resultado.ToString()
        esNuevoNumero = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox1.Text = "" Then Exit Sub

        Dim valorActual As Double = Convert.ToDouble(TextBox1.Text)

        If valorActual < 0 Then
            MsgBox("Error Matemático: No se puede calcular la raíz de un número negativo.", MsgBoxStyle.Critical, "Aviso")
            esNuevoNumero = True
            Exit Sub
        End If

        Dim resultado As Double = Math.Sqrt(valorActual)

        TextBox1.Text = resultado.ToString()
        esNuevoNumero = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox1.Text = "" Then Exit Sub

        Dim valorActual As Double = Convert.ToDouble(TextBox1.Text)

        If valorActual = 0 Then
            MsgBox("Error Matemático: No se puede dividir entre cero.", MsgBoxStyle.Critical, "Aviso")
            esNuevoNumero = True
            Exit Sub
        End If

        Dim resultado As Double = 1 / valorActual

        TextBox1.Text = resultado.ToString()
        esNuevoNumero = True
    End Sub
End Class