Public Class FormHasil
    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch

        lblNamaKartu.Text = ModulData.NamaLengkap
        lblIDKartu.Text = "ID: " & ModulData.IDAnggota
        lblDivisiKartu.Text = ModulData.Divisi
        lblKontakKartu.Text = ModulData.NoTelp
        lblHobiKartu.Text = "Hobi: " & ModulData.Hobi

        If ModulData.LokasiFoto <> "" AndAlso System.IO.File.Exists(ModulData.LokasiFoto) Then
            picFotoKartu.Image = Image.FromFile(ModulData.LokasiFoto)
        End If
    End Sub
End Class