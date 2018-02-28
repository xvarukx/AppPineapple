using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GrupoForza
    {
        static public bool insertarGrupo(Entidades.GrupoForza g)
        {
            if (!comprobarGrupo(g))
            {
                Conexion.OpenConnection();

                string query = "insert into grupoForza (idGrupo,fechaInicio,paquete,periodoCosecha) values(@grupo,@fecha,@paquete,@PeriodoCosecha)";
                MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

                comando.Parameters.AddWithValue("@grupo", g.IdGrupo);
                comando.Parameters.AddWithValue("@fecha", g.Fecha);
                comando.Parameters.AddWithValue("@lote", g.Lote);
                comando.Parameters.AddWithValue("@paquete", g.Paquete);
                comando.Parameters.AddWithValue("@PeriodoCosecha", g.PeriodoCosecha);
                comando.ExecuteNonQuery();
                Conexion.CloseConnection();
                return true;
            }
            return false;

        }

        static public void actualizarGrupo(Entidades.GrupoForza g)
        {

            Conexion.OpenConnection();

            string query = "update grupoForza set fechaInicio=@fecha, paquete = @paquete, periodoCosecha = @PeriodoCosecha where idgrupo = @grupo";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@grupo", g.IdGrupo);
            comando.Parameters.AddWithValue("@fecha", g.Fecha);
            comando.Parameters.AddWithValue("@paquete", g.Paquete);
            comando.Parameters.AddWithValue("@PeriodoCosecha", g.PeriodoCosecha);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
        }
        static public void eliminar(string g)
        {
            try
            {
                Conexion.OpenConnection();
                string query = "DELETE from grupoForza where idGrupo = @idGrupo";
                MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
                comando.Parameters.AddWithValue("@idGrupo", g);
                comando.Prepare();
                comando.ExecuteNonQuery();
                Conexion.CloseConnection();
            }
            catch (MySqlException ex)
            {
                Conexion.CloseConnection();
            }
            limpiarSeccion(g);
        }
        static public void limpiarSeccion(string g) {

            try
            {
                Conexion.OpenConnection();
                string query = "update seccion set grupoForza = 'Sin Grupo', idPaquete = 'Sin Paquete', posicion = -1  where grupoForza = @idGrupo";
                MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
                comando.Parameters.AddWithValue("@idGrupo", g);
              
                comando.Prepare();
                comando.ExecuteNonQuery();
                Conexion.CloseConnection();
            }
            catch (MySqlException ex)
            {
                Conexion.CloseConnection();
            }


        }
        static public bool comprobarGrupo(Entidades.GrupoForza g) {
            Conexion.OpenConnection();
            string query = "select * from grupoForza where lote = @lote and idGrupo = @idGrupo ";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idGrupo", g.IdGrupo);
            comando.Parameters.AddWithValue("@lote", g.Lote);
            comando.ExecuteNonQuery();
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read()) {
                Conexion.CloseConnection();
                return true;
            }
            Conexion.CloseConnection();
            return false;

        }



        static public List<string> listaId(string lote)
        {
            Conexion.OpenConnection();
            List<string> l = new List<string>();

            string query = "Select idGrupo from grupoForza where lote = @lote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@lote", lote);
            comando.Prepare();
            l.Add("Sin Grupo");
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                string s = reader.GetString("idGrupo");
                l.Add(s);
            }
            Conexion.CloseConnection();
            return l;
        }
        static public List<string> listaId(bool conGrupo)
        {
            Conexion.OpenConnection();
            List<string> l = new List<string>();

            string query = "Select idGrupo from grupoForza";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            if(conGrupo)
                l.Add("Sin Grupo");
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                string s = reader.GetString("idGrupo");
                l.Add(s);
            }
            Conexion.CloseConnection();
            return l;
        }
        static public DateTime fechaPeriodoCosecha(string id) {
            DateTime fecha = default(DateTime);
            Conexion.OpenConnection();
            string query = "select * from grupoForza where idGrupo = @idGrupo ";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idGrupo", id);
            comando.ExecuteNonQuery();
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                
                fecha= reader.GetDateTime("periodoCosecha");
                Conexion.CloseConnection();
                return fecha;
            }
            Conexion.CloseConnection();
            return fecha;



        }
        static public Entidades.GrupoForza getGrupo(string id){
            Entidades.GrupoForza g = new Entidades.GrupoForza();
            Conexion.OpenConnection();
            string query = "select * from grupoForza where idGrupo = @idGrupo ";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idGrupo", id);
            comando.ExecuteNonQuery();
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                g.IdGrupo = id;
                g.Paquete = reader.GetString("paquete");
                g.Fecha = reader.GetDateTime("fechaInicio");
                g.PeriodoCosecha = reader.GetDateTime("periodoCosecha");
                Conexion.CloseConnection();
                return g;
            }
            Conexion.CloseConnection();
            return g;


        }
    }
}
