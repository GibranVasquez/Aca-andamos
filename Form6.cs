using System;
using System.Threading;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class Form6 : Form
    {
        private int parkingSpaces = 10; // Espacios disponibles en el estacionamiento

        public Form6()
        {
            InitializeComponent();
            // Inicia el hilo de actualización de espacios de estacionamiento
            Thread updateThread = new Thread(UpdateParkingSpaces);
            updateThread.IsBackground = true; // Para que el hilo se detenga cuando se cierre la aplicación
            updateThread.Start();
        }

        private void UpdateParkingSpaces()
        {
            while (true)
            {
                // Simular proceso de actualización
                Thread.Sleep(5000);
                // Actualizar espacios disponibles en el estacionamiento
                Invoke((MethodInvoker)delegate
                {
                    // Actualizar el texto en algún control de la interfaz de usuario
                    // Supongamos que tienes un control de texto llamado textBox1
                    textBox1.Text = "Espacios disponibles: " + parkingSpaces;
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una cuenta
            Thread accountCreationThread = new Thread(() => CreateAccount("usuario1", "contraseña1"));
            accountCreationThread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Iniciar sesión
            Thread loginThread = new Thread(() => Login("usuario1", "contraseña1"));
            loginThread.Start();
        }

        private void CreateAccount(string username, string password)
        {
            Console.WriteLine("Creando cuenta de usuario...");
            // Simular proceso de creación de cuenta
            Thread.Sleep(2000);
            // Actualizar espacios disponibles en el estacionamiento
            lock (this)
            {
                parkingSpaces--;
                Console.WriteLine("Cuenta creada para el usuario '" + username + "'. Espacios disponibles actualizados: " + parkingSpaces);
            }
        }

        private void Login(string username, string password)
        {
            Console.WriteLine("Iniciando sesión del usuario...");
            // Simular proceso de inicio de sesión
            Thread.Sleep(1500);
            // Actualizar espacios disponibles en el estacionamiento
            lock (this)
            {
                parkingSpaces++;
                Console.WriteLine("Inicio de sesión exitoso para el usuario '" + username + "'. Espacios disponibles actualizados: " + parkingSpaces);
            }
        }
    }
}