Imports System.Data.SqlClient
Module Funciones
    ' Variables globales
    Public f, k, ntipoid As Integer
    'Crear método para validar solo mayusculas
    Public Sub Set_solo_letras(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
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
    Public Sub Set_solo_numeros(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim numerosPermitidos As String
        numerosPermitidos = "0123456789"
        If InStr(numerosPermitidos, ee.KeyChar) > 0 OrElse Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
        End If
    End Sub
    Public Sub EstiloProfesionalDataGrid(dgv As DataGridView)

        ' 🔹 Borde y líneas
        dgv.BorderStyle = BorderStyle.FixedSingle
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.GridColor = Color.LightGray

        ' 🔹 Ajustar tamaño automático
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' 🔹 Quitar fila vacía al final
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False


        ' 🔹 Selección completa
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.MultiSelect = False

        ' 🔹 Encabezados profesionales
        With dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.FromArgb(30, 60, 90)     ' Azul corporativo oscuro
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        dgv.EnableHeadersVisualStyles = False

        ' 🔹 Filas estilo corporativo
        With dgv.DefaultCellStyle
            .Font = New Font("Segoe UI", 8, FontStyle.Regular)
            .BackColor = Color.White
            .ForeColor = Color.Black
            .SelectionBackColor = Color.FromArgb(224, 238, 255)  ' Azul muy suave
            .SelectionForeColor = Color.Black
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        ' Alternar color de filas
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

        ' 🔹 Borde exterior elegante
        dgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single
        dgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single

    End Sub

End Module