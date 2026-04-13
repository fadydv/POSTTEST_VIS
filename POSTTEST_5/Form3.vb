Imports MySqlConnector

Public Class Form3
	Sub Tampil()
		dgvKategori.DataSource = GetCategories()
	End Sub

	Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Tampil()
	End Sub

	Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
		If txtKategori.Text = "" Then Return
		Try
			Using conn = GetConnection()
				conn.Open()
				Dim sql = "INSERT INTO tb_kategori (nama_kategori) VALUES (@nama)"
				Using cmd As New MySqlCommand(sql, conn)
					cmd.Parameters.AddWithValue("@nama", txtKategori.Text)
					cmd.ExecuteNonQuery()
				End Using
			End Using
			MessageBox.Show("Kategori Ditambah!")
			txtKategori.Clear()
			Tampil()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		Me.Close()
	End Sub

	Private Sub dgvKategori_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKategori.CellContentClick

	End Sub
End Class