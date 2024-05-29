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
            // Cerrar la ventana solo después de completar la operación de base de datos
            // this.Close(); // Comentado para cerrar después de la inserción

            string contraseña = textContra.Text;
            string confContraseña = textConfContra.Text;
            string gmail = textGmail.Text;

            // Cadena de conexión con los datos proporcionados
            string cadenaConexion = "Server=127.0.0.1;Database=dbdeltaparking;User ID=root;Password=;";

            try
            {
                using (MySqlConnection conexionBD = new MySqlConnection(cadenaConexion))
                {
                    conexionBD.Open();

                    // Consulta para insertar datos en la tabla crearcuenta
                    string consulta = "INSERT INTO crearcuenta (Password, ConfirmaPassword, Gmail) VALUES (@contraseña, @confirmar_contraseña, @gmail)";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                    {
                        // Parámetros para evitar SQL Injection
                        comando.Parameters.AddWithValue("@contraseña", contraseña);
                        comando.Parameters.AddWithValue("@confirmar_contraseña", confContraseña);
                        comando.Parameters.AddWithValue("@gmail", gmail);

                        // Ejecutar la consulta
                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar los datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                // Cerrar la ventana después de la inserción
                this.Close();
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
