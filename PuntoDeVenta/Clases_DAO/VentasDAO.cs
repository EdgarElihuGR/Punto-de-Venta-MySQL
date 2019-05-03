using System;
using MySql.Data.MySqlClient;
using PuntoDeVenta.Conexion_MySQL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Clases_DAO
{
    class VentasDAO
    {
        public static int crear(Venta add) // agregar
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("call CrearVenta('{0}','{1}','{2}','{3}')",
                                                    add.Subtotal, add.IVA, add.Total, add.Efecha), ConectorMySQL.Conectar());
            try
            {
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConectorMySQL.Desconectar();
            }

        }
        public static int ActualizarStock(int id, int stock)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("call actualizarStock('{0}','{1}')", stock, id), ConectorMySQL.Conectar());
            try

            {
                int actualizar = comando.ExecuteNonQuery();
                return actualizar;
            }
            catch (Exception)
            {
                return id;
            }
            finally
            {
                ConectorMySQL.Desconectar();
            }
        }
        public static List<Venta> leerTodo() // mostrar
        {
            List<Venta> lista = new List<Venta>();
            MySqlCommand comando = new MySqlCommand(String.Format("call VerVenta ()"), ConectorMySQL.Conectar());

            try
            {
                MySqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {

                    Venta p = new Venta();
                    p.ID = leer.GetInt32(0);
                    p.Subtotal = leer.GetDouble(1);
                    p.IVA = leer.GetDouble(2);
                    p.Total = leer.GetDouble(3);
                    p.Fecha = leer.GetDateTime(4);

                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                ConectorMySQL.Desconectar();
            }
        }




        public static int eliminar(int id)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("call EliminarVenta('{0}')", id), ConectorMySQL.Conectar());
            try
            {
                int eliminado = comando.ExecuteNonQuery();
                return eliminado;
            }
            catch (Exception)
            {
                return id;
            }
            finally
            {
                ConectorMySQL.Desconectar();
            }
        }
        public static List<Venta> leerPorid(int id) // buscar
        {
            List<Venta> listaBuscar = new List<Venta>();
            MySqlCommand comando = new MySqlCommand(String.Format("call buscarVentaId('{0}')", id), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Venta p = new Venta();
                    p.ID = leer.GetInt32(0);
                    p.Subtotal = leer.GetDouble(1);
                    p.IVA = leer.GetDouble(2);
                    p.Total = leer.GetDouble(3);
                    p.Fecha = leer.GetDateTime(4);

                    listaBuscar.Add(p);
                }
                return listaBuscar;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConectorMySQL.Desconectar();
            }
        }

        public static Venta leerPorIDUna(int id) // buscar
        {
            Venta p = new Venta();
            MySqlCommand comando = new MySqlCommand(String.Format("call buscarVentaId('{0}')", id), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    p.ID = leer.GetInt32(0);
                    p.Subtotal = leer.GetDouble(1);
                    p.IVA = leer.GetDouble(2);
                    p.Total = leer.GetDouble(3);
                    p.Fecha = leer.GetDateTime(4);

                }
                return p;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConectorMySQL.Desconectar();
            }
        }

        public static Venta leerPoFecha(string fecha) // buscar
        {
            Venta venta = new Venta();
            MySqlCommand comando = new MySqlCommand(String.Format("call buscarVentaFecha('{0}')", fecha), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    venta.ID = leer.GetInt32(0);
                    venta.Subtotal = leer.GetDouble(1);
                    venta.IVA = leer.GetDouble(2);
                    venta.Total = leer.GetDouble(3);
                    venta.Fecha = leer.GetDateTime(4);
                }
                return venta;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConectorMySQL.Desconectar();
            }
        }

        public static int ActualizarVenta(DetallesVenta detalle, Producto producto, int cantidad)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(String.Format(" call ActualizarVenta('{0}','{1}','{2}')",
                                                    detalle.ID_Venta, producto.Precio, cantidad), ConectorMySQL.Conectar());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error, venta no actualizada");
            }
            finally
            {
                ConectorMySQL.Desconectar();
            }

            return retorno;
        }

        public static bool VentaEnCeros(int id)
        {
            bool retorno = false;

            Venta p = new Venta();
            MySqlCommand comando = new MySqlCommand(String.Format(" call VBuscarId('{0}')", id), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    p.ID = leer.GetInt32(0);
                    p.Subtotal = leer.GetDouble(1);
                    p.IVA = leer.GetDouble(2);
                    p.Total = leer.GetDouble(3);
                    p.Fecha = leer.GetDateTime(4);

                }
                if (p.Subtotal == 0 && p.IVA == 0 && p.Total == 0)
                {
                    retorno = true;
                    return retorno;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConectorMySQL.Desconectar();
            }

            return retorno;
        }
    }
}
