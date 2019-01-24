using PuntoDeVenta.Clases_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PuntoDeVenta.Forms.OpcionUsuarios
{
    public partial class FormModificarUsuariosGen : Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
       public int id;
        public FormModificarUsuariosGen()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconoCerrarModifUsuariosGen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconoCerrarModifUsuariosGen_MouseHover(object sender, EventArgs e)
        {
            iconoCerrarModifUsuariosGen.BackColor = Color.IndianRed;
        }

        private void iconoCerrarModifUsuariosGen_MouseLeave(object sender, EventArgs e)
        {
            iconoCerrarModifUsuariosGen.BackColor = Color.WhiteSmoke;
        }

        private void botonConfirmarModifUsuariosGen_Click(object sender, EventArgs e)
        {
            int modificado = 0;
            if (txtBoxNombreModif.Text != "" && txtBoxContraModif.Text != "") {
                string nombre = txtBoxNombreModif.Text;
                string contraseña = Convert.ToString(txtBoxContraModif.Text);

                modificado = Clases_DAO.UsuariosDAO.Actualizarusuario(id, nombre, contraseña);
            }
            if (modificado > 0)
            {

                MessageBox.Show("El producto fue Modificado con Exito");
                MainMenuUsuarios.tablaUsuariosGenerales.DataSource = Clases_DAO.UsuariosDAO.leerTodo();
                this.Close();

            }
            else
            {
                MessageBox.Show("Error, hacen falta campos por llenar");
            }
        }

        private void txtBoxNombreModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }

        private void txtBoxContraModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }

        private void FormModificarUsuariosGen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
