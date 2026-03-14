Public Class FormCetak

	Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub


	Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

		Dim openFoto As New OpenFileDialog
		openFoto.Filter = "Image Files|*.jpg;*.png;*.jpeg"

		If openFoto.ShowDialog = DialogResult.OK Then
			pbFoto.Image = Image.FromFile(openFoto.FileName)
		End If

	End Sub


	Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

		Dim formHasil As New FormHasil

		formHasil.txtNama.Text = txtNama.Text
		formHasil.txtUmur.Text = txtUmur.Text
		formHasil.txtTanggal.Text = dtpTanggal.Text
		formHasil.txtTelepon.Text = txtTelepon.Text
		formHasil.txtAlamat.Text = txtAlamat.Text

		formHasil.pbFotoHasil.Image = pbFoto.Image

		Dim hobby As String = ""

		If cbGame.Checked Then hobby &= "Gaming, "
		If cbCoding.Checked Then hobby &= "Coding, "
		If cbTraveling.Checked Then hobby &= "Traveling, "
		If cbMenggambar.Checked Then hobby &= "Menggambar, "
		If cbMenulis.Checked Then hobby &= "Menulis, "

		If cbMemancing.Checked Then hobby &= "Memancing, "
		If cbMembaca.Checked Then hobby &= "Membaca, "
		If cbOlahraga.Checked Then hobby &= "Olahraga, "
		If cbMenyanyi.Checked Then hobby &= "Menyanyi, "
		If cbMenari.Checked Then hobby &= "Menari, "

		formHasil.txtHobby.Text = hobby

		formHasil.Show()

	End Sub

	Private Sub cbMenggambar_CheckedChanged(sender As Object, e As EventArgs) Handles cbMenggambar.CheckedChanged

	End Sub
End Class