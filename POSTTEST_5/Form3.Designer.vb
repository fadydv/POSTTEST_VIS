<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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

    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents card As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents txtKategori As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvKategori As System.Windows.Forms.DataGridView

	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		header = New Panel()
		lblTitle = New Label()
		card = New Panel()
		lblKategori = New Label()
		txtKategori = New TextBox()
		btnTambah = New Button()
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
		header.Size = New Size(600, 80)
		header.TabIndex = 1
		' 
		' lblTitle
		' 
		lblTitle.AutoSize = True
		lblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
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
		card.Controls.Add(btnBack)
		card.Controls.Add(dgvKategori)
		card.Location = New Point(30, 100)
		card.Name = "card"
		card.Size = New Size(540, 372)
		card.TabIndex = 0
		' 
		' lblKategori
		' 
		lblKategori.Location = New Point(30, 20)
		lblKategori.Name = "lblKategori"
		lblKategori.Size = New Size(125, 23)
		lblKategori.TabIndex = 0
		lblKategori.Text = "Nama Kategori"
		' 
		' txtKategori
		' 
		txtKategori.Location = New Point(30, 45)
		txtKategori.Name = "txtKategori"
		txtKategori.Size = New Size(338, 27)
		txtKategori.TabIndex = 1
		' 
		' btnTambah
		' 
		btnTambah.BackColor = Color.Maroon
		btnTambah.FlatStyle = FlatStyle.Flat
		btnTambah.ForeColor = Color.White
		btnTambah.Location = New Point(390, 45)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(120, 35)
		btnTambah.TabIndex = 2
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = False
		' 
		' btnBack
		' 
		btnBack.FlatStyle = FlatStyle.Flat
		btnBack.Location = New Point(30, 320)
		btnBack.Name = "btnBack"
		btnBack.Size = New Size(100, 30)
		btnBack.TabIndex = 3
		btnBack.Text = "Kembali"
		' 
		' dgvKategori
		' 
		dgvKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvKategori.BackgroundColor = Color.SeaShell
		dgvKategori.ColumnHeadersHeight = 29
		dgvKategori.Location = New Point(30, 100)
		dgvKategori.Name = "dgvKategori"
		dgvKategori.RowHeadersWidth = 51
		dgvKategori.Size = New Size(480, 200)
		dgvKategori.TabIndex = 4
		' 
		' Form3
		' 
		BackColor = Color.SeaShell
		ClientSize = New Size(600, 500)
		Controls.Add(card)
		Controls.Add(header)
		Name = "Form3"
		Text = "Data Kategori"
		header.ResumeLayout(False)
		header.PerformLayout()
		card.ResumeLayout(False)
		card.PerformLayout()
		CType(dgvKategori, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub
End Class