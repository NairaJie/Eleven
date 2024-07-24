<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtlama = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.rbmember = New System.Windows.Forms.RadioButton()
        Me.rbnon = New System.Windows.Forms.RadioButton()
        Me.cmbjenis = New System.Windows.Forms.ComboBox()
        Me.dttanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbbuku = New System.Windows.Forms.CheckBox()
        Me.cbpensil = New System.Windows.Forms.CheckBox()
        Me.cbpena = New System.Windows.Forms.CheckBox()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.dgview = New System.Windows.Forms.DataGridView()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(681, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Penyewaan Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Sewa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Penyewa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipe Penyewa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis Buku"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Pinjam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 460)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Lama Pinjam"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 537)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Bonus"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(179, 139)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(239, 29)
        Me.txtid.TabIndex = 8
        '
        'txtlama
        '
        Me.txtlama.Location = New System.Drawing.Point(179, 460)
        Me.txtlama.Name = "txtlama"
        Me.txtlama.Size = New System.Drawing.Size(239, 29)
        Me.txtlama.TabIndex = 9
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(179, 202)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(239, 29)
        Me.txtnama.TabIndex = 10
        '
        'rbmember
        '
        Me.rbmember.AutoSize = True
        Me.rbmember.Location = New System.Drawing.Point(179, 262)
        Me.rbmember.Name = "rbmember"
        Me.rbmember.Size = New System.Drawing.Size(109, 29)
        Me.rbmember.TabIndex = 11
        Me.rbmember.TabStop = True
        Me.rbmember.Text = "Member"
        Me.rbmember.UseVisualStyleBackColor = True
        '
        'rbnon
        '
        Me.rbnon.AutoSize = True
        Me.rbnon.Location = New System.Drawing.Point(409, 262)
        Me.rbnon.Name = "rbnon"
        Me.rbnon.Size = New System.Drawing.Size(150, 29)
        Me.rbnon.TabIndex = 12
        Me.rbnon.TabStop = True
        Me.rbnon.Text = "Non Member"
        Me.rbnon.UseVisualStyleBackColor = True
        '
        'cmbjenis
        '
        Me.cmbjenis.FormattingEnabled = True
        Me.cmbjenis.Items.AddRange(New Object() {"Novel", "Majalah", "Komik"})
        Me.cmbjenis.Location = New System.Drawing.Point(179, 314)
        Me.cmbjenis.Name = "cmbjenis"
        Me.cmbjenis.Size = New System.Drawing.Size(239, 32)
        Me.cmbjenis.TabIndex = 13
        '
        'dttanggal
        '
        Me.dttanggal.Location = New System.Drawing.Point(179, 383)
        Me.dttanggal.Name = "dttanggal"
        Me.dttanggal.Size = New System.Drawing.Size(317, 29)
        Me.dttanggal.TabIndex = 14
        '
        'cbbuku
        '
        Me.cbbuku.AutoSize = True
        Me.cbbuku.Location = New System.Drawing.Point(179, 533)
        Me.cbbuku.Name = "cbbuku"
        Me.cbbuku.Size = New System.Drawing.Size(83, 29)
        Me.cbbuku.TabIndex = 15
        Me.cbbuku.Text = "Buku"
        Me.cbbuku.UseVisualStyleBackColor = True
        '
        'cbpensil
        '
        Me.cbpensil.AutoSize = True
        Me.cbpensil.Location = New System.Drawing.Point(575, 533)
        Me.cbpensil.Name = "cbpensil"
        Me.cbpensil.Size = New System.Drawing.Size(91, 29)
        Me.cbpensil.TabIndex = 16
        Me.cbpensil.Text = "Pensil"
        Me.cbpensil.UseVisualStyleBackColor = True
        '
        'cbpena
        '
        Me.cbpena.AutoSize = True
        Me.cbpena.Location = New System.Drawing.Point(375, 533)
        Me.cbpena.Name = "cbpena"
        Me.cbpena.Size = New System.Drawing.Size(84, 29)
        Me.cbpena.TabIndex = 17
        Me.cbpena.Text = "Pena"
        Me.cbpena.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(37, 615)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(94, 39)
        Me.bttambah.TabIndex = 18
        Me.bttambah.Text = "Tambah"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(469, 615)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(94, 39)
        Me.btkeluar.TabIndex = 19
        Me.btkeluar.Text = "Keluar"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(324, 615)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(94, 39)
        Me.bthapus.TabIndex = 20
        Me.bthapus.Text = "Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(179, 615)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(94, 39)
        Me.btsimpan.TabIndex = 21
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'dgview
        '
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Location = New System.Drawing.Point(12, 709)
        Me.dgview.Name = "dgview"
        Me.dgview.RowHeadersWidth = 72
        Me.dgview.RowTemplate.Height = 31
        Me.dgview.Size = New System.Drawing.Size(779, 372)
        Me.dgview.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1702, 907)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.cbpena)
        Me.Controls.Add(Me.cbpensil)
        Me.Controls.Add(Me.cbbuku)
        Me.Controls.Add(Me.dttanggal)
        Me.Controls.Add(Me.cmbjenis)
        Me.Controls.Add(Me.rbnon)
        Me.Controls.Add(Me.rbmember)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtlama)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtlama As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents rbmember As RadioButton
    Friend WithEvents rbnon As RadioButton
    Friend WithEvents cmbjenis As ComboBox
    Friend WithEvents dttanggal As DateTimePicker
    Friend WithEvents cbbuku As CheckBox
    Friend WithEvents cbpensil As CheckBox
    Friend WithEvents cbpena As CheckBox
    Friend WithEvents bttambah As Button
    Friend WithEvents btkeluar As Button
    Friend WithEvents bthapus As Button
    Friend WithEvents btsimpan As Button
    Friend WithEvents dgview As DataGridView
End Class
