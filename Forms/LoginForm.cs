using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GörselProje1.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını, hazırladığımız adresi kullanarak başlatıyoruz
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
            try
            {
                connection.Open();
                string sql = "SELECT * FROM TableUser where KullaniciAd=@KullaniciAd AND Sifre=@Sifre";
                SqlCommand komut = new SqlCommand(sql, connection);

                komut.Parameters.AddWithValue("@KullaniciAd", txtName.Text);
                komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                //veri okuma
                SqlDataReader dr = komut.ExecuteReader();

                //eğer okuma başarılıysa ve kullanıcı varsa 
                if (dr.Read())
                {
                    MenuFrom menu = new MenuFrom(txtName.Text);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm();
            kayitForm.Show();
            this.Hide();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
