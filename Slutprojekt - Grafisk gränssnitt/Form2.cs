using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slutprojekt___Grafisk_gränssnitt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listBox1.Items.Add(100);
            listBox1.Items.Add(200);
            listBox1.Items.Add(500);
            listBox1.Items.Add(1000);
            listBox1.SelectedItem = listBox1.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;

            label3.Text = textBox1.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.f3.Läggtill(textBox1.Text.ToString() + ":");
            Class1.f3.Läggtill(listBox1.SelectedItem.ToString() + " kr");

            label3.Text = "";
            textBox1.Text = "";
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            DialogResult result;
            result = MessageBox.Show("Vill du fortsätta till startsida?", "Fråga", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                f1.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Vill du fortsätta till historik?", "Fråga", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Class1.f3.Show();
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
