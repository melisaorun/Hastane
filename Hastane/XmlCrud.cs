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
using System.Data.SqlClient;
using System.Xml;

namespace Hastane
{
    public partial class XmlCrud : Form
    {
        public XmlCrud()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=Hastane;Trusted_Connection=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc=new XmlDocument();
            XmlElement root=xmldoc.CreateElement("Hastalar");
            SqlCommand cmd = new SqlCommand("select* from Hastalar",conn);
            conn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                XmlElement hasta = xmldoc.CreateElement("HastaBilgi");

                XmlAttribute TC = xmldoc.CreateAttribute("TC");
                TC.Value = dr["TC"].ToString();

                XmlAttribute AdSoyad = xmldoc.CreateAttribute("AdSoyad");
                AdSoyad.Value = dr["AdSoyad"].ToString();

                XmlAttribute DogumTarihi = xmldoc.CreateAttribute("DogumTarihi");
                DogumTarihi.Value = dr["DogumTarihi"].ToString();

                XmlAttribute Cinsiyet = xmldoc.CreateAttribute("Cinsiyet");
                Cinsiyet.Value = dr["Cinsiyet"].ToString();

                XmlAttribute Telefon= xmldoc.CreateAttribute("Telefon");
                Telefon.Value = dr["Telefon"].ToString();

                XmlAttribute SosyalGuvenlik = xmldoc.CreateAttribute("SosyalGuvenlik");
                SosyalGuvenlik.Value = dr["SosyalGuvenlik"].ToString();

                hasta.Attributes.Append(TC);
                hasta.Attributes.Append(AdSoyad);
                hasta.Attributes.Append(DogumTarihi);
                hasta.Attributes.Append(Cinsiyet);
                hasta.Attributes.Append(Telefon);
                hasta.Attributes.Append(SosyalGuvenlik);
                root.AppendChild(hasta);

               
            }
            conn.Close();
            xmldoc.AppendChild(root);
            xmldoc.Save("hveri.xml");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Anasayfa sec = new Anasayfa();
            sec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Doktorlar");
            SqlCommand cmd = new SqlCommand("select* from Doktorlar", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                XmlElement doktor = xmldoc.CreateElement("DoktorBilgi");

                XmlAttribute TC = xmldoc.CreateAttribute("TC");
                TC.Value = dr["TC"].ToString();

                XmlAttribute AdiSoyadi = xmldoc.CreateAttribute("AdiSoyadi");
                AdiSoyadi.Value = dr["AdiSoyadi"].ToString();

                XmlAttribute DogumTarihi = xmldoc.CreateAttribute("DogumTarihi");
                DogumTarihi.Value = dr["DogumTarihi"].ToString();

                XmlAttribute Cinsiyet = xmldoc.CreateAttribute("Cinsiyet");
                Cinsiyet.Value = dr["Cinsiyet"].ToString();

                XmlAttribute Telefon = xmldoc.CreateAttribute("Telefon");
                Telefon.Value = dr["Telefon"].ToString();

                XmlAttribute UzmanlikAlani = xmldoc.CreateAttribute("UzmanlikAlani");
                UzmanlikAlani.Value = dr["UzmanlikAlani"].ToString();

                doktor.Attributes.Append(TC);
                doktor.Attributes.Append(AdiSoyadi);
                doktor.Attributes.Append(DogumTarihi);
                doktor.Attributes.Append(Cinsiyet);
                doktor.Attributes.Append(Telefon);
                doktor.Attributes.Append(UzmanlikAlani);
                root.AppendChild(doktor);


            }
            conn.Close();
            xmldoc.AppendChild(root);
            xmldoc.Save("dveri.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Randevular");
            SqlCommand cmd = new SqlCommand("select* from Randevular", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                XmlElement randevu = xmldoc.CreateElement("RandevuBilgi");

                XmlAttribute RandevuTarihi = xmldoc.CreateAttribute("RandevuTarihi");
                RandevuTarihi.Value = dr["RandevuTarihi"].ToString();

                XmlAttribute Saat = xmldoc.CreateAttribute("Saat");
                Saat.Value = dr["Saat"].ToString();


                randevu.Attributes.Append(RandevuTarihi);
                randevu.Attributes.Append(Saat);
                
                root.AppendChild(randevu);


            }
            conn.Close();
            xmldoc.AppendChild(root);
            xmldoc.Save("rveri.xml");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Faturalar");
            SqlCommand cmd = new SqlCommand("select* from Faturalar", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                XmlElement fatura = xmldoc.CreateElement("FaturaBilgi");

                XmlAttribute Odeme = xmldoc.CreateAttribute("Odeme");
                Odeme.Value = dr["Odeme"].ToString();


                fatura.Attributes.Append(Odeme);
               

                root.AppendChild(fatura);


            }
            conn.Close();
            xmldoc.AppendChild(root);
            xmldoc.Save("fveri.xml");
        }
    }
}
