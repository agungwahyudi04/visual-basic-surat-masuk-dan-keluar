<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class surat_diterima
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(surat_diterima))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tsurat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.update1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.tprihal = New System.Windows.Forms.RichTextBox()
        Me.tpengirim = New System.Windows.Forms.TextBox()
        Me.tgl = New System.Windows.Forms.DateTimePicker()
        Me.CBjenis = New System.Windows.Forms.ComboBox()
        Me.CBsifat = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tsurat)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.delete)
        Me.Panel1.Controls.Add(Me.update1)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.add)
        Me.Panel1.Controls.Add(Me.tprihal)
        Me.Panel1.Controls.Add(Me.tpengirim)
        Me.Panel1.Controls.Add(Me.tgl)
        Me.Panel1.Controls.Add(Me.CBjenis)
        Me.Panel1.Controls.Add(Me.CBsifat)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 327)
        Me.Panel1.TabIndex = 2
        '
        'tsurat
        '
        Me.tsurat.Location = New System.Drawing.Point(93, 111)
        Me.tsurat.Name = "tsurat"
        Me.tsurat.Size = New System.Drawing.Size(122, 20)
        Me.tsurat.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Sifat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Gecko Personal Use Only", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(192, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(219, 40)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "SURAT MASUK"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.informasi_surat.My.Resources.Resources.spiral_banner_green
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(572, 90)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(383, 293)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(52, 23)
        Me.delete.TabIndex = 28
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        Me.delete.Visible = False
        '
        'update1
        '
        Me.update1.Location = New System.Drawing.Point(325, 293)
        Me.update1.Name = "update1"
        Me.update1.Size = New System.Drawing.Size(52, 23)
        Me.update1.TabIndex = 27
        Me.update1.Text = "Update"
        Me.update1.UseVisualStyleBackColor = True
        Me.update1.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(499, 292)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(52, 23)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "Cancel"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(441, 292)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(52, 23)
        Me.add.TabIndex = 21
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = True
        '
        'tprihal
        '
        Me.tprihal.Location = New System.Drawing.Point(268, 175)
        Me.tprihal.Name = "tprihal"
        Me.tprihal.Size = New System.Drawing.Size(284, 98)
        Me.tprihal.TabIndex = 12
        Me.tprihal.Text = ""
        '
        'tpengirim
        '
        Me.tpengirim.Location = New System.Drawing.Point(93, 203)
        Me.tpengirim.Name = "tpengirim"
        Me.tpengirim.Size = New System.Drawing.Size(122, 20)
        Me.tpengirim.TabIndex = 11
        '
        'tgl
        '
        Me.tgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tgl.Location = New System.Drawing.Point(93, 159)
        Me.tgl.Name = "tgl"
        Me.tgl.Size = New System.Drawing.Size(100, 20)
        Me.tgl.TabIndex = 10
        Me.tgl.Value = New Date(2017, 12, 6, 0, 0, 0, 0)
        '
        'CBjenis
        '
        Me.CBjenis.FormattingEnabled = True
        Me.CBjenis.Items.AddRange(New Object() {"Surat Dinas", "Surat Pengantar", "Surat Perintah", "Surat Pribadi", "Surat Sosial", "Surat Telegram"})
        Me.CBjenis.Location = New System.Drawing.Point(293, 111)
        Me.CBjenis.Name = "CBjenis"
        Me.CBjenis.Size = New System.Drawing.Size(100, 21)
        Me.CBjenis.TabIndex = 8
        '
        'CBsifat
        '
        Me.CBsifat.FormattingEnabled = True
        Me.CBsifat.Items.AddRange(New Object() {"Biasa", "Penting", "Rahasia"})
        Me.CBsifat.Location = New System.Drawing.Point(93, 252)
        Me.CBsifat.Name = "CBsifat"
        Me.CBsifat.Size = New System.Drawing.Size(122, 21)
        Me.CBsifat.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Perihal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pengirim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Surat"
        '
        'surat_diterima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 329)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(375, 250)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "surat_diterima"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TAMBAH SURAT MASUK"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tsurat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents update1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents tprihal As System.Windows.Forms.RichTextBox
    Friend WithEvents tpengirim As System.Windows.Forms.TextBox
    Friend WithEvents tgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBjenis As System.Windows.Forms.ComboBox
    Friend WithEvents CBsifat As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
