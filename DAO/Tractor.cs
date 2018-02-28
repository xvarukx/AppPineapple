using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Tractor
    {
        static public DataTable buscarTractorTabla(string id)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select idTractor AS 'ID Tractor', descripcion AS 'Descripcion', marca AS 'Marca' from tractor Where idTractor LIKE @id or marca LIKE @id or descripcion LIKE @id";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@id", "%"+id+"%");
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }
        static public List<string> listaId(string id) {
            Conexion.OpenConnection();
            List<string> l = new List<string>();

            string query = "Select idTractor from tractor Where idTractor LIKE @id or marca LIKE @id or descripcion LIKE @id";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@id", "%" + id + "%");
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                string s = reader.GetString("idTractor");
                l.Add(s);
            }
            Conexion.CloseConnection();
            return l;
        }

        static public Entidades.Tractor buscarTractor(string id)
        {
            Conexion.OpenConnection();
            Entidades.Tractor t = new Entidades.Tractor();

            string query = "Select* from tractor Where idTractor = @idTractor";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idTractor", id);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                t.Descripcion = reader.GetString("descripcion");
                t.IdTractor = reader.GetString("idTractor");
                t.Marca = reader.GetString("marca");
          
                Conexion.CloseConnection();
                return t;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return t;

        }


        static public void eliminar(Entidades.Tractor t)
        {
            Conexion.OpenConnection();

            string query = "DELETE from tractor WHERE idTractor = @idTractor";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idTractor", t.IdTractor);
            comando.Prepare();

            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void insertar(Entidades.Tractor t)
        {
            Conexion.OpenConnection();

            string query = "insert into tractor (idTractor, marca, descripcion) values(@idTractor, @marca, @descripcion)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idTractor", t.IdTractor);
            comando.Parameters.AddWithValue("@marca",t.Marca);
            comando.Parameters.AddWithValue("@descripcion", t.Descripcion);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void modificar(Entidades.Tractor t)
        {
            Conexion.OpenConnection();

            string query = "UPDATE tractor SET marca = @marca, descripcion = @descripcion WHERE idTractor = @idTractor";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idTractor", t.IdTractor);
            comando.Parameters.AddWithValue("@marca", t.Descripcion);
            comando.Parameters.AddWithValue("@descripcion", t.Marca);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
    }
}
