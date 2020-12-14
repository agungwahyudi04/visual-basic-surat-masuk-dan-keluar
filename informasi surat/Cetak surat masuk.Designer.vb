<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cetak_surat_masuk
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
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reportmasuk1 = New informasi_surat.reportmasuk()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tgl2 = New System.Windows.Forms.DateTimePicker()
        Me.tgl1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = 0
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 0)
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = Me.reportmasuk1
        Me.CRV.ShowCloseButton = False
        Me.CRV.ShowGroupTreeButton = False
        Me.CRV.ShowLogo = False
        Me.CRV.ShowParameterPanelButton = False
        Me.CRV.ShowRefreshButton = False
        Me.CRV.ShowTextSearchButton = False
        Me.CRV.Size = New System.Drawing.Size(746, 376)
        Me.CRV.TabIndex = 0
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(554, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tgl2
        '
        Me.tgl2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tgl2.Location = New System.Drawing.Point(461, 5)
        Me.tgl2.Name = "tgl2"
        Me.tgl2.Size = New System.Drawing.Size(87, 20)
        Me.tgl2.TabIndex = 5
        '
        'tgl1
        '
        Me.tgl1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tgl1.Location = New System.Drawing.Point(368, 5)
        Me.tgl1.Name = "tgl1"
        Me.tgl1.Size = New System.Drawing.Size(87, 20)
        Me.tgl1.TabIndex = 4
        '
        'Cetak_surat_masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 376)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tgl2)
        Me.Controls.Add(Me.tgl1)
        Me.Controls.Add(Me.CRV)
        Me.Location = New System.Drawing.Point(340, 250)
        Me.Name = "Cetak_surat_masuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cetak_surat_masuk"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reportmasuk1 As informasi_surat.reportmasuk
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tgl2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tgl1 As System.Windows.Forms.DateTimePicker
End Class
