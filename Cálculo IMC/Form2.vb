Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim peso, altura As Double

        Try

            peso = (TextBox1.Text)
            altura = (TextBox2.Text)

        Catch ex As Exception
            MsgBox("Algo deu errado. Ultilize números!", vbCritical)

        End Try


        Dim c1, imc As Single

        c1 = altura * altura
        imc = peso / c1

        If imc < 20 Then
            TextBox5.Text = "Ruim. IMC: " & imc

        ElseIf imc <= 24.9 Then
            TextBox5.Text = "Bom. IMC: " & imc

        ElseIf imc <= 29.9 Then
            TextBox5.Text = "Pouco ruim. IMC: " & imc

        ElseIf imc <= 39.9 Then
            TextBox5.Text = "Ruim. IMC: " & imc

        ElseIf imc > 43 Then
            TextBox5.Text = "Péssimo. IMC: " & imc
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim peso, altura As Double

        Try

            peso = TextBox1.Text
            altura = TextBox2.Text

        Catch ex As Exception
            MsgBox("Algo deu errado. Ultilize números!", vbCritical)

        End Try

        Dim c1, imc As Double

        c1 = altura * altura
        imc = peso / c1

        If imc < 19 Then
            TextBox5.Text = "Ruim. IMC: " & imc

        ElseIf imc <= 23.9 Then
            TextBox5.Text = "Bom. IMC: " & imc

        ElseIf imc <= 28.9 Then
            TextBox5.Text = "Pouco ruim. IMC: " & imc

        ElseIf imc <= 38.9 Then
            TextBox5.Text = "Ruim. IMC: " & imc

        ElseIf imc > 39 Then
            TextBox5.Text = "Péssimo. IMC: " & imc
        End If
    End Sub

End Class