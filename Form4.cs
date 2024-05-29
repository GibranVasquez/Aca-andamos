using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close(); 

            string contraseña = textContra.Text;
            string confContraseña = textConfContra.Text;
            string gmail = textGmail.Text;

            
            string cadenaConexion = "Server=127.0.0.1;Database=dbdeltaparking;User ID=root;Password=;";

            string data = string.Empty;

            try
            {
                using (MySqlConnection conexionBD = new MySqlConnection(cadenaConexion))
                {
                    string consulta = "SHOW DATABASES";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                    {
                        conexionBD.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data += reader.GetString(0) + "\n";
                            }
                        }
                    }
                }

                MessageBox.Show(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
