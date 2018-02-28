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
    public class Bloque
    {
        static public DataTable buscarBloqueTabla(string id)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select* from bloque Where idBloque = @idBloque";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idBloque", id);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public Entidades.Bloque buscarBloque(string idBloque, string idLote)
        {
            Conexion.OpenConnection();
            Entidades.Bloque b = new Entidades.Bloque();

            string query = "Select* from bloque Where idBloque LIKE @idBloque AND idLote LIKE @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idBloque", idBloque);
            comando.Parameters.AddWithValue("@idLote", idLote);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                b.IdBloque = reader.GetString("idBloque");
                b.IdLote = reader.GetString("idLote");
                b.Area = reader.GetDouble("area");
                b.AreaUtilizada = reader.GetDouble("areaUtilizada");
                b.Posicion = reader.GetInt32("posicion");
                Conexion.CloseConnection();
                return b;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return b;

        }
        static public List<Entidades.Bloque> buscarBloqueLista(string lote)
        {
            List<Entidades.Bloque> bloques = new List<Entidades.Bloque>();
            Conexion.OpenConnection();
            Entidades.Bloque b = new Entidades.Bloque();

            string query = "Select * from bloque where idLote like @idLote Order by idBloque";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idLote", lote);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                b = new Entidades.Bloque();
                b.IdBloque = reader.GetString("idBloque");
                b.IdLote = reader.GetString("idLote");
                b.Area = reader.GetDouble("area");
                b.Posicion = reader.GetInt32("posicion");
                b.NumPlantas = reader.GetInt32("cantPlanta");
                b.CantSecciones = reader.GetInt32("cantSecciones");
                b.Detalles = reader.GetString("detalle");
                b.PosX = reader.GetInt32("posX");
                b.PosY = reader.GetInt32("posY");
                b.AreaUtilizada = reader.GetDouble("areaUtilizada");
                bloques.Add(b);
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return bloques;

        }
        static public List<Entidades.Bloque> buscarBloqueLista(string lote, string bloque)
        {
            List<Entidades.Bloque> bloques = new List<Entidades.Bloque>();
            Conexion.OpenConnection();
            Entidades.Bloque b = new Entidades.Bloque();

            string query = "Select* from bloque where idLote like @idLote AND idBloque LIKE @idBloque Order by idBloque";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idLote", lote);
            comando.Parameters.AddWithValue("@idBloque", bloque);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                b = new Entidades.Bloque();
                b.IdBloque = reader.GetString("idBloque");
                b.IdLote = reader.GetString("idLote");
                b.Area = reader.GetDouble("area");
                b.Posicion = reader.GetInt32("posicion");
                b.NumPlantas = reader.GetInt32("cantPlanta");
                b.CantSecciones = reader.GetInt32("cantSecciones");
                b.Detalles = reader.GetString("detalle");
                b.PosX = reader.GetInt32("posX");
                b.PosY = reader.GetInt32("posY");
                b.AreaUtilizada = reader.GetDouble("areaUtilizada");
                bloques.Add(b);
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return bloques;

        }

        static public DataTable Lista()
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select* from bloque";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public void eliminar(Entidades.Bloque b)
        {
            Conexion.OpenConnection();

            string query = "CALL eliminarBloque(@idLote, @idBloque)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idLote", b.IdLote);
            comando.Parameters.AddWithValue("@idBloque", b.IdBloque);
            comando.Prepare();

            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void insertar(Entidades.Bloque b)
        {
            Conexion.OpenConnection();

            string query = "insert into bloque (idBloque,idLote,area,posicion,cantPlanta,cantSecciones,posX,posY,detalle) values(@idBloque,@idLote,@area,@posicion,@cantPlanta,@cantSecciones,@posX,@posY,@detalle)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idBloque", b.IdBloque);
            comando.Parameters.AddWithValue("@idLote", b.IdLote);
            comando.Parameters.AddWithValue("@area", b.Area);
            comando.Parameters.AddWithValue("@posicion", b.Posicion);
            comando.Parameters.AddWithValue("@cantPlanta", b.NumPlantas);
            comando.Parameters.AddWithValue("@cantSecciones", b.CantSecciones - 1);
            comando.Parameters.AddWithValue("@posX", b.PosX);
            comando.Parameters.AddWithValue("@posY", b.PosY);
            comando.Parameters.AddWithValue("@detalle", b.Detalles);
            comando.Prepare();
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
        }

        static public void modificar(Entidades.Bloque b)
        {
            Conexion.OpenConnection();

            string query = "UPDATE bloque set area = @area, detalle = @detalle, cantPlanta= @cantPlanta, posicion = @posicion WHERE idBloque = @idBloque AND idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idBloque", b.IdBloque);
            comando.Parameters.AddWithValue("@idLote", b.IdLote);
            comando.Parameters.AddWithValue("@area", b.Area);
            comando.Parameters.AddWithValue("@posicion", b.Posicion);
            comando.Parameters.AddWithValue("@detalle", b.Detalles);
            comando.Parameters.AddWithValue("@cantPlanta", b.NumPlantas);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
        static public void cambiarLocation(Entidades.Bloque b)
        {
            Conexion.OpenConnection();

            string query = "UPDATE bloque set posX = @posX, posY = @posY WHERE idBloque = @idBloque AND idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idBloque", b.IdBloque);
            comando.Parameters.AddWithValue("@idLote", b.IdLote);
            comando.Parameters.AddWithValue("@posX", b.PosX);
            comando.Parameters.AddWithValue("@posY", b.PosY);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();

        }
        static public bool eliminable(Entidades.Bloque b)
        {
            Conexion.OpenConnection();
            string query = "Select* from seccion where idLote = @idLote AND idBloque = @idBloque AND posicion >-1";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idLote", b.IdLote);
            comando.Parameters.AddWithValue("@idBloque", b.IdBloque);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Conexion.CloseConnection();
                return false;
            }
            Conexion.CloseConnection();
            return true;
        }
    }
}
