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
using PuntoDeVenta.Clases_DAO;

namespace PuntoDeVenta.Forms.OpcionVentas
{
    public partial class FormModificarVentas : Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
        public FormModificarVentas()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconoCerrarModifVentas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconoCerrarModifVentas_MouseHover(object sender, EventArgs e)
        {
            iconoCerrarModifVentas.BackColor = Color.IndianRed;
        }

        private void iconoCerrarModifVentas_MouseLeave(object sender, EventArgs e)
        {
            iconoCerrarModifVentas.BackColor = Color.DimGray;
        }

        private void btnEliminarProdEnVenta_Click(object sender, EventArgs e)
        {
            if (tabladetalle.SelectedRows.Count == 1)
            {

                if (MessageBox.Show("¿Estás seguro que quieres eliminar este Producto?", "¡Aviso!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EliminarProductosVenta frmEliminar = new EliminarProductosVenta();
                    frmEliminar.Show();
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }
       }

        private void FormModificarVentas_Load(object sender, EventArgs e)
        {
         
        }

        private void btnBuscarProdEnVentas_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxBuscarProdEnVentas.Text)) // validar que no existan cambos vacios
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else
            {
                tabladetalle.ClearSelection();
                tabladetalle.DataSource = Clases_DAO.ProductosDAO.leerPordescripcion(txtBoxBuscarProdEnVentas.Text);
            }
        }

        private void tabladetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormModificarVentas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtBoxBuscarProdEnVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }
    }
}
