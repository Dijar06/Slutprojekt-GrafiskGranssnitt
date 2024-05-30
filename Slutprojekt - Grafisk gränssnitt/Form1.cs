namespace Slutprojekt___Grafisk_gränssnitt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            DialogResult result;
            result = MessageBox.Show("Vill du fortsätta till historik?", "Fråga", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Class1.f3.Show();
                this.Hide();
            }
        }
    }
}