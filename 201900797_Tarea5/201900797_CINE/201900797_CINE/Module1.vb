Module Module1
    Public vFuncion(8)
    Public vCine(8)
    Public SubTotal_a_pagar(8)
    Public vDescuento1(8)
    Public Descuento2(8)
    Public total_a_pagar(8)

    Public indice = 0


    Public calculo_subtotal As Double = 0
    Public calculo_desc1 As Double = 0

    Function calcularSubtotal(funcion As String, cine As String) As Double
        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 30
                    Case "2"
                        calculo_subtotal = 35
                    Case Else
                        calculo_subtotal = 40
                End Select
            Case "B"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 24
                    Case "2"
                        calculo_subtotal = 34
                    Case Else
                        calculo_subtotal = 44
                End Select

            Case "C"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 35
                    Case "2"
                        calculo_subtotal = 40
                    Case Else
                        calculo_subtotal = 50
                End Select

        End Select
        Return calculo_subtotal
    End Function

    Function calculoDescuento1(funcion As String, cine As String) As Double
        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then
            calculoDescuento1 = 0.055
        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            calculoDescuento1 = 0.03
        ElseIf (funcion = "2") And (cine = "A") Then
            calculoDescuento1 = 0.015
        End If
        Return calculoDescuento1
    End Function

End Module
