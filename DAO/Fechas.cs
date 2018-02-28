using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class Fechas
    {
        static public List<Entidades.Fecha> fechaPorMes(DateTime fecha)
        {
            Conexion.OpenConnection();
            List<Entidades.Fecha> list = new List<Entidades.Fecha>();

            string query = "obtenerFechasPorMes";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_fecha", fecha.AddDays(-fecha.Day));
            comando.Parameters.AddWithValue("_fecha2", new DateTime(fecha.Year,fecha.Month,DateTime.DaysInMonth(fecha.Year,fecha.Month)));
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.Fecha f = new Entidades.Fecha();
                f.FechaProgramada = reader.GetDateTime("FechaProgramada");
                f.Lote = reader.GetString("Lote");
                f.Seccion = reader.GetString("Seccion");
                f.Posicion = reader.GetInt32("Posicion");
                f.Paquete = reader.GetString("Paquete");
                f.Bloque = reader.GetString("Bloque");
                f.IdAplicacion = reader.GetInt32("IdAplicacion");
                f.Aplicacion = reader.GetString("NombreAplicacion");

               list.Add(f);
            }
            Conexion.CloseConnection();
            return list;
        }
        static public List<Entidades.Fecha> obtenerFechas(List<Entidades.Seccion> secciones) {
            
            List<Entidades.DetalleAplicacion> detalle;
            List<Entidades.Fecha> fechas = new List<Entidades.Fecha>();
            foreach (Entidades.Seccion s in secciones) {
                detalle = DetalleAplicacion.lista(s.Paquete);
                foreach (Entidades.DetalleAplicacion d in detalle) {
                    Entidades.Fecha f = new Entidades.Fecha();
                    f.Bloqueo = s.Bloqueo;
                    f.Siguiente = false;
                    if ((s.Posicion + 1) == d.Posicion)
                        f.Siguiente = true;
                    f.FechaProgramada = s.FechaInicial.AddDays(d.Tiempo);
                    f.Lote = s.IdLote;
                    f.Seccion = s.IdSeccion;
                    f.Bloque = s.IdBloque;
                    f.Paquete = s.Paquete;
                    f.IdAplicacion = d.IdAplicacion;
                    f.Aplicacion = d.NombreAplicacion;
                    f.Posicion = d.Posicion;
                    f.Area = s.Area;
                    f.grupoForza = s.GrupoForza;
                    
                    f.Semana = Entidades.conf.weekNumber(f.FechaProgramada);
                    fechas.Add(f);

                }
            }
            return fechas;
        }
        static public Entidades.Seccion obtenerFechaSiguiente(Entidades.Seccion s)
        {
           
            Entidades.Seccion seccion = s;
            Entidades.DetalleAplicacion d;
            d = DetalleAplicacion.getNombreAplicacion(s.Paquete, s.Posicion + 1);
            seccion.Aplicacion = d.NombreAplicacion;
            
            return seccion;
        }
        static public List<Entidades.Seccion> obtenerSeccionesConPaquete()
        {
            Conexion.OpenConnection();
            List<Entidades.Seccion> list = new List<Entidades.Seccion>();

            string query = "select idLote, idBloque, idSeccion,idPaquete,fechaProgramada,posicion,fechaInicial,area,grupoForza,bloqueo from seccion where idPaquete <> @paquete";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@paquete", "Sin Paquete");
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.Seccion s = new Entidades.Seccion();
                s.FechaProgramada = reader.GetDateTime("fechaProgramada");
                s.IdLote = reader.GetString("IdLote");
                s.IdSeccion = reader.GetString("IdSeccion");
                s.Posicion = reader.GetInt32("posicion");
                s.Paquete = reader.GetString("idPaquete");
                s.IdBloque = reader.GetString("IdBloque");
                s.FechaInicial = reader.GetDateTime("fechaInicial");
                s.Area = reader.GetDouble("area");
                s.GrupoForza = reader.GetString("grupoForza");
                s.Bloqueo = reader.GetBoolean("bloqueo");
                list.Add(s);
            }
            Conexion.CloseConnection();
            return list;
        }

    }
}
