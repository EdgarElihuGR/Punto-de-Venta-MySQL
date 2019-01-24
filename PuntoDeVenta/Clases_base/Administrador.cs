using PuntoDeVenta.Clases_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases_base
{
    class Administrador : Usuario
    {
        private UsuariosDAO objDato = new UsuariosDAO();

        public Administrador IniciarSesion()
        {
            Administrador admin = new Administrador();
            admin = UsuariosDAO.IniciarSesionAdmin(Nombre, Contraseña);
            return admin;
        }

        public Administrador(int ID, string Nombre, string Contraseña, string Tipo) : base(ID,Nombre,Contraseña,Tipo)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Contraseña = Contraseña;
            this.Tipo = Tipo;
        }

        public Administrador()
        {

        }


    }
}
