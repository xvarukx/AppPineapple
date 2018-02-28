using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace DAO
{
    public class Lote
    {
        static public DataTable buscarBloqueTabla(string id)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select* from lote Where idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idLote", id);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }
        static public List<Entidades.Lote> buscarLotes()
        {
            List<Entidades.Lote> lotes = new List<Entidades.Lote>();
            Conexion.OpenConnection();
            Entidades.Lote b = new Entidades.Lote();

            string query = "Select * from lote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                b = new Entidades.Lote();
                b.IdLote = reader.GetString("idLote");
             
                b.Area = reader.GetDouble("area");
                //b.Imagen = ByteArrayToImage((byte[])reader["imagen"]);
                b.CantPlantas = reader.GetDouble("cantPlantas");
                b.AreaUtilizada = reader.GetDouble("areaUtilizada");
                b.CantPlantas = reader.GetDouble("cantPlantas");
                b.AltoMapa = reader.GetDouble("altoMapa");
                b.AnchoMapa = reader.GetDouble("anchoMapa");
                lotes.Add(b);
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return lotes;

        }
        static public Image getImagen(string id)
        {
            Conexion.OpenConnection();
            Entidades.Lote l = new Entidades.Lote();

            string query = "Select imagen from lote Where idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idLote", id);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                l.Imagen = ByteArrayToImage((byte[])reader["imagen"]);
                Conexion.CloseConnection();
                return l.Imagen;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return l.Imagen;

        }

        static public void modificarNoImagen(Entidades.Lote l)
        {
            Conexion.OpenConnection();
            string query = "UPDATE lote set area = @area, anchoMapa = @anchoMapa, altoMapa = @altoMapa WHERE idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idLote", l.IdLote);
            comando.Parameters.AddWithValue("@area", l.Area);
            comando.Parameters.AddWithValue("@anchoMapa", l.AnchoMapa);
            comando.Parameters.AddWithValue("@altoMapa", l.AltoMapa);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public Entidades.Lote BuscarLote(string id)
        {
            Conexion.OpenConnection();
            Entidades.Lote l = new Entidades.Lote();

            string query = "Select* from lote Where idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idLote", id);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                l.IdLote = reader.GetString("idLote");
                l.Imagen = ByteArrayToImage((byte[])reader["imagen"]);
                l.Area = reader.GetDouble("area");
                l.AreaUtilizada = reader.GetDouble("areaUtilizada");
                l.CantPlantas = reader.GetDouble("cantPlantas");
                l.AnchoMapa = reader.GetDouble("anchoMapa");
                l.AltoMapa = reader.GetDouble("altoMapa");
                Conexion.CloseConnection();
                return l;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return l;

        }

        static public DataTable Lista()
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select* from lote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public void eliminar(Entidades.Lote l)
        {

            Conexion.OpenConnection();

            string query = "call eliminarLote(@idLote)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idLote", l.IdLote);
            comando.Prepare();

            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
        static public bool comprobarLote(string lote)
        {
            Conexion.OpenConnection();
            string query = "select distinct(c.idCedula), c.estadoAplicacion from cedulaidentidad c inner join detalleseccioncedula d on c.idCedula = d.idCedula where d.lote = @idLote and c.estadoAplicacion = 1";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idLote", lote);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                Conexion.CloseConnection();
                return true;
            }
            Conexion.CloseConnection();
            return false;

        }
        static public void insertar(Entidades.Lote l)
        {
            Conexion.OpenConnection();
            string query = "insert into lote (idLote, area,imagen,anchoMapa,altoMapa) values(@idLote, @area,@imagen,@ancho, @alto)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idLote", l.IdLote);
  
            comando.Parameters.AddWithValue("@area", l.Area);
            comando.Parameters.AddWithValue("@ancho", l.AnchoMapa);
            comando.Parameters.AddWithValue("@alto", l.AltoMapa);
            comando.Parameters.AddWithValue("@imagen", ImageToByteArray(l.Imagen));
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public void modificar(Entidades.Lote l)
        {
            Conexion.OpenConnection();

            string query = "UPDATE lote set area = @area, imagen = @imagen,anchoMapa = @ancho, altoMapa = @alto WHERE idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idLote", l.IdLote);
            comando.Parameters.AddWithValue("@imagen", ImageToByteArray(l.Imagen));
            comando.Parameters.AddWithValue("@area", l.Area);
            comando.Parameters.AddWithValue("@ancho", l.AnchoMapa);
            comando.Parameters.AddWithValue("@alto", l.AltoMapa);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public bool Existe(string id)
        {
            Conexion.OpenConnection();
            Entidades.Lote l = new Entidades.Lote();

            string query = "Select* from lote Where idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idLote", id);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                Conexion.CloseConnection();
                return true;
            }
            Conexion.CloseConnection();
            return false;

        }
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
