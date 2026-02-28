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
using System.Windows.Forms.DataVisualization.Charting;

namespace GörselProje1.Forms
{
    public partial class GrafikForm : Form
    {
        public string kullaniciAd;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UP1VM9G\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
        public GrafikForm(string gelenAd)
        {
            InitializeComponent();
            kullaniciAd=gelenAd;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void GrafikForm_Load(object sender, EventArgs e)
        {
            GrafigiDoldur();
        }

        void GrafigiDoldur()
        {
            // 1. Grafik Temizliği ve Başlık
            chart1.Series.Clear(); // Varsayılan seriyi sil
            chart1.Titles.Clear();
            chart1.Titles.Add("Kütüphane Kitap Durumu");

            // 2. Yeni Seri Ekleme (Pasta Grafiği)
            Series seri = chart1.Series.Add("Durumlar");
            seri.ChartType = SeriesChartType.Pie; // Pie = Pasta Grafik, 

            // Grafiğin üzerinde sayıların görünmesi için
            seri.IsValueShownAsLabel = true;

            try
            {
                baglanti.Open();

                // Veritabanından durumları sayalım (1=Rafta, 0=Ödünçte)
                // GROUP BY ile gruplayıp COUNT ile sayıyoruz
                SqlCommand komut = new SqlCommand("SELECT kitap_durum, COUNT(*) FROM TableBook GROUP BY kitap_durum", baglanti);

                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    string durumKodu = oku[0].ToString(); // 1 veya 0 gelir
                    int sayi = int.Parse(oku[1].ToString()); // Kaç tane olduğu

                    string etiket;
                    if (durumKodu == "1" || durumKodu.ToLower() == "true")
                        etiket = "Rafta (Müsait)";
                    else
                        etiket = "Ödünç Verilmiş";

                    // Grafiğe ekle: İsim (X), Değer (Y)
                    seri.Points.AddXY(etiket, sayi);
                }

                baglanti.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Grafik hatası: " + exc.Message);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuFrom menu = new MenuFrom(kullaniciAd);
            menu.Show();
            this.Hide();
        }
    }
}
