Imports System.Security.Cryptography
Imports System.Text

Module Security
    ' Formato de almacenamiento: PBKDF2$<iteraciones>$<saltBase64>$<hashBase64>
    Public UsuarioActual, RolActual As String
    Private Const ALG As String = "PBKDF2"

    ' Función para hashear la contraseña
    Public Function HashPassword(password As String, Optional iterations As Integer = 100000) As String
        If String.IsNullOrEmpty(password) Then Throw New ArgumentException("password vacío")

        Dim salt(31) As Byte ' 32 bytes
        Using rng = New RNGCryptoServiceProvider()
            rng.GetBytes(salt)
        End Using

        Dim hash() As Byte
        Using pbkdf2 As New Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256)
            hash = pbkdf2.GetBytes(32) ' 256-bit
        End Using

        Dim sSalt = Convert.ToBase64String(salt)
        Dim sHash = Convert.ToBase64String(hash)
        Return $"{ALG}${iterations}${sSalt}${sHash}"
    End Function

    ' Función para validar la contraseña contra el hash almacenado
    Public Function VerifyPassword(password As String, stored As String) As Boolean
        ' Evita “Demasiados argumentos…” manteniendo esta firma exacta.
        If String.IsNullOrWhiteSpace(stored) Then Return False

        Dim parts = stored.Split("$"c)
        If parts.Length <> 4 Then Return False
        If parts(0) <> ALG Then Return False

        Dim iterations As Integer
        If Not Integer.TryParse(parts(1), iterations) Then Return False

        Dim salt() As Byte
        Dim targetHash() As Byte
        Try
            salt = Convert.FromBase64String(parts(2))
            targetHash = Convert.FromBase64String(parts(3))
        Catch
            Return False
        End Try

        Dim computed() As Byte
        Using pbkdf2 As New Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256)
            computed = pbkdf2.GetBytes(targetHash.Length)
        End Using

        ' Comparación constante (sin CryptographicOperations)
        Return FixedTimeEquals(computed, targetHash)
    End Function

    ' Función de comparación en tiempo fijo
    Private Function FixedTimeEquals(a() As Byte, b() As Byte) As Boolean
        If a Is Nothing OrElse b Is Nothing OrElse a.Length <> b.Length Then Return False
        Dim diff As Integer = 0
        For i = 0 To a.Length - 1
            diff = diff Or (a(i) Xor b(i))
        Next
        Return diff = 0
    End Function
End Module
