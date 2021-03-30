Imports MySql.Data.MySqlClient
Public Class add
    Dim Conn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader
    Dim LokasiDB As String
    Dim table As DataTable
    Sub Koneksi()
        Dim str As String

        str = "Server=localhost; user id=root; password=; database=bps"

        Conn = New MySqlConnection(str)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        MainMenu.Show()
    End Sub




    Private Sub cmbkedeputian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkedeputian.SelectedIndexChanged
        Dim pil As String
        pil = cmbkedeputian.Items(cmbkedeputian.SelectedIndex).ToString
        cmbdirektorat.Enabled = True
        cmbsubdir.Enabled = False
        Select Case pil
            Case "Sekretariat Utama"
                cmbdirektorat.Items.Clear()
                cmbdirektorat.Items.Add("Karo Bina Program")
                cmbdirektorat.Items.Add("Karo Keuangan")
                cmbdirektorat.Items.Add("Karo Kepegawaian")
                cmbdirektorat.Items.Add("Karo Humas dan Hukum")
                cmbdirektorat.Items.Add("Karo Umum")
                cmbdirektorat.Items.Add("Karo Pusdiklat")
                cmbdirektorat.Items.Add("Ketua STIS")
            Case "Bidang Metodologi dan Informasi Statistik"
                cmbdirektorat.Items.Clear()
                cmbdirektorat.Items.Add("Dir. Pengembangan Metodologi Desain Sensus dan Survei")
                cmbdirektorat.Items.Add("Dir. Diseminasi Statistik")
                cmbdirektorat.Items.Add("Dir. Sistem Informasi Statistik")
            Case "Bidang Stat Sosial"
                cmbdirektorat.Items.Clear()
                cmbdirektorat.Items.Add("Dir. Stat Kepend & Ketenagakerjaan")
                cmbdirektorat.Items.Add("Dir. Stat Kesejahteraan Rakyat")
                cmbdirektorat.Items.Add("Dir. Stat Ketahanan Sosial")
            Case "Bidang Stat Produksi"
                cmbdirektorat.Items.Clear()
                cmbdirektorat.Items.Add("Dir. Stat Tanaman Pangan & Perkebunan")
                cmbdirektorat.Items.Add("Dir. Stat Peternakan, Perikanan & Kehutanan")
                cmbdirektorat.Items.Add("Dir. Stat Industri")
            Case "Bidang Stat Distribusi dan Jasa"
                cmbdirektorat.Items.Clear()
                cmbdirektorat.Items.Add("Dir. Stat Distribusi")
                cmbdirektorat.Items.Add("Dir. Stat Harga")
                cmbdirektorat.Items.Add("Dir. Stat Keuangan, TI dan Pariwisata")
            Case "Bidang Neraca dan Analisis Statistik"
                cmbdirektorat.Items.Clear()
                cmbdirektorat.Items.Add("Dir. Neraca Produksi")
                cmbdirektorat.Items.Add("Dir. Neraca Pengeluaran")
                cmbdirektorat.Items.Add("Dir. Analisis & Pengembangan Stat")
            Case "Inspektur Utama"
                cmbdirektorat.Items.Clear()
                cmbdirektorat.Items.Add("Inspektur Wilayah 1")
                cmbdirektorat.Items.Add("Inspektur Wilayah 2")
                cmbdirektorat.Items.Add("Inspektur Wilayah 3")
                cmbdirektorat.Items.Add("Administrasi")
        End Select
    End Sub

    Private Sub cmbdirektorat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdirektorat.SelectedIndexChanged
        Dim pil As String
        pil = cmbdirektorat.Items(cmbdirektorat.SelectedIndex).ToString
        cmbsubdir.Enabled = True
        Select Case pil
            Case "Karo Bina Program"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Penyusunan Rencana")
                cmbsubdir.Items.Add("Penyusunan Anggaran")
                cmbsubdir.Items.Add("Monitoring & Evaluasi")
                cmbsubdir.Items.Add("Transformasi Statistik")
            Case "Karo Keuangan"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Administrasi Keuangan")
                cmbsubdir.Items.Add("Perbendaharaan")
                cmbsubdir.Items.Add("Verifikasi")
                cmbsubdir.Items.Add("Akuntansi")
            Case "Karo Kepegawaian"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Administrasi Kepegawaian")
                cmbsubdir.Items.Add("Mutasi Pegawai")
                cmbsubdir.Items.Add("Kesejahteraan & Pengembangan Pegawai")
                cmbsubdir.Items.Add("Jabatan Fungsional")
            Case "Karo Humas dan Hukum"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Kerjasama, Protokol & Penyiapan Materi Pimpinan")
                cmbsubdir.Items.Add("Hubungan Masyarakat")
                cmbsubdir.Items.Add("Hukum & Organisasi")
            Case "Karo Umum"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Rumah Tangga")
                cmbsubdir.Items.Add("Penyimpanan & Penghapusan")
                cmbsubdir.Items.Add("Pengadaan Barang Jasa")
                cmbsubdir.Items.Add("Pencetakan, Arsip & Ekspedisi")
            Case "Karo Pusdiklat"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Tata Usaha")
                cmbsubdir.Items.Add("Diklat Prajabatan & Kepemimpinan")
                cmbsubdir.Items.Add("Diklat Teknis & Fungsional")
                cmbsubdir.Items.Add("Ruang Widyaiswara")
            Case "Ketua STIS"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Adm. Akademik & Kemahasiswaan")
                cmbsubdir.Items.Add("Adm. Umum")
                cmbsubdir.Items.Add("Pembantu Ketua STIS")
                cmbsubdir.Items.Add("Ketua Jurusan")

            Case "Dir. Pengembangan Metodologi Desain Sensus dan Survei"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Pengembangan Desain Sensus & Survei")
                cmbsubdir.Items.Add("Pengembangan Standardisasi & Klasifikasi Stat")
                cmbsubdir.Items.Add("Pengembangan Kerangka Sampel")
                cmbsubdir.Items.Add("Pengembangan Pemetaan Statistik")
            Case "Dir. Diseminasi Statistik"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Rujukan Statistik")
                cmbsubdir.Items.Add("Publikasi dan Kompilasi Statistik")
                cmbsubdir.Items.Add("Layanan dan Promosi Statistik")
                cmbsubdir.Items.Add("Perpustakaan dan Dokumentasi Statistik")
            Case "Dir. Sistem Informasi Statistik"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Integrasi Pengolahan Data")
                cmbsubdir.Items.Add("Jaringan Komunikasi Data")
                cmbsubdir.Items.Add("Pengembangan Basis Data")
                cmbsubdir.Items.Add("Pengelolaan Teknologi Informasi")

            Case "Dir. Stat Kepend & Ketenagakerjaan"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Statistik Demografi")
                cmbsubdir.Items.Add("Statistik Ketenagakerjaan")
                cmbsubdir.Items.Add("Statistik Upah & Pendapatan")
                cmbsubdir.Items.Add("Statistik Mobilitas Pend & Tenaga Kerja")
            Case "Dir. Stat Kesejahteraan Rakyat"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Statistik Rumah Tangga")
                cmbsubdir.Items.Add("Statistik Pendidikan & Kes.Sosial")
                cmbsubdir.Items.Add("Statistik Kesehatan & Perumahan")
            Case "Dir. Stat Ketahanan Sosial"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Statistik Ketahanan Wilayah")
                cmbsubdir.Items.Add("Statistik Lingkungan Hidup")
                cmbsubdir.Items.Add("Statistik Politik & Keamanan")
                cmbsubdir.Items.Add("Statistik Kerawanan Sosial")

            Case "Dir. Stat Tanaman Pangan & Perkebunan"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Statistik Tanaman Pangan")
                cmbsubdir.Items.Add("Statistik Hortikultura")
                cmbsubdir.Items.Add("Statistik Tanaman Perkebunan")
            Case "Dir. Stat Peternakan, Perikanan & Kehutanan"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Statistik Peternakan")
                cmbsubdir.Items.Add("Statistik Perikanan")
                cmbsubdir.Items.Add("Statistik Kehutanan")
            Case "Dir. Stat Industri"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Statistik Industri Besar & Sedang")
                cmbsubdir.Items.Add("Statistik Industri Kecil & Rumah Tangga")
                cmbsubdir.Items.Add("Statistik Pertambangan & Energi")
                cmbsubdir.Items.Add("Statistik Konstruksi")

            Case "Dir. Stat Distribusi"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Statistik Ekspor")
                cmbsubdir.Items.Add("Statistik Impor")
                cmbsubdir.Items.Add("Statistik Perdagangan Dalam Negeri")
                cmbsubdir.Items.Add("Statistik Transportasi")
            Case "Dir. Stat Harga"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Statistik Harga Produsen")
                cmbsubdir.Items.Add("Statistik Harga Perdagangan Besar")
                cmbsubdir.Items.Add("Statistik Harga Konsumen")
                cmbsubdir.Items.Add("Statistik Harga Pedesaan")
            Case "Dir. Stat Keuangan, TI dan Pariwisata"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Statistik Keuangan")
                cmbsubdir.Items.Add("Statistik Komunikasi & TI")
                cmbsubdir.Items.Add("Statistik Pariwisata")

            Case "Dir. Neraca Produksi"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Neraca Barang")
                cmbsubdir.Items.Add("Neraca Jasa")
                cmbsubdir.Items.Add("Konsolidasi Neraca Prod. Nasional")
                cmbsubdir.Items.Add("Konsolidasi Neraca Prod. Regional")
            Case "Dir. Neraca Pengeluaran"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Neraca Rumah Tangga & Institusi Nirlaba")
                cmbsubdir.Items.Add("Neraca Pemerintah & Badan Usaha")
                cmbsubdir.Items.Add("Neraca Modal & Luar Negeri")
                cmbsubdir.Items.Add("Konsolidasi Neraca Pengeluaran")
            Case "Dir. Analisis & Pengembangan Stat"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Analisis Statistik")
                cmbsubdir.Items.Add("Konsistensi Statistik")
                cmbsubdir.Items.Add("Indikator Statistik")
                cmbsubdir.Items.Add("Pengembangan Model Statistik Ekonomi")

            Case "Inspektur Wilayah 1"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Inspektur Wilayah 1")
            Case "Inspektur Wilayah 2"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Inspektur Wilayah 2")
            Case "Inspektur Wilayah 3"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Inspektur Wilayah 3")
            Case "Administrasi"
                cmbsubdir.Items.Clear()
                cmbsubdir.Items.Add("Administrasi")

        End Select
    End Sub

    Private Sub cmbsubdir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsubdir.SelectedIndexChanged
        panelAccount.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
        MainMenu.Show()

    End Sub

    Private Sub add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpACARA.CustomFormat = " yyyy/MM/dd"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Koneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Call Koneksi()
            Dim simpan As String = "INSERT INTO karyawan VALUES ('" & txtNIK.Text & "','" & txtNAMA.Text & "','" & txtEMAIL.Text & "','" & cmbsubdir.Text & "')"
            CMD = New MySqlCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            txtNIK.Clear()
            txtEMAIL.Clear()
            txtNAMA.Clear()

        Catch ex As Exception
            MessageBox.Show("Tidak Dapat Menambahkan Data, Periksa kembali Inputan Anda!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub btnACARA_Click(sender As Object, e As EventArgs) Handles btnACARA.Click
        Try
            Call Koneksi()
            Dim simpan As String = "INSERT INTO acara VALUES ('','" & txtNAMAACARA.Text & "','" & dtpACARA.Text & "','" & txtDESCACARA.Text & "')"
            CMD = New MySqlCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            txtNAMAACARA.Clear()
            txtDESCACARA.Clear()

        Catch ex As Exception
            MessageBox.Show("Tidak Dapat Menambahkan Data, Periksa kembali Inputan Anda!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class