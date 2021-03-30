Imports MySql.Data.MySqlClient
Public Class pemesanan
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
    Private Sub pemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btndelet.BackColor = Color.Red
        btndelet.ForeColor = Color.White
        cmbkedeputian.Enabled = False
        Try
            Koneksi()
            LokasiDB = "select * from acara"
            CMD = New MySqlCommand(LokasiDB, Conn)
            RD = CMD.ExecuteReader
            While RD.Read
                Dim sName = RD.GetString("nama")
                cmbACARA.Items.Add(sName)
            End While
        Catch ex As Exception

        End Try
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
        cmbSTAFF.Items.Clear()
        cmbSTAFF.Enabled = True
        Try

            Koneksi()
            LokasiDB = "select * from karyawan where divisi = '" & cmbsubdir.Text & "'"
            CMD = New MySqlCommand(LokasiDB, Conn)
            RD = CMD.ExecuteReader
            While RD.Read
                Dim sName = RD.GetString("nama")
                cmbSTAFF.Items.Add(sName)
            End While

            'If RD.HasRows Then
            'cmbStaff.Items.Add(RD.Item("nama"))
            'End If
        Catch ex As Exception

        End Try
        lblTOTALPESAN.Text = 0
        lbltotalKSS.Text = 0
        lbltotalKSL.Text = 0
        lbltotalKMS.Text = 0
        lbltotalKML.Text = 0
        lbltotalKLS.Text = 0
        lbltotalKLL.Text = 0
        lbltotalKXLS.Text = 0
        lbltotalKXLL.Text = 0
        lbljumlahtotal.Text = 0

        lblREGUKEL.Text = 0
        lbltotalkeluarga.Text = 0

        lblkelkidsSshort.Text = 0
        lblkelkidsSlong.Text = 0
        lblkelkidsMshort.Text = 0
        lblkelkidsMlong.Text = 0
        lblkelkidsLshort.Text = 0
        lblkelkidsLlong.Text = 0
        lblkelkidsXLshort.Text = 0
        lblkelkidsXLlong.Text = 0

        lblkeladultSshort.Text = 0
        lblkeladultSlong.Text = 0
        lblkeladultMshort.Text = 0
        lblkeladultMlong.Text = 0
        lblkeladultLshort.Text = 0
        lblkeladultLlong.Text = 0
        lblkeladultXLshort.Text = 0
        lblkeladultXLlong.Text = 0
        lblkeladultXXLshort.Text = 0
        lblkeladultXXLlong.Text = 0

        lblREGUDIV.Text = 0
        lbltotaldivisi.Text = 0

        lblregukidsSshort.Text = 0
        lblregukidsSlong.Text = 0
        lblregukidsMshort.Text = 0
        lblregukidsMlong.Text = 0
        lblregukidsLshort.Text = 0
        lblregukidsLlong.Text = 0
        lblregukidsXLshort.Text = 0
        lblregukidsXLlong.Text = 0

        lblreguadultSshort.Text = 0
        lblreguadultSlong.Text = 0
        lblreguadultMshort.Text = 0
        lblreguadultMlong.Text = 0
        lblreguadultLshort.Text = 0
        lblreguadultLlong.Text = 0
        lblreguadultXLshort.Text = 0
        lblreguadultXLlong.Text = 0
        lblreguadultXXLshort.Text = 0
        lblreguadultXXLlong.Text = 0
        Try

            Call Koneksi()

            LokasiDB = "SELECT *, SUM(jumlah) as total, COUNT(*) as totalpesan, SUM(kss) as KSsmall, SUM(ksl) as KSlong, SUM(kms) as KMsmall, SUM(kml) as KMlong, SUM(kls) as KLsmall, SUM(kll) as KLlong, SUM(kxls) as KXLsmall, SUM(kxll) as KXLlong, SUM(ass) as ASsmall, SUM(asl) as ASlong, SUM(ams) as AMsmall, SUM(aml) as AMlong, SUM(als) as ALsmall, SUM(adll) as ALlong, SUM(axls) as AXLsmall, SUM(axll) as AXLlong, SUM(axxls) as AXXLsmall, SUM(axxll) as AXXLlong FROM pemesanan where divisi = '" & cmbsubdir.Text & "' AND acara = '" & cmbACARA.Text & "'"
            CMD = New MySqlCommand(LokasiDB, Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                lblTOTALPESAN.Text = RD.Item("totalpesan")

                lbltotalKSS.Text = RD.Item("KSsmall")
                lbltotalKSL.Text = RD.Item("KSlong")
                lbltotalKMS.Text = RD.Item("KMsmall")
                lbltotalKML.Text = RD.Item("KMlong")
                lbltotalKLS.Text = RD.Item("KLSmall")
                lbltotalKLL.Text = RD.Item("KLLong")
                lbltotalKXLS.Text = RD.Item("KXLSmall")
                lbltotalKXLL.Text = RD.Item("KXLLong")

                lbltotalASS.Text = RD.Item("ASsmall")
                lbltotalASL.Text = RD.Item("ASlong")
                lbltotalAMS.Text = RD.Item("AMsmall")
                lbltotalAML.Text = RD.Item("AMlong")
                lbltotalALS.Text = RD.Item("ALSmall")
                lbltotalALL.Text = RD.Item("ALLong")
                lbltotalAXLS.Text = RD.Item("AXLSmall")
                lbltotalAXLL.Text = RD.Item("AXLLong")

                lbljumlahtotal.Text = RD.Item("total")

            End If


            Try
                Call Koneksi()
                Dim regu As String = "SELECT *, SUM(jumlah) as jumlahkel, COUNT(*) as Regukeluarga, SUM(kss) as KSsmall, SUM(ksl) as KSlong, SUM(kms) as KMsmall, SUM(kml) as KMlong, SUM(kls) as KLsmall, SUM(kll) as KLlong, SUM(kxls) as KXLsmall, SUM(kxll) as KXLlong, SUM(ass) as ASsmall, SUM(asl) as ASlong, SUM(ams) as AMsmall, SUM(aml) as AMlong, SUM(als) as ALsmall, SUM(adll) as ALlong, SUM(axls) as AXLsmall, SUM(axll) as AXLlong, SUM(axxls) as AXXLsmall, SUM(axxll) as AXXLlong FROM pemesanan where kategori = 'Regu Keluarga' AND divisi = '" & cmbsubdir.Text & "' AND acara = '" & cmbACARA.Text & "'"
                CMD = New MySqlCommand(regu, Conn)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows Then

                    lblREGUKEL.Text = RD.Item("Regukeluarga")
                    lbltotalkeluarga.Text = RD.Item("jumlahkel")

                    lblkelkidsSshort.Text = RD.Item("KSsmall")
                    lblkelkidsSlong.Text = RD.Item("KSlong")
                    lblkelkidsMshort.Text = RD.Item("KMsmall")
                    lblkelkidsMlong.Text = RD.Item("KMlong")
                    lblkelkidsLshort.Text = RD.Item("KLsmall")
                    lblkelkidsLlong.Text = RD.Item("KLlong")
                    lblkelkidsXLshort.Text = RD.Item("KXLsmall")
                    lblkelkidsXLlong.Text = RD.Item("KXLlong")

                    lblkeladultSshort.Text = RD.Item("ASsmall")
                    lblkeladultSlong.Text = RD.Item("ASlong")
                    lblkeladultMshort.Text = RD.Item("AMsmall")
                    lblkeladultMlong.Text = RD.Item("AMlong")
                    lblkeladultLshort.Text = RD.Item("ALsmall")
                    lblkeladultLlong.Text = RD.Item("ALlong")
                    lblkeladultXLshort.Text = RD.Item("AXLsmall")
                    lblkeladultXLlong.Text = RD.Item("AXLlong")
                    lblkeladultXXLshort.Text = RD.Item("AXXLsmall")
                    lblkeladultXXLlong.Text = RD.Item("AXXLlong")
                End If
            Catch ex As Exception

            End Try
            Try
                Call Koneksi()
                Dim regudiv As String = "SELECT *, SUM(jumlah) as jumlahdiv, COUNT(*) as Regudiv, SUM(kss) as KSsmall, SUM(ksl) as KSlong, SUM(kms) as KMsmall, SUM(kml) as KMlong, SUM(kls) as KLsmall, SUM(kll) as KLlong, SUM(kxls) as KXLsmall, SUM(kxll) as KXLlong, SUM(ass) as ASsmall, SUM(asl) as ASlong, SUM(ams) as AMsmall, SUM(aml) as AMlong, SUM(als) as ALsmall, SUM(adll) as ALlong, SUM(axls) as AXLsmall, SUM(axll) as AXLlong, SUM(axxls) as AXXLsmall, SUM(axxll) as AXXLlong FROM pemesanan where kategori = 'Regu Subdir/Bagian' AND divisi = '" & cmbsubdir.Text & "' AND acara = '" & cmbACARA.Text & "'"
                CMD = New MySqlCommand(regudiv, Conn)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows Then

                    lblREGUDIV.Text = RD.Item("Regudiv")
                    lbltotaldivisi.Text = RD.Item("jumlahdiv")

                    lblregukidsSshort.Text = RD.Item("KSsmall")
                    lblregukidsSlong.Text = RD.Item("KSlong")
                    lblregukidsMshort.Text = RD.Item("KMsmall")
                    lblregukidsMlong.Text = RD.Item("KMlong")
                    lblregukidsLshort.Text = RD.Item("KLsmall")
                    lblregukidsLlong.Text = RD.Item("KLlong")
                    lblregukidsXLshort.Text = RD.Item("KXLsmall")
                    lblregukidsXLlong.Text = RD.Item("KXLlong")

                    lblreguadultSshort.Text = RD.Item("ASsmall")
                    lblreguadultSlong.Text = RD.Item("ASlong")
                    lblreguadultMshort.Text = RD.Item("AMsmall")
                    lblreguadultMlong.Text = RD.Item("AMlong")
                    lblreguadultLshort.Text = RD.Item("ALsmall")
                    lblreguadultLlong.Text = RD.Item("ALlong")
                    lblreguadultXLshort.Text = RD.Item("AXLsmall")
                    lblreguadultXLlong.Text = RD.Item("AXLlong")
                    lblreguadultXXLshort.Text = RD.Item("AXXLsmall")
                    lblreguadultXXLlong.Text = RD.Item("AXXLlong")
                End If
            Catch ex As Exception

            End Try


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btndelet.Click
        Dim a As String = MessageBox.Show("Pesan Peringatan 1 : apakah anda ingin menghapus semua data pemesanan?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If a = vbOK Then
            Dim b As String = MessageBox.Show("Pesan Peringatan 2 : apakah anda yakin ingin menghapus semua data pemesanan?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If a = vbOK Then
                Dim c As String = MessageBox.Show("Pesan Peringatan terakhir : apakah anda yakin ingin menghapus semua data pemesanan? tekan ok untuk delete all data!", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
                Try
                    Koneksi()
                    Dim delete As String = "DELETE FROM pemesanan"
                    CMD = New MySqlCommand(delete, Conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data pemesanan berhasil di hapus", MsgBoxStyle.Information, "Information")
                Catch ex As Exception
                    MsgBox("there's an error when deleting data", MsgBoxStyle.Information, "Information")
                End Try
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnother.Click
        lblTOTALPESAN.Text = 0
        lbltotalKSS.Text = 0
        lbltotalKSL.Text = 0
        lbltotalKMS.Text = 0
        lbltotalKML.Text = 0
        lbltotalKLS.Text = 0
        lbltotalKLL.Text = 0
        lbltotalKXLS.Text = 0
        lbltotalKXLL.Text = 0
        lbljumlahtotal.Text = 0

        lblREGUKEL.Text = 0
        lbltotalkeluarga.Text = 0

        lblkelkidsSshort.Text = 0
        lblkelkidsSlong.Text = 0
        lblkelkidsMshort.Text = 0
        lblkelkidsMlong.Text = 0
        lblkelkidsLshort.Text = 0
        lblkelkidsLlong.Text = 0
        lblkelkidsXLshort.Text = 0
        lblkelkidsXLlong.Text = 0

        lblkeladultSshort.Text = 0
        lblkeladultSlong.Text = 0
        lblkeladultMshort.Text = 0
        lblkeladultMlong.Text = 0
        lblkeladultLshort.Text = 0
        lblkeladultLlong.Text = 0
        lblkeladultXLshort.Text = 0
        lblkeladultXLlong.Text = 0
        lblkeladultXXLshort.Text = 0
        lblkeladultXXLlong.Text = 0

        lblREGUDIV.Text = 0
        lbltotaldivisi.Text = 0

        lblregukidsSshort.Text = 0
        lblregukidsSlong.Text = 0
        lblregukidsMshort.Text = 0
        lblregukidsMlong.Text = 0
        lblregukidsLshort.Text = 0
        lblregukidsLlong.Text = 0
        lblregukidsXLshort.Text = 0
        lblregukidsXLlong.Text = 0

        lblreguadultSshort.Text = 0
        lblreguadultSlong.Text = 0
        lblreguadultMshort.Text = 0
        lblreguadultMlong.Text = 0
        lblreguadultLshort.Text = 0
        lblreguadultLlong.Text = 0
        lblreguadultXLshort.Text = 0
        lblreguadultXLlong.Text = 0
        lblreguadultXXLshort.Text = 0
        lblreguadultXXLlong.Text = 0
        Try

            Call Koneksi()

            LokasiDB = "SELECT *, SUM(jumlah) as total, COUNT(*) as totalpesan, SUM(kss) as KSsmall, SUM(ksl) as KSlong, SUM(kms) as KMsmall, SUM(kml) as KMlong, SUM(kls) as KLsmall, SUM(kll) as KLlong, SUM(kxls) as KXLsmall, SUM(kxll) as KXLlong, SUM(ass) as ASsmall, SUM(asl) as ASlong, SUM(ams) as AMsmall, SUM(aml) as AMlong, SUM(als) as ALsmall, SUM(adll) as ALlong, SUM(axls) as AXLsmall, SUM(axll) as AXLlong, SUM(axxls) as AXXLsmall, SUM(axxll) as AXXLlong FROM pemesanan where divisi = '" & btnother.Text & "' AND acara = '" & cmbACARA.Text & "'"
            CMD = New MySqlCommand(LokasiDB, Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                lblTOTALPESAN.Text = RD.Item("totalpesan")
                lbltotalKSS.Text = RD.Item("KSsmall")
                lbltotalKSL.Text = RD.Item("KSlong")
                lbltotalKMS.Text = RD.Item("KMsmall")
                lbltotalKML.Text = RD.Item("KMlong")
                lbltotalKLS.Text = RD.Item("KLSmall")
                lbltotalKLL.Text = RD.Item("KLLong")
                lbltotalKXLS.Text = RD.Item("KXLSmall")
                lbltotalKXLL.Text = RD.Item("KXLLong")
                lbljumlahtotal.Text = RD.Item("total")

            End If


            Try
                Call Koneksi()
                Dim regu As String = "SELECT *, SUM(jumlah) as jumlahkel, COUNT(*) as Regukeluarga, SUM(kss) as KSsmall, SUM(ksl) as KSlong, SUM(kms) as KMsmall, SUM(kml) as KMlong, SUM(kls) as KLsmall, SUM(kll) as KLlong, SUM(kxls) as KXLsmall, SUM(kxll) as KXLlong, SUM(ass) as ASsmall, SUM(asl) as ASlong, SUM(ams) as AMsmall, SUM(aml) as AMlong, SUM(als) as ALsmall, SUM(adll) as ALlong, SUM(axls) as AXLsmall, SUM(axll) as AXLlong, SUM(axxls) as AXXLsmall, SUM(axxll) as AXXLlong FROM pemesanan where kategori = 'Regu Keluarga' AND divisi = '" & btnother.Text & "' AND acara = '" & cmbACARA.Text & "'"
                CMD = New MySqlCommand(regu, Conn)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows Then

                    lblREGUKEL.Text = RD.Item("Regukeluarga")
                    lbltotalkeluarga.Text = RD.Item("jumlahkel")

                    lblkelkidsSshort.Text = RD.Item("KSsmall")
                    lblkelkidsSlong.Text = RD.Item("KSlong")
                    lblkelkidsMshort.Text = RD.Item("KMsmall")
                    lblkelkidsMlong.Text = RD.Item("KMlong")
                    lblkelkidsLshort.Text = RD.Item("KLsmall")
                    lblkelkidsLlong.Text = RD.Item("KLlong")
                    lblkelkidsXLshort.Text = RD.Item("KXLsmall")
                    lblkelkidsXLlong.Text = RD.Item("KXLlong")

                    lblkeladultSshort.Text = RD.Item("ASsmall")
                    lblkeladultSlong.Text = RD.Item("ASlong")
                    lblkeladultMshort.Text = RD.Item("AMsmall")
                    lblkeladultMlong.Text = RD.Item("AMlong")
                    lblkeladultLshort.Text = RD.Item("ALsmall")
                    lblkeladultLlong.Text = RD.Item("ALlong")
                    lblkeladultXLshort.Text = RD.Item("AXLsmall")
                    lblkeladultXLlong.Text = RD.Item("AXLlong")
                    lblkeladultXXLshort.Text = RD.Item("AXXLsmall")
                    lblkeladultXXLlong.Text = RD.Item("AXXLlong")
                End If
            Catch ex As Exception

            End Try
            Try
                Call Koneksi()
                Dim regudiv As String = "SELECT *, SUM(jumlah) as jumlahdiv, COUNT(*) as Regudiv, SUM(kss) as KSsmall, SUM(ksl) as KSlong, SUM(kms) as KMsmall, SUM(kml) as KMlong, SUM(kls) as KLsmall, SUM(kll) as KLlong, SUM(kxls) as KXLsmall, SUM(kxll) as KXLlong, SUM(ass) as ASsmall, SUM(asl) as ASlong, SUM(ams) as AMsmall, SUM(aml) as AMlong, SUM(als) as ALsmall, SUM(adll) as ALlong, SUM(axls) as AXLsmall, SUM(axll) as AXLlong, SUM(axxls) as AXXLsmall, SUM(axxll) as AXXLlong FROM pemesanan where kategori = 'Regu Subdir/Bagian' AND divisi = '" & btnother.Text & "' AND acara = '" & cmbACARA.Text & "'"
                CMD = New MySqlCommand(regudiv, Conn)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows Then

                    lblREGUDIV.Text = RD.Item("Regudiv")
                    lbltotaldivisi.Text = RD.Item("jumlahdiv")

                    lblregukidsSshort.Text = RD.Item("KSsmall")
                    lblregukidsSlong.Text = RD.Item("KSlong")
                    lblregukidsMshort.Text = RD.Item("KMsmall")
                    lblregukidsMlong.Text = RD.Item("KMlong")
                    lblregukidsLshort.Text = RD.Item("KLsmall")
                    lblregukidsLlong.Text = RD.Item("KLlong")
                    lblregukidsXLshort.Text = RD.Item("KXLsmall")
                    lblregukidsXLlong.Text = RD.Item("KXLlong")

                    lblreguadultSshort.Text = RD.Item("ASsmall")
                    lblreguadultSlong.Text = RD.Item("ASlong")
                    lblreguadultMshort.Text = RD.Item("AMsmall")
                    lblreguadultMlong.Text = RD.Item("AMlong")
                    lblreguadultLshort.Text = RD.Item("ALsmall")
                    lblreguadultLlong.Text = RD.Item("ALlong")
                    lblreguadultXLshort.Text = RD.Item("AXLsmall")
                    lblreguadultXLlong.Text = RD.Item("AXLlong")
                    lblreguadultXXLshort.Text = RD.Item("AXXLsmall")
                    lblreguadultXXLlong.Text = RD.Item("AXXLlong")
                End If
            Catch ex As Exception

            End Try


        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbACARA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbACARA.SelectedIndexChanged
        cmbkedeputian.Enabled = True
    End Sub

    Private Sub cmbSTAFF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSTAFF.SelectedIndexChanged
        Try
            lblpribadiKSS.Text = 0
            lblpribadiKSL.Text = 0
            lblpribadiKMS.Text = 0
            lblpribadiKML.Text = 0
            lblpribadiKLS.Text = 0
            lblpribadiKLL.Text = 0
            lblpribadiKXLS.Text = 0
            lblpribadiKXLL.Text = 0

            lblpribadiASS.Text = 0
            lblpribadiASL.Text = 0
            lblpribadiAMS.Text = 0
            lblpribadiAML.Text = 0
            lblpribadiALS.Text = 0
            lblpribadiALL.Text = 0
            lblpribadiAXLS.Text = 0
            lblpribadiAXLL.Text = 0

            lbljumlahpribadi.Text = 0
            chkSTATUS.Checked = False
            Koneksi()

            Dim status As String
            LokasiDB = "SELECT *, SUM(jumlah) as total, COUNT(*) as totalpesan, SUM(kss) as KSsmall, SUM(ksl) as KSlong, SUM(kms) as KMsmall, SUM(kml) as KMlong, SUM(kls) as KLsmall, SUM(kll) as KLlong, SUM(kxls) as KXLsmall, SUM(kxll) as KXLlong, SUM(ass) as ASsmall, SUM(asl) as ASlong, SUM(ams) as AMsmall, SUM(aml) as AMlong, SUM(als) as ALsmall, SUM(adll) as ALlong, SUM(axls) as AXLsmall, SUM(axll) as AXLlong, SUM(axxls) as AXXLsmall, SUM(axxll) as AXXLlong FROM pemesanan where divisi = '" & cmbsubdir.Text & "' AND acara = '" & cmbACARA.Text & "' AND nama = '" & cmbSTAFF.Text & "'"
            CMD = New MySqlCommand(LokasiDB, Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                status = RD.Item("status")
                If status = "sudah" Then
                    chkSTATUS.Checked = True
                Else : status = "belum"
                    chkSTATUS.Checked = False
                End If
                lblpribadiKSS.Text = RD.Item("KSsmall")
                lblpribadiKSL.Text = RD.Item("KSlong")
                lblpribadiKMS.Text = RD.Item("KMsmall")
                lblpribadiKML.Text = RD.Item("KMlong")
                lblpribadiKLS.Text = RD.Item("KLSmall")
                lblpribadiKLL.Text = RD.Item("KLLong")
                lblpribadiKXLS.Text = RD.Item("KXLSmall")
                lblpribadiKXLL.Text = RD.Item("KXLLong")

                lblpribadiASS.Text = RD.Item("ASsmall")
                lblpribadiASL.Text = RD.Item("ASlong")
                lblpribadiAMS.Text = RD.Item("AMsmall")
                lblpribadiAML.Text = RD.Item("AMlong")
                lblpribadiALS.Text = RD.Item("ALSmall")
                lblpribadiALL.Text = RD.Item("ALLong")
                lblpribadiAXLS.Text = RD.Item("AXLSmall")
                lblpribadiAXLL.Text = RD.Item("AXLLong")

                lbljumlahpribadi.Text = RD.Item("total")
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub chkSTATUS_CheckedChanged(sender As Object, e As EventArgs) Handles chkSTATUS.CheckedChanged
        If chkSTATUS.Checked = True Then
            Try
                Call Koneksi()
                Dim update As String = "update pemesanan set status='sudah' where nama = '" & cmbSTAFF.Text & "'"
                CMD = New MySqlCommand(update, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Melakukan Pengecekan Status Pengambilan", MsgBoxStyle.Information, "Information")

            Catch ex As Exception

            End Try
        ElseIf chkSTATUS.Checked = False Then
            Try
                Call Koneksi()
                Dim update As String = "update pemesanan set status='belum' where nama = '" & cmbSTAFF.Text & "'"
                CMD = New MySqlCommand(update, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Melakukan Pengecekan Status Pengambilan", MsgBoxStyle.Information, "Information")

            Catch ex As Exception

            End Try
        End If
    End Sub
End Class