using PuntoDeVenta.Forms;
using PuntoDeVenta.Forms.VentanasBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Forms
{
    public partial class VentanaBase : Form
    {
        FormMostrarProductos frmMostrarProductos;
        public VentanaBase()
        {
            InitializeComponent();

        }

        private void botonVerProductos_Click(object sender, EventArgs e)
        {
            frmMostrarProductos = new FormMostrarProductos();
            AddOwnedForm(frmMostrarProductos);
            frmMostrarProductos.Show();
            btnCancelarVenta.Visible = true;
            lblCancelarVenta.Visible = true;
            Form1.botonInventario.Enabled = false;
            Form1.botonVentas.Enabled = false;
            Form1.botonUsuarios.Enabled = false;
            Form1.button1.Enabled = false;
            Form1.iconoCerrar.Enabled = false;

            Form1.botonInventario.BackColor = Color.LightGray;
            Form1.botonVentas.BackColor = Color.LightGray;
            Form1.botonUsuarios.BackColor = Color.LightGray;
            Form1.button1.BackColor = Color.LightGray;
            Form1.iconoCerrar.BackColor = Color.LightGray;
        }

        private void VentanaBase_Load(object sender, EventArgs e)
        {
            label5.Text =Convert.ToString( DateTime.Now);
        }

        private void tablaHacerVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void botonQuitarProductos_Click(object sender, EventArgs e)
        {
            if (tablaHacerVentas.SelectedRows.Count == 1)
            {

                double subtotal = 0;
                foreach (DataGridViewRow row in tablaHacerVentas.Rows) // suma el importe
                {
                    subtotal += Convert.ToDouble(row.Cells["Column4"].Value);
                }
                labelSubtotal.Text = Convert.ToString(subtotal);
                double iva = subtotal * .16;
                labelIVA.Text = Convert.ToString(iva);
                double total = subtotal + iva;
                labelTotal.Text = Convert.ToString(total);

                
                int id = Convert.ToInt32(tablaHacerVentas.CurrentRow.Cells[0].Value);
                int stock = Convert.ToInt32(tablaHacerVentas.CurrentRow.Cells[1].Value);
                int Cantidad = Convert.ToInt32(tablaHacerVentas.CurrentRow.Cells[2].Value);

                int nuevotock = stock + Cantidad;

                Clases_DAO.VentasDAO.ActualizarStock(id, nuevotock);


                tablaHacerVentas.Rows.RemoveAt(tablaHacerVentas.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }
        }

        private void botonHacerVenta_Click(object sender, EventArgs e)
        {
            if (labelSubtotal.Text != "00.00") {
                DetallesVenta detalle = new DetallesVenta();
                Venta agregar = new Venta();
                agregar.Subtotal = Convert.ToDouble(labelSubtotal.Text);
                agregar.IVA = Convert.ToDouble(labelIVA.Text);
                agregar.Total = Convert.ToDouble(labelTotal.Text);
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                agregar.Efecha = sqlFormattedDate;

                int retorno = Clases_DAO.VentasDAO.crear(agregar);

                agregar = Clases_DAO.VentasDAO.leerPoFecha(agregar.Efecha);

                foreach (DataGridViewRow row in tablaHacerVentas.Rows)
                {
                    detalle.ID_Producto = Convert.ToInt32(row.Cells["idProducto"].Value);
                    detalle.Cantidad = Convert.ToInt32(row.Cells["Column1"].Value);
                    detalle.Descripcion = Convert.ToString(row.Cells["Column2"].Value);
                    detalle.Precio = Convert.ToDouble(row.Cells["Column3"].Value);
                    detalle.Importe = Convert.ToDouble(row.Cells["Column4"].Value);

                    detalle.ID_Venta = agregar.ID;
                    int retornos = Clases_DAO.DetalleVentaDAO.crear(detalle);

                }

                if (retorno > 0)
                {
                    MessageBox.Show("Agregado con éxito");
                    this.Close();
                    Clases_DAO.FuncionesGenerales.abrirFormInPanel(new VentanaBase(), Form1.panelContenedor);
                    Form1.botonInventario.BackColor = Color.LimeGreen;
                    Form1.botonVentas.BackColor = Color.LimeGreen;
                    Form1.botonUsuarios.BackColor = Color.LimeGreen;
                    Form1.button1.BackColor = Color.DimGray;
                    Form1.iconoCerrar.BackColor = Color.LimeGreen;
                    btnCancelarVenta.Visible = false;

                    Form1.botonInventario.Enabled = true;
                    Form1.botonVentas.Enabled = true;
                    Form1.botonUsuarios.Enabled = true;
                    Form1.button1.Enabled = true;
                    Form1.iconoCerrar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Agrega mínimo un producto para poder registrar la venta");
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            int cantidad = 0, idProducto = 0;
            Form1.botonInventario.BackColor = Color.LimeGreen;
            Form1.botonVentas.BackColor = Color.LimeGreen;
            Form1.botonUsuarios.BackColor = Color.LimeGreen;
            Form1.button1.BackColor = Color.DimGray;
            Form1.iconoCerrar.BackColor = Color.LimeGreen;
            frmMostrarProductos.Close();

            if (Program.tipoUsuario == "Administrador")
            {
                Form1.botonInventario.Enabled = true;
                Form1.botonVentas.Enabled = true;
                Form1.botonUsuarios.Enabled = true;
                Form1.button1.Enabled = true;
                Form1.iconoCerrar.Enabled = true;
            }
            else
            {
                Form1.button1.Enabled = true;
                Form1.iconoCerrar.Enabled = true;
                Form1.botonInventario.BackColor = Color.LightGray;
                Form1.botonVentas.BackColor = Color.LightGray;
                Form1.botonUsuarios.BackColor = Color.LightGray;
            }

            foreach (DataGridViewRow row in tablaHacerVentas.Rows)
            {
                Producto p = new Producto();
                idProducto = Convert.ToInt32(row.Cells["idProducto"].Value);
                cantidad = Convert.ToInt32(row.Cells["Column1"].Value);
                p = Clases_DAO.ProductosDAO.obtenerproducto(idProducto);
                cantidad += p.Stock;
                Clases_DAO.VentasDAO.ActualizarStock(idProducto, cantidad);
            }
            btnCancelarVenta.Visible = false;
            lblCancelarVenta.Visible = false;
            Clases_DAO.FuncionesGenerales.abrirFormInPanel(new VentanaBase(), Form1.panelContenedor);
        }
    }
}
