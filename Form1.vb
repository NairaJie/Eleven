Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=quiz_uas_2321022"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim cek As MySqlDataReader
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim tipe, bonus As String

    Sub tidakaktif()
        txtid.Enabled = False
        txtnama.Enabled = False
        rbmember.Enabled = False
        rbnon.Enabled = False
        cmbjenis.Enabled = False
        dttanggal.Enabled = False
        txtlama.Enabled = False
        cbbuku.Enabled = False
        cbpena.Enabled = False
        cbpensil.Enabled = False

        txtid.BackColor = Color.Gray
        txtnama.BackColor = Color.Gray
        rbmember.BackColor = Color.Gray
        rbnon.BackColor = Color.Gray
        cmbjenis.BackColor = Color.Gray
        dttanggal.BackColor = Color.Gray
        txtlama.BackColor = Color.Gray
        cbbuku.BackColor = Color.Gray
        cbpena.BackColor = Color.Gray
        cbpensil.BackColor = Color.Gray

        btsimpan.Enabled = False
        bthapus.Enabled = False
        btkeluar.Enabled = False
    End Sub

    Sub aktif()
        txtid.Enabled = True
        txtnama.Enabled = True
        rbmember.Enabled = True
        rbnon.Enabled = True
        cmbjenis.Enabled = True
        dttanggal.Enabled = True
        txtlama.Enabled = True
        cbbuku.Enabled = True
        cbpena.Enabled = True
        cbpensil.Enabled = True

        txtid.BackColor = Color.White
        txtnama.BackColor = Color.White
        rbmember.BackColor = Color.White
        rbnon.BackColor = Color.White
        cmbjenis.BackColor = Color.White
        dttanggal.BackColor = Color.White
        txtlama.BackColor = Color.White
        cbbuku.BackColor = Color.White
        cbpena.BackColor = Color.White
        cbpensil.BackColor = Color.White

        btsimpan.Enabled = True
        bthapus.Enabled = True
        btkeluar.Enabled = True
    End Sub

    Sub bersih()
        txtid.Text = ""
        txtnama.Text = ""
        txtlama.Text = ""
    End Sub

    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from perpus"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "perpus")
        dgview.DataSource = ds.Tables("perpus")
        kon.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        bersih()
        tampil()
    End Sub
    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * from perpus where id='" & txtid.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtnama.Text = cek.Item("nama")
            tipe = cek.Item("tipe")
            If tipe = "member" Then
                rbmember.Checked = True
            Else
                rbnon.Checked = True
            End If
            cmbjenis.Text = cek.Item("jenis")
            dttanggal.Value = cek.Item("tanggal")
            txtlama.Text = cek.Item("lama")
            bonus = cek.Item("bonus")
            If bonus = "buku" Then
                cbbuku.Checked = True
            ElseIf bonus = "pena" Then
                cbpena.Checked = True
            Else
                cbpensil.Checked = True
            End If
        End If
        kon.Close()
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If rbmember.Checked = True Then
            tipe = "Laki-Laki"
        Else
            tipe = "Perempuan"
        End If

        If cbbuku.Checked = True Then
            bonus = "buku"
        ElseIf cbpena.Checked = True Then
            bonus = "pena"
        Else
            bonus = "pensil"
        End If
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into perpus values " &
        " ('" & txtid.Text & "','" & txtnama.Text & "', " &
        " '" & tipe & "','" & cmbjenis.Text & "', " &
        " '" & Format(dttanggal.Value, "yyyy-MM-dd") & "','" & txtlama.Text &
        "','" & bonus & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
        tampil()
        bersih()
        tidakaktif()
        bttambah.Enabled = True
        btkeluar.Enabled = True
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from perpus where id='" & txtid.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
        tidakaktif()
    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        End
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        aktif()
        txtid.Focus()
        bttambah.Enabled = False
    End Sub
End Class
