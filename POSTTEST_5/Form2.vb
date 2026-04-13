Imports MySqlConnector

Public Class Form2
	Sub Tampil()
		dgvBrand.DataSource = GetBrands()
	End Sub

	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Tampil()
	End Sub

	Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
		If txtBrand.Text = "" Then Return
		Try
			Using conn = GetConnection()
				conn.Open()
				Dim sql = "INSERT INTO tb_brand (nama_brand) VALUES (@nama)"
				Using cmd As New MySqlCommand(sql, conn)
					cmd.Parameters.AddWithValue("@nama", txtBrand.Text)
					cmd.ExecuteNonQuery()
				End Using
			End Using
			MessageBox.Show("Brand Ditambah!")
			txtBrand.Clear()
			Tampil()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		Me.Close()
	End Sub

	Private Sub card_Paint(sender As Object, e As PaintEventArgs) Handles card.Paint

	End Sub

	Private Sub dgvBrand_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrand.CellContentClick

	End Sub
End Class