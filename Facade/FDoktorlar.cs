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
    public class FDoktorlar
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Listele1", Baglanti.conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static int Ekle(Doktorlar doktorlar)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("Ekle1", Baglanti.conn);
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("TC", doktorlar.TC);
                komut.Parameters.AddWithValue("AdiSoyadi", doktorlar.AdiSoyadi);
                komut.Parameters.AddWithValue("DogumTarihi", doktorlar.DogumTarihi);
                komut.Parameters.AddWithValue("Cinsiyet", doktorlar.Cinsiyet);
                komut.Parameters.AddWithValue("Telefon", doktorlar.Telefon);
                komut.Parameters.AddWithValue("UzmanlikAlani", doktorlar.UzmanlikAlani);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        public static bool Guncelle(Doktorlar doktorlar)
        {
            SqlCommand komut = new SqlCommand("Yenile1", DBaglanti.conn);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("DoktorNo", doktorlar.DoktorNo);
            komut.Parameters.AddWithValue("TC", doktorlar.TC);
            komut.Parameters.AddWithValue("AdiSoyadi", doktorlar.AdiSoyadi);
            komut.Parameters.AddWithValue("DogumTarihi", doktorlar.DogumTarihi);
            komut.Parameters.AddWithValue("Cinsiyet", doktorlar.Cinsiyet);
            komut.Parameters.AddWithValue("Telefon", doktorlar.Telefon);
            komut.Parameters.AddWithValue("UzmanlikAlani", doktorlar.UzmanlikAlani);
            return DBaglanti.exec(komut);
        }
        public static bool Sil(Doktorlar doktorlar)
        {
            SqlCommand komut = new SqlCommand("Sil1", DBaglanti.conn);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("DoktorNo", doktorlar.DoktorNo);
            return DBaglanti.exec(komut);
        }
        public static DataTable Ara(Doktorlar doktorlar)
        {
            SqlCommand komut = new SqlCommand("Ara1", DBaglanti.conn);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("AdiSoyadi", doktorlar.AdiSoyadi);
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            dr.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dr.Fill(dt);
            return dt;
        }

    }
}
