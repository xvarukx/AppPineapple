using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Paquete
    {
        static public List<Entidades.Paquete> getPaquete(string id)
        {
            Conexion.OpenConnection();
            List<Entidades.Paquete> l = new List<Entidades.Paquete>();

            string query = "SELECT* from paquete WHERE idPaquete = @id";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@id",id);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.Paquete paquete = new Entidades.Paquete();
                paquete.IdPaquete = reader.GetString("idPaquete");
                paquete.Descripcion = reader.GetString("descripcion");
                l.Add(paquete);
            }
            Conexion.CloseConnection();
            return l;
        }

        static public List<Entidades.Paquete> lista(string id)
        {
            Conexion.OpenConnection();
            List<Entidades.Paquete> l = new List<Entidades.Paquete>();

            string query = "SELECT* from paquete WHERE idPaquete LIKE @id OR descripcion LIKE @id";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@id", "%" + id + "%");
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.Paquete paquete = new Entidades.Paquete();
                paquete.IdPaquete = reader.GetString("idPaquete");
                paquete.Descripcion = reader.GetString("descripcion");
                l.Add(paquete);
            }
            Conexion.CloseConnection();
            return l;
        }

        static public void insertar(Entidades.Paquete p)
        {
            Conexion.OpenConnection();

            string query = "insert INTO paquete (idPaquete, descripcion) VALUES(@idPaquete, @descripcion)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idPaquete", p.IdPaquete);
            comando.Parameters.AddWithValue("@descripcion", p.Descripcion);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void editar(Entidades.Paquete p)
        {
            Conexion.OpenConnection();

            string query = "UPDATE tractor set descripcion = @descripcion WHERE idPaquete = @idPaquete";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idPaquete", p.IdPaquete);
            comando.Parameters.AddWithValue("@descripcion", p.Descripcion);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void eliminar(string p) 
        {
            try
            {
                Conexion.OpenConnection();

                MySqlCommand comando = new MySqlCommand("eliminarEtapa", Conexion.Connection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_etapa", p);
                comando.Prepare();
                comando.ExecuteNonQuery();

                Conexion.CloseConnection();
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
        }


    }
}
