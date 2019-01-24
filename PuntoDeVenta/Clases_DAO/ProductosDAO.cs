using MySql.Data.MySqlClient;
using PuntoDeVenta.Conexion_MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases_DAO
{
    public class ProductosDAO
    {
        public static int crear(Producto add) // agregar
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into compras(stock,descripcion,precio)values('{0}','{1}','{2}')",
                add.Stock, add.Descripcion, add.Precio), ConectorMySQL.Conectar());
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

        public static Producto obtenerproducto(int id)
        {
            Producto p = new Producto();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from compras where id = '{0}'", id), ConectorMySQL.Conectar());
            try
            {
            MySqlDataReader read = comando.ExecuteReader();

                while (read.Read())
            {
                p.ID = read.GetInt32(0);
                p.Stock = read.GetInt32(1);
                p.Descripcion = read.GetString(2);
                p.Precio = read.GetDouble(3);
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
        public static int eliminar(int id)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("DELETE FROM compras where id = '{0}'", id), ConectorMySQL.Conectar());
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

        public bool actualizar(object o)
        {
            throw new NotImplementedException();
        }

        public  static List<Producto> leerPordescripcion(string descripcion) // buscar
        {
            List<Producto> listaBuscar = new List<Producto>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from compras where descripcion = '{0}'", descripcion), ConectorMySQL.Conectar());
            try { 
            MySqlDataReader leer1 = comando.ExecuteReader();

            while (leer1.Read())
            {
                Producto p = new Producto();
                p.ID = leer1.GetInt32(0);
                p.Stock = leer1.GetInt32(1);
                p.Descripcion = leer1.GetString(2);
                p.Precio = leer1.GetDouble(3);
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

        public static List<Producto> leerTodo() // mostrar
        {
            List<Producto> lista = new List<Producto>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from compras"), ConectorMySQL.Conectar());

            try
            {
                MySqlDataReader leer = comando.ExecuteReader();
                 while (leer.Read())
                {

                    Producto p = new Producto();
                    p.ID = leer.GetInt32(0);
                    p.Stock = leer.GetInt32(1);
                    p.Descripcion = leer.GetString(2);
                    p.Precio = leer.GetDouble(3);
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
        public static int ActualizarStock(int id, string descripcion, int stock,double precio)
        {
            MySqlCommand comando = new MySqlCommand(String.Format(" UPDATE compras SET  descripcion = '{0}',stock = '{1}',precio='{2}' WHERE id = '{3}'", descripcion, stock, precio, id), ConectorMySQL.Conectar());
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



    }
}
