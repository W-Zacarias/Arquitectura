Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formView As New Form1
        formView.Close()
        Control.CheckForIllegalCrossThreadCalls = False
        'acciones inicializadoreas
        If Not SerialPort1.IsOpen Then
            Try
                SerialPort1.Open()
                Dim dato As String = SerialPort1.ReadLine()
                dato = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub EscucharRecibirPuertoSerial(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datos As String = SerialPort1.ReadLine()

        If datos <> "" Or datos <> " " Or Not datos Is Nothing Then

            If datos.Contains("R") Then
                TextBox1.AppendText(datos.Replace("R", vbCrLf))
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        Dim formView As New Form1
        Me.Hide()
        formView.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        Me.Close()
    End Sub

    Dim aux As String

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub



End Class