using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO
{
    public class Usuario 
    {
        static public bool Validar(Entidades.Usuario u) {
            Conexion.OpenConnection();

            string query = "SELECT * FROM usuario WHERE idUsuario= @usuario AND pass = @pass";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            comando.Parameters.AddWithValue("@usuario", u.IdUsuario);
            comando.Parameters.AddWithValue("@pass", u.Pass);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows) {
                Conexion.CloseConnection();
                return true;
            }
            Conexion.CloseConnection();
            return false;
        }

        static public DataTable buscarUsuarioTabla(string id)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select idUsuario as 'ID Usuario',tipo as 'Tipo' from usuario Where idUsuario LIKE @idUsuario";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idUsuario", "%"+id+"%");
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public Entidades.Usuario buscarUsuario(string id)
        {
            Conexion.OpenConnection();
            Entidades.Usuario u = new Entidades.Usuario();

            string query = "Select * from usuario Where idUsuario = @idUsuario";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idUsuario", id);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                u.IdUsuario = reader.GetString("idUsuario");
                u.Pass = reader.GetString("pass");
                u.Tipo = reader.GetString("tipo");
                Conexion.CloseConnection();
                return u;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return u;

        }

        static public DataTable Lista()
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select idUsuario,tipo from usuario";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public void eliminar(Entidades.Usuario u)
        {
            Conexion.OpenConnection();

            string query = "DELETE from usuario WHERE idUsuario = @idUsuario";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idUsuario", u.IdUsuario);
            comando.Prepare();

            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void insertar(Entidades.Usuario u)
        {
            Conexion.OpenConnection();

            string query = "insert into usuario (idUsuario, pass, tipo) values(@idUsuario, @pass, @tipo)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idUsuario", u.IdUsuario);
            comando.Parameters.AddWithValue("@pass", u.Pass);
            comando.Parameters.AddWithValue("@tipo", u.Tipo);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void modificar(Entidades.Usuario u)
        {
            Conexion.OpenConnection();

            string query = "UPDATE usuario set pass = @pass,tipo = @tipo WHERE idUsuario = @idUsuario";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idUsuario", u.IdUsuario);
            comando.Parameters.AddWithValue("@pass", u.Pass);
            comando.Parameters.AddWithValue("@tipo", u.Tipo);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }


    }
}
