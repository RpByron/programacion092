<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBcantidadC = New System.Windows.Forms.TextBox()
        Me.CBcompra = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBcantidadV = New System.Windows.Forms.TextBox()
        Me.CBVender = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBeuro = New System.Windows.Forms.RadioButton()
        Me.RBpesocolon = New System.Windows.Forms.RadioButton()
        Me.RBpesomx = New System.Windows.Forms.RadioButton()
        Me.RBdolar = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBTotalComisionC = New System.Windows.Forms.TextBox()
        Me.TBtotalSinComisionC = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBtotalVenta = New System.Windows.Forms.TextBox()
        Me.TBtotalsincomisionV = New System.Windows.Forms.TextBox()
        Me.ButtonCALC = New System.Windows.Forms.Button()
        Me.ButtonLIMP = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBcantidadC)
        Me.GroupBox1.Controls.Add(Me.CBcompra)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compra "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cantidad "
        '
        'TBcantidadC
        '
        Me.TBcantidadC.Location = New System.Drawing.Point(202, 74)
        Me.TBcantidadC.Name = "TBcantidadC"
        Me.TBcantidadC.Size = New System.Drawing.Size(125, 27)
        Me.TBcantidadC.TabIndex = 1
        '
        'CBcompra
        '
        Me.CBcompra.AutoSize = True
        Me.CBcompra.Location = New System.Drawing.Point(24, 42)
        Me.CBcompra.Name = "CBcompra"
        Me.CBcompra.Size = New System.Drawing.Size(84, 24)
        Me.CBcompra.TabIndex = 0
        Me.CBcompra.Text = "Compra"
        Me.CBcompra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TBcantidadV)
        Me.GroupBox2.Controls.Add(Me.CBVender)
        Me.GroupBox2.Location = New System.Drawing.Point(388, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 125)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad "
        '
        'TBcantidadV
        '
        Me.TBcantidadV.Location = New System.Drawing.Point(179, 74)
        Me.TBcantidadV.Name = "TBcantidadV"
        Me.TBcantidadV.Size = New System.Drawing.Size(125, 27)
        Me.TBcantidadV.TabIndex = 2
        '
        'CBVender
        '
        Me.CBVender.AutoSize = True
        Me.CBVender.Location = New System.Drawing.Point(23, 42)
        Me.CBVender.Name = "CBVender"
        Me.CBVender.Size = New System.Drawing.Size(81, 24)
        Me.CBVender.TabIndex = 1
        Me.CBVender.Text = "Vender "
        Me.CBVender.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.RBeuro)
        Me.GroupBox3.Controls.Add(Me.RBpesocolon)
        Me.GroupBox3.Controls.Add(Me.RBpesomx)
        Me.GroupBox3.Controls.Add(Me.RBdolar)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 155)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(744, 70)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione la moneda que desee "
        '
        'RBeuro
        '
        Me.RBeuro.AutoSize = True
        Me.RBeuro.Location = New System.Drawing.Point(611, 31)
        Me.RBeuro.Name = "RBeuro"
        Me.RBeuro.Size = New System.Drawing.Size(64, 24)
        Me.RBeuro.TabIndex = 3
        Me.RBeuro.TabStop = True
        Me.RBeuro.Text = "Euro "
        Me.RBeuro.UseVisualStyleBackColor = True
        '
        'RBpesocolon
        '
        Me.RBpesocolon.AutoSize = True
        Me.RBpesocolon.Location = New System.Drawing.Point(421, 31)
        Me.RBpesocolon.Name = "RBpesocolon"
        Me.RBpesocolon.Size = New System.Drawing.Size(73, 24)
        Me.RBpesocolon.TabIndex = 2
        Me.RBpesocolon.TabStop = True
        Me.RBpesocolon.Text = "Colon "
        Me.RBpesocolon.UseVisualStyleBackColor = True
        '
        'RBpesomx
        '
        Me.RBpesomx.AutoSize = True
        Me.RBpesomx.Location = New System.Drawing.Point(239, 31)
        Me.RBpesomx.Name = "RBpesomx"
        Me.RBpesomx.Size = New System.Drawing.Size(88, 24)
        Me.RBpesomx.TabIndex = 1
        Me.RBpesomx.TabStop = True
        Me.RBpesomx.Text = "Peso Mx "
        Me.RBpesomx.UseVisualStyleBackColor = True
        '
        'RBdolar
        '
        Me.RBdolar.AutoSize = True
        Me.RBdolar.Location = New System.Drawing.Point(70, 31)
        Me.RBdolar.Name = "RBdolar"
        Me.RBdolar.Size = New System.Drawing.Size(71, 24)
        Me.RBdolar.TabIndex = 0
        Me.RBdolar.TabStop = True
        Me.RBdolar.Text = "Dolar "
        Me.RBdolar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TBTotalComisionC)
        Me.GroupBox4.Controls.Add(Me.TBtotalSinComisionC)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 231)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 141)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tatal para la compra "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total sin comision "
        '
        'TBTotalComisionC
        '
        Me.TBTotalComisionC.Location = New System.Drawing.Point(202, 90)
        Me.TBTotalComisionC.Name = "TBTotalComisionC"
        Me.TBTotalComisionC.Size = New System.Drawing.Size(125, 27)
        Me.TBTotalComisionC.TabIndex = 4
        '
        'TBtotalSinComisionC
        '
        Me.TBtotalSinComisionC.Location = New System.Drawing.Point(202, 44)
        Me.TBtotalSinComisionC.Name = "TBtotalSinComisionC"
        Me.TBtotalSinComisionC.Size = New System.Drawing.Size(125, 27)
        Me.TBtotalSinComisionC.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.TBtotalVenta)
        Me.GroupBox5.Controls.Add(Me.TBtotalsincomisionV)
        Me.GroupBox5.Location = New System.Drawing.Point(388, 231)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(384, 141)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total para la venta "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Total sin comision "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 10
        '
        'TBtotalVenta
        '
        Me.TBtotalVenta.Location = New System.Drawing.Point(179, 90)
        Me.TBtotalVenta.Name = "TBtotalVenta"
        Me.TBtotalVenta.Size = New System.Drawing.Size(125, 27)
        Me.TBtotalVenta.TabIndex = 6
        '
        'TBtotalsincomisionV
        '
        Me.TBtotalsincomisionV.Location = New System.Drawing.Point(179, 40)
        Me.TBtotalsincomisionV.Name = "TBtotalsincomisionV"
        Me.TBtotalsincomisionV.Size = New System.Drawing.Size(125, 27)
        Me.TBtotalsincomisionV.TabIndex = 5
        '
        'ButtonCALC
        '
        Me.ButtonCALC.Location = New System.Drawing.Point(338, 394)
        Me.ButtonCALC.Name = "ButtonCALC"
        Me.ButtonCALC.Size = New System.Drawing.Size(94, 29)
        Me.ButtonCALC.TabIndex = 4
        Me.ButtonCALC.Text = "CALCULAR"
        Me.ButtonCALC.UseVisualStyleBackColor = True
        '
        'ButtonLIMP
        '
        Me.ButtonLIMP.Location = New System.Drawing.Point(107, 394)
        Me.ButtonLIMP.Name = "ButtonLIMP"
        Me.ButtonLIMP.Size = New System.Drawing.Size(94, 29)
        Me.ButtonLIMP.TabIndex = 5
        Me.ButtonLIMP.Text = "LIMPIAR"
        Me.ButtonLIMP.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(567, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "SALIR "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonLIMP)
        Me.Controls.Add(Me.ButtonCALC)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBcompra As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBVender As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ButtonCALC As Button
    Friend WithEvents ButtonLIMP As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents RBeuro As RadioButton
    Friend WithEvents RBpesocolon As RadioButton
    Friend WithEvents RBpesomx As RadioButton
    Friend WithEvents RBdolar As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TBcantidadC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBcantidadV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBTotalComisionC As TextBox
    Friend WithEvents TBtotalSinComisionC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBtotalVenta As TextBox
    Friend WithEvents TBtotalsincomisionV As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
