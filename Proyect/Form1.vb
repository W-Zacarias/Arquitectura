Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Label5.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False

        'acciones inicializadoreas
        If Not SerialPort1.IsOpen Then
            Try
                SerialPort1.Open()
                Dim dato As String = SerialPort1.ReadLine()
                dato = " "

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub EscucharRecibirPuertoSerial(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Dim datos As String = SerialPort1.ReadLine()

        If datos <> "" Or datos <> " " Or Not datos Is Nothing Then

            If datos.Contains("T") Then
                txtDatoRecibidoT.Text = datos.Replace("T", "")
                Dim valor As Integer = 0
                valor = txtDatoRecibidoT.Text
                If valor > 27 Then
                    setProgresBar(valor, Color.Red)
                ElseIf valor > 27 And valor <= 28 Then
                    setProgresBar(valor, Color.Yellow)
                ElseIf valor >= 0 And valor <= 27 Then
                    setProgresBar(valor, Color.Green)
                ElseIf valor > 99 And valor <= 100 Then
                    If MsgBox("La barra de Progreso esta llena") Then
                    End If
                End If
            ElseIf datos.Contains("D") Then
                CircularProgressBar1.Text = datos.Replace("D", "")
                Dim valor1 As Integer = 0
                valor1 = CircularProgressBar1.Text

                If valor1 >= 0 And valor1 <= 5 Then
                    CircularProgressBar1.Value = 100 - valor1
                    CircularProgressBar1.ForeColor = Color.Red
                    CircularProgressBar1.Text = (valor1).ToString() + "CM"
                    Label5.Visible = False
                    If MsgBox("ALGUIEN ESTA CERCA") Then
                        PictureBox3.Visible = True
                    End If
                ElseIf valor1 >= 6 And valor1 <= 10 Then
                    CircularProgressBar1.Value = 100 - valor1
                    CircularProgressBar1.ForeColor = Color.Yellow
                    CircularProgressBar1.Text = (valor1).ToString() + "CM"
                    PictureBox2.Visible = True
                    Label5.Visible = True
                ElseIf valor1 >= 10 Then
                    CircularProgressBar1.Value = 100 - valor1
                End If
            ElseIf datos.Contains("X") Then
                res.Text = datos.Replace("X", "")

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
    Public Function setCirProgresBar(valor As String, color As Color)
        CircularProgressBar1.Value = valor
        CircularProgressBar1.ForeColor = color
        Return Nothing
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        Dim formView As New Form2
        Me.Hide()
        formView.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class