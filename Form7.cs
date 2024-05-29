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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Cerrar la ventana solo después de completar la operación de base de datos
            // this.Close(); // Comentado para cerrar después de la inserción

            string contraseña = textPassw.Text;
            string gmail = textcorreo.Text;

            // Cadena de conexión con los datos proporcionados
            string cadenaConexion = "Server=127.0.0.1;Database=dbdeltaparking;User ID=root;Password=;";

            try
            {
                using (MySqlConnection conexionBD = new MySqlConnection(cadenaConexion))
                {
                    conexionBD.Open();

                    // Consulta para verificar las credenciales en la tabla iniciosesion
                    string consulta = "SELECT COUNT(*) FROM iniciosesion WHERE Password = @contraseña AND Gmail = @gmail";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                    {
                        // Parámetros para evitar SQL Injection
                        comando.Parameters.AddWithValue("@contraseña", contraseña);
                        comando.Parameters.AddWithValue("@gmail", gmail);

                        // Ejecutar la consulta y obtener el resultado
                        int count = Convert.ToInt32(comando.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Inicio de sesión exitoso.");
                        }
                        else
                        {
                            MessageBox.Show("Credenciales incorrectas. Por favor, intenta nuevamente.");
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
    }
}
