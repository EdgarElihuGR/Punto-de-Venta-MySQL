using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class Venta
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }//Para quitar, no uso
 
        public double Subtotal { get; set; }
        public double IVA { get; set; }

        public double Total { get; set; }

        public string Efecha { get; set; }
        public Venta(int id,double subtotal, double IVA, double total ,string Efecha,DateTime fecha)
        {
            this.ID = id;
            this.Efecha = Efecha;
            this.Subtotal = subtotal;
            this.IVA = IVA;
            this.Total = total;

        }

        public Venta()
        {
        }

        public override bool Equals(object obj)
        {
            var venta = obj as Venta;
            return venta != null &&
                   ID == venta.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }

        public override string ToString()
        {
            return "\nID: " + ID + "\nFecha: " + Fecha  + 
                    "\nSubtotal: " + Subtotal + "\nIVA: " +
                    IVA + "\nTotal: " + Total;
        }
    }
}
