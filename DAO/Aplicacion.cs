using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    static public class Aplicacion 
    {
        static public void eliminar(Entidades.Aplicacion c)
        {
            Conexion.OpenConnection();

            string query = "DELETE from aplicacion WHERE idAplicacion = @idAplicacion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idAplicacion", c.IdAplicacion);
            comando.Prepare();
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
        }

        static public bool buscarAplicacionEtapa(Entidades.Aplicacion c)
        {
            
            Conexion.OpenConnection();

            string query = "select * from detalleaplicacion where idAplicacion =@idAplicacion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idAplicacion", c.IdAplicacion);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Conexion.CloseConnection();
                return true;
            }
            Conexion.CloseConnection();
            return false;
        }
        static public List<Entidades.Aplicacion> lista()
        {
            Conexion.OpenConnection();
            List<Entidades.Aplicacion> l = new List<Entidades.Aplicacion>();
            string query = "SELECT* from aplicacion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.Aplicacion aplicacion = new Entidades.Aplicacion();
                aplicacion.IdAplicacion = reader.GetInt32("idAplicacion");
                aplicacion.Nombre = reader.GetString("nombre");
            
              //  aplicacion.Tipo = reader.GetString("tipo");
                l.Add(aplicacion);
            }
            Conexion.CloseConnection();
            return l;
        }
        static public Entidades.Aplicacion buscarAplicacion(int id)
        {
            Conexion.OpenConnection();
            Entidades.Aplicacion a = new Entidades.Aplicacion();

            string query = "Select * from aplicacion Where idAplicacion = @id";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@id", id);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                a.Nombre = reader.GetString("nombre");
               

                Conexion.CloseConnection();
                return a;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return a;

        }
        static public DataTable buscarTable(string busqueda)
        {

            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "call pina.buscarAplicacion(@busqueda)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;


        }
        static public DataTable mostrarAplicaciones()
        {
         
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("select * from aplicacion", Conexion.Connection);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);
            // Se asigna el DataTable como origen de datos del DataGridView
            // Se cierra la conexión a la base de datos
            Conexion.CloseConnection();
            return dtDatos;


        }

        static public void insertarAplicacion(Entidades.Aplicacion a) {

            Conexion.OpenConnection();

            string query = "insert into aplicacion (nombre) values(@nombre)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@nombre", a.Nombre);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();

        }
        static public void modificarAplicacion(Entidades.Aplicacion a)
        {

            Conexion.OpenConnection();

            string query = "Update aplicacion set nombre = @nombre where idAplicacion = @idAplicacion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@nombre", a.Nombre);
            comando.Parameters.AddWithValue("@idAplicacion", a.IdAplicacion);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();

        }
        
    }

}

