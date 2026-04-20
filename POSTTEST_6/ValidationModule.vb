Module ValidationModule
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiKosong(ep As ErrorProvider,
                                    txt As TextBox,
                                    pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiCombo(ep As ErrorProvider,
                                   cmb As ComboBox,
                                   pesan As String) As Boolean
        If cmb.SelectedIndex = -1 Then
            ep.SetError(cmb, pesan)
            Return False
        Else
            ep.SetError(cmb, "")
            Return True
        End If
    End Function

    Public Function ValidasiRating(ep As ErrorProvider,
                                    txt As TextBox) As Boolean
        Dim val As Integer
        If Not Integer.TryParse(txt.Text.Trim(), val) OrElse val < 1 OrElse val > 5 Then
            ep.SetError(txt, "Rating harus angka 1 - 5!")
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function
End Module