Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(calcularSubtotal("4", "A"))

        If indice < 9 Then
            vFuncion(indice) = ComboBox2.SelectedItem
            vCine(indice) = ComboBox1.SelectedItem
            SubTotal_a_pagar(indice) = calcularSubtotal(vFuncion(indice), vCine(indice))
            vDescuento1(indice) = SubTotal_a_pagar(indice) * calculoDescuento1(vFuncion(indice), vCine(indice))

            Funcion.Items.Add(vFuncion(indice))
            Cine.Items.Add(vCine(indice))
            SubTotal.Items.Add(SubTotal_a_pagar(indice))
            Descuento1.Items.Add(vDescuento1(indice))

        ElseIf indice >= 9 Then

        End If
    End Sub
End Class
