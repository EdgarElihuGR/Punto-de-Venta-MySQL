using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases_base
{
    class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Tipo { get; set; }

        public Usuario(int ID, string Nombre, string Contraseña, string Tipo)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Contraseña = Contraseña;
            this.Tipo = Tipo;
        }

        public Usuario()
        {

        }

        public override bool Equals(object obj)
        {
            var usuario = obj as Usuario;
            return usuario != null &&
                   ID == usuario.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }
    }
}
