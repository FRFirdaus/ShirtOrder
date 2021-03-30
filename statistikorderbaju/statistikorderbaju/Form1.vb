Imports MySql.Data.MySqlClient
Public Class frmPESAN
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
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStaff.SelectedIndexChanged
        tmrSTAFF.Enabled = False
        lblStaff.Hide()
        grpKATEGORI.Enabled = True
        lblPEMESAN.Text = cmbStaff.Text
    End Sub

    Private Sub lblsdir_Click(sender As Object, e As EventArgs) Handles lblsdir.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpPESAN.Enabled = False
        cmbdirektorat.Enabled = False
        cmbsubdir.Enabled = False
        cmbStaff.Enabled = False
        lbldir.Hide()
        lblsdir.Hide()
        lblStaff.Hide()
        deputi.Enabled = True
        btnPesan.Enabled = False
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkedeputian.SelectedIndexChanged
        Dim pil As String
        pil = cmbkedeputian.Items(cmbkedeputian.SelectedIndex).ToString
        cmbdirektorat.Enabled = True
        lblDEPUTI.Hide()
        deputi.Enabled = False
        lbldir.Show()
        direktorat.Enabled = True
        cmbsubdir.Enabled = False
        cmbStaff.Enabled = False
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
        cmbStaff.Enabled = False
        lbldir.Hide()
        direktorat.Enabled = False
        lblsdir.Show()
        subdir.Enabled = True
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

    Private Sub deputi_Tick(sender As Object, e As EventArgs) Handles deputi.Tick
        Select Case lblDEPUTI.Visible
            Case True
                lblDEPUTI.Visible = False
            Case False
                lblDEPUTI.Visible = True

        End Select
    End Sub

    Private Sub direktorat_Tick(sender As Object, e As EventArgs) Handles direktorat.Tick
        Select Case lbldir.Visible
            Case True
                lbldir.Visible = False
            Case False
                lbldir.Visible = True

        End Select
    End Sub

    Private Sub subdir_Tick(sender As Object, e As EventArgs) Handles subdir.Tick
        Select Case lblsdir.Visible
            Case True
                lblsdir.Visible = False
            Case False
                lblsdir.Visible = True
        End Select
    End Sub

    Private Sub nama_Tick(sender As Object, e As EventArgs) Handles tmrSTAFF.Tick
        Select Case lblStaff.Visible
            Case True
                lblStaff.Visible = False
            Case False
                lblStaff.Visible = True
        End Select
    End Sub

    Private Sub cmbsubdir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsubdir.SelectedIndexChanged
        cmbStaff.Items.Clear()
        lblsdir.Hide()
        subdir.Enabled = False
        lblStaff.Show()
        tmrSTAFF.Enabled = True
        cmbStaff.Enabled = True
        Try

            Koneksi()
            LokasiDB = "select * from karyawan where divisi = '" & cmbsubdir.Text & "'"
            CMD = New MySqlCommand(LokasiDB, Conn)
            RD = CMD.ExecuteReader
            While RD.Read
                Dim sName = RD.GetString("nama")
                cmbStaff.Items.Add(sName)
            End While

            'If RD.HasRows Then
            'cmbStaff.Items.Add(RD.Item("nama"))
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click, Button28.Click
        grpOTHER.Left = 273
        Button29.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Skid.Text = Skid.Text - 1
        If Skid.Text < 0 Then
            Skid.Text = 0
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Mkid.Text = Mkid.Text - 1
        If Mkid.Text < 0 Then
            Mkid.Text = 0
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Lkid.Text = Lkid.Text - 1
        If Lkid.Text < 0 Then
            Lkid.Text = 0
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        XLkid.Text = XLkid.Text - 1
        If XLkid.Text < 0 Then
            XLkid.Text = 0
        End If
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Skid.Text = Skid.Text + 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Mkid.Text = Mkid.Text + 1
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Lkid.Text = Lkid.Text + 1
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        XLkid.Text = XLkid.Text + 1
    End Sub



    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Sadult.Text = Sadult.Text - 1
        If Sadult.Text < 0 Then
            Sadult.Text = 0
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Madult.Text = Madult.Text - 1
        If Madult.Text < 0 Then
            Madult.Text = 0
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Ladult.Text = Ladult.Text - 1
        If Ladult.Text < 0 Then
            Ladult.Text = 0
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        XLadult.Text = XLadult.Text - 1
        If XLadult.Text < 0 Then
            XLadult.Text = 0
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        XXLadult.Text = XXLadult.Text - 1
        If XXLadult.Text < 0 Then
            XXLadult.Text = 0
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Sadult.Text = Sadult.Text + 1
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Madult.Text = Madult.Text + 1
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Ladult.Text = Ladult.Text + 1
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        XLadult.Text = XLadult.Text + 1
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        XXLadult.Text = XXLadult.Text + 1
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        Dim a As String = MessageBox.Show("Apakah Anda Yakin Data Pemesanan Sudah Benar?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If a = vbOK Then
            If cmbACARA.Text = "" Then
                MessageBox.Show("Whoops!, Silahkan Pilih Acara!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If lblQUOTA.Text < lbljumlahpesan.Text Then
                    MessageBox.Show("Whoops!, jumlah pemesanan anda melebihi kuota!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If lblPEMESAN.Text = cmbStaff.Text Then
                        Try
                            Call Koneksi()
                            Dim simpan As String = "INSERT INTO pemesanan VALUES ('""','" & cmbStaff.Text & "','" & cmbsubdir.Text & "','" & cmbACARA.Text & "','" & cmbKategori.Text & "','" & lbljumlahpesan.Text & "','" & lblSSKID.Text & "','" & lblSLKID.Text & "','" & lblMSKID.Text & "','" & lblMLKID.Text & "','" & lblLSKID.Text & "','" & lblLLKID.Text & "','" & lblXLSKID.Text & "','" & lblXLLKID.Text & "','" & lblSSADULT.Text & "','" & lblSLADULT.Text & "','" & lblMSADULT.Text & "','" & lblMLADULT.Text & "','" & lblLSADULT.Text & "','" & lblLLADULT.Text & "','" & lblXLSADULT.Text & "','" & lblXLLADULT.Text & "','" & lblXXLSADULT.Text & "','" & lblXXLLADULT.Text & "','belum')"
                            CMD = New MySqlCommand(simpan, Conn)
                            CMD.ExecuteNonQuery()
                            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")

                        Catch ex As Exception
                            MessageBox.Show("Tidak Dapat Menambahkan Data, Periksa kembali Inputan Anda!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    ElseIf lblPEMESAN.Text = txtOTHER.Text Then
                        Try
                            Call Koneksi()
                            Dim simpan As String = "INSERT INTO pemesanan VALUES ('""','" & lblPEMESAN.Text & "','other','" & cmbKategori.Text & "','" & lbljumlahpesan.Text & "','" & lblSSKID.Text & "','" & lblSLKID.Text & "','" & lblMSKID.Text & "','" & lblMLKID.Text & "','" & lblLSKID.Text & "','" & lblLLKID.Text & "','" & lblXLSKID.Text & "','" & lblXLLKID.Text & "','" & lblSSADULT.Text & "','" & lblSLADULT.Text & "','" & lblMSADULT.Text & "','" & lblMLADULT.Text & "','" & lblLSADULT.Text & "','" & lblLLADULT.Text & "','" & lblXLSADULT.Text & "','" & lblXLLADULT.Text & "','" & lblXXLSADULT.Text & "','" & lblXXLLADULT.Text & "','belum')"
                            CMD = New MySqlCommand(simpan, Conn)
                            CMD.ExecuteNonQuery()
                            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")

                        Catch ex As Exception
                            MessageBox.Show("Tidak Dapat Menambahkan Data, Periksa kembali Inputan Anda!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub other_Tick(sender As Object, e As EventArgs) Handles other.Tick
        grpOTHER.Left = grpOTHER.Left - 4
        If grpOTHER.Left = 21 Then
            other.Enabled = False
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        other.Enabled = True
        Button29.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        grpKATEGORI.Enabled = True
        lblPEMESAN.Text = txtOTHER.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged
        grpPESAN.Enabled = True
        btnPesan.Enabled = True
        Dim pil As String
        pil = cmbKategori.Items(cmbKategori.SelectedIndex).ToString
        Select Case pil
            Case "Regu Subdir/Bagian"
                lblQUOTA.Text = 7
                If lbljumlahpesan.Text > lblQUOTA.Text Then
                    MessageBox.Show("Pemesanan Anda Melebihi Batas Pemesanan!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lbljumlahpesan.ForeColor = Color.Red
                Else
                    lbljumlahpesan.ForeColor = Color.Black
                End If
            Case "Regu Keluarga"
                lblQUOTA.Text = 5
                If lbljumlahpesan.Text > lblQUOTA.Text Then
                    MessageBox.Show("Pemesanan Anda Melebihi Batas Pemesanan!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lbljumlahpesan.ForeColor = Color.Red
                Else
                    lbljumlahpesan.ForeColor = Color.Black
                End If
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Skid.Text = 0
        Mkid.Text = 0
        Lkid.Text = 0
        XLkid.Text = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Sadult.Text = 0
        Madult.Text = 0
        Ladult.Text = 0
        XLadult.Text = 0
        XXLadult.Text = 0
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles chSS.CheckedChanged
        If chSS.Checked = True Then
            chSL.Checked = False
        End If

    End Sub

    Private Sub chSL_CheckedChanged(sender As Object, e As EventArgs) Handles chSL.CheckedChanged
        If chSL.Checked = True Then
            chSS.Checked = False
        End If

    End Sub

    Private Sub chMS_CheckedChanged(sender As Object, e As EventArgs) Handles chMS.CheckedChanged
        If chMS.Checked = True Then
            chML.Checked = False
        End If
    End Sub

    Private Sub chML_CheckedChanged(sender As Object, e As EventArgs) Handles chML.CheckedChanged
        If chML.Checked = True Then
            chMS.Checked = False
        End If
    End Sub

    Private Sub chLS_CheckedChanged(sender As Object, e As EventArgs) Handles chLS.CheckedChanged
        If chLS.Checked = True Then
            chLL.Checked = False
        End If
    End Sub

    Private Sub chLL_CheckedChanged(sender As Object, e As EventArgs) Handles chLL.CheckedChanged
        If chLL.Checked = True Then
            chLS.Checked = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pil As String
        pil = cmbKategori.Items(cmbKategori.SelectedIndex).ToString
        If pil = "Regu Subdir/Bagian" Then
            If chSS.Checked = True Then
                lblSSKID.Text = lblSSKID.Text + Int(Skid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Skid.Text)
            ElseIf chSL.Checked = True Then
                lblSLKID.Text = lblSLKID.Text + Int(Skid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Skid.Text)
            End If

            If chML.Checked = True Then
                lblMLKID.Text = lblMLKID.Text + Int(Mkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Mkid.Text)
            ElseIf chMS.Checked = True Then
                lblMSKID.Text = lblMSKID.Text + Int(Mkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Mkid.Text)
            End If

            If chLL.Checked = True Then
                lblLLKID.Text = lblLLKID.Text + Int(Lkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Lkid.Text)
            ElseIf chLS.Checked = True Then
                lblLSKID.Text = lblLSKID.Text + Int(Lkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Lkid.Text)
            End If

            If chXLL.Checked = True Then
                lblXLLKID.Text = lblXLLKID.Text + Int(XLkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XLkid.Text)
            ElseIf chXLS.Checked = True Then
                lblXLSKID.Text = lblXLSKID.Text + Int(XLkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XLkid.Text)
            End If

            If lbljumlahpesan.Text > lblQUOTA.Text Then
                MessageBox.Show("Pemesanan Anda Melebihi Batas Pemesanan!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lbljumlahpesan.ForeColor = Color.Red
            Else
                lbljumlahpesan.ForeColor = Color.Black
            End If


        ElseIf pil = "Regu Keluarga" Then
            If chSS.Checked = True Then
                lblSSKID.Text = lblSSKID.Text + Int(Skid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Skid.Text)
            ElseIf chSL.Checked = True Then
                lblSLKID.Text = lblSLKID.Text + Int(Skid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Skid.Text)
            End If

            If chML.Checked = True Then
                lblMLKID.Text = lblMLKID.Text + Int(Mkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Mkid.Text)
            ElseIf chMS.Checked = True Then
                lblMSKID.Text = lblMSKID.Text + Int(Mkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Mkid.Text)
            End If

            If chLL.Checked = True Then
                lblLLKID.Text = lblLLKID.Text + Int(Lkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Lkid.Text)
            ElseIf chLS.Checked = True Then
                lblLSKID.Text = lblLSKID.Text + Int(Lkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Lkid.Text)
            End If

            If chXLL.Checked = True Then
                lblXLLKID.Text = lblXLLKID.Text + Int(XLkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XLkid.Text)
            ElseIf chXLS.Checked = True Then
                lblXLSKID.Text = lblXLSKID.Text + Int(XLkid.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XLkid.Text)
            End If

        End If

        If lbljumlahpesan.Text > lblQUOTA.Text Then
            MessageBox.Show("Pemesanan Anda Melebihi Batas Pemesanan!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbljumlahpesan.ForeColor = Color.Red
        ElseIf lbljumlahpesan.Text <= lblQUOTA.Text Then
            lbljumlahpesan.ForeColor = Color.Black
        End If

    End Sub

    Private Sub chSSADULT_CheckedChanged(sender As Object, e As EventArgs) Handles chSSADULT.CheckedChanged
        If chSSADULT.Checked = True Then
            chSLADULT.Checked = False
        End If
    End Sub

    Private Sub chSLADULT_CheckedChanged(sender As Object, e As EventArgs) Handles chSLADULT.CheckedChanged
        If chSLADULT.Checked = True Then
            chSSADULT.Checked = False
        End If
    End Sub

    Private Sub chMSADULT_CheckedChanged(sender As Object, e As EventArgs) Handles chMSADULT.CheckedChanged
        If chMSADULT.Checked = True Then
            chMLADULT.Checked = False
        End If
    End Sub

    Private Sub chMLADULT_CheckedChanged(sender As Object, e As EventArgs) Handles chMLADULT.CheckedChanged
        If chMLADULT.Checked = True Then
            chMSADULT.Checked = False
        End If
    End Sub

    Private Sub chLSADULT_CheckedChanged(sender As Object, e As EventArgs) Handles chLSADULT.CheckedChanged
        If chLSADULT.Checked = True Then
            chLLADULT.Checked = False
        End If
    End Sub

    Private Sub chLLADULT_CheckedChanged(sender As Object, e As EventArgs) Handles chLLADULT.CheckedChanged
        If chLLADULT.Checked = True Then
            chLSADULT.Checked = False
        End If
    End Sub

    Private Sub chXLSADULT_CheckedChanged(sender As Object, e As EventArgs) Handles chXLSADULT.CheckedChanged
        If chXLSADULT.Checked = True Then
            chXLLADULT.Checked = False
        End If
    End Sub

    Private Sub chXLLADULT_CheckedChanged(sender As Object, e As EventArgs) Handles chXLLADULT.CheckedChanged
        If chXLLADULT.Checked = True Then
            chXLSADULT.Checked = False
        End If
    End Sub

    Private Sub chXXLSADULT_CheckedChanged(sender As Object, e As EventArgs) Handles chXXLSADULT.CheckedChanged
        If chXXLSADULT.Checked = True Then
            chXXLLADULT.Checked = False
        End If
    End Sub

    Private Sub chXXLLADULT_CheckedChanged(sender As Object, e As EventArgs) Handles chXXLLADULT.CheckedChanged
        If chXXLLADULT.Checked = True Then
            chXXLSADULT.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pil As String
        pil = cmbKategori.Items(cmbKategori.SelectedIndex).ToString
        If pil = "Regu Subdir/Bagian" Then
            If chSSADULT.Checked = True Then
                lblSSADULT.Text = lblSSADULT.Text + Int(Sadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Sadult.Text)
            ElseIf chSLADULT.Checked = True Then
                lblSLADULT.Text = lblSLADULT.Text + Int(Sadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Sadult.Text)
            End If

            If chMLADULT.Checked = True Then
                lblMLADULT.Text = lblMLADULT.Text + Int(Madult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Madult.Text)
            ElseIf chMSADULT.Checked = True Then
                lblMSADULT.Text = lblMSADULT.Text + Int(Madult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Madult.Text)
            End If

            If chLLADULT.Checked = True Then
                lblLLADULT.Text = lblLLADULT.Text + Int(Ladult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Ladult.Text)
            ElseIf chLSADULT.Checked = True Then
                lblLSADULT.Text = lblLSADULT.Text + Int(Ladult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Ladult.Text)
            End If

            If chXLLADULT.Checked = True Then
                lblXLLADULT.Text = lblXLLADULT.Text + Int(XLadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XLadult.Text)
            ElseIf chXLSADULT.Checked = True Then
                lblXLSADULT.Text = lblXLSADULT.Text + Int(XLadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XLadult.Text)
            End If

            If chXXLLADULT.Checked = True Then
                lblXXLLADULT.Text = lblXXLLADULT.Text + Int(XXLadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XXLadult.Text)
            ElseIf chXXLSADULT.Checked = True Then
                lblXXLSADULT.Text = lblXXLSADULT.Text + Int(XXLadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XXLadult.Text)
            End If

            If lbljumlahpesan.Text > lblQUOTA.Text Then
                MessageBox.Show("Pemesanan Anda Melebihi Batas Pemesanan!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lbljumlahpesan.ForeColor = Color.Red
            Else
                lbljumlahpesan.ForeColor = Color.Black
            End If
        ElseIf pil = "Regu Keluarga" Then
            If chSSADULT.Checked = True Then
                lblSSADULT.Text = lblSSADULT.Text + Int(Sadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Sadult.Text)
            ElseIf chSLADULT.Checked = True Then
                lblSLADULT.Text = lblSLADULT.Text + Int(Sadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Sadult.Text)
            End If

            If chMLADULT.Checked = True Then
                lblMLADULT.Text = lblMLADULT.Text + Int(Madult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Madult.Text)
            ElseIf chMSADULT.Checked = True Then
                lblMSADULT.Text = lblMSADULT.Text + Int(Madult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Madult.Text)
            End If

            If chLLADULT.Checked = True Then
                lblLLADULT.Text = lblLLADULT.Text + Int(Ladult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Ladult.Text)
            ElseIf chLSADULT.Checked = True Then
                lblLSADULT.Text = lblLSADULT.Text + Int(Ladult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(Ladult.Text)
            End If

            If chXLLADULT.Checked = True Then
                lblXLLADULT.Text = lblXLLADULT.Text + Int(XLadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XLadult.Text)
            ElseIf chXLSADULT.Checked = True Then
                lblXLSADULT.Text = lblXLSADULT.Text + Int(XLadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XLadult.Text)
            End If

            If chXXLLADULT.Checked = True Then
                lblXXLLADULT.Text = lblXXLLADULT.Text + Int(XXLadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XXLadult.Text)
            ElseIf chXXLSADULT.Checked = True Then
                lblXXLSADULT.Text = lblXXLSADULT.Text + Int(XXLadult.Text)
                lbljumlahpesan.Text = lbljumlahpesan.Text + Int(XXLadult.Text)
            End If

            If lbljumlahpesan.Text > lblQUOTA.Text Then
                MessageBox.Show("Pemesanan Anda Melebihi Batas Pemesanan!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lbljumlahpesan.ForeColor = Color.Red
            Else
                lbljumlahpesan.ForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim pil As String = MessageBox.Show("Apakah Anda Yakin ingin Menghapus Data Pemesanan?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If pil = vbOK Then
            lblSSKID.Text = 0
            lblMSKID.Text = 0
            lblLSKID.Text = 0
            lblXLSKID.Text = 0
            lblSLKID.Text = 0
            lblMLKID.Text = 0
            lblLLKID.Text = 0
            lblXLSKID.Text = 0
            lblXLLKID.Text = 0
            lblSSADULT.Text = 0
            lblMSADULT.Text = 0
            lblLSADULT.Text = 0
            lblXLSADULT.Text = 0
            lblXXLSADULT.Text = 0
            lblSLADULT.Text = 0
            lblMLADULT.Text = 0
            lblLLADULT.Text = 0
            lblXLLADULT.Text = 0
            lblXXLLADULT.Text = 0

            lbljumlahpesan.Text = 0
            lbljumlahpesan.ForeColor = Color.Black
        End If


    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub chXLS_CheckedChanged_1(sender As Object, e As EventArgs) Handles chXLS.CheckedChanged
        If chXLS.Checked = True Then
            chXLL.Checked = False
        End If
    End Sub

    Private Sub chXLL_CheckedChanged(sender As Object, e As EventArgs) Handles chXLL.CheckedChanged
        If chXLL.Checked = True Then
            chXLS.Checked = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles cmbACARA.SelectedIndexChanged

    End Sub
End Class
