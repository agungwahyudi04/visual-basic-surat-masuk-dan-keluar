<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahSuratMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahSuratKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarSuratMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarSuratKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(-6, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1363, 547)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BackgroundImage = Global.informasi_surat.My.Resources.Resources.spiral_banner_green4
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 185)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(307, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(729, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jl. Raya Gresik - Babat No.100, Sidokumpul, Kec. Lamongan, Kabupaten Lamongan, Ja" & _
            "wa Timur 62212"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(827, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DINAS TANAMAN PANGAN, HOLTIKULTURA DAN PERKEBUNAN KABUPATEN LAMONGAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(365, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(610, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SISTEM INFORMASI PENGARSIPAN SURAT"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahSuratMasukToolStripMenuItem, Me.TambahSuratKeluarToolStripMenuItem, Me.DaftarSuratMasukToolStripMenuItem, Me.DaftarSuratKeluarToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'TambahSuratMasukToolStripMenuItem
        '
        Me.TambahSuratMasukToolStripMenuItem.Name = "TambahSuratMasukToolStripMenuItem"
        Me.TambahSuratMasukToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.TambahSuratMasukToolStripMenuItem.Text = "Tambah Surat Masuk"
        '
        'TambahSuratKeluarToolStripMenuItem
        '
        Me.TambahSuratKeluarToolStripMenuItem.Name = "TambahSuratKeluarToolStripMenuItem"
        Me.TambahSuratKeluarToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.TambahSuratKeluarToolStripMenuItem.Text = "Tambah Surat Keluar"
        '
        'DaftarSuratMasukToolStripMenuItem
        '
        Me.DaftarSuratMasukToolStripMenuItem.Name = "DaftarSuratMasukToolStripMenuItem"
        Me.DaftarSuratMasukToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.DaftarSuratMasukToolStripMenuItem.Text = "Daftar Surat Masuk"
        '
        'DaftarSuratKeluarToolStripMenuItem
        '
        Me.DaftarSuratKeluarToolStripMenuItem.Name = "DaftarSuratKeluarToolStripMenuItem"
        Me.DaftarSuratKeluarToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.DaftarSuratKeluarToolStripMenuItem.Text = "Daftar Surat Keluar"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "SISTEM INFORMASI PENGARSIPAN SURAT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahSuratMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahSuratKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarSuratMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarSuratKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
