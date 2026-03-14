<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
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

        Me.pbFotoHasil = New PictureBox()

        Me.lblNama = New Label()
        Me.lblUmur = New Label()
        Me.lblTanggal = New Label()
        Me.lblTelepon = New Label()
        Me.lblAlamat = New Label()
        Me.lblHobby = New Label()

        Me.txtNama = New Label()
        Me.txtUmur = New Label()
        Me.txtTanggal = New Label()
        Me.txtTelepon = New Label()
        Me.txtAlamat = New Label()
        Me.txtHobby = New Label()

        CType(Me.pbFotoHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.pbFotoHasil.Location = New Point(30, 40)
        Me.pbFotoHasil.Size = New Size(150, 180)
        Me.pbFotoHasil.SizeMode = PictureBoxSizeMode.Zoom
        Me.pbFotoHasil.BorderStyle = BorderStyle.FixedSingle

        Me.lblNama.Location = New Point(210, 40)
        Me.lblNama.Text = "Nama"

        Me.lblUmur.Location = New Point(210, 70)
        Me.lblUmur.Text = "Umur"

        Me.lblTanggal.Location = New Point(210, 100)
        Me.lblTanggal.Text = "Tanggal Lahir"

        Me.lblTelepon.Location = New Point(210, 130)
        Me.lblTelepon.Text = "No Telpon"

        Me.lblAlamat.Location = New Point(210, 160)
        Me.lblAlamat.Text = "Alamat"

        Me.lblHobby.Location = New Point(210, 190)
        Me.lblHobby.Text = "Hobby"

        Me.txtNama.Location = New Point(320, 40)
        Me.txtNama.Size = New Size(200, 23)

        Me.txtUmur.Location = New Point(320, 70)

        Me.txtTanggal.Location = New Point(320, 100)

        Me.txtTelepon.Location = New Point(320, 130)

        Me.txtAlamat.Location = New Point(320, 160)
        Me.txtAlamat.Size = New Size(220, 23)

        Me.txtHobby.Location = New Point(320, 190)
        Me.txtHobby.Size = New Size(250, 23)

        Me.ClientSize = New Size(600, 260)

        Me.Controls.Add(Me.pbFotoHasil)

        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblUmur)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.lblTelepon)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblHobby)

        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtHobby)

        Me.Text = "Kartu Komunitas"

        CType(Me.pbFotoHasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbFotoHasil As PictureBox

    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblHobby As Label

    Friend WithEvents txtNama As Label
    Friend WithEvents txtUmur As Label
    Friend WithEvents txtTanggal As Label
    Friend WithEvents txtTelepon As Label
    Friend WithEvents txtAlamat As Label
    Friend WithEvents txtHobby As Label

End Class