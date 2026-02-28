using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GörselProje1.Forms
{
    public partial class IadeTalepForm : Form
    {
        //menüde ngelen ismi tutuyoruz
        public string kullaniciAd;
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

        public IadeTalepForm(string gelenAd)
        {
            InitializeComponent();
            kullaniciAd = gelenAd;
        }

        private void IadeTalebi_Load(object sender, EventArgs e)
        {
            //form açılınca kullanıcının ödünç aldığı kitap bilgilerini getirir
            KullanicininKitaplariniGetir();

        }

        //sadece o kişinin kitaplarını getir
        void KullanicininKitaplariniGetir()
        {
            try
            {
                if (con.State == ConnectionState.Closed) 
                { 
                    con.Open();
                }

                //durumu ödünç=0 olan ve ödünç alan kişi giriş yapan kullanıcıya eşit olan kitaplar
                string sql = "SELECT * FROM TableBook WHERE kitap_durum='0' AND odunc_alan=@kadi";
                SqlDataAdapter da = new SqlDataAdapter(sql,con);
                da.SelectCommand.Parameters.AddWithValue("@kadi",kullaniciAd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvIadeListesi.DataSource = dt;
                dgvIadeListesi.Columns[0].Visible = false;
                dgvIadeListesi.Columns[4].Visible = false;
                dgvIadeListesi.Columns[5].Visible = false;
                dgvIadeListesi.Columns[6].Visible = false;
                dgvIadeListesi.Columns[7].Visible = false;
                dgvIadeListesi.Columns[8].Visible = false;

                //sütun isimlerni düzenleme
                dgvIadeListesi.Columns[1].HeaderText = "Kitap Adı";
                dgvIadeListesi.Columns[2].HeaderText = "Yazar";
                dgvIadeListesi.Columns[3].HeaderText = "Sayfa Sayısı";

                //iade edilecek kitap yoksa liste boşsa
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("İade edilecek kitap bulunmamaktadır.");
                }

            }
            catch (Exception exc) 
            { 
                MessageBox.Show("Hata: "+exc.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dgvIadeListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (dgvIadeListesi.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iade etmek istediğiniz kitabı seçiniz.");
                return;
            }
            //seçilen kitap bilgilerini alma
            string secilenId = dgvIadeListesi.CurrentRow.Cells[0].Value.ToString();
            string secilenKitapAd = dgvIadeListesi.CurrentRow.Cells[1].Value.ToString();

            try
            {
                con.Open();
                //kitabı iade etmee işlemi ekliyor ve kitap durumu 1 oluyor ve odunç alan kişi null oluyor
                string sqlUpdate = "UPDATE TableBook SET kitap_durum='1',odunc_alan=NULL WHERE kitap_id=@id";
                SqlCommand komut=new SqlCommand(sqlUpdate, con);
                komut.Parameters.AddWithValue("@id",secilenId);
                komut.ExecuteNonQuery();

                //geçmiş işlemlere kaydetme loglama
                string sqlLog = "INSERT INTO TableIslem (kullanici_ad,islem_turu,islem_aciklama,islem_tarihi) VALUES (@kadi,'İade Etme',@kitap,@tarih)";
                SqlCommand komutLog=new SqlCommand(sqlLog, con);
                komutLog.Parameters.AddWithValue("@kadi",kullaniciAd);
                komutLog.Parameters.AddWithValue("@kitap",secilenKitapAd);
                komutLog.Parameters.AddWithValue("@tarih", DateTime.Now);
                komutLog.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kitap başarıyla iade edildi.", "Teşekkürler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi yenile 
                KullanicininKitaplariniGetir();

            }
            catch (Exception exc) 
            {
                MessageBox.Show("Hata: " + exc.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
            finally
            {
                con.Close();
            }
        }

        //otomatik seçimi kaldırmak için 
        private void dgvIadeListesi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvIadeListesi.ClearSelection();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuFrom menu = new MenuFrom(kullaniciAd);
            menu.Show();
            this.Hide();
        }
    }
}
