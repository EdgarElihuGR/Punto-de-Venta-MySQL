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

namespace PuntoDeVenta.Forms.OpcionVentas
{
    public partial class MainMenuVentas : Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
        public int id_seleccionado {set;get;}
    
        public MainMenuVentas()
        {
            InitializeComponent();
        }

        private void btnRegresarVentanaBase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarVentas_Click(object sender, EventArgs e)
        {
           
            if (tablaVentas.SelectedRows.Count == 1)
            {
               int  id = Convert.ToInt32(tablaVentas.CurrentRow.Cells[0].Value);
                FormModificarVentas d = new FormModificarVentas();
                FormModificarVentas.tabladetalle.DataSource = Clases_DAO.DetalleVentaDAO.leerDetalleVenta(id);
                FormModificarVentas.tabladetalle.Columns[0].Visible = false;
                FormModificarVentas.tabladetalle.Columns[5].Visible = false;
                FormModificarVentas.tabladetalle.Columns[6].Visible = false;
                d.Show();
                   
            } else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }
         }
        private void btnEliminarVentas_Click(object sender, EventArgs e)
        {
            List<DetallesVenta> detalles = new List<DetallesVenta>();
            if (tablaVentas.SelectedRows.Count == 1)
            {

                if (MessageBox.Show("¿Estás seguro que quieres eliminar la venta?", "¡Aviso!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaVentas.CurrentRow.Cells[0].Value);
                    detalles = Clases_DAO.DetalleVentaDAO.leerDetalleVenta(id);

                    foreach (DetallesVenta detalle in detalles)
                    {
                        Producto p = new Producto();
                        p = Clases_DAO.ProductosDAO.obtenerproducto(detalle.ID_Producto);
                        detalle.Cantidad += p.Stock;
                        Clases_DAO.VentasDAO.ActualizarStock(detalle.ID_Producto, detalle.Cantidad);
                    }

                    int eliminado = Clases_DAO.VentasDAO.eliminar(id);
                    if (eliminado > 0)
                    {
                        MessageBox.Show("La venta fue eliminada con éxito");
                        tablaVentas.DataSource = Clases_DAO.VentasDAO.leerTodo();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }
        }

        private void MainMenuVentas_Load(object sender, EventArgs e)
        {
            tablaVentas.DataSource = Clases_DAO.VentasDAO.leerTodo();
            tablaVentas.Columns[5].Visible = false;
        }

        private void btDetalles_Click(object sender, EventArgs e)
        {

            Form frm = new FormModificarVentas();
            frm.Show();
        }

        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxBuscarVentas.Text)) // validar que no existan cambos vacios
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else
            {
                tablaVentas.ClearSelection();
                tablaVentas.DataSource = Clases_DAO.VentasDAO.leerPorid(Convert.ToInt32(txtBoxBuscarVentas.Text));
            }
        }

        private void tablaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxBuscarVentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxBuscarVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumerosEnteros(e);
        }
    }
}
