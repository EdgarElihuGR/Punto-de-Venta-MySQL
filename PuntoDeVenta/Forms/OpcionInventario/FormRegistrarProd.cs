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
using System.Windows.Forms; //Librerías

namespace PuntoDeVenta.Forms.OpcionInventario
{
    public partial class FormRegistrarProd : Form //Clase parcial que hereda de Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
        public FormRegistrarProd() //Método constructor
        {
            InitializeComponent();//Se inicializan los componentes
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconoCerrarRegiProd_Click(object sender, EventArgs e)//Evento, si se hace click en la x de cerrar ventana
        {
            this.Close();//Se cierra la ventana
        }

        private void iconoCerrarRegiProd_MouseHover(object sender, EventArgs e)/*Evento, si se pasa el mouse sobre la x de la
                                                                                ventana*/
        {
            iconoCerrarRegiProd.BackColor = Color.IndianRed;//Se cambia su color de fondo a IndianRed
        }

        private void iconoCerrarRegiProd_MouseLeave(object sender, EventArgs e)/*Evento, si se retira el mouse de la x de la 
                                                                                ventana*/
        {
            iconoCerrarRegiProd.BackColor = Color.WhiteSmoke;//Se cambia su color de fondo a WhiteSmoke
        }

        
        private void botonConfirmarRegisProd_Click_1(object sender, EventArgs e)/*Evento, si se hace click en el botón de
                                                                                 confirmar el registro del producto*/ 
        {
            Producto agregar = new Producto();//Se instancia un nuevo producto
            int retorno = 0;

            if (textBoxStockRegis.Text != "" && textBoxDescripRegis.Text != "" && textBoxPrecioRegis.Text != "") {
                agregar.Stock = Convert.ToInt32(textBoxStockRegis.Text);/*Se le agrega al atributo numStock del producto lo que 
                                                                        está en el textbox #Stock*/

                agregar.Descripcion = textBoxDescripRegis.Text;/*Se le agrega al atributo descripcion del producto lo que 
                                                                        está en el textbox Descripción*/

                agregar.Precio = Convert.ToDouble(textBoxPrecioRegis.Text);/*Se le agrega al atributo precio del producto lo que 
                                                                        está en el textbox Precio*/

                retorno = Clases_DAO.ProductosDAO.crear(agregar);/*Se llama al método crear de la clase estática ProductosDAO,
                                                                  se le pasa como parámetro el producto que creamos y asignamos
                                                                  los atributos y el valor que retorna lo guardamos en una 
                                                                  variable llamada retorno*/
            }

            if (retorno > 0)//Condicionamos si el valor de retorno es mayor a cero 
            {
                MessageBox.Show("Agregado con éxito");
                MainMenuInventario.tablaProductos.DataSource = Clases_DAO.ProductosDAO.leerTodo();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, hacen falta campos por llenar");
            }

        }

        private void textBoxPrecioRegis_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumerosEnterosYPunto(e, textBoxPrecioRegis);
        }

        private void textBoxStockRegis_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumerosEnteros(e);
        }

        private void textBoxDescripRegis_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }

        private void FormRegistrarProd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    }

