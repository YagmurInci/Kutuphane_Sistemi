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

namespace GörselProje1.Forms
{
    public partial class KitapBagis : Form
    {
        public event EventHandler KalinKitapEvent;
        public string kullaniciAd;
        public KitapBagis(string gelenAd)
        {
            InitializeComponent();
            kullaniciAd = gelenAd;
        }

        private void KitapBagis_Load(object sender, EventArgs e)
        {
            // EVENTE ABONE OLMA
            // Bu olay gerçekleşirse, 'UyariVer' metodunu çalıştır olayı metoda bağladık
            this.KalinKitapEvent += new EventHandler(UyariVer);
        }

        // EVENT ÇALIŞINCA olacaklar
        void UyariVer(object sender, EventArgs e)
        {
            MessageBox.Show("Dikkat: Çok kalın bir kitap (1000+ sayfa) sisteme eklendi!", "Özel Event Çalıştı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int girilenSayfa = 0;
            int.TryParse(txtSayfa.Text, out girilenSayfa);

            // Eğer sayfa 1000'den büyükse 
            if (girilenSayfa > 1000 )
            {
              //bu form
                KalinKitapEvent(this, EventArgs.Empty);
            }
            // boş kontrol validation ekledim
            if (string.IsNullOrWhiteSpace(txtKitapAd.Text) ||
                string.IsNullOrWhiteSpace(txtYazarAd.Text) ||
                string.IsNullOrWhiteSpace(txtSayfa.Text))
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kod buradan geriye dönsün  aşağıdaki veritabanı işlemlerini YAPmasın diye ekledim.
            }

            // Kullanıcı sayfa yerine harf vs yazarsa
            int sayfaSayisi;
            if (!int.TryParse(txtSayfa.Text, out sayfaSayisi))
            {
                MessageBox.Show("Lütfen sayfa sayısını sadece sayı giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
            con.Open();
            //kitabı stoğa ekliycez ve durumu 1 olacak 
            SqlCommand komut = new SqlCommand("INSERT INTO TableBook (kitap_ad,yazar_ad,sayfa_sayisi,kayit_tarihi,bagisci_ad,bagisci_mail,kitap_durum) VALUES (@ad,@yazar,@sayfa,@tarih,@bagisci,@mail,1)", con);

            komut.Parameters.AddWithValue("@ad", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@yazar", txtYazarAd.Text);
            komut.Parameters.AddWithValue("@sayfa", txtSayfa.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now);
            komut.Parameters.AddWithValue("@bagisci", kullaniciAd);
            komut.Parameters.AddWithValue("@mail", txtMail.Text);
            komut.ExecuteNonQuery();

            //geçmişe log at
            SqlCommand log = new SqlCommand("INSERT INTO TableIslem (kullanici_ad,islem_turu,islem_aciklama,islem_tarihi) VALUES (@kadi,'Bağış',@detay,@tarih)",con);
            log.Parameters.AddWithValue("@kadi", kullaniciAd);
            log.Parameters.AddWithValue("@detay", txtKitapAd.Text);
            log.Parameters.AddWithValue("@tarih", DateTime.Now);
            log.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bağışınız İçin Teşekkürler!");
            // text leri sıfırla
            txtKitapAd.Clear();
            txtYazarAd.Clear();
            txtSayfa.Clear();
            txtMail.Clear();
            txtBagisciAdSoyad.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBagisciMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBagisciAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateBagis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuFrom menu = new MenuFrom(kullaniciAd);
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuFrom menu = new MenuFrom(kullaniciAd);
            menu.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
