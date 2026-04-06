<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		components = New ComponentModel.Container()
		msMenuUtama = New MenuStrip()
		menuInput = New ToolStripMenuItem()
		menuLihat = New ToolStripMenuItem()
		menuSimpan = New ToolStripMenuItem()
		menuBuka = New ToolStripMenuItem()
		menuKeluar = New ToolStripMenuItem()
		lblJudulApp = New Label()
		picLogo = New PictureBox()
		TabControl1 = New TabControl()
		tabPage1 = New TabPage()
		cmbDivisi = New ComboBox()
		rbPerempuan = New RadioButton()
		rbLaki = New RadioButton()
		dtpLahir = New DateTimePicker()
		txtID = New TextBox()
		txtNama = New TextBox()
		tabPage2 = New TabPage()
		txtAlamat = New TextBox()
		txtEmail = New TextBox()
		mtbTelp = New MaskedTextBox()
		tabPage3 = New TabPage()
		btnSimpanCetak = New Button()
		grpHobi = New GroupBox()
		chk8 = New CheckBox()
		chk7 = New CheckBox()
		chk6 = New CheckBox()
		chk5 = New CheckBox()
		chk4 = New CheckBox()
		chk3 = New CheckBox()
		chk2 = New CheckBox()
		chk1 = New CheckBox()
		grpPeran = New GroupBox()
		rbAdmin = New RadioButton()
		rbAnggota = New RadioButton()
		rbKetua = New RadioButton()
		btnBrowse = New Button()
		picProfil = New PictureBox()
		OpenFileDialog1 = New OpenFileDialog()
		SaveFileDialog1 = New SaveFileDialog()
		ErrorProvider1 = New ErrorProvider(components)
		msMenuUtama.SuspendLayout()
		CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
		TabControl1.SuspendLayout()
		tabPage1.SuspendLayout()
		tabPage2.SuspendLayout()
		tabPage3.SuspendLayout()
		grpHobi.SuspendLayout()
		grpPeran.SuspendLayout()
		CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' msMenuUtama
		' 
		msMenuUtama.BackColor = SystemColors.Window
		msMenuUtama.ImageScalingSize = New Size(20, 20)
		msMenuUtama.Items.AddRange(New ToolStripItem() {menuInput, menuLihat, menuSimpan, menuBuka, menuKeluar})
		msMenuUtama.Location = New Point(0, 0)
		msMenuUtama.Name = "msMenuUtama"
		msMenuUtama.Size = New Size(781, 28)
		msMenuUtama.TabIndex = 0
		' 
		' menuInput
		' 
		menuInput.BackColor = SystemColors.Control
		menuInput.Name = "menuInput"
		menuInput.Size = New Size(93, 24)
		menuInput.Text = "Input Data"
		' 
		' menuLihat
		' 
		menuLihat.BackColor = SystemColors.Control
		menuLihat.Name = "menuLihat"
		menuLihat.Size = New Size(94, 24)
		menuLihat.Text = "Lihat Kartu"
		' 
		' menuSimpan
		' 
		menuSimpan.BackColor = SystemColors.Control
		menuSimpan.Name = "menuSimpan"
		menuSimpan.Size = New Size(109, 24)
		menuSimpan.Text = "Simpan Data"
		' 
		' menuBuka
		' 
		menuBuka.BackColor = SystemColors.Control
		menuBuka.Name = "menuBuka"
		menuBuka.Size = New Size(91, 24)
		menuBuka.Text = "Buka Data"
		' 
		' menuKeluar
		' 
		menuKeluar.BackColor = SystemColors.Control
		menuKeluar.Name = "menuKeluar"
		menuKeluar.Size = New Size(65, 24)
		menuKeluar.Text = "Keluar"
		' 
		' lblJudulApp
		' 
		lblJudulApp.AutoSize = True
		lblJudulApp.BackColor = Color.IndianRed
		lblJudulApp.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudulApp.ForeColor = Color.Maroon
		lblJudulApp.Location = New Point(211, 46)
		lblJudulApp.Name = "lblJudulApp"
		lblJudulApp.Size = New Size(452, 41)
		lblJudulApp.TabIndex = 1
		lblJudulApp.Text = "KARTU KOMUNITAS ENHYPEN" & vbCrLf
		' 
		' picLogo
		' 
		picLogo.BackColor = Color.Transparent
		picLogo.Image = My.Resources.Resources.ENHYPEN_LOGO
		picLogo.Location = New Point(111, 35)
		picLogo.Name = "picLogo"
		picLogo.Size = New Size(83, 62)
		picLogo.SizeMode = PictureBoxSizeMode.Zoom
		picLogo.TabIndex = 2
		picLogo.TabStop = False
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(tabPage1)
		TabControl1.Controls.Add(tabPage2)
		TabControl1.Controls.Add(tabPage3)
		TabControl1.Location = New Point(12, 103)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(758, 438)
		TabControl1.TabIndex = 3
		' 
		' tabPage1
		' 
		tabPage1.BackColor = SystemColors.Window
		tabPage1.Controls.Add(cmbDivisi)
		tabPage1.Controls.Add(rbPerempuan)
		tabPage1.Controls.Add(rbLaki)
		tabPage1.Controls.Add(dtpLahir)
		tabPage1.Controls.Add(txtID)
		tabPage1.Controls.Add(txtNama)
		tabPage1.Location = New Point(4, 29)
		tabPage1.Name = "tabPage1"
		tabPage1.Padding = New Padding(3)
		tabPage1.Size = New Size(750, 405)
		tabPage1.TabIndex = 0
		tabPage1.Text = "Data Utama"
		' 
		' cmbDivisi
		' 
		cmbDivisi.FormattingEnabled = True
		cmbDivisi.Items.AddRange(New Object() {"Web Development", "UI/UX Design", "Data Science", "Cyber Security"})
		cmbDivisi.Location = New Point(23, 219)
		cmbDivisi.Name = "cmbDivisi"
		cmbDivisi.Size = New Size(250, 28)
		cmbDivisi.TabIndex = 5
		cmbDivisi.Text = "-- Pilih Divisi --"
		' 
		' rbPerempuan
		' 
		rbPerempuan.AutoSize = True
		rbPerempuan.Location = New Point(135, 179)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(104, 24)
		rbPerempuan.TabIndex = 4
		rbPerempuan.TabStop = True
		rbPerempuan.Text = "Perempuan"
		rbPerempuan.UseVisualStyleBackColor = True
		' 
		' rbLaki
		' 
		rbLaki.AutoSize = True
		rbLaki.Location = New Point(23, 179)
		rbLaki.Name = "rbLaki"
		rbLaki.Size = New Size(85, 24)
		rbLaki.TabIndex = 3
		rbLaki.TabStop = True
		rbLaki.Text = "Laki-laki"
		rbLaki.UseVisualStyleBackColor = True
		' 
		' dtpLahir
		' 
		dtpLahir.CalendarMonthBackground = SystemColors.Control
		dtpLahir.CustomFormat = "dd/MM/yyyy"
		dtpLahir.Format = DateTimePickerFormat.Custom
		dtpLahir.Location = New Point(23, 131)
		dtpLahir.Name = "dtpLahir"
		dtpLahir.Size = New Size(250, 27)
		dtpLahir.TabIndex = 2
		' 
		' txtID
		' 
		txtID.BackColor = SystemColors.Control
		txtID.Location = New Point(23, 81)
		txtID.Name = "txtID"
		txtID.PlaceholderText = "ID Anggota"
		txtID.Size = New Size(250, 27)
		txtID.TabIndex = 1
		' 
		' txtNama
		' 
		txtNama.BackColor = SystemColors.Control
		txtNama.Location = New Point(23, 31)
		txtNama.Name = "txtNama"
		txtNama.PlaceholderText = "Nama Lengkap"
		txtNama.Size = New Size(400, 27)
		txtNama.TabIndex = 0
		' 
		' tabPage2
		' 
		tabPage2.BackColor = SystemColors.Window
		tabPage2.Controls.Add(txtAlamat)
		tabPage2.Controls.Add(txtEmail)
		tabPage2.Controls.Add(mtbTelp)
		tabPage2.Location = New Point(4, 29)
		tabPage2.Name = "tabPage2"
		tabPage2.Padding = New Padding(3)
		tabPage2.Size = New Size(750, 405)
		tabPage2.TabIndex = 1
		tabPage2.Text = "Kontak & Info"
		' 
		' txtAlamat
		' 
		txtAlamat.Location = New Point(25, 136)
		txtAlamat.Multiline = True
		txtAlamat.Name = "txtAlamat"
		txtAlamat.PlaceholderText = "Alamat Lengkap"
		txtAlamat.Size = New Size(400, 100)
		txtAlamat.TabIndex = 2
		' 
		' txtEmail
		' 
		txtEmail.Location = New Point(25, 85)
		txtEmail.Name = "txtEmail"
		txtEmail.PlaceholderText = "Email (contoh@mail.com)"
		txtEmail.Size = New Size(300, 27)
		txtEmail.TabIndex = 1
		' 
		' mtbTelp
		' 
		mtbTelp.Location = New Point(25, 33)
		mtbTelp.Mask = "0000-0000-0000"
		mtbTelp.Name = "mtbTelp"
		mtbTelp.Size = New Size(200, 27)
		mtbTelp.TabIndex = 0
		' 
		' tabPage3
		' 
		tabPage3.BackColor = SystemColors.Window
		tabPage3.Controls.Add(btnSimpanCetak)
		tabPage3.Controls.Add(grpHobi)
		tabPage3.Controls.Add(grpPeran)
		tabPage3.Controls.Add(btnBrowse)
		tabPage3.Controls.Add(picProfil)
		tabPage3.Location = New Point(4, 29)
		tabPage3.Name = "tabPage3"
		tabPage3.Size = New Size(750, 405)
		tabPage3.TabIndex = 2
		tabPage3.Text = "Profil & Aktivitas"
		' 
		' btnSimpanCetak
		' 
		btnSimpanCetak.BackColor = Color.Brown
		btnSimpanCetak.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
		btnSimpanCetak.ForeColor = Color.White
		btnSimpanCetak.Location = New Point(499, 336)
		btnSimpanCetak.Name = "btnSimpanCetak"
		btnSimpanCetak.Size = New Size(231, 51)
		btnSimpanCetak.TabIndex = 4
		btnSimpanCetak.Text = "Simpan & Cetak Kartu"
		btnSimpanCetak.UseMnemonic = False
		btnSimpanCetak.UseVisualStyleBackColor = False
		' 
		' grpHobi
		' 
		grpHobi.Controls.Add(chk8)
		grpHobi.Controls.Add(chk7)
		grpHobi.Controls.Add(chk6)
		grpHobi.Controls.Add(chk5)
		grpHobi.Controls.Add(chk4)
		grpHobi.Controls.Add(chk3)
		grpHobi.Controls.Add(chk2)
		grpHobi.Controls.Add(chk1)
		grpHobi.Location = New Point(187, 137)
		grpHobi.Name = "grpHobi"
		grpHobi.Size = New Size(318, 183)
		grpHobi.TabIndex = 3
		grpHobi.TabStop = False
		grpHobi.Text = "Hobby / Minat"
		' 
		' chk8
		' 
		chk8.AutoSize = True
		chk8.Location = New Point(164, 139)
		chk8.Name = "chk8"
		chk8.Size = New Size(82, 24)
		chk8.TabIndex = 7
		chk8.Text = "Menulis"
		chk8.UseVisualStyleBackColor = True
		' 
		' chk7
		' 
		chk7.AutoSize = True
		chk7.Location = New Point(16, 139)
		chk7.Name = "chk7"
		chk7.Size = New Size(94, 24)
		chk7.TabIndex = 6
		chk7.Text = "Menyanyi"
		chk7.UseVisualStyleBackColor = True
		' 
		' chk6
		' 
		chk6.AutoSize = True
		chk6.Location = New Point(164, 104)
		chk6.Name = "chk6"
		chk6.Size = New Size(91, 24)
		chk6.TabIndex = 5
		chk6.Text = "Traveling"
		chk6.UseVisualStyleBackColor = True
		' 
		' chk5
		' 
		chk5.AutoSize = True
		chk5.Location = New Point(16, 104)
		chk5.Name = "chk5"
		chk5.Size = New Size(121, 24)
		chk5.TabIndex = 4
		chk5.Text = "Menggambar"
		chk5.UseVisualStyleBackColor = True
		' 
		' chk4
		' 
		chk4.AutoSize = True
		chk4.Location = New Point(164, 69)
		chk4.Name = "chk4"
		chk4.Size = New Size(92, 24)
		chk4.TabIndex = 3
		chk4.Text = "Olahraga"
		chk4.UseVisualStyleBackColor = True
		' 
		' chk3
		' 
		chk3.AutoSize = True
		chk3.Location = New Point(16, 69)
		chk3.Name = "chk3"
		chk3.Size = New Size(79, 24)
		chk3.TabIndex = 2
		chk3.Text = "Coding"
		chk3.UseVisualStyleBackColor = True
		' 
		' chk2
		' 
		chk2.AutoSize = True
		chk2.Location = New Point(164, 34)
		chk2.Name = "chk2"
		chk2.Size = New Size(97, 24)
		chk2.TabIndex = 1
		chk2.Text = "Membaca"
		chk2.UseVisualStyleBackColor = True
		' 
		' chk1
		' 
		chk1.AutoSize = True
		chk1.Location = New Point(16, 34)
		chk1.Name = "chk1"
		chk1.Size = New Size(83, 24)
		chk1.TabIndex = 0
		chk1.Text = "Gaming"
		chk1.UseVisualStyleBackColor = True
		' 
		' grpPeran
		' 
		grpPeran.Controls.Add(rbAdmin)
		grpPeran.Controls.Add(rbAnggota)
		grpPeran.Controls.Add(rbKetua)
		grpPeran.Location = New Point(187, 23)
		grpPeran.Name = "grpPeran"
		grpPeran.Size = New Size(318, 100)
		grpPeran.TabIndex = 2
		grpPeran.TabStop = False
		grpPeran.Text = "Pilihan Peran"
		' 
		' rbAdmin
		' 
		rbAdmin.AutoSize = True
		rbAdmin.Location = New Point(216, 42)
		rbAdmin.Name = "rbAdmin"
		rbAdmin.Size = New Size(74, 24)
		rbAdmin.TabIndex = 2
		rbAdmin.TabStop = True
		rbAdmin.Text = "Admin"
		rbAdmin.UseVisualStyleBackColor = True
		' 
		' rbAnggota
		' 
		rbAnggota.AutoSize = True
		rbAnggota.Location = New Point(106, 42)
		rbAnggota.Name = "rbAnggota"
		rbAnggota.Size = New Size(88, 24)
		rbAnggota.TabIndex = 1
		rbAnggota.TabStop = True
		rbAnggota.Text = "Anggota"
		rbAnggota.UseVisualStyleBackColor = True
		' 
		' rbKetua
		' 
		rbKetua.AutoSize = True
		rbKetua.Location = New Point(16, 42)
		rbKetua.Name = "rbKetua"
		rbKetua.Size = New Size(68, 24)
		rbKetua.TabIndex = 0
		rbKetua.TabStop = True
		rbKetua.Text = "Ketua"
		rbKetua.UseVisualStyleBackColor = True
		' 
		' btnBrowse
		' 
		btnBrowse.BackColor = SystemColors.Control
		btnBrowse.Location = New Point(23, 192)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(130, 30)
		btnBrowse.TabIndex = 1
		btnBrowse.Text = "Browse Foto"
		btnBrowse.UseVisualStyleBackColor = False
		' 
		' picProfil
		' 
		picProfil.BackColor = SystemColors.Control
		picProfil.BorderStyle = BorderStyle.FixedSingle
		picProfil.Location = New Point(23, 23)
		picProfil.Name = "picProfil"
		picProfil.Size = New Size(130, 150)
		picProfil.SizeMode = PictureBoxSizeMode.Zoom
		picProfil.TabIndex = 0
		picProfil.TabStop = False
		' 
		' OpenFileDialog1
		' 
		OpenFileDialog1.FileName = "OpenFileDialog1"
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' Form1
		' 
		AutoScaleMode = AutoScaleMode.None
		BackgroundImage = My.Resources.Resources.background_form
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(781, 553)
		Controls.Add(TabControl1)
		Controls.Add(picLogo)
		Controls.Add(lblJudulApp)
		Controls.Add(msMenuUtama)
		MainMenuStrip = msMenuUtama
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Aplikasi Kartu Komunitas"
		msMenuUtama.ResumeLayout(False)
		msMenuUtama.PerformLayout()
		CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
		TabControl1.ResumeLayout(False)
		tabPage1.ResumeLayout(False)
		tabPage1.PerformLayout()
		tabPage2.ResumeLayout(False)
		tabPage2.PerformLayout()
		tabPage3.ResumeLayout(False)
		grpHobi.ResumeLayout(False)
		grpHobi.PerformLayout()
		grpPeran.ResumeLayout(False)
		grpPeran.PerformLayout()
		CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents msMenuUtama As MenuStrip
	Friend WithEvents menuInput As ToolStripMenuItem
    Friend WithEvents menuLihat As ToolStripMenuItem
    Friend WithEvents menuSimpan As ToolStripMenuItem
    Friend WithEvents menuBuka As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents lblJudulApp As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabPage1 As TabPage
    Friend WithEvents tabPage2 As TabPage
    Friend WithEvents tabPage3 As TabPage
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cmbDivisi As ComboBox
    Friend WithEvents mtbTelp As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents grpHobi As GroupBox
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class