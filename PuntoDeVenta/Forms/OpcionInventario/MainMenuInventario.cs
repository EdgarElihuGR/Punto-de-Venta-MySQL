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

namespace PuntoDeVenta.Forms.OpcionInventario
{
    public partial class MainMenuInventario : Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
        public Producto productoseleccionado { set; get; }

        public Producto productosactual { set; get; }
        public MainMenuInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonNuevoProd_Click(object sender, EventArgs e)
        {
            Form frmRegisProd = new FormRegistrarProd();
            frmRegisProd.Show();
        }

        private void botonModificarProd_Click(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaProductos.CurrentRow.Cells[0].Value);

                productoseleccionado = Clases_DAO.ProductosDAO.obtenerproducto(id);


                FormModificarProd frmModifProd = new FormModificarProd();

                if (productoseleccionado != null) //si se selecciona un producto se vaya al txt
                {
                    productosactual = productoseleccionado;

                    frmModifProd.id = id;
                    frmModifProd.txtBoxPrecioModif.Text = Convert.ToString(productosactual.Precio);
                    frmModifProd.txtBoxStockModif.Text = Convert.ToString(productosactual.Stock);
                    frmModifProd.txtBoxDescripModif.Text = productosactual.Descripcion;
                }
                frmModifProd.Show();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");

            }
        }

        private void botonEliminarProd_Click(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaProductos.CurrentRow.Cells[0].Value);

                int eliminado = Clases_DAO.ProductosDAO.eliminar(id);

                if (eliminado > 0)
                {
                    MessageBox.Show("El producto fue eliminado con éxito");
                    MainMenuInventario.tablaProductos.DataSource = Clases_DAO.ProductosDAO.leerTodo();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }    
        }
        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxBuscarProd.Text)) // validar que no existan cambos vacios
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else
            {
                tablaProductos.ClearSelection();
                tablaProductos.DataSource = Clases_DAO.ProductosDAO.leerPordescripcion(txtBoxBuscarProd.Text);
            }
        }
        private void MainMenuInventario_Load(object sender, EventArgs e)
        {
            tablaProductos.DataSource = Clases_DAO.ProductosDAO.leerTodo();
            tablaProductos.Columns[0].Visible = false;
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxBuscarProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }
    }
}
