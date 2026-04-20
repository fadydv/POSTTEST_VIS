Public Class Form4
    Dim selectedID As Integer = 0

    Sub KondisiAwal()
        dgvReview.DataSource = GetAllReview()
        SembunyikanKolomID()
        txtReviewer.Clear()
        txtRating.Clear()
        txtKomentar.Clear()
        dtpTanggal.Value = DateTime.Today
        txtSearch.Clear()
        ErrorProvider1.Clear()
        selectedID = 0
        cmbProduk.SelectedIndex = -1
    End Sub

    Sub SembunyikanKolomID()
        If dgvReview.Columns.Count > 0 Then
            If dgvReview.Columns.Contains("id_review") Then
                dgvReview.Columns("id_review").Visible = False
            End If
        End If
    End Sub

    Sub LoadCombo()
        cmbProduk.DataSource = GetProdukList()
        cmbProduk.DisplayMember = "nama_produk"
        cmbProduk.ValueMember = "id_produk"
        cmbProduk.SelectedIndex = -1
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo()
        KondisiAwal()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        Dim vRev = ValidasiKosong(ErrorProvider1, txtReviewer, "Nama reviewer wajib diisi!")
        Dim vRat = ValidasiRating(ErrorProvider1, txtRating)
        If Not vRev Or Not vRat Then Return
        If cmbProduk.SelectedIndex = -1 Then
            MessageBox.Show("Pilih produk terlebih dahulu!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If SimpanReview(CInt(cmbProduk.SelectedValue),
                        txtReviewer.Text.Trim(),
                        CInt(txtRating.Text.Trim()),
                        txtKomentar.Text.Trim(),
                        dtpTanggal.Value.ToString("yyyy-MM-dd")) Then
            MessageBox.Show("Review berhasil disimpan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCombo()
            KondisiAwal()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedID = 0 Then
            MessageBox.Show("Pilih review yang ingin diubah!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ErrorProvider1.Clear()
        Dim vRev = ValidasiKosong(ErrorProvider1, txtReviewer, "Nama reviewer wajib diisi!")
        Dim vRat = ValidasiRating(ErrorProvider1, txtRating)
        If Not vRev Or Not vRat Then Return

        If UbahReview(selectedID,
                      CInt(cmbProduk.SelectedValue),
                      txtReviewer.Text.Trim(),
                      CInt(txtRating.Text.Trim()),
                      txtKomentar.Text.Trim(),
                      dtpTanggal.Value.ToString("yyyy-MM-dd")) Then
            MessageBox.Show("Review berhasil diubah!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCombo()
            KondisiAwal()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedID = 0 Then
            MessageBox.Show("Pilih review yang ingin dihapus!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("Yakin ingin menghapus review ini?",
                           "Konfirmasi", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            If HapusReview(selectedID) Then
                MessageBox.Show("Review berhasil dihapus!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadCombo()
                KondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        LoadCombo()
        KondisiAwal()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub dgvReview_CellClick(sender As Object,
                e As DataGridViewCellEventArgs) Handles dgvReview.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvReview.Rows(e.RowIndex)
            selectedID = CInt(row.Cells("id_review").Value)
            cmbProduk.Text = row.Cells("nama_produk").Value.ToString()
            txtReviewer.Text = row.Cells("nama_reviewer").Value.ToString()
            txtRating.Text = row.Cells("rating").Value.ToString()
            txtKomentar.Text = row.Cells("komentar").Value.ToString()
            Dim tgl As DateTime
            If DateTime.TryParse(row.Cells("tgl_review").Value.ToString(), tgl) Then
                dtpTanggal.Value = tgl
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) _
        Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            dgvReview.DataSource = GetAllReview()
        Else
            dgvReview.DataSource = SearchReview(txtSearch.Text.Trim())
        End If
        SembunyikanKolomID()
    End Sub

    Private Sub txtRating_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtRating.KeyPress
        HanyaAngka(e)
    End Sub
End Class