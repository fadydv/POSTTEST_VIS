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
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Label1 = New Label()
		txtIPS = New TextBox()
		btnTambah = New Button()
		btnReset = New Button()
		Label2 = New Label()
		txtIPK = New TextBox()
		lblPredikat = New Label()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(187, 144)
		Label1.Name = "Label1"
		Label1.Size = New Size(86, 20)
		Label1.TabIndex = 0
		Label1.Text = "IP Semester"
		' 
		' txtIPS
		' 
		txtIPS.BackColor = Color.Snow
		txtIPS.BorderStyle = BorderStyle.FixedSingle
		txtIPS.Location = New Point(327, 142)
		txtIPS.Name = "txtIPS"
		txtIPS.Size = New Size(193, 27)
		txtIPS.TabIndex = 1
		' 
		' btnTambah
		' 
		btnTambah.BackColor = Color.RosyBrown
		btnTambah.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		btnTambah.ForeColor = SystemColors.ControlText
		btnTambah.Location = New Point(327, 189)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(93, 29)
		btnTambah.TabIndex = 2
		btnTambah.Text = "Tambah"
		btnTambah.TextImageRelation = TextImageRelation.ImageAboveText
		btnTambah.UseVisualStyleBackColor = False
		' 
		' btnReset
		' 
		btnReset.BackColor = Color.RosyBrown
		btnReset.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		btnReset.ForeColor = SystemColors.ControlText
		btnReset.Location = New Point(427, 189)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(93, 29)
		btnReset.TabIndex = 3
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = False
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(187, 239)
		Label2.Name = "Label2"
		Label2.Size = New Size(89, 20)
		Label2.TabIndex = 4
		Label2.Text = "IP Kumulatif"
		' 
		' txtIPK
		' 
		txtIPK.BackColor = Color.Snow
		txtIPK.BorderStyle = BorderStyle.FixedSingle
		txtIPK.ForeColor = SystemColors.ControlText
		txtIPK.Location = New Point(327, 237)
		txtIPK.Name = "txtIPK"
		txtIPK.ReadOnly = True
		txtIPK.Size = New Size(193, 27)
		txtIPK.TabIndex = 5
		' 
		' lblPredikat
		' 
		lblPredikat.AutoSize = True
		lblPredikat.Location = New Point(327, 283)
		lblPredikat.Name = "lblPredikat"
		lblPredikat.Size = New Size(18, 20)
		lblPredikat.TabIndex = 6
		lblPredikat.Text = "..."
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.MistyRose
		ClientSize = New Size(800, 451)
		Controls.Add(lblPredikat)
		Controls.Add(txtIPK)
		Controls.Add(Label2)
		Controls.Add(btnReset)
		Controls.Add(btnTambah)
		Controls.Add(txtIPS)
		Controls.Add(Label1)
		Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		FormBorderStyle = FormBorderStyle.FixedSingle
		Icon = CType(resources.GetObject("$this.Icon"), Icon)
		Name = "Form1"
		Text = "Kalkulator IP"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents txtIPS As TextBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents txtIPK As TextBox
	Friend WithEvents lblPredikat As Label

End Class
