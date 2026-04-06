Imports System.IO

Public Class Form1
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Nama hanya boleh berisi huruf!", "Peringatan")
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("ID hanya boleh berisi angka!", "Peringatan")
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ModulData.LokasiFoto = OpenFileDialog1.FileName
            picProfil.Image = Image.FromFile(ModulData.LokasiFoto)
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Or cmbDivisi.SelectedIndex = -1 Then
            MessageBox.Show("Inputan tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ModulData.NamaLengkap = txtNama.Text
        ModulData.IDAnggota = txtID.Text
        ModulData.TglLahir = dtpLahir.Value.ToShortDateString()
        ModulData.Gender = If(rbLaki.Checked, "Laki-laki", "Perempuan")
        ModulData.Divisi = cmbDivisi.Text
        ModulData.NoTelp = mtbTelp.Text
        ModulData.Email = txtEmail.Text
        ModulData.Alamat = txtAlamat.Text

        If rbKetua.Checked Then
            ModulData.Peran = "Ketua"
        ElseIf rbAdmin.Checked Then
            ModulData.Peran = "Admin"
        Else
            ModulData.Peran = "Anggota"
        End If

        Dim listHobi As New List(Of String)
        Dim checks() As CheckBox = {chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8}
        For Each c In checks
            If c.Checked Then listHobi.Add(c.Text)
        Next
        ModulData.Hobi = String.Join(", ", listHobi)

        If MessageBox.Show("Data berhasil disimpan. Cetak kartu sekarang?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            FormHasil.Show()
        End If
    End Sub

    Private Sub menuSimpan_Click(sender As Object, e As EventArgs) Handles menuSimpan.Click
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Using sw As New StreamWriter(SaveFileDialog1.FileName)
                sw.WriteLine(txtNama.Text)
                sw.WriteLine(txtID.Text)
                sw.WriteLine(dtpLahir.Text)
                sw.WriteLine(ModulData.Gender)
                sw.WriteLine(cmbDivisi.Text)
                sw.WriteLine(mtbTelp.Text)
                sw.WriteLine(txtEmail.Text)
                sw.WriteLine(txtAlamat.Text)
                sw.WriteLine(ModulData.LokasiFoto)
            End Using
            MessageBox.Show("Data berhasil disimpan ke file!", "Sukses")
        End If
    End Sub

    Private Sub menuBuka_Click(sender As Object, e As EventArgs) Handles menuBuka.Click
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim d() As String = File.ReadAllLines(OpenFileDialog1.FileName)
            If d.Length >= 8 Then
                txtNama.Text = d(0)
                txtID.Text = d(1)
                dtpLahir.Text = d(2)
                If d(3) = "Laki-laki" Then rbLaki.Checked = True Else rbPerempuan.Checked = True
                cmbDivisi.Text = d(4)
                mtbTelp.Text = d(5)
                txtEmail.Text = d(6)
                txtAlamat.Text = d(7)
                If d.Length > 8 AndAlso File.Exists(d(8)) Then
                    ModulData.LokasiFoto = d(8)
                    picProfil.Image = Image.FromFile(d(8))
                End If
                ModulData.NamaLengkap = txtNama.Text
                MessageBox.Show("Data berhasil dimuat!", "Sukses")
            End If
        End If
    End Sub

    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihat.Click
        If ModulData.NamaLengkap = "" Then
            MessageBox.Show("Belum ada data!")
        Else
            FormHasil.Show()
        End If
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        If MessageBox.Show("Yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class