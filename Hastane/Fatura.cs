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
    public partial class Fatura : Form
    {
        public Fatura()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anasayfa sec = new Anasayfa();
            sec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FFaturalar.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Faturalar faturalar = new Faturalar();
            faturalar.Odeme=comboBox1.Text;
            faturalar.HastaNo = Convert.ToInt32(textBox2.Text);
            if (BLFaturalar.Yurut(faturalar) > 0)
            {
                MessageBox.Show("Basarılı Kayıt");
            }
            else
            {
                MessageBox.Show("Basarısız Kayıt");
            }
            dataGridView1.DataSource = FFaturalar.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Faturalar faturalar = new Faturalar();
            faturalar.FaturaNo = Convert.ToInt32(textBox2.Text);
            faturalar.Odeme = comboBox1.Text;
            faturalar.HastaNo = Convert.ToInt32(textBox2.Text);

            dataGridView1.DataSource = FFaturalar.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Faturalar faturalar = new Faturalar();
            faturalar.FaturaNo = Convert.ToInt32(textBox2.Text);
            if (!FFaturalar.Sil(faturalar))
            {
                MessageBox.Show("Basarısız");
            }
            dataGridView1.DataSource = FFaturalar.Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Faturalar faturalar = new Faturalar();
            faturalar.HastaNo = Convert.ToInt32(textBox4.Text);
            dataGridView1.DataSource = FFaturalar.Ara(faturalar);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Tag = satir.Cells["FaturaNo"].Value.ToString();
            comboBox1.Text = satir.Cells["Odeme"].Value.ToString();
            textBox4.Text = satir.Cells["HastaNo"].Value.ToString();
            
        }
    }
}
