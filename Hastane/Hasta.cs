using Business;
using Entity;
using Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void Hasta_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anasayfa sec = new Anasayfa();
            sec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FHastalar.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hastalar hastalar = new Hastalar();
            hastalar.TC = Convert.ToInt32(textBox1.Text);
            hastalar.AdSoyad = textBox2.Text;
            hastalar.DogumTarihi = dateTimePicker1.Value;
            hastalar.Cinsiyet = comboBox2.Text;
            hastalar.Telefon = Convert.ToInt32(textBox4.Text);
            hastalar.SosyalGuvenlik = comboBox1.Text;
            if (BLHastalar.Yurut(hastalar) > 0)
            {
                MessageBox.Show("Basarılı Kayıt");
            }
            else
            {
                MessageBox.Show("Basarısız Kayıt");
            }
            dataGridView1.DataSource = FHastalar.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hastalar hastalar = new Hastalar();
            hastalar.HastaNo = Convert.ToInt32(textBox5.Text);
            hastalar.TC = Convert.ToInt32(textBox1.Text);
            hastalar.AdSoyad = textBox2.Text;
            hastalar.DogumTarihi = dateTimePicker1.Value;
            hastalar.Cinsiyet = comboBox2.Text;
            hastalar.Telefon = Convert.ToInt32(textBox4.Text);
            hastalar.SosyalGuvenlik = comboBox1.Text;
            if (!FHastalar.Guncelle(hastalar))
            {
                MessageBox.Show("Basarısız");
            }
            dataGridView1.DataSource = FHastalar.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hastalar hastalar = new Hastalar();
            hastalar.HastaNo = Convert.ToInt32(textBox5.Text);
            if (!FHastalar.Sil(hastalar))
            {
                MessageBox.Show("Basarısız");
            }
            dataGridView1.DataSource = FHastalar.Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hastalar hastalar = new Hastalar();
            hastalar.TC = Convert.ToInt32(textBox1.Text);
            dataGridView1.DataSource = FHastalar.Ara(hastalar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox5.Tag = satir.Cells["HastaNo"].Value.ToString();
            textBox1.Text = satir.Cells["TC"].Value.ToString();
            textBox2.Text = satir.Cells["AdSoyad"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["DogumTarihi"].Value.ToString();
            comboBox2.Text = satir.Cells["Cinsiyet"].Value.ToString();
            textBox4.Text = satir.Cells["Telefon"].Value.ToString();
            comboBox1.Text = satir.Cells["SosyalGuvenlik"].Value.ToString();
        }
    }
}
