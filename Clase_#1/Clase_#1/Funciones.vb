Imports System.Data.SqlClient

Module Funciones
    ' Variables globales
    Public f, k, ntipoid, ntipoestado As Integer

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


'Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles Btneliminar.Click
'    If MessageBox.Show("¿Eliminar TODO en CIUDADANO y BITACORA_CIUDADANO y reiniciar consecutivos?",
'                       "Confirmar eliminación masiva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
'        Exit Sub
'    End If

'    Dim cs As String = "Data Source=DESKTOP-HPG8TC6\SQLEXPRESS;Initial Catalog=II36DB03Q2025;Trusted_connection=Yes"

'    Using cn As New SqlConnection(cs)
'        cn.Open()
'        Using tx = cn.BeginTransaction()
'            Try
'                ' 1) Borrar primero BITACORA (hija) y luego CIUDADANO (padre)
'                Using cmd1 As New SqlCommand("DELETE FROM dbo.BITACORA_CIUDADANO;", cn, tx)
'                    cmd1.ExecuteNonQuery()
'                End Using

'                Using cmd2 As New SqlCommand("DELETE FROM dbo.CIUDADANO;", cn, tx)
'                    cmd2.ExecuteNonQuery()
'                End Using

'                ' 2) RESEED condicional SOLO si la tabla tiene IDENTITY
'                Dim sqlReseed As String =
'                    "IF EXISTS (SELECT 1 FROM sys.identity_columns WHERE object_id = OBJECT_ID('dbo.CIUDADANO'))
'                    BEGIN
'                        DBCC CHECKIDENT ('dbo.CIUDADANO', RESEED, 0);
'                    END;

'                    IF EXISTS (SELECT 1 FROM sys.identity_columns WHERE object_id = OBJECT_ID('dbo.BITACORA_CIUDADANO'))
'                    BEGIN
'                        DBCC CHECKIDENT ('dbo.BITACORA_CIUDADANO', RESEED, 0);
'                    END;

'                    IF OBJECT_ID('dbo.seq_bitacora', 'SO') IS NOT NULL
'                    BEGIN
'                        ALTER SEQUENCE dbo.seq_bitacora RESTART WITH 1;
'                    END;"

'                Using cmdReseed As New SqlCommand(sqlReseed, cn, tx)
'                    cmdReseed.CommandType = CommandType.Text
'                    cmdReseed.ExecuteNonQuery()
'                End Using

'                tx.Commit()
'                MessageBox.Show("Registros eliminados. Consecutivos reiniciados según corresponda.", "Éxito",
'                                MessageBoxButtons.OK, MessageBoxIcon.Information)

'            Catch ex As Exception
'                tx.Rollback()
'                MessageBox.Show("Error al eliminar/reiniciar: " & ex.Message, "Error",
'                                MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        End Using
'    End Using
'End Sub