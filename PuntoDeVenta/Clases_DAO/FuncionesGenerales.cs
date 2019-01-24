using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Clases_DAO
{
    class FuncionesGenerales
    {
        public static void abrirFormInPanel(object formHijo, Panel panelContenedor)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(fh);
            panelContenedor.Tag = fh;
            fh.Show();
        }

        public void SoloLetrasYNumeros(KeyPressEventArgs e) {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tecla ingresada no válida");
            }
        }

        public void SoloNumerosEnteros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tecla ingresada no válida");
            }
        }

        public void SoloNumerosEnterosYPunto(KeyPressEventArgs e, TextBox textBox)
        {
            try
            {
                if (e.KeyChar >= 46 && e.KeyChar <= 57)
                {
                    if (e.KeyChar != 47 && e.KeyChar >=48) {
                        e.Handled = false;
                    }
                    else
                    {
                        string data = textBox.Text;
                        for (int i = 0; i<data.Length; i++)
                        {
                            if (data.Contains("."))
                            {
                                e.Handled = true;
                            }
                        }
                    }
                    
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {
                MessageBox.Show("Tecla ingresada no válida");
            }
        }
    }
}
