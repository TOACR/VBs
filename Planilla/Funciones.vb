Module Funciones

    ' Variables globales
    Public horasext As Integer

    ' Método para validar solo letras (mayúsculas)
    Public Sub set_solo_letras(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim cadena As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
        If InStr(cadena, ee.KeyChar) > 0 OrElse Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
            MsgBox("Solo se permiten letras mayúsculas", MsgBoxStyle.Exclamation, "Validación")
        End If
    End Sub

    ' Método para validar solo números
    Public Sub set_solo_numeros(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim numerosPermitidos As String = "0123456789"
        If InStr(numerosPermitidos, ee.KeyChar) > 0 OrElse Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
            MsgBox("Solo se permiten números", MsgBoxStyle.Exclamation, "Validación")
        End If
    End Sub

End Module