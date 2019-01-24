using PuntoDeVenta.Clases_DAO;
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

namespace PuntoDeVenta.Forms.OpcionInventario
{
    public partial class FormModificarProd : Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
        public int id;
        public FormModificarProd()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconoCerrarModiProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconoCerrarModiProd_MouseHover(object sender, EventArgs e)
        {
            iconoCerrarModiProd.BackColor = Color.IndianRed;
        }

        private void iconoCerrarModiProd_MouseLeave(object sender, EventArgs e)
        {
            iconoCerrarModiProd.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormModificarProd_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConfirmarModifProd_Click(object sender, EventArgs e)
        {
            int modificado = 0;
            if (txtBoxStockModif.Text != "" && txtBoxDescripModif.Text != "" && txtBoxPrecioModif.Text != "") {
                int stock = Convert.ToInt32(txtBoxStockModif.Text);
                string descripcion = txtBoxDescripModif.Text;
                double precio = Convert.ToDouble(txtBoxPrecioModif.Text);

                modificado = Clases_DAO.ProductosDAO.ActualizarStock(id, descripcion, stock, precio);
            }
            if (modificado > 0)
            {

                MessageBox.Show("El producto fue modificado con éxito");
                MainMenuInventario.tablaProductos.DataSource = Clases_DAO.ProductosDAO.leerTodo();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Error, hacen falta campos por llenar");
            }
        }

        private void txtBoxPrecioModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumerosEnterosYPunto(e,txtBoxPrecioModif);
        }

        private void txtBoxStockModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumerosEnteros(e);
        }

        private void txtBoxDescripModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }

        private void FormModificarProd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
