Imports System.Globalization
Imports System.Threading
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Menú Principal"
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-CR")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-CR")
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Txt_fecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM yyyy hh:mm:ss tt")
    End Sub

    ' Botón 1: Administrador
    Private Sub BtnAdministrador_Click(sender As Object, e As EventArgs) Handles BtnAdministrador.Click
        Dim login As New FormLogin("ADMIN") ' rol forzado
        login.ShowDialog()
    End Sub

    ' Botón 2: Consumibles
    Private Sub BtnConsumibles_Click(sender As Object, e As EventArgs) Handles BtnConsumibles.Click
        Dim login As New FormLogin("CONSUMIBLES") ' rol forzado
        login.ShowDialog()
    End Sub

    ' Botón 3: Consultas (sin login)
    Private Sub BtnConsultas_Click(sender As Object, e As EventArgs) Handles BtnConsultas.Click
        Dim f As New Form4_Consultas()
        f.Show()
    End Sub

    ' Botón 4: Salir
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub


End Class

