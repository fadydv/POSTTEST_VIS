<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents txtBrand As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvBrand As System.Windows.Forms.DataGridView

	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		header = New Panel()
		lblTitle = New Label()
		card = New Panel()
		lblBrand = New Label()
		txtBrand = New TextBox()
		btnTambah = New Button()
		btnBack = New Button()
		dgvBrand = New DataGridView()
		header.SuspendLayout()
		card.SuspendLayout()
		CType(dgvBrand, ComponentModel.ISupportInitialize).BeginInit()
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
		lblTitle.Size = New Size(223, 32)
		lblTitle.TabIndex = 0
		lblTitle.Text = "Manajemen Brand"
		' 
		' card
		' 
		card.BackColor = Color.White
		card.Controls.Add(lblBrand)
		card.Controls.Add(txtBrand)
		card.Controls.Add(btnTambah)
		card.Controls.Add(btnBack)
		card.Controls.Add(dgvBrand)
		card.Location = New Point(30, 100)
		card.Name = "card"
		card.Size = New Size(540, 372)
		card.TabIndex = 0
		' 
		' lblBrand
		' 
		lblBrand.Location = New Point(30, 20)
		lblBrand.Name = "lblBrand"
		lblBrand.Size = New Size(100, 23)
		lblBrand.TabIndex = 0
		lblBrand.Text = "Nama Brand"
		' 
		' txtBrand
		' 
		txtBrand.Location = New Point(30, 45)
		txtBrand.Name = "txtBrand"
		txtBrand.Size = New Size(338, 27)
		txtBrand.TabIndex = 1
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
		btnBack.ForeColor = SystemColors.ControlText
		btnBack.Location = New Point(30, 320)
		btnBack.Name = "btnBack"
		btnBack.Size = New Size(100, 30)
		btnBack.TabIndex = 3
		btnBack.Text = "Kembali"
		' 
		' dgvBrand
		' 
		dgvBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvBrand.BackgroundColor = Color.SeaShell
		dgvBrand.ColumnHeadersHeight = 29
		dgvBrand.Location = New Point(30, 100)
		dgvBrand.Name = "dgvBrand"
		dgvBrand.RowHeadersWidth = 51
		dgvBrand.Size = New Size(480, 200)
		dgvBrand.TabIndex = 4
		' 
		' Form2
		' 
		BackColor = Color.SeaShell
		ClientSize = New Size(600, 500)
		Controls.Add(card)
		Controls.Add(header)
		Name = "Form2"
		Text = "Data Brand"
		header.ResumeLayout(False)
		header.PerformLayout()
		card.ResumeLayout(False)
		card.PerformLayout()
		CType(dgvBrand, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub
End Class