using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Facade
{
    public class FFaturalar
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Listele3", Baglanti.conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static int Ekle(Faturalar faturalar)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("Ekle3", Baglanti.conn);
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("Odeme", faturalar.Odeme);
                komut.Parameters.AddWithValue("HastaNo", faturalar.HastaNo);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        public static bool Guncelle(Faturalar faturalar)
        {
            SqlCommand komut = new SqlCommand("Yenile2", DBaglanti.conn);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("FaturaNo", faturalar.FaturaNo);
            komut.Parameters.AddWithValue("Odeme", faturalar.Odeme);
            komut.Parameters.AddWithValue("HastaNo", faturalar.HastaNo);
            return DBaglanti.exec(komut);
        }
        public static bool Sil(Faturalar faturalar)
        {
            SqlCommand komut = new SqlCommand("Sil3", DBaglanti.conn);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("FaturaNo", faturalar.FaturaNo);
            return DBaglanti.exec(komut);
        }
        public static DataTable Ara(Faturalar faturalar)
        {
            SqlCommand komut = new SqlCommand("Ara3", DBaglanti.conn);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("HastaNo", faturalar.HastaNo);
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            dr.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dr.Fill(dt);
            return dt;

        }
    }
}
