using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO
{
    public class Chofer
    {
        static public Entidades.Chofer buscarChofer(string id) {
            Entidades.Chofer c = new Entidades.Chofer();
            Conexion.OpenConnection();

            string query = "Select* from chofer Where cedula = @cedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@cedula", id);
            comando.Prepare();

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                c.Celuda = reader.GetString("cedula");
                c.Nombre = reader.GetString("nombre");
                c.Apellido = reader.GetString("apellido");
                c.Apellido2 = reader.GetString("apellido2");
                c.Telefono = reader.GetString("telefono");
                Conexion.CloseConnection();
                return c;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return c;
        }
        static public List<string> listaId(string id)
        {
            Conexion.OpenConnection();
            List<string> l = new List<string>();

            string query = "Select cedula from chofer Where cedula LIKE @id or nombre LIKE @id or apellido LIKE @id";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@id", "%" + id + "%");
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                string s = reader.GetString("cedula");
                l.Add(s);
            }
            Conexion.CloseConnection();
            return l;
        }

        static public DataTable buscarChoferTabla(string busqueda) {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();

            string query = "call pina.buscarChofer(@busqueda)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@busqueda", "%"+busqueda+"%");
            comando.Prepare();

            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }


        static public void eliminar(Entidades.Chofer c)
        {
            Conexion.OpenConnection();

            string query = "DELETE from chofer WHERE cedula = @cedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@cedula", c.Celuda);
            comando.Prepare();

            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void insertar(Entidades.Chofer c)
        {
            Conexion.OpenConnection();

            string query = "insert into chofer (cedula, nombre, apellido, apellido2, telefono) values(@cedula, @nombre, @apellido, @apellido2, @telefono)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);


            comando.Parameters.AddWithValue("@cedula", c.Celuda);
            comando.Parameters.AddWithValue("@nombre", c.Nombre);
            comando.Parameters.AddWithValue("@apellido", c.Apellido);
            comando.Parameters.AddWithValue("@apellido2", c.Apellido2);
            comando.Parameters.AddWithValue("@telefono", c.Telefono);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void modificar(Entidades.Chofer c)
        {
            Conexion.OpenConnection();

            string query = "UPDATE chofer set nombre = @nombre, apellido = @apellido, apellido2 = @apellido2, telefono = @telefono WHERE cedula = @cedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@cedula", c.Celuda);
            comando.Parameters.AddWithValue("@nombre", c.Nombre);
            comando.Parameters.AddWithValue("@apellido", c.Apellido);
            comando.Parameters.AddWithValue("@apellido2", c.Apellido2);
            comando.Parameters.AddWithValue("@telefono", c.Telefono);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
    }
}

