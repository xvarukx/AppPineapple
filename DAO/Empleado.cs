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
    public class Empleado
    {
        static public Entidades.Empleado buscarEmpleado(string id) {
            Entidades.Empleado c = new Entidades.Empleado();
            Conexion.OpenConnection();

            string query = "Select* from empleado Where cedula = @cedula";
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
                c.Puesto = reader.GetString("puesto");
                c.FechaContratacion = reader.GetDateTime("fechaContratacion");
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

            string query = "Select cedula from empleado Where cedula LIKE @id or nombre LIKE @id or apellido LIKE @id";
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

        static public DataTable buscarEmpleadoTabla(string busqueda) {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();

            string query = "call pina.buscarEmpleado(@busqueda)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@busqueda", "%"+busqueda+"%");
            comando.Prepare();

            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }


        static public void eliminar(Entidades.Empleado c)
        {
            Conexion.OpenConnection();

            string query = "DELETE from empleado WHERE cedula = @cedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@cedula", c.Celuda);
            comando.Prepare();

            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void insertar(Entidades.Empleado c)
        {
            Conexion.OpenConnection();

            string query = "insert into Empleado (cedula, nombre, apellido, apellido2, telefono, fechaContratacion, puesto) values(@cedula, @nombre, @apellido, @apellido2, @telefono, @fechaContratacion, @puesto)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);


            comando.Parameters.AddWithValue("@cedula", c.Celuda);
            comando.Parameters.AddWithValue("@nombre", c.Nombre);
            comando.Parameters.AddWithValue("@apellido", c.Apellido);
            comando.Parameters.AddWithValue("@apellido2", c.Apellido2);
            comando.Parameters.AddWithValue("@telefono", c.Telefono);
            comando.Parameters.AddWithValue("@fechaContratacion", c.FechaContratacion);
            comando.Parameters.AddWithValue("@puesto", c.Puesto);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void modificar(Entidades.Empleado c)
        {
            Conexion.OpenConnection();

            string query = "UPDATE empleado set nombre = @nombre, apellido = @apellido, apellido2 = @apellido2, telefono = @telefono, fechaContratacion = @fechaContratacion, puesto =  @puesto WHERE cedula = @cedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@cedula", c.Celuda);
            comando.Parameters.AddWithValue("@nombre", c.Nombre);
            comando.Parameters.AddWithValue("@apellido", c.Apellido);
            comando.Parameters.AddWithValue("@apellido2", c.Apellido2);
            comando.Parameters.AddWithValue("@telefono", c.Telefono);
            comando.Parameters.AddWithValue("@fechaContratacion", c.FechaContratacion);
            comando.Parameters.AddWithValue("@puesto", c.Puesto);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
    }
}

