using System;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form6());
            Application.Run(new Form2());
            Application.Run(new Form3());
            Application.Run(new Form4());
            Application.Run(new Form5());
            
        }

    }
}
