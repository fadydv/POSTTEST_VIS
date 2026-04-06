<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
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

	'NOTE: The following procedure is required by the Windows Form Designer
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		picBackgroundKartu = New PictureBox()
		picFotoKartu = New PictureBox()
		lblNamaKartu = New Label()
		lblIDKartu = New Label()
		lblDivisiKartu = New Label()
		lblKontakKartu = New Label()
		lblHobiKartu = New Label()
		CType(picBackgroundKartu, ComponentModel.ISupportInitialize).BeginInit()
		CType(picFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' picBackgroundKartu
		' 
		picBackgroundKartu.Dock = DockStyle.Fill
		picBackgroundKartu.Image = My.Resources.Resources.kartu1
		picBackgroundKartu.Location = New Point(0, 0)
		picBackgroundKartu.Name = "picBackgroundKartu"
		picBackgroundKartu.Size = New Size(781, 428)
		picBackgroundKartu.SizeMode = PictureBoxSizeMode.StretchImage
		picBackgroundKartu.TabIndex = 0
		picBackgroundKartu.TabStop = False
		' 
		' picFotoKartu
		' 
		picFotoKartu.BackColor = Color.Gainsboro
		picFotoKartu.BorderStyle = BorderStyle.FixedSingle
		picFotoKartu.Location = New Point(110, 104)
		picFotoKartu.Name = "picFotoKartu"
		picFotoKartu.Size = New Size(178, 215)
		picFotoKartu.SizeMode = PictureBoxSizeMode.Zoom
		picFotoKartu.TabIndex = 1
		picFotoKartu.TabStop = False
		' 
		' lblNamaKartu
		' 
		lblNamaKartu.AutoSize = True
		lblNamaKartu.BackColor = Color.Transparent
		lblNamaKartu.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
		lblNamaKartu.Location = New Point(360, 122)
		lblNamaKartu.Name = "lblNamaKartu"
		lblNamaKartu.Size = New Size(202, 32)
		lblNamaKartu.TabIndex = 2
		lblNamaKartu.Text = "[Nama Lengkap]"
		' 
		' lblIDKartu
		' 
		lblIDKartu.AutoSize = True
		lblIDKartu.BackColor = Color.Transparent
		lblIDKartu.Font = New Font("Segoe UI", 10.0F)
		lblIDKartu.Location = New Point(360, 172)
		lblIDKartu.Name = "lblIDKartu"
		lblIDKartu.Size = New Size(108, 23)
		lblIDKartu.TabIndex = 3
		lblIDKartu.Text = "[ID Anggota]"
		' 
		' lblDivisiKartu
		' 
		lblDivisiKartu.AutoSize = True
		lblDivisiKartu.BackColor = Color.Transparent
		lblDivisiKartu.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
		lblDivisiKartu.Location = New Point(360, 210)
		lblDivisiKartu.Name = "lblDivisiKartu"
		lblDivisiKartu.Size = New Size(59, 23)
		lblDivisiKartu.TabIndex = 4
		lblDivisiKartu.Text = "[Divisi]"
		' 
		' lblKontakKartu
		' 
		lblKontakKartu.AutoSize = True
		lblKontakKartu.BackColor = Color.Transparent
		lblKontakKartu.Font = New Font("Segoe UI", 9.0F)
		lblKontakKartu.Location = New Point(360, 247)
		lblKontakKartu.Name = "lblKontakKartu"
		lblKontakKartu.Size = New Size(65, 20)
		lblKontakKartu.TabIndex = 5
		lblKontakKartu.Text = "[Kontak]"
		' 
		' lblHobiKartu
		' 
		lblHobiKartu.AutoSize = True
		lblHobiKartu.BackColor = Color.Transparent
		lblHobiKartu.Font = New Font("Segoe UI", 9.0F)
		lblHobiKartu.Location = New Point(360, 281)
		lblHobiKartu.Name = "lblHobiKartu"
		lblHobiKartu.Size = New Size(52, 20)
		lblHobiKartu.TabIndex = 6
		lblHobiKartu.Text = "[Hobi]"
		' 
		' FormHasil
		' 
		AutoScaleMode = AutoScaleMode.None
		ClientSize = New Size(781, 428)
		Controls.Add(lblHobiKartu)
		Controls.Add(lblKontakKartu)
		Controls.Add(lblDivisiKartu)
		Controls.Add(lblIDKartu)
		Controls.Add(lblNamaKartu)
		Controls.Add(picFotoKartu)
		Controls.Add(picBackgroundKartu)
		FormBorderStyle = FormBorderStyle.FixedToolWindow
		Name = "FormHasil"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Hasil ID Card Komunitas"
		CType(picBackgroundKartu, ComponentModel.ISupportInitialize).EndInit()
		CType(picFotoKartu, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents picBackgroundKartu As PictureBox
	Friend WithEvents picFotoKartu As PictureBox
    Friend WithEvents lblNamaKartu As Label
    Friend WithEvents lblIDKartu As Label
    Friend WithEvents lblDivisiKartu As Label
    Friend WithEvents lblKontakKartu As Label
    Friend WithEvents lblHobiKartu As Label
End Class