using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Configuracion
    {
        static public Entidades.Configuracion getConfiguracion()
        {
            Conexion.OpenConnection();
            Entidades.Configuracion c = new Entidades.Configuracion();
            string query = "Select* from configuracion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                c.FrecuenciaCorreos = reader.GetInt32("frecuenciaCorreos");
                Conexion.CloseConnection();
                return c;
            }
            Conexion.CloseConnection();
            return c;
        }
        static public void setFrecuenciaCorreos(int f)
        {
            Conexion.OpenConnection();
            Entidades.Configuracion c = new Entidades.Configuracion();
            string query = "UPDATE configuracion set frecuenciaCorreos = @frecuenciaCorreos";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@frecuenciaCorreos", f);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
    }
}
