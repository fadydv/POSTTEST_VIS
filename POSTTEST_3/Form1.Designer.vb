<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		pbFoto = New PictureBox()
		btnBrowse = New Button()
		btnCetak = New Button()
		lblNama = New Label()
		lblUmur = New Label()
		lblTanggal = New Label()
		lblTelepon = New Label()
		lblAlamat = New Label()
		txtNama = New TextBox()
		txtUmur = New TextBox()
		txtTelepon = New TextBox()
		txtAlamat = New TextBox()
		dtpTanggal = New DateTimePicker()
		gbJenisKelamin = New GroupBox()
		rbLaki = New RadioButton()
		rbPerempuan = New RadioButton()
		gbHobby = New GroupBox()
		cbGame = New CheckBox()
		cbCoding = New CheckBox()
		cbTraveling = New CheckBox()
		cbMenggambar = New CheckBox()
		cbMenulis = New CheckBox()
		cbMemancing = New CheckBox()
		cbMembaca = New CheckBox()
		cbOlahraga = New CheckBox()
		cbMenyanyi = New CheckBox()
		cbMenari = New CheckBox()
		CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
		gbJenisKelamin.SuspendLayout()
		gbHobby.SuspendLayout()
		SuspendLayout()

		pbFoto.BorderStyle = BorderStyle.FixedSingle
		pbFoto.Location = New Point(20, 29)
		pbFoto.Name = "pbFoto"
		pbFoto.Size = New Size(201, 295)
		pbFoto.SizeMode = PictureBoxSizeMode.Zoom
		pbFoto.TabIndex = 0
		pbFoto.TabStop = False

		btnBrowse.Location = New Point(75, 349)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(90, 30)
		btnBrowse.TabIndex = 1
		btnBrowse.Text = "Browse"

		btnCetak.Location = New Point(255, 344)
		btnCetak.Name = "btnCetak"
		btnCetak.Size = New Size(150, 35)
		btnCetak.TabIndex = 2
		btnCetak.Text = "Cetak Kartu"

		lblNama.Location = New Point(240, 40)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(100, 23)
		lblNama.TabIndex = 3
		lblNama.Text = "Nama"

		lblUmur.Location = New Point(240, 75)
		lblUmur.Name = "lblUmur"
		lblUmur.Size = New Size(100, 23)
		lblUmur.TabIndex = 4
		lblUmur.Text = "Umur"

		lblTanggal.Location = New Point(240, 110)
		lblTanggal.Name = "lblTanggal"
		lblTanggal.Size = New Size(100, 23)
		lblTanggal.TabIndex = 5
		lblTanggal.Text = "Tanggal Lahir"

		lblTelepon.Location = New Point(240, 145)
		lblTelepon.Name = "lblTelepon"
		lblTelepon.Size = New Size(100, 23)
		lblTelepon.TabIndex = 6
		lblTelepon.Text = "No Telpon"

		lblAlamat.Location = New Point(240, 180)
		lblAlamat.Name = "lblAlamat"
		lblAlamat.Size = New Size(100, 23)
		lblAlamat.TabIndex = 7
		lblAlamat.Text = "Alamat"

		txtNama.Location = New Point(350, 40)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(170, 27)
		txtNama.TabIndex = 8

		txtUmur.Location = New Point(350, 75)
		txtUmur.Name = "txtUmur"
		txtUmur.Size = New Size(170, 27)
		txtUmur.TabIndex = 9

		txtTelepon.Location = New Point(350, 145)
		txtTelepon.Name = "txtTelepon"
		txtTelepon.Size = New Size(170, 27)
		txtTelepon.TabIndex = 10

		txtAlamat.Location = New Point(350, 180)
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(170, 27)
		txtAlamat.TabIndex = 11

		dtpTanggal.Format = DateTimePickerFormat.Short
		dtpTanggal.Location = New Point(350, 110)
		dtpTanggal.Name = "dtpTanggal"
		dtpTanggal.Size = New Size(200, 27)
		dtpTanggal.TabIndex = 12

		gbJenisKelamin.Controls.Add(rbLaki)
		gbJenisKelamin.Controls.Add(rbPerempuan)
		gbJenisKelamin.Location = New Point(240, 220)
		gbJenisKelamin.Name = "gbJenisKelamin"
		gbJenisKelamin.Size = New Size(170, 100)
		gbJenisKelamin.TabIndex = 13
		gbJenisKelamin.TabStop = False
		gbJenisKelamin.Text = "Jenis Kelamin"

		rbLaki.Location = New Point(15, 30)
		rbLaki.Name = "rbLaki"
		rbLaki.Size = New Size(104, 24)
		rbLaki.TabIndex = 0
		rbLaki.Text = "Laki-laki"

		rbPerempuan.Location = New Point(15, 60)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(104, 24)
		rbPerempuan.TabIndex = 1
		rbPerempuan.Text = "Perempuan"

		gbHobby.Controls.Add(cbGame)
		gbHobby.Controls.Add(cbCoding)
		gbHobby.Controls.Add(cbTraveling)
		gbHobby.Controls.Add(cbMenggambar)
		gbHobby.Controls.Add(cbMenulis)
		gbHobby.Controls.Add(cbMemancing)
		gbHobby.Controls.Add(cbMembaca)
		gbHobby.Controls.Add(cbOlahraga)
		gbHobby.Controls.Add(cbMenyanyi)
		gbHobby.Controls.Add(cbMenari)
		gbHobby.Location = New Point(430, 220)
		gbHobby.Name = "gbHobby"
		gbHobby.Size = New Size(300, 168)
		gbHobby.TabIndex = 14
		gbHobby.TabStop = False
		gbHobby.Text = "Hobby"

		cbGame.Location = New Point(15, 30)
		cbGame.Name = "cbGame"
		cbGame.Size = New Size(104, 24)
		cbGame.TabIndex = 0
		cbGame.Text = "Gaming"

		cbCoding.Location = New Point(15, 55)
		cbCoding.Name = "cbCoding"
		cbCoding.Size = New Size(104, 24)
		cbCoding.TabIndex = 1
		cbCoding.Text = "Coding"

		cbTraveling.Location = New Point(15, 80)
		cbTraveling.Name = "cbTraveling"
		cbTraveling.Size = New Size(104, 24)
		cbTraveling.TabIndex = 2
		cbTraveling.Text = "Traveling"

		cbMenggambar.Location = New Point(15, 105)
		cbMenggambar.Name = "cbMenggambar"
		cbMenggambar.Size = New Size(129, 24)
		cbMenggambar.TabIndex = 3
		cbMenggambar.Text = "Menggambar"

		cbMenulis.Location = New Point(15, 130)
		cbMenulis.Name = "cbMenulis"
		cbMenulis.Size = New Size(104, 24)
		cbMenulis.TabIndex = 4
		cbMenulis.Text = "Menulis"

		cbMemancing.Location = New Point(150, 30)
		cbMemancing.Name = "cbMemancing"
		cbMemancing.Size = New Size(122, 24)
		cbMemancing.TabIndex = 5
		cbMemancing.Text = "Memancing"

		cbMembaca.Location = New Point(150, 55)
		cbMembaca.Name = "cbMembaca"
		cbMembaca.Size = New Size(104, 24)
		cbMembaca.TabIndex = 6
		cbMembaca.Text = "Membaca"

		cbOlahraga.Location = New Point(150, 80)
		cbOlahraga.Name = "cbOlahraga"
		cbOlahraga.Size = New Size(104, 24)
		cbOlahraga.TabIndex = 7
		cbOlahraga.Text = "Olahraga"

		cbMenyanyi.Location = New Point(150, 105)
		cbMenyanyi.Name = "cbMenyanyi"
		cbMenyanyi.Size = New Size(113, 24)
		cbMenyanyi.TabIndex = 8
		cbMenyanyi.Text = "Menyanyi"

		cbMenari.Location = New Point(150, 130)
		cbMenari.Name = "cbMenari"
		cbMenari.Size = New Size(104, 24)
		cbMenari.TabIndex = 9
		cbMenari.Text = "Menari"

		ClientSize = New Size(760, 400)
		Controls.Add(pbFoto)
		Controls.Add(btnBrowse)
		Controls.Add(btnCetak)
		Controls.Add(lblNama)
		Controls.Add(lblUmur)
		Controls.Add(lblTanggal)
		Controls.Add(lblTelepon)
		Controls.Add(lblAlamat)
		Controls.Add(txtNama)
		Controls.Add(txtUmur)
		Controls.Add(txtTelepon)
		Controls.Add(txtAlamat)
		Controls.Add(dtpTanggal)
		Controls.Add(gbJenisKelamin)
		Controls.Add(gbHobby)
		Name = "FormCetak"
		Text = "Cetak Kartu Komunitas"
		CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
		gbJenisKelamin.ResumeLayout(False)
		gbHobby.ResumeLayout(False)
		ResumeLayout(False)
		PerformLayout()

	End Sub

	Friend WithEvents pbFoto As PictureBox
	Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button

    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox

    Friend WithEvents dtpTanggal As DateTimePicker

    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton

    Friend WithEvents gbHobby As GroupBox

    Friend WithEvents cbGame As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbMenulis As CheckBox

    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbMenari As CheckBox

End Class