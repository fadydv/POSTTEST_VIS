Public Class Form1

    Sub TampilData()
        lstBuku.Items.Clear()

        For i As Integer = 0 To HitungJumlah() - 1
            lstBuku.Items.Add(judulBuku(i) & " - " & genreBuku(i))
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJudul.Text <> "" And txtGenre.Text <> "" Then
            TambahData(txtJudul.Text, txtGenre.Text)
            TampilData()

            txtJudul.Clear()
            txtGenre.Clear()
            txtJudul.Focus()
        Else
            MsgBox("Mohon isi Judul dan Genre buku!")
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtHapus.Text <> "" Then
            HapusData(txtHapus.Text)
            TampilData()
            txtHapus.Clear()
        Else
            MsgBox("Masukkan judul buku yang ingin dihapus!")
        End If
    End Sub

End Class