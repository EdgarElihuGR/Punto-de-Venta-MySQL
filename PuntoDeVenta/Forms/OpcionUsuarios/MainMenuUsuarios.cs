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

namespace PuntoDeVenta.Forms.OpcionUsuarios
{
    partial class MainMenuUsuarios : Form
    {
        FuncionesGenerales validaciones = new FuncionesGenerales();
        public UsuarioGeneral usuarioseleccionado { set; get; }

        public UsuarioGeneral usuarioactual { set; get; }
        public MainMenuUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegresarVentanaBase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarUsuariosGen_Click(object sender, EventArgs e)
        {
            Form frmRegisUsuariosGen = new FormRegistrarUsuariosGen();
            frmRegisUsuariosGen.Show();
        }

        private void btnModificarUsuariosGen_Click(object sender, EventArgs e)
        {
            if (tablaUsuariosGenerales.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaUsuariosGenerales.CurrentRow.Cells[0].Value);

                usuarioseleccionado = Clases_DAO.UsuariosDAO.obtenerproducto(id);


                FormModificarUsuariosGen frmModiusuario = new FormModificarUsuariosGen();

                if (usuarioseleccionado != null) //si se selecciona un producto se vaya al txt
                {
                    usuarioactual = usuarioseleccionado;

                    frmModiusuario.id = id;
                    frmModiusuario.txtBoxNombreModif.Text = Convert.ToString(usuarioactual.Nombre);
                    frmModiusuario.txtBoxContraModif.Text = Convert.ToString(usuarioactual.Contraseña);
                    
                }
                frmModiusuario.Show();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");

            }
        }

        private void btnEliminarUsuariosGen_Click(object sender, EventArgs e)
        {
            if (tablaUsuariosGenerales.SelectedRows.Count == 1)
            {
                string tipo = Convert.ToString(tablaUsuariosGenerales.CurrentRow.Cells[3].Value);
                if (tipo != "Administrador") {
                    int id = Convert.ToInt32(tablaUsuariosGenerales.CurrentRow.Cells[0].Value);

                    int eliminado = Clases_DAO.UsuariosDAO.eliminar(id);

                    if (eliminado > 0)
                    {
                        MessageBox.Show("El usuario fue eliminado con éxito");
                        tablaUsuariosGenerales.DataSource = Clases_DAO.UsuariosDAO.leerTodo();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el usuario root");
                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");

            }
  } 
        private void btnBuscarUsuariosGen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxBuscarUsuariosGen.Text)) // validar que no existan cambos vacios
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else
            {
                tablaUsuariosGenerales.ClearSelection();
                tablaUsuariosGenerales.DataSource = Clases_DAO.UsuariosDAO.leerPordescripcion(txtBoxBuscarUsuariosGen.Text);
            }
        }

        private void MainMenuUsuarios_Load(object sender, EventArgs e)
        {
            tablaUsuariosGenerales.DataSource = Clases_DAO.UsuariosDAO.leerTodo();
            tablaUsuariosGenerales.Columns[2].Visible = false;
        }

        private void txtBoxBuscarUsuariosGen_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasYNumeros(e);
        }
    }
}
