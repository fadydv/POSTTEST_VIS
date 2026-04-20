Imports MySqlConnector

Public Class Form2
    Dim selectedID As Integer = 0

    Sub Tampil()
        dgvBrand.DataSource = GetBrands()
    End Sub

    Sub KondisiAwal()
        Tampil()
        txtBrand.Clear()
        selectedID = 0
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtBrand.Text.Trim() = "" Then
            MessageBox.Show("Nama brand tidak boleh kosong!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If SimpanBrand(txtBrand.Text.Trim()) Then
            MessageBox.Show("Brand berhasil ditambah!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            KondisiAwal()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedID = 0 Then
            MessageBox.Show("Pilih brand yang ingin diubah!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtBrand.Text.Trim() = "" Then
            MessageBox.Show("Nama brand tidak boleh kosong!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If UbahBrand(selectedID, txtBrand.Text.Trim()) Then
            MessageBox.Show("Brand berhasil diubah!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            KondisiAwal()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedID = 0 Then
            MessageBox.Show("Pilih brand yang ingin dihapus!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("Yakin ingin menghapus brand ini?" &
                           vbCrLf & "(Produk dengan brand ini tidak akan terhapus)",
                           "Konfirmasi", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            If HapusBrand(selectedID) Then
                MessageBox.Show("Brand berhasil dihapus!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                KondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KondisiAwal()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub dgvBrand_CellClick(sender As Object,
                e As DataGridViewCellEventArgs) Handles dgvBrand.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBrand.Rows(e.RowIndex)
            selectedID = CInt(row.Cells("id_brand").Value)
            txtBrand.Text = row.Cells("nama_brand").Value.ToString()
        End If
    End Sub

    Private Sub card_Paint(sender As Object, e As PaintEventArgs) Handles card.Paint
    End Sub
End Class