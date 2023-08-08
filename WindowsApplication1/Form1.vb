Public Class frmDivisibilidade

    Private Function IsDivididoPor(Numero As Long, DivNumero As Long) As Boolean

        If DivNumero <> 0 Then
            Return Numero Mod DivNumero = 0
        End If

        Return False

    End Function

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lstResultado.Items.Clear()

        Dim numero As Integer = Convert.ToInt32(txtNumero.Text)

        Dim valor(20) As Boolean

        For x = 1 To 20
            valor(x) = IsDivididoPor(numero, x)
        Next

        If valor.Any(Function(x) x.Equals(False)) Then
            lstResultado.Items.Add(numero & " é divisível por: ")
        End If

        For y = 1 To 20
            If valor(y) Then
                lstResultado.Items.Add(y)
            End If
        Next
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            If (Asc(e.KeyChar) = 8) Then
                e.Handled = False
            End If
        End If
    End Sub
End Class
