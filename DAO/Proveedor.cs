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
    public class Proveedor
    {
        static public DataTable buscarProveedorTabla(string id)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select idProveedor as 'ID Proveedor',nombre as 'Nombre', descripcion as 'Descripcion', telefono as 'Telefono', correo as 'Correo', direccion as 'Direccion' from proveedor Where idProveedor LIKE @id OR nombre LIKE @id";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@id", "%" + id + "%");
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public Entidades.Proveedor buscarProveedor(string id)
        {
            Conexion.OpenConnection();
            Entidades.Proveedor p = new Entidades.Proveedor();

            string query = "Select* from proveedor Where idProveedor = @id";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@id", id);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                p.Correo = reader.GetString("correo");
                p.Descripcion = reader.GetString("descripcion");
                p.Direccion = reader.GetString("direccion");
                p.IdProvedor = reader.GetString("idProveedor");
                p.Nombre = reader.GetString("nombre");
                p.Telefono = reader.GetString("telefono");
                Conexion.CloseConnection();
                return p;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return p;

        }


        static public void eliminar(Entidades.Proveedor p)
        {
            Conexion.OpenConnection();

            string query = "DELETE from proveedor WHERE idProveedor = @idProveedor";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idProveedor", p.IdProvedor);
            comando.Prepare();

            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void insertar(Entidades.Proveedor p)
        {
            Conexion.OpenConnection();

            string query = "insert into proveedor (idProveedor, nombre, telefono, direccion, correo, descripcion) values(@idProveedor, @nombre, @telefono, @direccion, @correo, @descripcion)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);


            comando.Parameters.AddWithValue("@idProveedor", p.IdProvedor);
            comando.Parameters.AddWithValue("@nombre", p.Nombre);
            comando.Parameters.AddWithValue("@telefono", p.Telefono);
            comando.Parameters.AddWithValue("@direccion", p.Direccion);
            comando.Parameters.AddWithValue("@correo", p.Correo);
            comando.Parameters.AddWithValue("@descripcion", p.Descripcion);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void modificar(Entidades.Proveedor p)
        {
            Conexion.OpenConnection();

            string query = "UPDATE proveedor Set nombre = @nombre, telefono = @telefono, direccion = @direccion , correo = @correo, descripcion = @descripcion WHERE idProveedor = @idProveedor";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idProveedor", p.IdProvedor);
            comando.Parameters.AddWithValue("@nombre", p.Nombre);
            comando.Parameters.AddWithValue("@telefono", p.Telefono);
            comando.Parameters.AddWithValue("@direccion", p.Direccion);
            comando.Parameters.AddWithValue("@correo", p.Correo);
            comando.Parameters.AddWithValue("@descripcion", p.Descripcion);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
    }
}
