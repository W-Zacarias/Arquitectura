<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtDatoRecibido = New System.Windows.Forms.TextBox()
        Me.res = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ProgressBar1.Location = New System.Drawing.Point(45, 247)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(415, 43)
        Me.ProgressBar1.TabIndex = 0
        '
        'txtDatoRecibido
        '
        Me.txtDatoRecibido.BackColor = System.Drawing.Color.Maroon
        Me.txtDatoRecibido.Enabled = False
        Me.txtDatoRecibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatoRecibido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDatoRecibido.Location = New System.Drawing.Point(85, 123)
        Me.txtDatoRecibido.Multiline = True
        Me.txtDatoRecibido.Name = "txtDatoRecibido"
        Me.txtDatoRecibido.Size = New System.Drawing.Size(342, 105)
        Me.txtDatoRecibido.TabIndex = 6
        Me.txtDatoRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'res
        '
        Me.res.Enabled = False
        Me.res.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.res.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.res.Location = New System.Drawing.Point(183, 317)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(146, 29)
        Me.res.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TEMPERATURA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(539, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.txtDatoRecibido)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txtDatoRecibido As TextBox
    Friend WithEvents res As TextBox
    Friend WithEvents Label1 As Label
End Class
