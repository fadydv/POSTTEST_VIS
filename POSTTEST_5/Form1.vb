Public Class Form1
	Dim selectedID As Integer = 0

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadComboBox()

		KondisiAwal()
	End Sub

	Sub KondisiAwal()
		dgvProduk.DataSource = GetAllProduk()

		SembunyikanKolomID()

		txtNama.Clear()
		txtWarna.Clear()
		txtHarga.Clear()
		txtStok.Clear()
		txtSearch.Clear()

		ErrorProvider1.Clear()

		selectedID = 0

		cmbBrand.SelectedIndex = -1
		cmbKategori.SelectedIndex = -1
	End Sub

	Sub LoadComboBox()
		cmbBrand.DataSource = GetBrands()
		cmbBrand.DisplayMember = "nama_brand"
		cmbBrand.ValueMember = "id_brand"
		cmbBrand.SelectedIndex = -1

		cmbKategori.DataSource = GetCategories()
		cmbKategori.DisplayMember = "nama_kategori"
		cmbKategori.ValueMember = "id_kategori"
		cmbKategori.SelectedIndex = -1
	End Sub

	Sub SembunyikanKolomID()
		If dgvProduk.Columns.Count > 4 Then
			dgvProduk.Columns(2).Visible = False
			dgvProduk.Columns(4).Visible = False
		End If
	End Sub

	Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
		Dim vNama = ValidasiKosong(ErrorProvider1, txtNama, "Nama produk wajib diisi!")

		If cmbBrand.SelectedIndex = -1 Then
			MessageBox.Show("Silakan pilih Brand terlebih dahulu!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If

		If cmbKategori.SelectedIndex = -1 Then
			MessageBox.Show("Silakan pilih Kategori terlebih dahulu!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If

		If vNama Then
			Dim idB As Integer = CInt(cmbBrand.SelectedValue)
			Dim idK As Integer = CInt(cmbKategori.SelectedValue)

			If SimpanProduk(txtNama.Text, idB, idK, txtWarna.Text, Val(txtHarga.Text), Val(txtStok.Text)) Then
				MessageBox.Show("Produk Berhasil Disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
				KondisiAwal()
			End If
		End If
	End Sub

	Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
		If selectedID = 0 Then
			MessageBox.Show("Pilih data lipstick pada tabel yang ingin dihapus!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If

		If MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
			If HapusProduk(selectedID) Then
				MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
				KondisiAwal()
			End If
		End If
	End Sub

	Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
		KondisiAwal()
	End Sub

	Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
		dgvProduk.DataSource = SearchProduk(txtSearch.Text)
		SembunyikanKolomID()
	End Sub

	Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
		If e.RowIndex >= 0 Then
			Dim row As DataGridViewRow = dgvProduk.Rows(e.RowIndex)

			selectedID = Val(row.Cells(0).Value)

			txtNama.Text = row.Cells(1).Value.ToString()

			cmbBrand.SelectedValue = row.Cells(2).Value
			cmbKategori.SelectedValue = row.Cells(4).Value

			txtWarna.Text = row.Cells(6).Value.ToString()
			txtHarga.Text = row.Cells(7).Value.ToString()
			txtStok.Text = row.Cells(8).Value.ToString()
		End If
	End Sub

	Private Sub lblMenuBrand_Click(sender As Object, e As EventArgs) Handles lblMenuBrand.Click
		Form2.Show()
	End Sub

	Private Sub lblMenuKategori_Click(sender As Object, e As EventArgs) Handles lblMenuKategori.Click
		Form3.Show()
	End Sub

	Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
		HanyaAngka(e)
	End Sub

	Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
		HanyaAngka(e)
	End Sub

	Private Sub header_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

	End Sub
End Class