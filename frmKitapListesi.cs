using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Vize_hazırlık
{
    public partial class frmKitapListesi : Form
    {
        public frmKitapListesi()
        {
            InitializeComponent();
        }
        private void ListeyiGuncelle()
        {
            lstKitaplar.Items.Clear();
            dgvKitaplar.Columns.Clear();

            dgvKitaplar.Columns.Add("Ad", "Kitap Adı");
            dgvKitaplar.Columns.Add("Yazar", "Yazar");
            dgvKitaplar.Columns.Add("Kategori", "Kategori");
            dgvKitaplar.Columns.Add("Durum", "Durum");

            foreach (Kitap k in Kitap.KitapListesi)
            {
                lstKitaplar.Items.Add(k.Ad);
                dgvKitaplar.Rows.Add(k.Ad, k.Yazar, k.Kategori, k.Durum);
            }

            dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmKitapListesi_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. En dıştaki <Kitaplar> etiketini oluşturuyoruz 
                XElement kokEleman = new XElement("Kitaplar");

                // 2. Hafızadaki listemizi dönüp her kitap için bir <Kitap> etiketi hazırlıyoruz 
                foreach (Kitap k in Kitap.KitapListesi)
                {
                    XElement kitapDugumu = new XElement("Kitap",
                        new XElement("Ad", k.Ad),
                        new XElement("Yazar", k.Yazar),
                        new XElement("Kategori", k.Kategori),
                        new XElement("Durum", k.Durum)
                    );

                    // Hazırladığımız bu kitabı ana listeye ekliyoruz
                    kokEleman.Add(kitapDugumu);
                }

                // 3. XML Dosyasını oluşturup bilgisayara kaydediyoruz
                XDocument xmlDosyasi = new XDocument(kokEleman);
                xmlDosyasi.Save("kitaplar.xml");

                MessageBox.Show("Kitaplar başarıyla XML dosyasına kaydedildi!", "Süper!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists("kitaplar.xml"))
                {
                    XDocument xmlDosyasi = XDocument.Load("kitaplar.xml");

                    Kitap.KitapListesi.Clear();

                    // DİKKAT: Burası tam olarak "Kitap" olmalı (Hocanın XML'indeki etiket adı)
                    // Eğer senin kodunda "Kitaplar" yazıyorsa 0 sonuç verir.
                    var kitaplar = xmlDosyasi.Descendants("Kitap");

                    foreach (XElement element in kitaplar)
                    {
                        Kitap okunanKitap = new Kitap();

                        // Element isimlerinin büyük/küçük harfine çok dikkat!
                        okunanKitap.Ad = element.Element("Ad")?.Value ?? "";
                        okunanKitap.Yazar = element.Element("Yazar")?.Value ?? "";
                        okunanKitap.Kategori = element.Element("Kategori")?.Value ?? "";
                        okunanKitap.Durum = element.Element("Durum")?.Value ?? "";

                        Kitap.KitapListesi.Add(okunanKitap);
                    }

                    ListeyiGuncelle();
                    MessageBox.Show(Kitap.KitapListesi.Count + " adet kitap başarıyla yüklendi!", "Bilgi");
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            // Önce kategori seçilmiş mi diye kontrol edelim
            if (cmbFiltre.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen filtrelemek için bir kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenKategori = cmbFiltre.SelectedItem.ToString();

            // DataGridView'in içindeki satırları temizleyelim
            dgvKitaplar.Rows.Clear();

            // Ortak listemizde dönüp SADECE seçilen kategoriyle eşleşenleri ekrana basalım
            foreach (Kitap k in Kitap.KitapListesi)
            {
                if (k.Kategori == secilenKategori)
                {
                    dgvKitaplar.Rows.Add(k.Ad, k.Yazar, k.Kategori, k.Durum);
                }
            }
        }

        // 2. YENİLE BUTONU KODLARI (Ayrı bir buton olarak)
        private void btnYenile_Click(object sender, EventArgs e)
        {
            cmbFiltre.SelectedIndex = -1; // ComboBox'taki seçimi kaldır
            ListeyiGuncelle();            // Daha önce yazdığımız metotla tüm listeyi geri getir

        }
}
}
