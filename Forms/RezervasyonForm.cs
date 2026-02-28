using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace GörselProje1.Forms
{
    public partial class RezervasyonForm : Form
    {
        public string kullaniciAd;
        
        public RezervasyonForm(string gelenAd)
        {
            InitializeComponent();
            kullaniciAd=gelenAd;
        }

        private void RezervasyonForm_Load(object sender, EventArgs e)
        {
            //form yüklenince date bugünü göstersin geçmişi değil
            dtpTarih.MinDate = DateTime.Now;
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            //boş alan var mı?
            if (cmbOdaNo.SelectedIndex == -1 || cmbSaatAraligi.SelectedIndex == -1 || cmbKisiSayisi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            // ComboBox'ta 09:00 - 11:00 parçalayıp veritabanı için saat formatına çevirmeliyiz.
            string secilenAralik = cmbSaatAraligi.Text; 
            string[] saatler = secilenAralik.Split('-'); // Tireden ikiye bölüyor

            string baslangicSaatiStr = saatler[0].Trim(); // "09:00"
            string bitisSaatiStr = saatler[1].Trim();     // "11:00"

            // Tarihle saati birleştiriyoruz (Bugünün tarihi + Seçilen saat)
            DateTime tarih = dtpTarih.Value.Date; // Sadece gün kısmı
            DateTime baslangicZamani = tarih.Add(TimeSpan.Parse(baslangicSaatiStr));
            DateTime bitisZamani = tarih.Add(TimeSpan.Parse(bitisSaatiStr));

            // Veritabanı Bağlantısı
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

            try
            {
                con.Open();

                //rezervasyon tablosuna kayıt yapıyoru
                string sqlRezerv = "INSERT INTO TableRezervasyon (kullanici_ad, oda_no, baslangic_saat, bitis_saat, rezervasyon_durum) VALUES (@kadi, @oda, @baslangic, @bitis, 'Aktif')";
                SqlCommand komutRezerv = new SqlCommand(sqlRezerv,con);

                komutRezerv.Parameters.AddWithValue("@kadi", kullaniciAd); // Menüden gelen kullanıcı adı
                komutRezerv.Parameters.AddWithValue("@oda", cmbOdaNo.Text);
                komutRezerv.Parameters.AddWithValue("@baslangic", baslangicZamani);
                komutRezerv.Parameters.AddWithValue("@bitis", bitisZamani);

                komutRezerv.ExecuteNonQuery(); // İlk kayıt tamam

                //işlem geçmişine kayıt,loglama
                string sqlLog = "INSERT INTO TableIslem (kullanici_ad, islem_turu, islem_aciklama, islem_tarihi) VALUES (@kadi, 'Rezervasyon', @detay, @tarih)";
                SqlCommand komutLog = new SqlCommand(sqlLog,con);

                komutLog.Parameters.AddWithValue("@kadi", kullaniciAd);
                string detay = cmbOdaNo.Text + " (" + secilenAralik + ")"; // 2. oda (11-13) aralığı gibi detay yazacak
                komutLog.Parameters.AddWithValue("@detay", detay);
                komutLog.Parameters.AddWithValue("@tarih", DateTime.Now); // İşlemin yapıldığı an

                komutLog.ExecuteNonQuery(); // İkinci kayıt tamam

                con.Close();

                MessageBox.Show("Rezervasyonunuz başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            MenuFrom menu = new MenuFrom(kullaniciAd);
            menu.Show();
            this.Hide();
        }

        private void cmbSaatAraligi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOdaNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
