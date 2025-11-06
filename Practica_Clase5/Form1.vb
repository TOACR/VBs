Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Txtnombre_Keypress(sender As Object, e As EventArgs) Handles Txtnombre.KeyPress
        set_solo_letras(e)
    End Sub

    Private Sub Txtprimer_apellido_Keypress(sender As Object, e As EventArgs) Handles Txtprimer_apellido.KeyPress
        set_solo_letras(e)
    End Sub

    Private Sub Txtsegundo_apellido_Keypress(sender As Object, e As EventArgs) Handles Txtsegundo_apellido.KeyPress
        set_solo_letras(e)
    End Sub

    Private Sub Txtextra_Keypress(sender As Object, e As EventArgs) Handles Txtextra.KeyPress
        set_solo_numeros(e)
    End Sub

    Private Sub Txtextra_Lostfocus(sender As Object, e As EventArgs) Handles Txtextra.LostFocus
        If Val(Txtextra.Text) > "60" Then
            MsgBox("El máximo de horas extra es 60")
            Txtextra.Focus()
        End If

    End Sub

    Private Sub Txtsalario_bruto_Keypress(sender As Object, e As EventArgs) Handles Txtsalario_bruto.KeyPress
        set_solo_numeros(e)
    End Sub

    Private Sub Txtdeducciones_Keypress(sender As Object, e As EventArgs) Handles Txtdeducciones.KeyPress
        set_solo_numeros(e)
    End Sub

    Private Sub Txtsalario_neto_Keypress(sender As Object, e As EventArgs) Handles Txtsalario_neto.KeyPress
        set_solo_numeros(e)
    End Sub

    Private Sub Txtsalario_neto_Keypress(sender As Object, e As KeyPressEventArgs) Handles Txtsalario_neto.KeyPress

    End Sub
End Class
