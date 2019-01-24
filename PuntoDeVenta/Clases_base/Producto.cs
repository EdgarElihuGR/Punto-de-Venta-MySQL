using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    public class Producto
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }

        public Producto(string descripcion, int numStock, double precio)
        {
            this.Descripcion = descripcion;
            this.Stock = numStock;
            this.Precio = precio;
        }

        public Producto()
        {

        }

        public override bool Equals(object obj)
        {
            var producto = obj as Producto;
            return producto != null &&
                   ID == producto.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }

        public override string ToString()
        {
            return "\nID: " + ID + "\nDescripción: " + Descripcion + "\n#Stock: " + Stock
                + "\nPrecio: " + Precio;
        }
    }
}
