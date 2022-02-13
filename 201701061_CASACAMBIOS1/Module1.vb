Module Module1
    Public Const Dolar = 7.69
    Public Const PMx = 0.38
    Public Const Colon = 0.012
    Public Const Euro = 8.79
    Public Const Ccompra = 0.025
    Public Const Ccventa = 0.03



    Sub Limpiar()
    'procedimiento que limpia los objetos de ingreso de datos y selección de opciones
    Form1.TBcantidadC.Clear()
    Form1.TBTotalComisionC.Clear()
    Form1.TBcantidadV.Clear()
    Form1.TBTotalComisionC.Clear()
    Form1.TBtotalsincomisionV.Clear()
    Form1.TBtotalVenta.Clear()

    Form1.RBdolar.Checked = False
    Form1.RBeuro.Checked = 0
    Form1.RBpesocolon.Checked = 0
    Form1.RBpesomx.Checked = False
    Form1.CBcompra.Checked = 0
    Form1.CBVender.Checked = False

    'se procede a ocultar las cajas de texto de los resultados
    Form1.GroupBox5.Visible = False
    Form1.GroupBox4.Visible = False


End Sub

End Module