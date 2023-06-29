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
    public class FHastalar
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Listele", Baglanti.conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static int Ekle(Hastalar hastalar)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("Ekle", Baglanti.conn);
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("TC", hastalar.TC);
                komut.Parameters.AddWithValue("AdSoyad", hastalar.AdSoyad);
                komut.Parameters.AddWithValue("DogumTarihi", hastalar.DogumTarihi);
                komut.Parameters.AddWithValue("Cinsiyet", hastalar.Cinsiyet);
                komut.Parameters.AddWithValue("Telefon", hastalar.Telefon);
                komut.Parameters.AddWithValue("SosyalGuvenlik", hastalar.SosyalGuvenlik);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        public static bool Guncelle(Hastalar hastalar)
        {
            SqlCommand komut = new SqlCommand("Yenile", DBaglanti.conn);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("HastaNo", hastalar.HastaNo);
            komut.Parameters.AddWithValue("TC", hastalar.TC);
            komut.Parameters.AddWithValue("AdSoyad", hastalar.AdSoyad);
            komut.Parameters.AddWithValue("DogumTarihi", hastalar.DogumTarihi);
            komut.Parameters.AddWithValue("Cinsiyet", hastalar.Cinsiyet);
            komut.Parameters.AddWithValue("Telefon", hastalar.Telefon);
            komut.Parameters.AddWithValue("SosyalGuvenlik", hastalar.SosyalGuvenlik);
            return DBaglanti.exec(komut);
        }
        public static bool Sil(Hastalar hastalar)
        {
            SqlCommand komut = new SqlCommand("Sil", DBaglanti.conn);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("HastaNo", hastalar.HastaNo);
            return DBaglanti.exec(komut);
        }
        public static DataTable Ara(Hastalar hastalar)
        {
            SqlCommand komut = new SqlCommand("Ara", DBaglanti.conn);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("TC", hastalar.TC);
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            dr.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dr.Fill(dt);
            return dt;
        }



    }
}

