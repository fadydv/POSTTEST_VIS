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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        grpTambah = New GroupBox()
        txtJudul = New TextBox()
        txtGenre = New TextBox()
        btnTambah = New Button()
        grpHapus = New GroupBox()
        txtHapus = New TextBox()
        btnHapus = New Button()
        lstBuku = New ListBox()
        grpTambah.SuspendLayout()
        grpHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 0
        Label3.Text = "Judul Buku"
        ' 
        ' grpTambah
        ' 
        grpTambah.Controls.Add(Label1)
        grpTambah.Controls.Add(Label2)
        grpTambah.Controls.Add(txtJudul)
        grpTambah.Controls.Add(txtGenre)
        grpTambah.Controls.Add(btnTambah)
        grpTambah.Location = New Point(20, 20)
        grpTambah.Name = "grpTambah"
        grpTambah.Size = New Size(320, 180)
        grpTambah.TabIndex = 0
        grpTambah.TabStop = False
        grpTambah.Text = "Tambah Buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(120, 40)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(180, 27)
        txtJudul.TabIndex = 2
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(120, 80)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(180, 27)
        txtGenre.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(200, 120)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(100, 30)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        ' 
        ' grpHapus
        ' 
        grpHapus.Controls.Add(Label3)
        grpHapus.Controls.Add(txtHapus)
        grpHapus.Controls.Add(btnHapus)
        grpHapus.Location = New Point(360, 20)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(320, 180)
        grpHapus.TabIndex = 1
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(120, 40)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(180, 27)
        txtHapus.TabIndex = 1
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(200, 120)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(100, 30)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        ' 
        ' lstBuku
        ' 
        lstBuku.Location = New Point(150, 220)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(400, 184)
        lstBuku.TabIndex = 2
        ' 
        ' Form1
        ' 
        ClientSize = New Size(720, 450)
        Controls.Add(grpTambah)
        Controls.Add(grpHapus)
        Controls.Add(lstBuku)
        Name = "Form1"
        Text = "Posttest 2"
        grpTambah.ResumeLayout(False)
        grpTambah.PerformLayout()
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grpTambah As GroupBox
    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lstBuku As ListBox

End Class