using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class DetallesVenta
    {
        public int ID_Detalle { get; set; }
        public int Cantidad { get; set; }

        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public double Importe { get; set; }

        public int ID_Venta { get; set; }
        public int ID_Producto { get; set; }

        public DetallesVenta(int id_detalle, int cantidad,
                    string descripcion, double precio, double importe, int id_venta, int id_producto)
        {
            ID_Detalle = id_detalle;
            Cantidad = cantidad;
            Descripcion = descripcion;
            Importe = importe;
            Precio = precio;
            ID_Venta = id_venta;
            ID_Producto = id_producto;
            //StockProducto = stockProducto;
        }

        public DetallesVenta()
        {
        }

        public override bool Equals(object obj)
        {
            var venta = obj as Venta;
            return venta != null &&
                 ID_Venta == venta.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID_Venta.GetHashCode();
        }

        public override string ToString()
        {
            return "\nID_Venta: " + ID_Venta + "\nID_Producto" + ID_Producto;
        }
    
    
    }
}
