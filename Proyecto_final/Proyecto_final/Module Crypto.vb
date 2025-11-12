Imports System.Security.Cryptography
Imports System.Text

Module Crypto

    Private Const Iterations As Integer = 100000
    Private Const SaltSize As Integer = 16
    Private Const KeySize As Integer = 32

    ' Genera hash seguro para guardar en BD
    Public Function HashPassword(password As String) As String
        Dim salt(SaltSize - 1) As Byte
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(salt)
        End Using

        Dim hash() As Byte
        Using pbkdf2 As New Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256)
            hash = pbkdf2.GetBytes(KeySize)
        End Using

        Return $"{Iterations}:{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}"
    End Function

    ' Verifica contraseña ingresada contra la guardada en BD
    Public Function VerifyPassword(password As String, stored As String) As Boolean
        Dim parts = stored.Split(":"c)
        Dim iter = Integer.Parse(parts(0))
        Dim salt = Convert.FromBase64String(parts(1))
        Dim expected = Convert.FromBase64String(parts(2))

        Dim actual() As Byte
        Using pbkdf2 As New Rfc2898DeriveBytes(password, salt, iter, HashAlgorithmName.SHA256)
            actual = pbkdf2.GetBytes(expected.Length)
        End Using

        Return FixedTimeEquals(actual, expected)
    End Function

    ' Reemplazo de CryptographicOperations.FixedTimeEquals
    Private Function FixedTimeEquals(a() As Byte, b() As Byte) As Boolean
        If a Is Nothing OrElse b Is Nothing OrElse a.Length <> b.Length Then Return False
        Dim diff As Integer = 0
        For i = 0 To a.Length - 1
            diff = diff Or (a(i) Xor b(i))
        Next
        Return diff = 0
    End Function

End Module










