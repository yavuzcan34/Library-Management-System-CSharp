using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_hazırlık
{
    public partial class frmKitapGiris : Form
    {
        public frmKitapGiris()
        {
            InitializeComponent();
        }

        private void Temizle_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // TextBox'ların içini temizliyoruz
            txtKitapAdi.Clear(); // veya txtKitapAdi.Text = "";
            txtYazar.Clear();
            txtISBN.Clear();
            txtYayinevi.Clear(); // Eğer ismini txtYayinevi yaptıysan
            txtYil.Clear();      // Eğer ismini txtYil yaptıysan

            // ComboBox'lardaki seçimleri kaldırıyoruz (-1 hiçbir şey seçili değil demektir)
            cmbKategori.SelectedIndex = -1;
            cmbDurum.SelectedIndex = -1;

            // İmleci tekrar ilk kutuya (Kitap Adı) konumlandırıyoruz ki kullanıcı hemen yeni veri girebilsin
            txtKitapAdi.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Boş Alan Kontrolü (Hocanın 10 puanlık Genel Kalite kriteri için)
                if (string.IsNullOrWhiteSpace(txtKitapAdi.Text) ||
                    string.IsNullOrWhiteSpace(txtYazar.Text) ||
                    cmbKategori.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen yıldızlı (*) alanları (Kitap Adı, Yazar, Kategori) doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kodun aşağıya devam etmesini engeller
                }

                // 2. Yeni Kitap Nesnesini Oluşturma ve Formdaki Verileri İçine Atma
                Kitap yeniKitap = new Kitap();
                yeniKitap.Ad = txtKitapAdi.Text;
                yeniKitap.Yazar = txtYazar.Text;
                yeniKitap.ISBN = txtISBN.Text;
                yeniKitap.Yayinevi = txtYayinevi.Text;
                yeniKitap.Yil = txtYil.Text;
                yeniKitap.Kategori = cmbKategori.SelectedItem.ToString();

                // Durum seçilmediyse varsayılan olarak boş kalmasın
                if (cmbDurum.SelectedIndex != -1)
                    yeniKitap.Durum = cmbDurum.SelectedItem.ToString();
                else
                    yeniKitap.Durum = "Belirtilmedi";
                // Kitabı ortak listemize ekliyoruz
                Kitap.KitapListesi.Add(yeniKitap);

                // 3. Başarı Mesajı
                MessageBox.Show($"'{yeniKitap.Ad}' isimli kitap başarıyla oluşturuldu!\n(Bir sonraki adımda bunu listeye aktaracağız)", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Ekleme bittikten sonra formu yeni kayıt için otomatik temizleyelim
                btnTemizle.PerformClick();
            }
            catch (Exception ex)
            {
                // Yine Genel Kalite kriteri olan try-catch hata yönetimi
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
