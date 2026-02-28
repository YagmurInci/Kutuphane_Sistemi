using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GörselProje1.Forms
{
    public partial class OduncTalebi : Form
    {
        public string kullaniciAd;

        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
     
        public OduncTalebi(string gelenAd)
        {
            InitializeComponent();
            kullaniciAd = gelenAd;
        }

        private void OduncTalebi_Load(object sender, EventArgs e)
        {
            //form açılınca kitapları getir
            KitaplariGetir();


        }

        //aranan parametrei boş gerlirse hepsini  dolu gelirse filtreleyerek getir
        void KitaplariGetir(string aranan = "")
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //sorgu sadece müsait olanları getir ve arama kutusuna yazılanı içeriyorsa getir
                string sql = "SELECT kitap_id, kitap_ad, yazar_ad, sayfa_sayisi, kitap_durum FROM TableBook WHERE kitap_durum='1' AND kitap_ad LIKE '%" + aranan + "%'";

                SqlDataAdapter da = new SqlDataAdapter(sql,con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvKitaplar.DataSource = dt;
                dgvKitaplar.Columns[0].Visible = false;
                dgvKitaplar.Columns[4].Visible = false;
                dgvKitaplar.Columns[5].Visible = false;
                dgvKitaplar.Columns[6].Visible = false;
                dgvKitaplar.Columns[7].Visible = false;

                //datagrid varsayılan olarak seçili geliyor bunu engellemek içn 
                //dgvKitaplar.ClearSelection();
            }
            catch (Exception exc) 
            {
                MessageBox.Show("Hata: " + exc.Message);
            }
            
            finally
            {
                con.Close();
            }

        }

        // Arama Kutusuna Her Harf Yazıldığında Çalışır
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            KitaplariGetir(txtAra.Text);
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            // Listeden bir satır seçili mi kontrolü
            if (dgvKitaplar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen listeden bir kitap seçiniz.");
                return;
            }

            string secilenId = dgvKitaplar.CurrentRow.Cells[0].Value.ToString();
            string secilenKitapAd = dgvKitaplar.CurrentRow.Cells[1].Value.ToString();

            try
            {
                con.Open();
                //kitap_id ye göre kitap durumunu ödüntçe=0 yap
                SqlCommand komutGuncelle = new SqlCommand("UPDATE TableBook SET Kitap_durum='0',odunc_alan=@kadi WHERE kitap_id=@id",con);
                komutGuncelle.Parameters.AddWithValue("@id",secilenId);
                komutGuncelle.Parameters.AddWithValue("@kadi",kullaniciAd);
                komutGuncelle.ExecuteNonQuery();

                //odunç işlemini kişinin geçmiş işlemlerine kaydetme (TableIslem)
                SqlCommand komutGecmis = new SqlCommand("INSERT INTO TableIslem (kullanici_ad,islem_turu,islem_aciklama,islem_tarihi)  VALUES (@kadi,'Ödünç Alma',@kitap,@tarih)",con);
                komutGecmis.Parameters.AddWithValue("@kadi",kullaniciAd);
                komutGecmis.Parameters.AddWithValue("@kitap", secilenKitapAd);//açıklama- kitap adı
                komutGecmis.Parameters.AddWithValue("@tarih", DateTime.Now);
                komutGecmis.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(secilenKitapAd+" adlı kitabı başarıyla ödünç aldınız. İyi okumalar!","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);

                //arama kutusunu temizle
                txtAra.Clear();

                //liisteyi sıfırlayıp yeniden getir
                KitaplariGetir();

                //listeyi yeniliycez ki aldığımız kitap listeden kaybolsun 
                KitaplariGetir(txtAra.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Bir Hata Oluştu: " + exc.Message);
                if (con.State == ConnectionState.Open) 
                { 
                    con.Close();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuFrom menu = new MenuFrom(kullaniciAd);
            menu.Show();
            this.Hide();
        }

        private void dgvKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
