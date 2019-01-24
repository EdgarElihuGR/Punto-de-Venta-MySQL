using PuntoDeVenta.Clases_DAO;
using PuntoDeVenta.Conexion_MySQL;
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
using PuntoDeVenta.Forms;
using PuntoDeVenta.Forms.OpcionInventario;
using PuntoDeVenta.Forms.OpcionVentas;
using PuntoDeVenta.Forms.OpcionUsuarios;
using PuntoDeVenta.Forms.Login;

namespace PuntoDeVenta
{
    public partial class Form1 : Form
    {
        public static ProductosDAO productosDAO = new ProductosDAO();
        ConectorMySQL conector = new ConectorMySQL();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            PrivilegioUsuario();
            MostrarUsuarioActivo();
            mostrarVentanaBaseAdmin();
            
        }

        private void PrivilegioUsuario()
        {
            if (Program.tipoUsuario != "Administrador")
            {
                botonInventario.Enabled = false;
                botonInventario.BackColor = Color.LightGray;
                botonVentas.Enabled = false;
                botonVentas.BackColor = Color.LightGray;
                botonUsuarios.Enabled = false;
                botonUsuarios.BackColor = Color.LightGray;
            }
        }

        private void MostrarUsuarioActivo()
        {
            labelTipoUsuario.Text = Program.tipoUsuario;
            labelNombreUsuario.Text = Program.nombreUsuario;
        }

        public void mostrarVentanaBaseAdmin()
        {
            Clases_DAO.FuncionesGenerales.abrirFormInPanel(new VentanaBase(),panelContenedor);
        }

        private void regresarAVentanaBaseAdmin(object sender, FormClosedEventArgs e)
        {
            mostrarVentanaBaseAdmin();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconoMultiTab.Visible = true;
            iconoMaximizar.Visible = false;
        }

        private void iconoMultiTab_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconoMultiTab.Visible = false;
            iconoMaximizar.Visible = true;
        }

        private void iconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraOpciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

        private void iconoCerrar_MouseHover(object sender, EventArgs e)
        {
            iconoCerrar.BackColor = Color.IndianRed;
        }

        private void iconoCerrar_MouseLeave(object sender, EventArgs e)
        {
            iconoCerrar.BackColor = Color.LimeGreen;
        }

        private void iconoMultiTab_MouseHover(object sender, EventArgs e)
        {
            iconoMultiTab.BackColor = Color.LightGreen;
        }

        private void iconoMultiTab_MouseLeave(object sender, EventArgs e)
        {
            iconoMultiTab.BackColor = Color.LimeGreen;
        }

        private void iconoMaximizar_MouseHover(object sender, EventArgs e)
        {
            iconoMaximizar.BackColor = Color.LightGreen;
        }

        private void iconoMaximizar_MouseLeave(object sender, EventArgs e)
        {
            iconoMaximizar.BackColor = Color.LimeGreen;
        }

        private void iconoMinimizar_MouseHover(object sender, EventArgs e)
        {
            iconoMinimizar.BackColor = Color.LightGreen;
        }

        private void iconoMinimizar_MouseLeave(object sender, EventArgs e)
        {
            iconoMinimizar.BackColor = Color.LimeGreen;
        }

        private void botonInventario_Click(object sender, EventArgs e)
        {
            MainMenuInventario frm = new MainMenuInventario();
            frm.FormClosed += new FormClosedEventHandler(regresarAVentanaBaseAdmin);
            Clases_DAO.FuncionesGenerales.abrirFormInPanel(frm,panelContenedor);
        }

        private void botonVentas_Click(object sender, EventArgs e)
        {
            MainMenuVentas frm = new MainMenuVentas();
            frm.FormClosed += new FormClosedEventHandler(regresarAVentanaBaseAdmin);
            Clases_DAO.FuncionesGenerales.abrirFormInPanel(frm, panelContenedor);
        }

        private void botonUsuarios_Click(object sender, EventArgs e)
        {
            MainMenuUsuarios frm = new MainMenuUsuarios();
            frm.FormClosed += new FormClosedEventHandler(regresarAVentanaBaseAdmin);
            Clases_DAO.FuncionesGenerales.abrirFormInPanel(frm, panelContenedor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de cerrar sesión?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form frmLogin = new Login();
                Form1.ActiveForm.Close();
                frmLogin.Show();
            }
        }
    }
}
