using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI_MODERNISTA
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        static string conexion = "server=127.0.0.1;port=3306;database=dbdeltaparking;UID=root;PASSWORDS=;";
        MySqlConnection conectado = new MySqlConnection(conexion); 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario1<Form4>();
            button2.BackColor = Color.FromArgb(12, 61, 92);
            AbrirFormulario1<Form7>();
            AbrirFormulario1<Form3>();
            AbrirFormulario1<Form5>();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario1<Form3>();
            button4.BackColor = Color.FromArgb(12, 61, 92);
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario1<Form5>();
            button6.BackColor = Color.FromArgb(12, 61, 92);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario1<Form7>();
            button5.BackColor = Color.FromArgb(12, 61, 92);
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }



        public void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelPrincipal.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelPrincipal.Controls.Add(formulario);
                PanelPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
                button2.BackColor = Color.FromArgb(4, 41, 68);
            if(Application.OpenForms["Form2"] == null)
                button4.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                button6.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                button5.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void AbrirFormulario1<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelPrincipal.Controls.OfType<MiForm>().FirstOrDefault();
            // Si el formulario no existe en el panel
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelPrincipal.Controls.Add(formulario);
                PanelPrincipal.Tag = formulario;
                formulario.Show();
            }
            else
            {
                formulario.BringToFront(); // Si el formulario ya existe, solo lo lleva al frente
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
