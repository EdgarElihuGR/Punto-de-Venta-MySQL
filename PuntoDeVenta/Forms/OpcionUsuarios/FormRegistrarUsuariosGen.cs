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
    public partial class FormRegistrarUsuariosGen : Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
        public FormRegistrarUsuariosGen()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconoCerrarRegiUsuariosGen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconoCerrarRegiUsuariosGen_MouseHover(object sender, EventArgs e)
        {
            iconoCerrarRegiUsuariosGen.BackColor = Color.IndianRed;
        }

        private void iconoCerrarRegiUsuariosGen_MouseLeave(object sender, EventArgs e)
        {
            iconoCerrarRegiUsuariosGen.BackColor = Color.WhiteSmoke;
        }

        private void botonConfirmarRegisUsuariosGen_Click(object sender, EventArgs e)
        {
            int retorno = 0;
            if (txtBoxNombreRegis.Text != "" && txtContraRegis.Text != "") {
                UsuarioGeneral agregar = new UsuarioGeneral();
                agregar.Nombre = txtBoxNombreRegis.Text;
                agregar.Contraseña = txtContraRegis.Text;
                retorno = Clases_DAO.UsuariosDAO.crear(agregar);
            }

            if (retorno > 0)
            {
                MessageBox.Show("Agregado con éxito");
                MainMenuUsuarios.tablaUsuariosGenerales.DataSource = Clases_DAO.UsuariosDAO.leerTodo();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, hacen falta campos por llenar");
            }
        }

        private void txtBoxNombreRegis_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }

        private void txtContraRegis_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }

        private void FormRegistrarUsuariosGen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
