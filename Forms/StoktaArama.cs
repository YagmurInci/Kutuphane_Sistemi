using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO; //dosya işlemleri için 

namespace GörselProje1.Forms
{
    public partial class StoktaArama : Form
    {
        public string kullaniciAd;
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
        public StoktaArama(string gelenAd)
        {
            InitializeComponent();
            kullaniciAd=gelenAd;
        }

        private void StoktaArama_Load(object sender, EventArgs e)
        {
            KitaplariListele();
        }

        void KitaplariListele(string aranan="")
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
            con.Open();
            //tüm kitapları getirme
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TableBook WHERE kitap_ad LIKE '%"+aranan+"%'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKitaplar.DataSource = dt; 
            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KitaplariListele(txtAra.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuFrom menu = new MenuFrom(kullaniciAd);
            menu.Show();
            this.Hide();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            // Dosyayı nereye kaydedeceğimizi soran pencere
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyası|*.txt"; // Sadece txt dosyası oluştur
            save.FileName = "Kitap_Listesi_" + DateTime.Now.ToString("dd_MM_yyyy"); // Varsayılan isim

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // StreamWriter->Dosya yazma aracı
                    // save.FileName->Kullanıcının seçtiği dosya yolu
                    StreamWriter yazici = new StreamWriter(save.FileName);

                    // Başlık Yazalım
                    yazici.WriteLine("--- KÜTÜPHANE KİTAP LİSTESİ ---");
                    yazici.WriteLine("Oluşturulma Tarihi: " + DateTime.Now.ToString());
                    yazici.WriteLine("--------------------------------------------------");
                    yazici.WriteLine(""); // Boş satır

                    // DataGridView'deki satırları tek tek döngüyle alıp dosyaya yazıyor
                    for (int i = 0; i < dgvKitaplar.Rows.Count; i++)
                    {
                        // Satır boş değilse 
                        if (dgvKitaplar.Rows[i].Cells[0].Value != null)
                        {
                            string satir = "";


                            string kitapAd = dgvKitaplar.Rows[i].Cells[1].Value.ToString();
                            string yazar = dgvKitaplar.Rows[i].Cells[2].Value.ToString();

                            
                            satir = kitapAd + " - " + yazar;

                            yazici.WriteLine(satir);
                        }
                    }

                    yazici.Close(); // Dosyayı kapatıp kaydetmeyi bitir
                    MessageBox.Show("Liste başarıyla masaüstüne kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Dosya yazılırken hata oluştu: " + exc.Message);
                }
            }
        }

        private void dgvKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
