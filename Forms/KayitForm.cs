using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GörselProje1.Forms
{
    public partial class KayitForm : Form
    {
        SqlConnection connection=new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
        
        public KayitForm()
        {
            InitializeComponent();
        }


        //DbConnection con = new DbConnection();
        private void KayitForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAdSoyad.Text) || string.IsNullOrEmpty(txtKullanici.Text) ||
                    string.IsNullOrEmpty(txtDate.Text) || string.IsNullOrEmpty(txtmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            try
            {
                
                if (connection.State != ConnectionState.Open)
                        connection.Open();
               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO TableUser(IsimSoyisim,KullaniciAd,DogumTarihi,Mail,Sifre)  VALUES(@IsimSoyisim,@KullaniciAd,@DogumTarihi,@Mail,@Sifre)";

                cmd.Parameters.AddWithValue("@IsimSoyisim",txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@KullaniciAd", txtKullanici.Text);
                cmd.Parameters.AddWithValue("@DogumTarihi", txtDate.Text);
                cmd.Parameters.AddWithValue("@Mail", txtmail.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                //veritabanına kayıt atıp çalıştırma 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                txtAdSoyad.Clear();
                txtKullanici.Clear();
                txtmail.Clear();
                txtSifre.Clear();
                txtSifre.Clear();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

