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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void Läggtill(string item)
        {
            listBox2.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            DialogResult result;
            result = MessageBox.Show("Vill du fortsätta till pengarutdrag?", "Fråga", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                f1.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
