Module Funciones
    ' Variables globales
    Public f, ntipoid As Integer

    'Crear método para validar solo mayusculas
    Public Sub set_solo_letras(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim cadena As String
        cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
        ee.KeyChar = Char.ToUpper(ee.KeyChar)
        If InStr(cadena, ee.KeyChar) Then
            ee.Handled = False
        ElseIf Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
        End If

    End Sub

End Module
