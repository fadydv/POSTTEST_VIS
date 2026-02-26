Public Class Form1

	Dim total As Double = 0
	Dim jumlah As Integer = 0

	Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

		Dim nilai As Double

		If Double.TryParse(txtIPS.Text, nilai) Then

			If nilai >= 0 And nilai <= 4 Then

				total = total + nilai
				jumlah = jumlah + 1

				Dim ipk As Double = total / jumlah
				txtIPK.Text = Format(ipk, "0.00")

				If ipk >= 3.01 Then
					lblPredikat.Text = "Sangat Memuaskan"
				ElseIf ipk >= 3.0 Then
					lblPredikat.Text = "Memuaskan"
				ElseIf ipk >= 2.75 Then
					lblPredikat.Text = "Cukup"
				Else
					lblPredikat.Text = "Kurang"
				End If

				txtIPS.Text = ""

			Else
				MessageBox.Show("IP harus antara 0 - 4")
			End If

		Else
			MessageBox.Show("Masukkan angka yang valid!")
		End If

	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

		total = 0
		jumlah = 0
		txtIPS.Text = ""
		txtIPK.Text = ""
		lblPredikat.Text = ""

	End Sub

	Private Sub txtIPK_TextChanged(sender As Object, e As EventArgs) Handles txtIPK.TextChanged

	End Sub
End Class