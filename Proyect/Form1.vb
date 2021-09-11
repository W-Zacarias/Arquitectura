Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        'acciones inicializadoreas
        If Not SerialPort1.IsOpen Then
            Try
                SerialPort1.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub EscucharRecibirPuertoSerial(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datos As String = SerialPort1.ReadLine()
        If datos <> "" Or datos <> " " Or Not datos Is Nothing Then
            txtDatoRecibido.Text = datos
            Dim valor As Double = 0
            valor = txtDatoRecibido.Text
            If valor > 60 Then
                setProgresBar(valor, Color.Red)
            ElseIf valor > 35 And valor <= 60 Then
                setProgresBar(valor, Color.Yellow)
            ElseIf valor >= 0 And valor <= 35 Then
                setProgresBar(valor, Color.Green)
            ElseIf valor > 99 And valor <= 100 Then
                If MsgBox("La barra de Progreso esta llena") Then
                End If
            End If
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("GRACIAS POR UTILIZAR MI SOFTWARE - WILY ZACARIAS") Then
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
            End If
        End If
    End Sub

    Public Function setProgresBar(valor As String, color As Color)
        ProgressBar1.Value = valor
        ProgressBar1.ForeColor = color
        Return Nothing
    End Function

End Class