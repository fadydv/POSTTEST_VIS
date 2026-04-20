Imports MySqlConnector

Public Class Form3
    Dim selectedID As Integer = 0

    Sub Tampil()
        dgvKategori.DataSource = GetCategories()
    End Sub

    Sub KondisiAwal()
        Tampil()
        txtKategori.Clear()
        selectedID = 0
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtKategori.Text.Trim() = "" Then
            MessageBox.Show("Nama kategori tidak boleh kosong!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If SimpanKategori(txtKategori.Text.Trim()) Then
            MessageBox.Show("Kategori berhasil ditambah!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            KondisiAwal()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedID = 0 Then
            MessageBox.Show("Pilih kategori yang ingin diubah!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtKategori.Text.Trim() = "" Then
            MessageBox.Show("Nama kategori tidak boleh kosong!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If UbahKategori(selectedID, txtKategori.Text.Trim()) Then
            MessageBox.Show("Kategori berhasil diubah!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            KondisiAwal()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedID = 0 Then
            MessageBox.Show("Pilih kategori yang ingin dihapus!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("Yakin ingin menghapus kategori ini?",
                           "Konfirmasi", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            If HapusKategori(selectedID) Then
                MessageBox.Show("Kategori berhasil dihapus!", "Sukses",
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

    Private Sub dgvKategori_CellClick(sender As Object,
                e As DataGridViewCellEventArgs) Handles dgvKategori.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvKategori.Rows(e.RowIndex)
            selectedID = CInt(row.Cells("id_kategori").Value)
            txtKategori.Text = row.Cells("nama_kategori").Value.ToString()
        End If
    End Sub
End Class