using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GörselProje1.Forms
{
    public partial class MenuFrom : Form
    {
        public string kullaniciAd;
        public MenuFrom(string gelenAd)
        {
            InitializeComponent();
            kullaniciAd = gelenAd;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProfilForm profil = new ProfilForm(kullaniciAd);
            profil.Show();
            this.Hide();//menüyü gizle
        }

        private void MenuFrom_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?","Çıkış Yap",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes) 
            {
                //logine dön
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }

        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            RezervasyonForm rezervasyon = new RezervasyonForm(kullaniciAd);
            rezervasyon.Show();
            this.Hide();
        }

        private void btnStokArama_Click(object sender, EventArgs e)
        {
            StoktaArama stok = new StoktaArama(kullaniciAd);
            stok.Show();
            this.Hide();
        }

        private void btnBagis_Click(object sender, EventArgs e)
        {
            KitapBagis bagis = new KitapBagis(kullaniciAd);
            bagis.Show();
            this.Hide();
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            GecmisIslemlerForm gecmis =new GecmisIslemlerForm(kullaniciAd);
            gecmis.Show();
            this.Hide();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            OduncTalebi odunc = new OduncTalebi(kullaniciAd);
            odunc.Show();
            this.Hide();
        }

        private void btnİade_Click(object sender, EventArgs e)
        {
            IadeTalepForm iade = new IadeTalepForm(kullaniciAd);
            iade.Show();
            this.Hide();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            GrafikForm grafik = new GrafikForm(kullaniciAd);
            grafik.Show();
            this.Hide();
        }
    }
}
