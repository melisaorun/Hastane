using Facade;
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

namespace Hastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=Hastane;Trusted_Connection=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select* from Kullanicilar where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre", conn);
            komut.Parameters.AddWithValue("KullaniciAdi", textBox1.Text);
            komut.Parameters.AddWithValue("Sifre", textBox2.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı","Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}
