Imports System.Math
Public Class Form1

    Private Sub ButtonCALC_Click(sender As Object, e As EventArgs) Handles ButtonCALC.Click

        Dim CantidadCambioC As Double
        Dim TotalsinComisionC As Double
        Dim TotalComisionC As Double
        Dim CantidadV As Double
        Dim TotalsinComisionV As Double
        Dim TotalVenta As Double

        'LECTURA DE DATOS 

        CantidadCambioC = Val(TBcantidadC.Text)
        TotalsinComisionC = Val(TBtotalSinComisionC.Text)
        TotalComisionC = Val(TBTotalComisionC.Text)
        CantidadV = Val(TBcantidadV.Text)
        TotalsinComisionV = Val(TBtotalsincomisionV.Text)
        TotalVenta = Val(TBtotalVenta.Text)

        'CALCULOS COMPRA 

        If CBcompra.Checked = True Then
            If RBdolar.Checked = True Then
                TBtotalSinComisionC.Text = Round(Val(TBcantidadC.Text) * Dolar, 2)
            End If
            If RBpesomx.Checked = True Then
                TBtotalSinComisionC.Text = Round(Val(TBcantidadC.Text) * PMx, 2)
            End If
            If RBpesocolon.Checked = True Then
                TBtotalSinComisionC.Text = Round(Val(TBcantidadC.Text) * Colon, 2)
            End If
            If RBeuro.Checked = True Then
                TBtotalSinComisionC.Text = Round(Val(TBcantidadC.Text) * Euro, 2)

            End If

        End If

        If CBcompra.Checked = True Then
            TBTotalComisionC.Text = Round((TBtotalSinComisionC.Text * Ccompra) + (TBtotalSinComisionC.Text), 2)
        End If



        'CALCULO VENTA

        If CBVender.Checked = True Then
            If RBdolar.Checked = True Then
                TBtotalsincomisionV.Text = Round(Val(TBcantidadV.Text) * Dolar, 2)
            End If
            If RBpesomx.Checked = True Then
                TBtotalsincomisionV.Text = Round(Val(TBcantidadV.Text) * PMx, 2)
            End If
            If RBpesocolon.Checked = True Then
                TBtotalsincomisionV.Text = Round(Val(TBcantidadV.Text) * Colon, 2)
            End If
            If RBeuro.Checked = True Then
                TBtotalsincomisionV.Text = Round(Val(TBcantidadV.Text) * Euro, 2)

            End If


        End If
        If CBVender.Checked = True Then
            TBtotalVenta.Text = Round((TBtotalsincomisionV.Text * Ccventa) + (TBtotalsincomisionV.Text), 2)
        End If

        GroupBox4.Visible = True
        GroupBox5.Visible = True


    End Sub

    Private Sub ButtonLIMP_Click(sender As Object, e As EventArgs) Handles ButtonLIMP.Click
        'Procedimiento en Modulo1
        Limpiar()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE SALIDA") = vbYes) Then
            End
        Else
            Limpiar()
        End If
    End Sub
End Class
