using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace GörselProje1.Forms
{
    public partial class GecmisIslemlerForm : Form
    {
        public string kullaniciAd;
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

        public GecmisIslemlerForm(string gelenAd)
        {
            InitializeComponent();
            kullaniciAd = gelenAd;
        }

        private void GecmisIslemlerForm_Load(object sender, EventArgs e)
        {
            
            GecmisiGetir();
        }

        void GecmisiGetir()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Sadece bu kullanıcının işlemlerini, en yeniden en eskiye sıralayarak getirmek için bunu yaptım
                string sql = "SELECT * FROM TableIslem WHERE kullanici_ad=@kadi ORDER BY islem_tarihi DESC"; //descending-azalan

                //dataset c# kodum ile veritabanı arasındaki veri alışverişini düzenler
                SqlDataAdapter da = new SqlDataAdapter(sql,con);
                da.SelectCommand.Parameters.AddWithValue("@kadi", kullaniciAd);//parametre atama

                //veri tablosu oluşturma ve doldurma
                DataTable dt = new DataTable();  //sanal tabllo oluşturma
                da.Fill(dt);// veritabanından gelen verileri(da) sanal tabloya (dt)atar

               

                if (dgvGecmis != null)
                {
                    dgvGecmis.DataSource = dt; //sanal tabloyu gride bağla
                    dgvGecmis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //sütunları ekrana yay

                    // Görünüm Ayarları
                    if (dgvGecmis.Columns.Count > 0)
                    {
                        dgvGecmis.Columns[0].Visible = false; 
                        dgvGecmis.Columns[1].Visible = false; // Kendi adını görmesine gerek yok

                        // Başlıkları Türkçeleştirmek için
                        dgvGecmis.Columns[2].HeaderText = "İşlem Türü";
                        dgvGecmis.Columns[3].HeaderText = "Açıklama / Kitap Adı";
                        dgvGecmis.Columns[4].HeaderText = "Tarih";
                    }
                    dgvGecmis.ClearSelection();//varsayılan seçilen satırı kaldır 
                }
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuFrom menu = new MenuFrom(kullaniciAd);
            menu.Show();
            this.Hide();
        }

        private void btnIndır_Click(object sender, EventArgs e)
        {
            //dosya kaydetme penceresi oluşturma
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyası | *.txt";
            save.FileName = "Gecmis_Islemlerim_" + DateTime.Now.ToString("dd_MM_yyyy");

            if (save.ShowDialog() == DialogResult.OK) //eğer tamama basarsa
            {
                try
                {
                    //dosyayı oluşturup yazacaz
                    StreamWriter yazici = new StreamWriter(save.FileName); //yazmak için
                    //başlık bölümü 
                    yazici.WriteLine("---KÜTÜPHANE İŞLEM GEÇMİŞİ---");
                    yazici.WriteLine("Kullanıcı: " + kullaniciAd);
                    yazici.WriteLine("Rapor Tarihi: " + DateTime.Now.ToString());
                    yazici.WriteLine("---------------------------------------------------------------------------------");
                    yazici.WriteLine("İŞLEM TÜRÜ          |  AÇIKLAMA / DETAY             | TARİH");
                    yazici.WriteLine("---------------------------------------------------------------------------------");

                    //tablodaki satırları tek tek alıyoruz
                    foreach (DataGridViewRow satir in dgvGecmis.Rows)
                    {
                        //boş satırları alma
                        if (satir.Cells[0].Value != null)
                        {
                            string tur = satir.Cells[2].Value.ToString();
                            string detay = satir.Cells[3].Value.ToString();
                            string tarih = satir.Cells[4].Value.ToString();

                            //padright kullanıyorum hizalama için (yazıyı yazdıktan sonra tamamlayana kadar boşluk bırakır )
                            string yazilacakSatir = tur.PadRight(20) + "| " + detay.PadRight(30) + "| " + tarih;

                            yazici.WriteLine(yazilacakSatir);

                        }
                    }

                    yazici.WriteLine("-----------------------------------------------------------------------------------");
                    yazici.Close(); //dosyayı kapat

                    MessageBox.Show("İşlem geçmişi başarıyla kaydedildi!", "Basarili",MessageBoxButtons.OK,MessageBoxIcon.Information);


                }
                catch (Exception exc) 
                { 
                    MessageBox.Show("Dosya kaydedilirken bir hata oluştu: "+exc.Message,"Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
