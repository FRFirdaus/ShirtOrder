Public Class MainMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPESAN.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        add.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pemesanan.Show()
    End Sub
End Class