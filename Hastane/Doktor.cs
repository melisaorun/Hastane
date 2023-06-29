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
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FDoktorlar.Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anasayfa sec = new Anasayfa();
            sec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktorlar doktorlar = new Doktorlar();
            doktorlar.TC = Convert.ToInt32(textBox1.Text);
            doktorlar.AdiSoyadi = textBox2.Text;
            doktorlar.DogumTarihi = dateTimePicker1.Value;
            doktorlar.Cinsiyet = comboBox2.Text;
            doktorlar.Telefon = Convert.ToInt32(textBox4.Text);
            doktorlar.UzmanlikAlani = comboBox1.Text;
            if (BLDoktorlar.Yurut(doktorlar) > 0)
            {
                MessageBox.Show("Basarılı Kayıt");
            }
            else
            {
                MessageBox.Show("Basarısız Kayıt");
            }
            dataGridView1.DataSource = FDoktorlar.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doktorlar doktorlar = new Doktorlar();
            doktorlar.DoktorNo = Convert.ToInt32(textBox5.Text);
            doktorlar.TC = Convert.ToInt32(textBox1.Text);
            doktorlar.AdiSoyadi = textBox2.Text;
            doktorlar.DogumTarihi = dateTimePicker1.Value;
            doktorlar.Cinsiyet = comboBox2.Text;
            doktorlar.Telefon = Convert.ToInt32(textBox4.Text);
            doktorlar.UzmanlikAlani = comboBox1.Text;
            if (!FDoktorlar.Guncelle(doktorlar))
            {
                MessageBox.Show("Basarısız");
            }
            dataGridView1.DataSource = FDoktorlar.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doktorlar doktorlar = new Doktorlar();
            doktorlar.DoktorNo = Convert.ToInt32(textBox5.Text);
            if (!FDoktorlar.Sil(doktorlar))
            {
                MessageBox.Show("Basarısız");
            }
            dataGridView1.DataSource = FDoktorlar.Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Doktorlar doktorlar = new Doktorlar();
            doktorlar.AdiSoyadi = textBox2.Text;
            dataGridView1.DataSource = FDoktorlar.Ara(doktorlar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox5.Tag = satir.Cells["DoktorNo"].Value.ToString();
            textBox1.Text = satir.Cells["TC"].Value.ToString();
            textBox2.Text = satir.Cells["AdiSoyadi"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["DogumTarihi"].Value.ToString();
            comboBox2.Text = satir.Cells["Cinsiyet"].Value.ToString();
            textBox4.Text = satir.Cells["Telefon"].Value.ToString();
            comboBox1.Text = satir.Cells["UzmanlikAlani"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
