<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cardInput As System.Windows.Forms.Panel
    Friend WithEvents cardTable As System.Windows.Forms.Panel
    Friend WithEvents lblProduk As System.Windows.Forms.Label
    Friend WithEvents cmbProduk As System.Windows.Forms.ComboBox
    Friend WithEvents lblReviewer As System.Windows.Forms.Label
    Friend WithEvents txtReviewer As System.Windows.Forms.TextBox
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents txtRating As System.Windows.Forms.TextBox
    Friend WithEvents lblKomentar As System.Windows.Forms.Label
    Friend WithEvents txtKomentar As System.Windows.Forms.TextBox
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvReview As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		components = New ComponentModel.Container()
		header = New Panel()
		lblTitle = New Label()
		cardInput = New Panel()
		lblProduk = New Label()
		cmbProduk = New ComboBox()
		lblReviewer = New Label()
		txtReviewer = New TextBox()
		lblRating = New Label()
		txtRating = New TextBox()
		lblKomentar = New Label()
		txtKomentar = New TextBox()
		lblTanggal = New Label()
		dtpTanggal = New DateTimePicker()
		btnSimpan = New Button()
		btnUbah = New Button()
		btnHapus = New Button()
		btnBatal = New Button()
		btnBack = New Button()
		cardTable = New Panel()
		lblSearch = New Label()
		txtSearch = New TextBox()
		dgvReview = New DataGridView()
		ErrorProvider1 = New ErrorProvider(components)
		header.SuspendLayout()
		cardInput.SuspendLayout()
		cardTable.SuspendLayout()
		CType(dgvReview, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' header
		' 
		header.BackColor = Color.FromArgb(CByte(120), CByte(0), CByte(40))
		header.Controls.Add(lblTitle)
		header.Dock = DockStyle.Top
		header.Location = New Point(0, 0)
		header.Name = "header"
		header.Size = New Size(1100, 80)
		header.TabIndex = 2
		' 
		' lblTitle
		' 
		lblTitle.AutoSize = True
		lblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
		lblTitle.ForeColor = Color.White
		lblTitle.Location = New Point(20, 25)
		lblTitle.Name = "lblTitle"
		lblTitle.Size = New Size(277, 32)
		lblTitle.TabIndex = 0
		lblTitle.Text = "Review Produk Lipstick"
		' 
		' cardInput
		' 
		cardInput.BackColor = Color.White
		cardInput.Controls.Add(lblProduk)
		cardInput.Controls.Add(cmbProduk)
		cardInput.Controls.Add(lblReviewer)
		cardInput.Controls.Add(txtReviewer)
		cardInput.Controls.Add(lblRating)
		cardInput.Controls.Add(txtRating)
		cardInput.Controls.Add(lblKomentar)
		cardInput.Controls.Add(txtKomentar)
		cardInput.Controls.Add(lblTanggal)
		cardInput.Controls.Add(dtpTanggal)
		cardInput.Controls.Add(btnSimpan)
		cardInput.Controls.Add(btnUbah)
		cardInput.Controls.Add(btnHapus)
		cardInput.Controls.Add(btnBatal)
		cardInput.Controls.Add(btnBack)
		cardInput.Location = New Point(20, 100)
		cardInput.Name = "cardInput"
		cardInput.Size = New Size(320, 529)
		cardInput.TabIndex = 1
		' 
		' lblProduk
		' 
		lblProduk.Location = New Point(20, 20)
		lblProduk.Name = "lblProduk"
		lblProduk.Size = New Size(120, 20)
		lblProduk.TabIndex = 0
		lblProduk.Text = "Produk Lipstick"
		' 
		' cmbProduk
		' 
		cmbProduk.Location = New Point(20, 42)
		cmbProduk.Name = "cmbProduk"
		cmbProduk.Size = New Size(280, 28)
		cmbProduk.TabIndex = 1
		' 
		' lblReviewer
		' 
		lblReviewer.Location = New Point(20, 80)
		lblReviewer.Name = "lblReviewer"
		lblReviewer.Size = New Size(120, 20)
		lblReviewer.TabIndex = 2
		lblReviewer.Text = "Nama Reviewer"
		' 
		' txtReviewer
		' 
		txtReviewer.Location = New Point(20, 100)
		txtReviewer.Name = "txtReviewer"
		txtReviewer.Size = New Size(280, 27)
		txtReviewer.TabIndex = 3
		' 
		' lblRating
		' 
		lblRating.Location = New Point(20, 138)
		lblRating.Name = "lblRating"
		lblRating.Size = New Size(100, 20)
		lblRating.TabIndex = 4
		lblRating.Text = "Rating (1-5)"
		' 
		' txtRating
		' 
		txtRating.Location = New Point(20, 158)
		txtRating.Name = "txtRating"
		txtRating.Size = New Size(80, 27)
		txtRating.TabIndex = 5
		' 
		' lblKomentar
		' 
		lblKomentar.Location = New Point(20, 198)
		lblKomentar.Name = "lblKomentar"
		lblKomentar.Size = New Size(100, 20)
		lblKomentar.TabIndex = 6
		lblKomentar.Text = "Komentar"
		' 
		' txtKomentar
		' 
		txtKomentar.Location = New Point(20, 218)
		txtKomentar.Multiline = True
		txtKomentar.Name = "txtKomentar"
		txtKomentar.Size = New Size(280, 60)
		txtKomentar.TabIndex = 7
		' 
		' lblTanggal
		' 
		lblTanggal.Location = New Point(20, 292)
		lblTanggal.Name = "lblTanggal"
		lblTanggal.Size = New Size(120, 20)
		lblTanggal.TabIndex = 8
		lblTanggal.Text = "Tanggal Review"
		' 
		' dtpTanggal
		' 
		dtpTanggal.Format = DateTimePickerFormat.Short
		dtpTanggal.Location = New Point(20, 315)
		dtpTanggal.Name = "dtpTanggal"
		dtpTanggal.Size = New Size(280, 27)
		dtpTanggal.TabIndex = 9
		' 
		' btnSimpan
		' 
		btnSimpan.BackColor = Color.FromArgb(CByte(128), CByte(0), CByte(32))
		btnSimpan.FlatStyle = FlatStyle.Flat
		btnSimpan.ForeColor = Color.White
		btnSimpan.Location = New Point(20, 360)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(280, 32)
		btnSimpan.TabIndex = 10
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = False
		' 
		' btnUbah
		' 
		btnUbah.BackColor = Color.FromArgb(CByte(160), CByte(0), CByte(40))
		btnUbah.FlatStyle = FlatStyle.Flat
		btnUbah.ForeColor = Color.White
		btnUbah.Location = New Point(20, 398)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(280, 32)
		btnUbah.TabIndex = 11
		btnUbah.Text = "Ubah"
		btnUbah.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.Firebrick
		btnHapus.FlatStyle = FlatStyle.Flat
		btnHapus.ForeColor = Color.White
		btnHapus.Location = New Point(20, 438)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(130, 32)
		btnHapus.TabIndex = 12
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' btnBatal
		' 
		btnBatal.BackColor = Color.Gray
		btnBatal.FlatStyle = FlatStyle.Flat
		btnBatal.ForeColor = Color.White
		btnBatal.Location = New Point(170, 438)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(130, 32)
		btnBatal.TabIndex = 13
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = False
		' 
		' btnBack
		' 
		btnBack.FlatStyle = FlatStyle.Flat
		btnBack.Location = New Point(20, 478)
		btnBack.Name = "btnBack"
		btnBack.Size = New Size(130, 28)
		btnBack.TabIndex = 14
		btnBack.Text = "Kembali"
		' 
		' cardTable
		' 
		cardTable.BackColor = Color.White
		cardTable.Controls.Add(lblSearch)
		cardTable.Controls.Add(txtSearch)
		cardTable.Controls.Add(dgvReview)
		cardTable.Location = New Point(360, 100)
		cardTable.Name = "cardTable"
		cardTable.Size = New Size(720, 529)
		cardTable.TabIndex = 0
		' 
		' lblSearch
		' 
		lblSearch.Location = New Point(20, 16)
		lblSearch.Name = "lblSearch"
		lblSearch.Size = New Size(220, 20)
		lblSearch.TabIndex = 0
		lblSearch.Text = "Cari (Nama Produk / Reviewer)"
		' 
		' txtSearch
		' 
		txtSearch.Location = New Point(20, 38)
		txtSearch.Name = "txtSearch"
		txtSearch.Size = New Size(680, 27)
		txtSearch.TabIndex = 1
		' 
		' dgvReview
		' 
		dgvReview.AllowUserToAddRows = False
		dgvReview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvReview.BackgroundColor = Color.SeaShell
		dgvReview.ColumnHeadersHeight = 29
		dgvReview.Location = New Point(20, 80)
		dgvReview.Name = "dgvReview"
		dgvReview.ReadOnly = True
		dgvReview.RowHeadersWidth = 51
		dgvReview.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvReview.Size = New Size(680, 426)
		dgvReview.TabIndex = 2
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' Form4
		' 
		BackColor = Color.SeaShell
		ClientSize = New Size(1100, 651)
		Controls.Add(cardTable)
		Controls.Add(cardInput)
		Controls.Add(header)
		Name = "Form4"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Review Produk Lipstick"
		header.ResumeLayout(False)
		header.PerformLayout()
		cardInput.ResumeLayout(False)
		cardInput.PerformLayout()
		cardTable.ResumeLayout(False)
		cardTable.PerformLayout()
		CType(dgvReview, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub
End Class