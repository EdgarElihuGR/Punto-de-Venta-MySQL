using MySql.Data.MySqlClient;
using PuntoDeVenta.Clases_base;
using PuntoDeVenta.Conexion_MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases_DAO
{
    class UsuariosDAO
    {
        public static int crear( UsuarioGeneral add) // agregar
        { 
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into usuarios(nombre,contraseña)values('{0}','{1}')",
                add.Nombre,add.Contraseña), ConectorMySQL.Conectar());
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
        public static List<UsuarioGeneral> leerTodo() // mostrar
        {
            List<UsuarioGeneral> lista = new List<UsuarioGeneral>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from usuarios"), ConectorMySQL.Conectar());

            try
            {

                MySqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {

                    UsuarioGeneral p = new UsuarioGeneral();
                    p.ID = leer.GetInt32(0);
                    p.Nombre = leer.GetString(1);
                    p.Contraseña = leer.GetString(2);
                    p.Tipo = leer.GetString(3);
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
        public static List<UsuarioGeneral> leerPordescripcion(string nombre) // buscar
        {
            List<UsuarioGeneral> listaBuscar = new List<UsuarioGeneral>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from usuarios where nombre = '{0}'", nombre), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    UsuarioGeneral p = new UsuarioGeneral();
                    p.ID = leer.GetInt32(0);
                    p.Nombre = leer.GetString(1);
                    p.Contraseña = leer.GetString(2);
                    p.Tipo = leer.GetString(3);
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

        public static UsuarioGeneral IniciarSesionGeneral(string nombre, string contra)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("select * from usuarios where nombre = '{0}' and contraseña = '{1}'", nombre,contra), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();
                UsuarioGeneral p = new UsuarioGeneral();
                while (leer.Read())
                {
                    p.ID = leer.GetInt32(0);
                    p.Nombre = leer.GetString(1);
                    p.Contraseña = leer.GetString(2);
                    p.Tipo = leer.GetString(3);
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

        public static Administrador IniciarSesionAdmin(string nombre, string contra)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("select * from usuarios where nombre = '{0}' and contraseña = '{1}'", nombre, contra), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();
                Administrador a = new Administrador();
                while (leer.Read())
                {
                    a.ID = leer.GetInt32(0);
                    a.Nombre = leer.GetString(1);
                    a.Contraseña = leer.GetString(2);
                    a.Tipo = leer.GetString(3);
                }
                return a;
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

            MySqlCommand comando = new MySqlCommand(String.Format("DELETE FROM usuarios where id = '{0}'", id), ConectorMySQL.Conectar());
            try
            {
                int eliminado = comando.ExecuteNonQuery();
                return eliminado;
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
        public static UsuarioGeneral obtenerproducto(int id)
        {
            UsuarioGeneral s = new UsuarioGeneral();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from usuarios where id = '{0}'", id), ConectorMySQL.Conectar());
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    s.ID = leer.GetInt32(0);
                    s.Nombre = leer.GetString(1);
                    s.Contraseña = leer.GetString(2);
                    s.Tipo = leer.GetString(3);
                }
                return s;
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
        public static int Actualizarusuario(int id, string nombre, string comtraseña)
        {
            MySqlCommand comando = new MySqlCommand(String.Format(" UPDATE usuarios SET  nombre = '{0}',contraseña = '{1}' WHERE id = '{2}'", nombre, comtraseña, id), ConectorMySQL.Conectar());
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
