using System.Data.SqlClient;

namespace GörselProje1.Helpers
{
    public class DbConnection
    {
        // Dosya adı KutuphaneSistemi.db olarak belirlendi
        // public static string connectionString = "Data Source=KutuphaneSistemi.db;Version=3;";
        string adres = @"Data Source=DESKTOP-UP1VM9G\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Trust Server Certificate=True";
        
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(adres);
            baglanti.Open();
            return baglanti;
        }
    }
}