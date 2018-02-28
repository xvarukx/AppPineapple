using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DetalleAplicacion
    {
        static public DataTable listaTable(string idPaquete)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "call buscarDetalle(@idPaquete)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idPaquete", idPaquete);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }



       public static Entidades.DetalleAplicacion buscarForza(Entidades.Seccion s) {

            Conexion.OpenConnection();
            Entidades.DetalleAplicacion paquete = new Entidades.DetalleAplicacion();
            DataTable dtDatos = new DataTable();
            string query = "select * from aplicacion a inner join detalleaplicacion d on a.idAplicacion = d.idAplicacion where d.idPaquete = @idPaquete and a.tipo = 'Forza' and posicion > @posicion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idPaquete", s.Paquete);
            comando.Parameters.AddWithValue("@posicion", s.Posicion);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
            
                paquete.IdPaquete = reader.GetString("idPaquete");
                paquete.IdAplicacion = reader.GetInt32("idAplicacion");
                paquete.Posicion = reader.GetInt32("posicion");
                paquete.Tiempo = reader.GetInt32("tiempo");
                break;
                
            }

            Conexion.CloseConnection();
            return paquete;

        }
        static public List<Entidades.DetalleAplicacion> lista(string idPaquete)
        {
            Conexion.OpenConnection();
            List<Entidades.DetalleAplicacion> l = new List<Entidades.DetalleAplicacion>();

            string query = "SELECT * from detalleaplicacion d inner join aplicacion a on d.idAplicacion = a.idAplicacion WHERE idPaquete = @idPaquete ORDER BY posicion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idPaquete",idPaquete);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.DetalleAplicacion paquete = new Entidades.DetalleAplicacion();
                paquete.IdPaquete = reader.GetString("idPaquete");
                paquete.IdAplicacion = reader.GetInt32("idAplicacion");
                paquete.Posicion = reader.GetInt32("posicion");
                paquete.Tiempo = reader.GetInt32("tiempo");
                paquete.NombreAplicacion = reader.GetString("nombre");
                l.Add(paquete);
            }
            Conexion.CloseConnection();
            return l;
        }
        static public Entidades.DetalleAplicacion getNombreAplicacion(string idPaquete,int posicion)
        {
            Conexion.OpenConnection();
            Entidades.DetalleAplicacion paquete= null ;

            string query = "SELECT * from detalleaplicacion d inner join aplicacion a on d.idAplicacion = a.idAplicacion WHERE idPaquete = @idPaquete and d.posicion = @posicion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idPaquete", idPaquete);
            comando.Parameters.AddWithValue("@posicion", posicion);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                paquete = new Entidades.DetalleAplicacion();
                paquete.IdPaquete = reader.GetString("idPaquete");
                paquete.IdAplicacion = reader.GetInt32("idAplicacion");
                paquete.Posicion = reader.GetInt32("posicion");
                paquete.Tiempo = reader.GetInt32("tiempo");
                paquete.NombreAplicacion = reader.GetString("nombre");
                
            }
            Conexion.CloseConnection();
            return paquete;
        }
        static public Entidades.DetalleAplicacion getDetallePaquete(string idPaquete, string idAplicacion)
        {
            Conexion.OpenConnection();
            Entidades.DetalleAplicacion paquete = new Entidades.DetalleAplicacion(); 

            string query = "SELECT* from paquete WHERE idPaquete = @idPaquete AND idAplicacion = @idAplicacion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idPaquete", idPaquete);
            comando.Parameters.AddWithValue("@idAplicacion", idAplicacion);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                paquete = new Entidades.DetalleAplicacion();
                paquete.IdPaquete = reader.GetString("idPaquete");
                paquete.IdAplicacion = reader.GetInt32("idAplicacion");
                paquete.Posicion = reader.GetInt32("posicion");
                paquete.Tiempo = reader.GetInt32("tiempo");
            }
            Conexion.CloseConnection();
            return paquete;
        }

        static public Entidades.DetalleAplicacion getDetallePaquetePosicion(string idPaquete, int posicion)
        {
            Conexion.OpenConnection();
            Entidades.DetalleAplicacion paquete = new Entidades.DetalleAplicacion();

            string query = "SELECT * from detalleaplicacion WHERE idPaquete = @idPaquete AND posicion = @posicion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idPaquete", idPaquete);
            comando.Parameters.AddWithValue("@posicion", posicion);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                paquete = new Entidades.DetalleAplicacion();
                paquete.IdPaquete = reader.GetString("idPaquete");
                paquete.IdAplicacion = reader.GetInt32("idAplicacion");
                paquete.Posicion = reader.GetInt32("posicion");
                paquete.Tiempo = reader.GetInt32("tiempo");
            }
            Conexion.CloseConnection();
            return paquete;
        }
        static public void insertar(Entidades.DetalleAplicacion p)
        {
            Conexion.OpenConnection();

            string query = "insert INTO detalleaplicacion (idPaquete, idAplicacion, posicion, tiempo) VALUES(@idPaquete, @idAplicacion, @posicion, @tiempo)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idPaquete", p.IdPaquete);
            comando.Parameters.AddWithValue("@idAplicacion", p.IdAplicacion);
            comando.Parameters.AddWithValue("@posicion", p.Posicion);
            comando.Parameters.AddWithValue("@tiempo", p.Tiempo);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
        static public void editar(Entidades.DetalleAplicacion p)
        {
            Conexion.OpenConnection();

            string query = "UPDATE detalleaplicacion SET tiempo = @tiempo WHERE idPaquete = @idPaquete AND idAplicacion = @idAplicacion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idPaquete", p.IdPaquete);
            comando.Parameters.AddWithValue("@idAplicacion", p.IdAplicacion);
            comando.Parameters.AddWithValue("@tiempo", p.Tiempo);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
        static public void eliminar(Entidades.DetalleAplicacion p)
        {
            Conexion.OpenConnection();

            string query = "DELETE FROM detalleaplicacion WHERE idPaquete = @idPaquete, idAplicacion = @idAplicacion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idPaquete", p.IdPaquete);
            comando.Parameters.AddWithValue("@idAplicacion", p.IdAplicacion);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
        static private void eliminarTodos(string idPaquete)
        {
            Conexion.OpenConnection();

            string query = "DELETE FROM detalleaplicacion WHERE idPaquete = @idPaquete";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idPaquete", idPaquete);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }


        static public void Actualizar(string idPaquete, List<Entidades.DetalleAplicacion> l)
        {
            eliminarTodos(idPaquete);
            Entidades.DetalleAplicacion da;
            for (int i = 0; i < l.Count; i++) {
                da = l[i];
                da.Posicion = i;
                insertar(da);
            }
        }

    }
}
