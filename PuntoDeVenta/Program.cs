using PuntoDeVenta.Conexion_MySQL;
using PuntoDeVenta.Forms.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    static class Program
    {
        public static string tipoUsuario;
        public static string nombreUsuario;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Form1());
        }
    }
}
