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
    public class Producto
    {
        //Retorna codigo, nombre, unidad y cantidad
        static public DataTable buscarProductoTabla(string busqueda, string tipo)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "call pina.buscarProducto(@busqueda, @tipo)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@busqueda", "%"+busqueda+"%");
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public Entidades.Producto buscarProducto(string id)
        {
            Conexion.OpenConnection();
            Entidades.Producto p = new Entidades.Producto();
            string query = "Select* from producto Where idProducto = @idProducto";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idProducto", id);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                p.Cantidad = reader.GetDouble("cantidad");
                p.Costo = reader.GetDouble("costo");
                p.IdProducto = reader.GetString("idProducto");
                p.IngredienteActivo = reader.GetString("ingredienteActivo");
                p.Maximo = reader.GetDouble("maximo");
                p.Minimo = reader.GetDouble("minimo");
                p.Nombre = reader.GetString("nombre");
                p.Tipo = reader.GetString("tipo");
                p.Unidad = reader.GetString("unidad");
                p.Dias = reader.GetInt32("dias");
                Conexion.CloseConnection();
                return p;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return p;

        }

        static public DataTable Lista()
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select* from producto";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public void eliminar(Entidades.Producto p)
        {
            Conexion.OpenConnection();

            string query = "DELETE from producto WHERE idProducto = @idProducto";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idProducto", p.IdProducto);
            comando.Prepare();

            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void insertar(Entidades.Producto p)
        {
            Conexion.OpenConnection();

            string query = "insert into producto (idProducto, nombre, ingredienteActivo, unidad, cantidad, minimo, maximo, costo, tipo, dias) values(@idProducto, @nombre, @ingredienteActivo, @unidad, @cantidad, @minimo, @maximo, @costo, @tipo, @dias)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idProducto",p.IdProducto);
            comando.Parameters.AddWithValue("@nombre",p.Nombre);
            comando.Parameters.AddWithValue("@ingredienteActivo", p.IngredienteActivo);
            comando.Parameters.AddWithValue("@unidad", p.Unidad);
            comando.Parameters.AddWithValue("@cantidad", p.Cantidad);
            comando.Parameters.AddWithValue("@minimo", p.Minimo);
            comando.Parameters.AddWithValue("@maximo", p.Maximo);
            comando.Parameters.AddWithValue("@costo", p.Costo);
            comando.Parameters.AddWithValue("@tipo", p.Tipo);
            comando.Parameters.AddWithValue("@dias", p.Dias);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void modificar(Entidades.Producto p)
        {
            Conexion.OpenConnection();

            string query = "UPDATE producto SET nombre = @nombre, ingredienteActivo = @ingredienteActivo, unidad = @unidad, cantidad = @cantidad, minimo = @minimo, maximo = @maximo, costo = @costo, tipo = @tipo, dias = @dias WHERE idProducto = @idProducto";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idProducto", p.IdProducto);
            comando.Parameters.AddWithValue("@nombre", p.Nombre);
            comando.Parameters.AddWithValue("@ingredienteActivo", p.IngredienteActivo);
            comando.Parameters.AddWithValue("@unidad", p.Unidad);
            comando.Parameters.AddWithValue("@cantidad", p.Cantidad);
            comando.Parameters.AddWithValue("@minimo", p.Minimo);
            comando.Parameters.AddWithValue("@maximo", p.Maximo);
            comando.Parameters.AddWithValue("@costo", p.Costo);
            comando.Parameters.AddWithValue("@tipo", p.Tipo);
            comando.Parameters.AddWithValue("@dias", p.Dias);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
        static public DataTable mostrarProductos(string busqueda, string tipo)
        {

            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "select idProducto,nombre,ingredienteActivo,unidad, cantidad  from producto where tipo Like @tipo and (idProducto LIKE @busqueda or nombre LIKE @busqueda)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@tipo", "%"+tipo+"%");
            comando.Parameters.AddWithValue("@busqueda", "%"+busqueda+"%");
            comando.Prepare();
            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);
            
            Conexion.CloseConnection();
            return dtDatos;


        }

        static public void supply(string id, double cantidad) {
            Conexion.OpenConnection();
            string query = "UPDATE producto SET cantidad = cantidad + @cantidad WHERE idProducto = @id";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void restarInventario(int idProducto, double totalDosis) {
            Conexion.OpenConnection();
            
            MySqlCommand comando = new MySqlCommand("restarInventario", Conexion.Connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("totalDosis", totalDosis);
            comando.Parameters.AddWithValue("id", idProducto);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
        }

        static public List<Entidades.Notificacion> Notificaciones()
        {
            List<Entidades.Notificacion> l = new List<Entidades.Notificacion>();
            Conexion.OpenConnection();
            string query = "Select* from producto Where cantidad <= minimo";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.Producto p = new Entidades.Producto();
                p.Cantidad = reader.GetDouble("cantidad");
                p.IdProducto = reader.GetString("idProducto");
                p.Nombre = reader.GetString("nombre");
                p.Minimo = reader.GetDouble("minimo");

                Entidades.Notificacion n = new Entidades.Notificacion();
                n.Titulo = "Producto Agotado\n" + "Codigo: "+p.IdProducto + "\nDescripcion: " + p.Nombre;
                n.Contenido = "El producto presenta cantidades\ninferiores a las recomedadas\nen el inventario" + "\nCodigo: " + p.IdProducto + "\nDescripcion: " + p.Nombre+"\nCantidad actual :"+p.Cantidad+"\nCantidad minima recomendada: "+p.Minimo;
                l.Add(n);
            }
            Conexion.CloseConnection();
            return l;
        }
    }
}
