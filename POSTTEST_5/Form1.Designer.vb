<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

	Friend WithEvents sidebar As System.Windows.Forms.Panel
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents cardInput As System.Windows.Forms.Panel
    Friend WithEvents cardTable As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblMenuBrand As System.Windows.Forms.Label
    Friend WithEvents lblMenuKategori As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents cmbBrand As System.Windows.Forms.ComboBox
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lblWarna As System.Windows.Forms.Label
    Friend WithEvents txtWarna As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblStok As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvProduk As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		components = New ComponentModel.Container()
		sidebar = New Panel()
		lblMenuBrand = New Label()
		lblMenuKategori = New Label()
		header = New Panel()
		lblSubtitle = New Label()
		lblTitle = New Label()
		cardInput = New Panel()
		lblNama = New Label()
		txtNama = New TextBox()
		lblBrand = New Label()
		cmbBrand = New ComboBox()
		lblKategori = New Label()
		cmbKategori = New ComboBox()
		lblWarna = New Label()
		txtWarna = New TextBox()
		lblHarga = New Label()
		txtHarga = New TextBox()
		lblStok = New Label()
		txtStok = New TextBox()
		btnSimpan = New Button()
		btnUbah = New Button()
		btnHapus = New Button()
		btnBatal = New Button()
		cardTable = New Panel()
		lblSearch = New Label()
		txtSearch = New TextBox()
		dgvProduk = New DataGridView()
		ErrorProvider1 = New ErrorProvider(components)
		sidebar.SuspendLayout()
		header.SuspendLayout()
		cardInput.SuspendLayout()
		cardTable.SuspendLayout()
		CType(dgvProduk, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' sidebar
		' 
		sidebar.BackColor = Color.FromArgb(CByte(100), CByte(0), CByte(30))
		sidebar.Controls.Add(lblMenuBrand)
		sidebar.Controls.Add(lblMenuKategori)
		sidebar.Dock = DockStyle.Left
		sidebar.Location = New Point(0, 0)
		sidebar.Name = "sidebar"
		sidebar.Size = New Size(200, 680)
		sidebar.TabIndex = 3
		' 
		' lblMenuBrand
		' 
		lblMenuBrand.AutoSize = True
		lblMenuBrand.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
		lblMenuBrand.ForeColor = Color.White
		lblMenuBrand.Location = New Point(25, 40)
		lblMenuBrand.Name = "lblMenuBrand"
		lblMenuBrand.Size = New Size(125, 25)
		lblMenuBrand.TabIndex = 0
		lblMenuBrand.Text = "Kelola Brand"
		' 
		' lblMenuKategori
		' 
		lblMenuKategori.AutoSize = True
		lblMenuKategori.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
		lblMenuKategori.ForeColor = Color.White
		lblMenuKategori.Location = New Point(25, 79)
		lblMenuKategori.Name = "lblMenuKategori"
		lblMenuKategori.Size = New Size(147, 25)
		lblMenuKategori.TabIndex = 1
		lblMenuKategori.Text = "Kelola Kategori"
		' 
		' header
		' 
		header.BackColor = Color.White
		header.Controls.Add(lblSubtitle)
		header.Controls.Add(lblTitle)
		header.Dock = DockStyle.Top
		header.Location = New Point(200, 0)
		header.Name = "header"
		header.Size = New Size(950, 90)
		header.TabIndex = 2
		' 
		' lblSubtitle
		' 
		lblSubtitle.AutoSize = True
		lblSubtitle.ForeColor = SystemColors.ControlDarkDark
		lblSubtitle.Location = New Point(40, 57)
		lblSubtitle.Name = "lblSubtitle"
		lblSubtitle.Size = New Size(273, 20)
		lblSubtitle.TabIndex = 0
		lblSubtitle.Text = "Kelola data produk, brand, dan kategori"
		' 
		' lblTitle
		' 
		lblTitle.AutoSize = True
		lblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
		lblTitle.Location = New Point(40, 20)
		lblTitle.Name = "lblTitle"
		lblTitle.Size = New Size(362, 37)
		lblTitle.TabIndex = 1
		lblTitle.Text = "Dashboard Produk Lipstick"
		' 
		' cardInput
		' 
		cardInput.BackColor = Color.White
		cardInput.Controls.Add(lblNama)
		cardInput.Controls.Add(txtNama)
		cardInput.Controls.Add(lblBrand)
		cardInput.Controls.Add(cmbBrand)
		cardInput.Controls.Add(lblKategori)
		cardInput.Controls.Add(cmbKategori)
		cardInput.Controls.Add(lblWarna)
		cardInput.Controls.Add(txtWarna)
		cardInput.Controls.Add(lblHarga)
		cardInput.Controls.Add(txtHarga)
		cardInput.Controls.Add(lblStok)
		cardInput.Controls.Add(txtStok)
		cardInput.Controls.Add(btnSimpan)
		cardInput.Controls.Add(btnUbah)
		cardInput.Controls.Add(btnHapus)
		cardInput.Controls.Add(btnBatal)
		cardInput.Location = New Point(240, 120)
		cardInput.Name = "cardInput"
		cardInput.Size = New Size(340, 531)
		cardInput.TabIndex = 1
		' 
		' lblNama
		' 
		lblNama.Location = New Point(30, 20)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(100, 23)
		lblNama.TabIndex = 0
		lblNama.Text = "Nama Produk"
		' 
		' txtNama
		' 
		txtNama.Location = New Point(30, 40)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(280, 27)
		txtNama.TabIndex = 1
		' 
		' lblBrand
		' 
		lblBrand.Location = New Point(30, 80)
		lblBrand.Name = "lblBrand"
		lblBrand.Size = New Size(100, 23)
		lblBrand.TabIndex = 2
		lblBrand.Text = "Brand"
		' 
		' cmbBrand
		' 
		cmbBrand.Location = New Point(30, 100)
		cmbBrand.Name = "cmbBrand"
		cmbBrand.Size = New Size(280, 28)
		cmbBrand.TabIndex = 3
		' 
		' lblKategori
		' 
		lblKategori.Location = New Point(30, 140)
		lblKategori.Name = "lblKategori"
		lblKategori.Size = New Size(100, 23)
		lblKategori.TabIndex = 4
		lblKategori.Text = "Kategori"
		' 
		' cmbKategori
		' 
		cmbKategori.Location = New Point(30, 160)
		cmbKategori.Name = "cmbKategori"
		cmbKategori.Size = New Size(280, 28)
		cmbKategori.TabIndex = 5
		' 
		' lblWarna
		' 
		lblWarna.Location = New Point(30, 200)
		lblWarna.Name = "lblWarna"
		lblWarna.Size = New Size(100, 23)
		lblWarna.TabIndex = 6
		lblWarna.Text = "Warna"
		' 
		' txtWarna
		' 
		txtWarna.Location = New Point(30, 220)
		txtWarna.Name = "txtWarna"
		txtWarna.Size = New Size(280, 27)
		txtWarna.TabIndex = 7
		' 
		' lblHarga
		' 
		lblHarga.Location = New Point(30, 260)
		lblHarga.Name = "lblHarga"
		lblHarga.Size = New Size(100, 23)
		lblHarga.TabIndex = 8
		lblHarga.Text = "Harga"
		' 
		' txtHarga
		' 
		txtHarga.Location = New Point(30, 280)
		txtHarga.Name = "txtHarga"
		txtHarga.Size = New Size(280, 27)
		txtHarga.TabIndex = 9
		' 
		' lblStok
		' 
		lblStok.Location = New Point(30, 320)
		lblStok.Name = "lblStok"
		lblStok.Size = New Size(100, 23)
		lblStok.TabIndex = 10
		lblStok.Text = "Stok"
		' 
		' txtStok
		' 
		txtStok.Location = New Point(30, 340)
		txtStok.Name = "txtStok"
		txtStok.Size = New Size(280, 27)
		txtStok.TabIndex = 11
		' 
		' btnSimpan
		' 
		btnSimpan.BackColor = Color.FromArgb(CByte(128), CByte(0), CByte(32))
		btnSimpan.FlatStyle = FlatStyle.Flat
		btnSimpan.ForeColor = Color.White
		btnSimpan.Location = New Point(30, 390)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(280, 35)
		btnSimpan.TabIndex = 12
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = False
		' 
		' btnUbah
		' 
		btnUbah.BackColor = Color.FromArgb(CByte(160), CByte(0), CByte(40))
		btnUbah.FlatStyle = FlatStyle.Flat
		btnUbah.ForeColor = Color.White
		btnUbah.Location = New Point(30, 435)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(280, 35)
		btnUbah.TabIndex = 13
		btnUbah.Text = "Ubah"
		btnUbah.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.Firebrick
		btnHapus.FlatStyle = FlatStyle.Flat
		btnHapus.ForeColor = Color.White
		btnHapus.Location = New Point(30, 480)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(130, 35)
		btnHapus.TabIndex = 14
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' btnBatal
		' 
		btnBatal.BackColor = Color.Gray
		btnBatal.FlatStyle = FlatStyle.Flat
		btnBatal.ForeColor = Color.White
		btnBatal.Location = New Point(180, 480)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(130, 35)
		btnBatal.TabIndex = 15
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = False
		' 
		' cardTable
		' 
		cardTable.BackColor = Color.White
		cardTable.Controls.Add(lblSearch)
		cardTable.Controls.Add(txtSearch)
		cardTable.Controls.Add(dgvProduk)
		cardTable.Location = New Point(600, 120)
		cardTable.Name = "cardTable"
		cardTable.Size = New Size(520, 531)
		cardTable.TabIndex = 0
		' 
		' lblSearch
		' 
		lblSearch.Location = New Point(30, 20)
		lblSearch.Name = "lblSearch"
		lblSearch.Size = New Size(146, 23)
		lblSearch.TabIndex = 0
		lblSearch.Text = "Cari (Nama / Brand)"
		' 
		' txtSearch
		' 
		txtSearch.Location = New Point(30, 45)
		txtSearch.Name = "txtSearch"
		txtSearch.Size = New Size(460, 27)
		txtSearch.TabIndex = 1
		' 
		' dgvProduk
		' 
		dgvProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvProduk.BackgroundColor = Color.SeaShell
		dgvProduk.ColumnHeadersHeight = 29
		dgvProduk.Location = New Point(30, 90)
		dgvProduk.Name = "dgvProduk"
		dgvProduk.RowHeadersWidth = 51
		dgvProduk.Size = New Size(460, 400)
		dgvProduk.TabIndex = 2
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' Form1
		' 
		BackColor = Color.SeaShell
		ClientSize = New Size(1150, 680)
		Controls.Add(cardTable)
		Controls.Add(cardInput)
		Controls.Add(header)
		Controls.Add(sidebar)
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Lipstick Management"
		sidebar.ResumeLayout(False)
		sidebar.PerformLayout()
		header.ResumeLayout(False)
		header.PerformLayout()
		cardInput.ResumeLayout(False)
		cardInput.PerformLayout()
		cardTable.ResumeLayout(False)
		cardTable.PerformLayout()
		CType(dgvProduk, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)

	End Sub
End Class