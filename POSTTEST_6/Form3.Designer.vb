<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
    Friend WithEvents card As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents txtKategori As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvKategori As System.Windows.Forms.DataGridView

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		header = New Panel()
		lblTitle = New Label()
		card = New Panel()
		lblKategori = New Label()
		txtKategori = New TextBox()
		btnTambah = New Button()
		btnUbah = New Button()
		btnHapus = New Button()
		btnBatal = New Button()
		btnBack = New Button()
		dgvKategori = New DataGridView()
		header.SuspendLayout()
		card.SuspendLayout()
		CType(dgvKategori, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' header
		' 
		header.BackColor = Color.FromArgb(CByte(120), CByte(0), CByte(40))
		header.Controls.Add(lblTitle)
		header.Dock = DockStyle.Top
		header.Location = New Point(0, 0)
		header.Name = "header"
		header.Size = New Size(620, 80)
		header.TabIndex = 1
		' 
		' lblTitle
		' 
		lblTitle.AutoSize = True
		lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
		lblTitle.ForeColor = Color.White
		lblTitle.Location = New Point(20, 25)
		lblTitle.Name = "lblTitle"
		lblTitle.Size = New Size(253, 32)
		lblTitle.TabIndex = 0
		lblTitle.Text = "Manajemen Kategori"
		' 
		' card
		' 
		card.BackColor = Color.White
		card.Controls.Add(lblKategori)
		card.Controls.Add(txtKategori)
		card.Controls.Add(btnTambah)
		card.Controls.Add(btnUbah)
		card.Controls.Add(btnHapus)
		card.Controls.Add(btnBatal)
		card.Controls.Add(btnBack)
		card.Controls.Add(dgvKategori)
		card.Location = New Point(30, 100)
		card.Name = "card"
		card.Size = New Size(560, 407)
		card.TabIndex = 0
		' 
		' lblKategori
		' 
		lblKategori.Location = New Point(30, 20)
		lblKategori.Name = "lblKategori"
		lblKategori.Size = New Size(120, 23)
		lblKategori.TabIndex = 0
		lblKategori.Text = "Nama Kategori"
		' 
		' txtKategori
		' 
		txtKategori.Location = New Point(30, 45)
		txtKategori.Name = "txtKategori"
		txtKategori.Size = New Size(300, 27)
		txtKategori.TabIndex = 1
		' 
		' btnTambah
		' 
		btnTambah.BackColor = Color.Maroon
		btnTambah.FlatStyle = FlatStyle.Flat
		btnTambah.ForeColor = Color.White
		btnTambah.Location = New Point(30, 85)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(110, 32)
		btnTambah.TabIndex = 2
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = False
		' 
		' btnUbah
		' 
		btnUbah.BackColor = Color.FromArgb(CByte(160), CByte(0), CByte(40))
		btnUbah.FlatStyle = FlatStyle.Flat
		btnUbah.ForeColor = Color.White
		btnUbah.Location = New Point(150, 85)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(110, 32)
		btnUbah.TabIndex = 3
		btnUbah.Text = "Ubah"
		btnUbah.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.Firebrick
		btnHapus.FlatStyle = FlatStyle.Flat
		btnHapus.ForeColor = Color.White
		btnHapus.Location = New Point(270, 85)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(110, 32)
		btnHapus.TabIndex = 4
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' btnBatal
		' 
		btnBatal.BackColor = Color.Gray
		btnBatal.FlatStyle = FlatStyle.Flat
		btnBatal.ForeColor = Color.White
		btnBatal.Location = New Point(390, 85)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(110, 32)
		btnBatal.TabIndex = 5
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = False
		' 
		' btnBack
		' 
		btnBack.FlatStyle = FlatStyle.Flat
		btnBack.Location = New Point(30, 365)
		btnBack.Name = "btnBack"
		btnBack.Size = New Size(100, 30)
		btnBack.TabIndex = 6
		btnBack.Text = "Kembali"
		' 
		' dgvKategori
		' 
		dgvKategori.AllowUserToAddRows = False
		dgvKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvKategori.BackgroundColor = Color.SeaShell
		dgvKategori.ColumnHeadersHeight = 29
		dgvKategori.Location = New Point(30, 135)
		dgvKategori.Name = "dgvKategori"
		dgvKategori.ReadOnly = True
		dgvKategori.RowHeadersWidth = 51
		dgvKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvKategori.Size = New Size(500, 220)
		dgvKategori.TabIndex = 7
		' 
		' Form3
		' 
		BackColor = Color.SeaShell
		ClientSize = New Size(620, 529)
		Controls.Add(card)
		Controls.Add(header)
		Name = "Form3"
		StartPosition = FormStartPosition.CenterParent
		Text = "Data Kategori"
		header.ResumeLayout(False)
		header.PerformLayout()
		card.ResumeLayout(False)
		card.PerformLayout()
		CType(dgvKategori, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub
End Class