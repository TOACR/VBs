Public Class Form2
    Dim conexion As New Conexion()
    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        If TxtRuta.Text = "" Then
            MessageBox.Show("Debe ingresar una ruta de archivo.")
        Else
            conexion.CargarArchivo(TxtRuta.Text.Trim)
        End If
    End Sub
End Class