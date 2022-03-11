<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmIngreso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngreso))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.txtArticulo2 = New System.Windows.Forms.TextBox
        Me.txtArticulo1 = New System.Windows.Forms.TextBox
        Me.txtEtiqueta = New System.Windows.Forms.TextBox
        Me.txtSerial = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.HardwareButton1 = New Microsoft.WindowsCE.Forms.HardwareButton
        Me.ErrorLongitud = New Microsoft.WindowsCE.Forms.Notification
        Me.ErrorArticulo = New Microsoft.WindowsCE.Forms.Notification
        Me.CargaExitosa = New Microsoft.WindowsCE.Forms.Notification
        Me.Label9 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "Volver a Principal"
        '
        'txtArticulo2
        '
        Me.txtArticulo2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular)
        Me.txtArticulo2.Location = New System.Drawing.Point(63, 137)
        Me.txtArticulo2.MaxLength = 20
        Me.txtArticulo2.Name = "txtArticulo2"
        Me.txtArticulo2.Size = New System.Drawing.Size(169, 24)
        Me.txtArticulo2.TabIndex = 17
        '
        'txtArticulo1
        '
        Me.txtArticulo1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular)
        Me.txtArticulo1.Location = New System.Drawing.Point(63, 54)
        Me.txtArticulo1.MaxLength = 20
        Me.txtArticulo1.Name = "txtArticulo1"
        Me.txtArticulo1.Size = New System.Drawing.Size(169, 24)
        Me.txtArticulo1.TabIndex = 15
        '
        'txtEtiqueta
        '
        Me.txtEtiqueta.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular)
        Me.txtEtiqueta.Location = New System.Drawing.Point(63, 165)
        Me.txtEtiqueta.MaxLength = 20
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.Size = New System.Drawing.Size(169, 24)
        Me.txtEtiqueta.TabIndex = 18
        '
        'txtSerial
        '
        Me.txtSerial.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular)
        Me.txtSerial.Location = New System.Drawing.Point(63, 82)
        Me.txtSerial.MaxLength = 20
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(169, 24)
        Me.txtSerial.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.Text = "Etiqueta :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.Text = "Artículo :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.Text = "Serial : "
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.Text = "Artículo :"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 219)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(102, 28)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
        Me.btnEnviar.Location = New System.Drawing.Point(131, 219)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(102, 28)
        Me.btnEnviar.TabIndex = 13
        Me.btnEnviar.Text = "Enviar Datos"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HardwareButton1
        '
        Me.HardwareButton1.AssociatedControl = Nothing
        Me.HardwareButton1.HardwareKey = Microsoft.WindowsCE.Forms.HardwareKeys.ApplicationKey1
        '
        'ErrorLongitud
        '
        Me.ErrorLongitud.Caption = "Información del sistema"
        Me.ErrorLongitud.Icon = CType(resources.GetObject("ErrorLongitud.Icon"), System.Drawing.Icon)
        Me.ErrorLongitud.InitialDuration = 5
        Me.ErrorLongitud.Text = "Longitud del campo incorrecta.  Por favor verifique el código ingresado."
        '
        'ErrorArticulo
        '
        Me.ErrorArticulo.Caption = "Información del sistema."
        Me.ErrorArticulo.InitialDuration = 5
        Me.ErrorArticulo.Text = "El artículo ingresado no es el correcto. Por favor verifique el artículo ingresad" & _
            "o."
        '
        'CargaExitosa
        '
        Me.CargaExitosa.Caption = "Informacion del Sistema."
        Me.CargaExitosa.InitialDuration = 5
        Me.CargaExitosa.Text = "Los datos fuerón almacenados satisfactoriamente. !!"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(6, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(234, 30)
        Me.Label9.Text = "Validación y transmición de articulos"
        '
        'FrmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtArticulo2)
        Me.Controls.Add(Me.txtArticulo1)
        Me.Controls.Add(Me.txtEtiqueta)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnEnviar)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Menu = Me.mainMenu1
        Me.Name = "FrmIngreso"
        Me.Text = "Control Artículo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtArticulo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtArticulo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEtiqueta As System.Windows.Forms.TextBox
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HardwareButton1 As Microsoft.WindowsCE.Forms.HardwareButton
    Friend WithEvents ErrorLongitud As Microsoft.WindowsCE.Forms.Notification
    Friend WithEvents ErrorArticulo As Microsoft.WindowsCE.Forms.Notification
    Friend WithEvents CargaExitosa As Microsoft.WindowsCE.Forms.Notification
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
