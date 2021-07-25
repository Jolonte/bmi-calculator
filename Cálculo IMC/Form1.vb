Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Deseja terminar a aplicação?",
        MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub
End Class
