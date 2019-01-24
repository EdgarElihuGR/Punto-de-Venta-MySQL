using MySql.Data.MySqlClient;
using PuntoDeVenta.Clases_base;
using PuntoDeVenta.Clases_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
   class UsuarioGeneral : Usuario
    {
        private UsuariosDAO objDato = new UsuariosDAO();

        public UsuarioGeneral( int ID, string Nombre, string Contraseña ,string Tipo) : base(ID,Nombre,Contraseña,Tipo)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Contraseña = Contraseña;
            this.Tipo = Tipo;

        }

        public UsuarioGeneral()
        {

        }

        
        public UsuarioGeneral IniciarSesion()
        {
            UsuarioGeneral usuario = new UsuarioGeneral();
            usuario = UsuariosDAO.IniciarSesionGeneral(Nombre,Contraseña);
            return usuario;
        }
    }
}
