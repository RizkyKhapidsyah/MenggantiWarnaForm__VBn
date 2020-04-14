Public Class FormUtama
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .btnTampilkanWarna.Text = "Tampilkan"
            .btnKembalikanWarna.Text = "Kembalikan"
        End With

        Try
            'Jika file Setting tidak ada di folder Bin,
            'maka kita akan membuat file tersebut dengan nama "Setting"
            'Proses ini untuk pertama kali program dijalankan.
            If System.IO.File.Exists(AppPath&("Setting.txt")) = False Then
                'Mendeklarasikan file Setting yang akan dibuat lalu di tulis
                'AppPath adalah nama alamat dimana file exe disimpan
                Dim sw As New System.IO.StreamWriter(AppPath&("Setting.txt"))
                'Mensetting warna untuk pertama kali adalah warna default form (control)
                Dim c As System.Drawing.Color = System.Drawing.ColorTranslator.FromHtml("Control")
                'Mengconvert warna menjadi bilangan hexa, lalu di tulis pada file setting
                sw.WriteLine("#" & Hex(c.ToArgb))
                sw.Close() 'Menutup file yang dibuka.
            Else 'Jika file setting sudah ada,
                Dim color As String
                'Mendeklarasikan file string yang akan di baca
                'AppPath adalah nama alamat dimana file exe akan disimpan
                Dim sr As New System.IO.StreamReader(AppPath&("Setting.txt"))
                'Mengambil text dari file setting
                color = sr.ReadLine()
                'Menutup File
                sr.Close()
                'Mensetting warna dari file setting
                Dim color2 As System.Drawing.Color = System.Drawing.ColorTranslator.FromHtml(color)
                'Mengubah warna untuk background form sesuai dengan fiel setting
                Me.BackColor = color2
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub BtnTampilkanWarna_Click(sender As Object, e As EventArgs) Handles btnTampilkanWarna.Click
        Try
            'Menampilkan dialog warna
            'Jika menekan tombol OK pada dialog warna
            If dlgWarna.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'Background form sama dengan warna yang dipilih pada dialog warna
                Me.BackColor = dlgWarna.Color
                'Mendeklarasikan file setting2 yang akan ditulis (file ini hanya temporary saja)
                'AppPath adalah nama alamat dimana file exe disimpan
                Dim sw As New System.IO.StreamWriter(AppPath&("Setting2.txt"))
                'Mengoknvert warna menjadi bilangan hexa lalu ditulis pada file Setting2
                Dim a As String = Hex(dlgWarna.Color.ToArgb)
                'Memoting 2 digit pertama dari hasil konvert
                a = a.Substring(2)
                'Menuliskan hasil konvert ke dalam file Setting2
                sw.WriteLine("#" & a)
                sw.Close() 'Menutup File
                System.IO.File.Delete(AppPath&("Setting.txt"))
                'Mengganti nama file Seeting2 menjadi Setting
                System.IO.File.Move(AppPath & ("Setting2.txt"), AppPath&("Setting.txt"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnKembalikanWarna_Click(sender As Object, e As EventArgs) Handles btnKembalikanWarna.Click
        Try
            'mendeklarasikan file Setting2 yang akan di tulis (file ini hanya temporary saja)
            'AppPath adalah Nama alamat dimana file exe disimpan
            Dim sw As New System.IO.StreamWriter(AppPath & ("Setting2.txt"))
            'Mesetting warna untuk pertama kali di jalankan adalah warna Default Form (Control)
            Dim color2 As System.Drawing.Color = System.Drawing.ColorTranslator.FromHtml("Control")
            'Mengubah Warna untuk Background menjadi default
            Me.BackColor = color2
            'mengconvert warna menjadi bilangan Hexa,lalu di tulis pada file Setting2
            sw.WriteLine("#" & Hex(color2.ToArgb))
            sw.Close() 'menutup file Setting2
            System.IO.File.Delete(AppPath & ("Setting.txt")) 'Menghapus File Setting dari Drive
            'Mengganti nama File Setting2 menjadi Setting
            System.IO.File.Move(AppPath & ("Setting2.txt"), AppPath & ("Setting.txt"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
