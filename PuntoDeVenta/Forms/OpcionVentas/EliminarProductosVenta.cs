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
    public partial class EliminarProductosVenta : Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
        Producto producto = new Producto();
        public int cantidad = 0;
        public EliminarProductosVenta()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DetallesVenta detalle = new DetallesVenta();
            int stockSuma = 0, stockResta = 0;
            cantidad = Convert.ToInt32(txtCantidadEliminar.Text);
            int idVenta = Convert.ToInt32(FormModificarVentas.tabladetalle.CurrentRow.Cells[5].Value);
            int idDetalle = Convert.ToInt32(FormModificarVentas.tabladetalle.CurrentRow.Cells[0].Value);
            detalle = Clases_DAO.DetalleVentaDAO.leerDetalleVentaUna(idDetalle);
            producto = Clases_DAO.ProductosDAO.obtenerproducto(detalle.ID_Producto);

            if (cantidad <= detalle.Cantidad) {
                stockResta = detalle.Cantidad - cantidad;
                stockSuma = producto.Stock + cantidad;

                if (cantidad < detalle.Cantidad)
                {
                    int eliminado = Clases_DAO.VentasDAO.ActualizarStock(detalle.ID_Producto, stockSuma);
                    Clases_DAO.DetalleVentaDAO.ActualizarStockDetalle(detalle.ID_Detalle, stockResta, producto.Precio);

                    Clases_DAO.VentasDAO.ActualizarVenta(detalle, producto, cantidad);
                    if (eliminado > 0)
                    {
                        MessageBox.Show("El Producto fue eliminado con éxito");
                        FormModificarVentas.tabladetalle.DataSource = Clases_DAO.DetalleVentaDAO.leerDetalleVenta(idVenta);
                        MainMenuVentas.tablaVentas.DataSource = Clases_DAO.VentasDAO.leerTodo();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    int eliminado = Clases_DAO.VentasDAO.ActualizarStock(detalle.ID_Producto, stockSuma);
                    Clases_DAO.VentasDAO.ActualizarVenta(detalle, producto, cantidad);
                    if (eliminado > 0)
                    {
                        MessageBox.Show("El Producto fue eliminado con éxito");
                        Clases_DAO.DetalleVentaDAO.eliminarDetalleVenta(detalle.ID_Detalle);
                        FormModificarVentas.tabladetalle.DataSource = Clases_DAO.DetalleVentaDAO.leerDetalleVenta(idVenta);
                        MainMenuVentas.tablaVentas.DataSource = Clases_DAO.VentasDAO.leerTodo();
                        if (Clases_DAO.VentasDAO.VentaEnCeros(idVenta))
                        {
                            Clases_DAO.VentasDAO.eliminar(idVenta);
                        }
                        MainMenuVentas.tablaVentas.DataSource = Clases_DAO.VentasDAO.leerTodo();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se existe esa cantidad del producto en la venta");
            }
            this.Dispose();
        }

        private void txtCantidadEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumerosEnteros(e);
        }
    }
}
