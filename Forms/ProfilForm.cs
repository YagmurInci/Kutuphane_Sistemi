using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GörselProje1.Forms
{
    public partial class ProfilForm : Form
    {
        public String kullaniciAd;
        public ProfilForm(string gelenAd)
        {
            InitializeComponent();
            kullaniciAd = gelenAd;
        }

        private void ProfilForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
            connection.Open();

            //giriş yapan kişinin bilgilerini getir
            SqlCommand komut = new SqlCommand("SELECT * FROM TableUser Where kullaniciAd=@p1",connection);
            komut.Parameters.AddWithValue("@p1", kullaniciAd);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                // Veritabanından gelenleri kutulara yaz
                txtAdSoyad.Text = dr["IsimSoyisim"].ToString();
                txtKullanici.Text = dr["KullaniciAd"].ToString() ;
                txtMail.Text = dr["Mail"].ToString();
                txtSifre.Text = dr["Sifre"].ToString();
                txtDate.Value = Convert.ToDateTime(dr["DogumTarihi"]);

            }
            connection.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuFrom menu = new MenuFrom(kullaniciAd);
            menu.Show();
            this.Hide();
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            //emin mi diye sorma
            DialogResult cevap=MessageBox.Show("Hesabınızı Kalıcı Olarak Silmek İstediğinize Emin Misiniz?","Hesap Silme",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

                try
                {
                    con.Open();
                    //kullanıcıyı veritabanından silme
                    SqlCommand komut = new SqlCommand("DELETE FROM TableUser WHERE KullaniciAd=@KullaniciAd", con);
                    komut.Parameters.AddWithValue("@KullaniciAd", kullaniciAd);
                    komut.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Hesabınız Silindi Giriş Ekranına Yönlendiriliyorsunuz.");

                    //hesap silindi giriş ekranı açılır
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Close(); //profil sayfası kapanır
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Silme İşlemi Başarısız: "+ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAdSoyad.Text) || string.IsNullOrEmpty(txtKullanici.Text) ||
                    string.IsNullOrEmpty(txtDate.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

            try
            {
                con.Open();
                //şuanki kullanıcının bilgileri güncellenecek. şart(WHERE) eski kullanıcı adı ama güncellenebilir
                string sql = "UPDATE TableUser SET IsimSoyisim=@isim,KullaniciAd=@yeniKad,Mail=@mail,DogumTarihi=@tarih," +
                    "Sifre=@sifre WHERE KullaniciAd=@KullaniciAd";

                SqlCommand komut=new SqlCommand(sql, con);
                //parametreleri kutucukların şimdiki halinden alıyoruz
                komut.Parameters.AddWithValue("@isim",txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@yeniKad", txtKullanici.Text);
                komut.Parameters.AddWithValue("@mail", txtMail.Text);
                komut.Parameters.AddWithValue("@tarih", txtDate.Value);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut.Parameters.AddWithValue("@KullaniciAd", kullaniciAd);

                int sonuc=komut.ExecuteNonQuery();
                //satır değişikliği yapılınca kullanıcı bulunamazsa sonuc 0 döner ve değişiklik yapılamaz
                if (sonuc > 0) 
                {
                    MessageBox.Show("Bilgileriniz Başarıyla Güncellendi.", "Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    kullaniciAd = txtKullanici.Text;
                }
                else
                {
                    MessageBox.Show("Güncelleme Yapılamadı. Kullanıcı Bulunamadı.");
                }

            }
            catch (Exception exc) 
            {
                //var olan kullanıcının adını girme gibi hatalar için 
                MessageBox.Show("Hata Oluştu: "+exc.Message);
            }


        }

    }
}
