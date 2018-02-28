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
    public class SprayBoom

    {
        static public DataTable buscarSprayBoomTabla(string id)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Call buscarSpray(@id)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@id", "%"+id+"%");
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public List<string> listaId(string id)
        {
            Conexion.OpenConnection();
            List<string> l = new List<string>();

            string query = "Select idSprayBoom from  SprayBoom Where idSprayBoom LIKE @id";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@id", "%" + id + "%");
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                string s = reader.GetString("idSprayBoom");
                l.Add(s);
            }
            Conexion.CloseConnection();
            return l;
        }

        static public Entidades.SprayBoom buscarSprayBoom(string id)
        {
            Conexion.OpenConnection();
            Entidades.SprayBoom s = new Entidades.SprayBoom();

            string query = "Select* from SprayBoom Where idSprayBoom LIKE @idSprayBoom";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idSprayBoom", id);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                s.Boquilla = reader.GetString("boquilla");
                s.Capacidad = reader.GetDouble("capacidad");
                s.IdSprayBoom = reader.GetString("idSprayBoom");
                s.Km= reader.GetString("km");
                s.Marcha= reader.GetString("marcha");
                s.Metodo = reader.GetString("metodo");
                s.Psi = reader.GetDouble("psi");
                s.Rpm = reader.GetDouble("rpm");
                
                Conexion.CloseConnection();
                return s;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return s;

        }

        static public DataTable Lista()
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select* from sprayboom";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public void eliminar(Entidades.SprayBoom s)
        {
            Conexion.OpenConnection();

            string query = "DELETE from SprayBoom WHERE idSprayBoom = @idSprayBoom";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSprayBoom", s.IdSprayBoom);
            comando.Prepare();

            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void insertar(Entidades.SprayBoom s)
        {
            Conexion.OpenConnection();

            string query = "insert into sprayboom (idSprayBoom, capacidad, psi, rpm, boquilla, km, marcha, metodo) values(@idSprayBoom, @capacidad, @psi, @rpm, @boquilla, @km, @marcha, @metodo)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSprayBoom", s.IdSprayBoom);
            comando.Parameters.AddWithValue("@capacidad", s.Capacidad);
            comando.Parameters.AddWithValue("@psi", s.Psi);
            comando.Parameters.AddWithValue("@rpm", s.Rpm);
            comando.Parameters.AddWithValue("@boquilla", s.Boquilla);
            comando.Parameters.AddWithValue("@km", s.Km);
            comando.Parameters.AddWithValue("@marcha", s.Marcha);
            comando.Parameters.AddWithValue("@metodo", s.Metodo);

            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void modificar(Entidades.SprayBoom s)
        {
            Conexion.OpenConnection();

            string query = "UPDATE sprayboom set capacidad = @capacidad, psi = @psi, rpm = @rpm, boquilla = @boquilla, km = @km, marcha = @marcha, metodo = @metodo WHERE idSprayBoom = @idSprayBoom";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSprayBoom", s.IdSprayBoom);
            comando.Parameters.AddWithValue("@capacidad", s.Capacidad);
            comando.Parameters.AddWithValue("@psi", s.Psi);
            comando.Parameters.AddWithValue("@rpm", s.Rpm);
            comando.Parameters.AddWithValue("@boquilla", s.Boquilla);
            comando.Parameters.AddWithValue("@km", s.Km);
            comando.Parameters.AddWithValue("@marcha", s.Marcha);
            comando.Parameters.AddWithValue("@metodo", s.Metodo);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
    }
}
