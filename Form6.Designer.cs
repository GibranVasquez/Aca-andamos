using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form inicio = new Form6();
            inicio.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Form f = new Form4();
            f.ShowDialog();
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Form home = new Form2();
            home.ShowDialog();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            Form selec = new Form3();
            selec.ShowDialog();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Form itick = new Form5();
            itick.ShowDialog();
        }
    }
}