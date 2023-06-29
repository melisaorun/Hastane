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
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FRandevular.Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anasayfa sec = new Anasayfa();
            sec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            randevular.RandevuTarihi = dateTimePicker1.Value;
            randevular.Saat = comboBox1.Text;
            randevular.DoktorNo = Convert.ToInt32(textBox1.Text);
            randevular.HastaNo= Convert.ToInt32(textBox2.Text);
            if (BLRandevular.Yurut(randevular) > 0)
            {
                MessageBox.Show("Basarılı Kayıt");
            }
            else
            {
                MessageBox.Show("Basarısız Kayıt");
            }
            dataGridView1.DataSource = FRandevular.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            randevular.RandevuNo = Convert.ToInt32(textBox5.Text);
            randevular.RandevuTarihi = dateTimePicker1.Value;
            randevular.Saat = comboBox1.Text;
            randevular.DoktorNo = Convert.ToInt32(textBox1.Text);
            randevular.HastaNo = Convert.ToInt32(textBox2.Text);
            if (!FRandevular.Guncelle(randevular))
            {
                MessageBox.Show("Basarısız");
            }

            dataGridView1.DataSource = FRandevular.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            randevular.RandevuNo = Convert.ToInt32(textBox5.Text);
            if (!FRandevular.Sil(randevular))
            {
                MessageBox.Show("Basarısız");
            }
            dataGridView1.DataSource = FRandevular.Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            randevular.HastaNo = Convert.ToInt32(textBox1.Text);
            dataGridView1.DataSource =FRandevular.Ara(randevular);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox5.Tag = satir.Cells["RandevuNo"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["RandevuTarihi"].Value.ToString();
            comboBox1.Text = satir.Cells["Saat"].Value.ToString();
            textBox1.Text = satir.Cells["HastaNo"].Value.ToString();
            textBox2.Text = satir.Cells["DoktorNo"].Value.ToString();
        }
    }
}
