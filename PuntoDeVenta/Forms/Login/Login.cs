using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using PuntoDeVenta.Clases_DAO;

namespace PuntoDeVenta.Forms.Login
{
    public partial class Login : Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Snow;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.LightGray;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.Snow;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLoguear_Click(object sender, EventArgs e)
        {
            UsuarioGeneral usuario = new UsuarioGeneral();
            lblErrorUsuario.Visible = false;
            lblErrorContra.Visible = false;

            if (txtUsuario.Text != "Usuario" && txtContra.Text != "Contraseña")
            {
                lblErrorUsuario.Visible = false;
                lblErrorContra.Visible = false;
                usuario = UsuariosDAO.IniciarSesionGeneral(txtUsuario.Text, txtContra.Text);
                if (usuario.Nombre != null)
                {
                    this.Hide();
                    Form1 inicio = new Form1();
                    Program.tipoUsuario = usuario.Tipo;
                    Program.nombreUsuario = usuario.Nombre;
                    inicio.Show();

                }
                else
                {
                    lblErrorLogin.Text = "Usuario o contraseña inválidas, intente de nuevo";
                    lblErrorLogin.Visible = true;
                    txtContra.Text = "";
                    txtContra_Leave(null, e);
                    txtUsuario.Focus();
                }
            }
            else if (txtUsuario.Text == "Usuario" && txtContra.Text == "Contraseña")
            {
                lblErrorUsuario.Text = "Hace falta ingresar el usuario";
                lblErrorUsuario.Visible = true;
                lblErrorContra.Text = "Hace falta ingresar la contraseña";
                lblErrorContra.Visible = true;
            }
            else if(txtUsuario.Text == "Usuario")
            {
                lblErrorUsuario.Text = "Hace falta ingresar el usuario";
                lblErrorUsuario.Visible = true;
            }
            else if (txtContra.Text == "Contraseña")
            {
                lblErrorContra.Text = "Hace falta ingresar la contraseña";
                lblErrorContra.Visible = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }
    }
}
