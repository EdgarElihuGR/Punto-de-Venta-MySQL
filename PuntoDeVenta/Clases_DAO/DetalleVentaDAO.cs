﻿using MySql.Data.MySqlClient;
using PuntoDeVenta.Conexion_MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases_DAO
{
    class DetalleVentaDAO
    {
        public static int eliminarDetalleVenta(int id)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("DELETE FROM detalleventas where id_detalle = '{0}'", id), ConectorMySQL.Conectar());
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
        public static List<DetallesVenta> leerDetalleVenta(int id) // buscar
        {
            List<DetallesVenta> listaBuscar = new List<DetallesVenta>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from detalleventas where id_venta = '{0}'", id), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer1 = comando.ExecuteReader();

                while (leer1.Read())
                {
                    DetallesVenta p = new DetallesVenta();
                    p.ID_Detalle = leer1.GetInt32(0);
                    p.Cantidad = leer1.GetInt32(1);
                    p.Descripcion = leer1.GetString(2);
                    p.Precio = leer1.GetDouble(3);
                    p.Importe = leer1.GetDouble(4);
                    p.ID_Producto = leer1.GetInt32(5);
                    p.ID_Venta = leer1.GetInt32(6);

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

        public static DetallesVenta leerDetalleVentaUna(int id) // buscar
        {
            DetallesVenta p = new DetallesVenta();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from detalleventas where Id_Detalle = '{0}'", id), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer1 = comando.ExecuteReader();

                while (leer1.Read())
                {
                    p.ID_Detalle = leer1.GetInt32(0);
                    p.Cantidad = leer1.GetInt32(1);
                    p.Descripcion = leer1.GetString(2);
                    p.Precio = leer1.GetDouble(3);
                    p.Importe = leer1.GetDouble(4);
                    p.ID_Producto = leer1.GetInt32(5);
                    p.ID_Venta = leer1.GetInt32(6);
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
        public static int crear(DetallesVenta add) // agregar
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into detalleventas(Cantidad,descripcion,precio,Importe,id_producto,id_venta)values('{0}','{1}','{2}','{3}','{4}','{5}')",
                add.Cantidad, add.Descripcion, add.Precio, add.Importe, add.ID_Producto,add.ID_Venta), ConectorMySQL.Conectar());// el 9 de arriba es el id venta tiene que ser el mismo que crea al hacer la venta
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

        public static List<DetallesVenta> leerTodo() // mostrar
        {
            List<DetallesVenta> lista = new List<DetallesVenta>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from detalleventas"), ConectorMySQL.Conectar());

            try
            {
                MySqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {

                    DetallesVenta d = new DetallesVenta();
                    d.ID_Detalle = leer.GetInt32(0);
                    d.Cantidad = leer.GetInt32(1);
                    d.Descripcion = leer.GetString(2);
                    d.Precio = leer.GetDouble(3);
                    d.Importe = leer.GetDouble(4);
                    d.ID_Venta = leer.GetInt32(5);

                    lista.Add(d);
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

        public static void ActualizarStockDetalle(int id, int stock, double precio)
        {
            double importe = 0;

            importe = stock * precio;
            MySqlCommand comando = new MySqlCommand(String.Format(" UPDATE detalleventas SET Cantidad = '{0}', importe = '{1}' WHERE Id_Detalle = '{2}'", stock, importe, id), ConectorMySQL.Conectar());
            try

            {
                comando.ExecuteNonQuery();
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

        public static List<DetallesVenta> leerPordescripcion(string descripcion) // buscar
        {
            List<DetallesVenta> listaBuscar = new List<DetallesVenta>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from detalleventas where descripcion = '{0}'", descripcion), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer1 = comando.ExecuteReader();

                while (leer1.Read())
                {
                    DetallesVenta d = new DetallesVenta();
                    d.ID_Detalle = leer1.GetInt32(0);
                    d.Cantidad = leer1.GetInt32(1);
                    d.Descripcion = leer1.GetString(2);
                    d.Precio = leer1.GetDouble(3);
                    d.Importe = leer1.GetDouble(4);
                    listaBuscar.Add(d);
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
    }
}