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

namespace PuntoDeVenta.Forms.VentanasBase
{
    public partial class FormMostrarProductos : Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
        public FormMostrarProductos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void iconoCerrarProductosAVender_MouseHover(object sender, EventArgs e)

        {
            iconoCerrarProductosAVender.BackColor = Color.IndianRed;
        }

        private void iconoCerrarProductosAVender_MouseLeave(object sender, EventArgs e)
        {
            iconoCerrarProductosAVender.BackColor = Color.WhiteSmoke;
        }

        private void iconoCerrarProductosAVender_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarProdV_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxBuscarVenta.Text)) // validar que no existan cambos vacios
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else
            {
                tablaMostrarProductos.ClearSelection();
                tablaMostrarProductos.DataSource = Clases_DAO.ProductosDAO.leerPordescripcion(txtBoxBuscarVenta.Text);
            }
        }

        private void FormMostrarProductos_Load(object sender, EventArgs e)
        {
            tablaMostrarProductos.DataSource = Clases_DAO.ProductosDAO.leerTodo();
            tablaMostrarProductos.Columns[0].Visible = false;
        }

        private void botonAgregarProdAVender_Click(object sender, EventArgs e)
        {
            if (tablaMostrarProductos.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaMostrarProductos.CurrentRow.Cells[0].Value);
                string descripcion = Convert.ToString(tablaMostrarProductos.CurrentRow.Cells[1].Value);
                int stock = Convert.ToInt32(tablaMostrarProductos.CurrentRow.Cells[2].Value);
                double precio = Convert.ToDouble(tablaMostrarProductos.CurrentRow.Cells[3].Value);
                int cantidad = Convert.ToInt32(Cantidad.Text);
                if (cantidad <= stock && cantidad != 0)
                {
                    int nuevotock = stock - cantidad;

                    Clases_DAO.VentasDAO.ActualizarStock(id, nuevotock); 

                    VentanaBase v = Owner as VentanaBase; // Reconoce la ventana padre a la hijo
                   
                    double importe = cantidad * precio;
                    v.tablaHacerVentas.Rows.Add(id,nuevotock,cantidad, descripcion, precio, importe);
                    double subtotal=0;

                    foreach (DataGridViewRow row in v.tablaHacerVentas.Rows) // Suma el importe
                    {
                        subtotal += Convert.ToDouble(row.Cells["Column4"].Value);
                    }
                    v.labelSubtotal.Text = Convert.ToString(subtotal);
                    double iva = subtotal * .16;
                    v.labelIVA.Text=Convert.ToString( iva );
                    double total = subtotal + iva;
                    v.labelTotal.Text = Convert.ToString(total);
                    
                    this.Close();
                }
                else if (cantidad == 0)
                {
                    
                }
                else
                {
                    MessageBox.Show("No se cuenta con el Stock suficiente");
                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }

        }

        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumerosEnteros(e);
        }

        private void FormMostrarProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtBoxBuscarVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }
    }
}
   
