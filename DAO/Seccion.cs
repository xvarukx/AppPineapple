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
    public class Seccion
    {
        static public DataTable buscarSeccionTabla(string lote)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select idSeccion,idBloque,idLote,posicion,grupoForza from seccion Where idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idLote", lote);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }
        static public DataTable TablaSecciones(string lote, string bloque)/////////////
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select idBloque,idSeccion,idPaquete,posicion,grupoForza,fechaSiembra, fechaInicial from seccion Where idLote = @idLote AND idBloque LIKE @idBloque ORDER BY idBloque";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idLote", lote);
            comando.Parameters.AddWithValue("@idBloque", bloque);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();

            return dtDatos;
        }
        static public void editPosicion(Entidades.Seccion seccion)
        {
            Entidades.DetalleAplicacion a = DAO.DetalleAplicacion.getDetallePaquetePosicion(seccion.Paquete, seccion.Posicion+1);
            seccion.FechaProgramada = buscarSeccion(seccion.IdSeccion, seccion.IdLote, seccion.IdBloque).FechaInicial.AddDays(a.Tiempo);
            Conexion.OpenConnection();
            string query = "UPDATE seccion set posicion = @posicion, idPaquete = @idPaquete, fechaProgramada = @fechaProgramada WHERE idSeccion = @idSeccion AND idBloque = @idBloque AND idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSeccion", seccion.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", seccion.IdBloque);
            comando.Parameters.AddWithValue("@idLote", seccion.IdLote);
            comando.Parameters.AddWithValue("@posicion", seccion.Posicion);
            comando.Parameters.AddWithValue("@idPaquete", seccion.Paquete);
            comando.Parameters.AddWithValue("@fechaProgramada", seccion.FechaProgramada);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
        static public List<string> comprobarSeccion(Entidades.Seccion seccion)
        {
   
            
            Conexion.OpenConnection();
            string query = "select c.idCedula,c.estadoAplicacion from cedulaidentidad c inner join detalleseccioncedula d on c.idCedula = d.idCedula where d.lote = @idLote and d.bloque = @idBloque and d.seccion = @idSeccion and c.estadoAplicacion = 1";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            List<string> cedulas = new List<string>();
            comando.Parameters.AddWithValue("@idSeccion", seccion.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", seccion.IdBloque);
            comando.Parameters.AddWithValue("@idLote", seccion.IdLote);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {


                cedulas.Add(reader.GetString("idCedula"));
            }
            Conexion.CloseConnection();
            return cedulas;
        }

        static public void editPaquete(Entidades.Seccion seccion)
        {
            Entidades.DetalleAplicacion a = DAO.DetalleAplicacion.getDetallePaquetePosicion(seccion.Paquete, seccion.Posicion+1);
            seccion.FechaProgramada = buscarSeccion(seccion.IdSeccion, seccion.IdLote, seccion.IdBloque).FechaInicial.AddDays(a.Tiempo);
            Conexion.OpenConnection();

            string query = "UPDATE seccion set grupoForza = 'Sin Grupo', idPaquete = @idPaquete, posicion = -1, fechaProgramada = @fechaProgramada WHERE idSeccion = @idSeccion AND idBloque = @idBloque AND idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSeccion", seccion.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", seccion.IdBloque);
            comando.Parameters.AddWithValue("@idLote", seccion.IdLote);
            comando.Parameters.AddWithValue("@fechaProgramada", seccion.FechaProgramada);
            comando.Parameters.AddWithValue("@idPaquete", seccion.Paquete);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
        static public void editFechaInicial(Entidades.Seccion seccion)
        {
            Entidades.Seccion s = buscarSeccion(seccion.IdSeccion, seccion.IdLote, seccion.IdBloque);
            Entidades.DetalleAplicacion a = DAO.DetalleAplicacion.getDetallePaquetePosicion(s.Paquete, s.Posicion+1);
            seccion.FechaProgramada = seccion.FechaInicial.AddDays(a.Tiempo);
            Conexion.OpenConnection();

            string query = "UPDATE seccion set fechaInicial = @fechaInicial, fechaProgramada = @fechaProgramada WHERE idSeccion = @idSeccion AND idBloque = @idBloque AND idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSeccion", seccion.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", seccion.IdBloque);
            comando.Parameters.AddWithValue("@idLote", seccion.IdLote);
            comando.Parameters.AddWithValue("@fechaInicial", seccion.FechaInicial);
            comando.Parameters.AddWithValue("@fechaProgramada", seccion.FechaProgramada);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

            static public void cambiarLocation(Entidades.Seccion s)
        {
            Conexion.OpenConnection();

            string query = "UPDATE seccion set posX = @posX, posY = @posY WHERE idSeccion = @idSeccion AND idBloque = @idBloque AND idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSeccion", s.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", s.IdBloque);
            comando.Parameters.AddWithValue("@idLote", s.IdLote);
            comando.Parameters.AddWithValue("@posX", s.PosX);
            comando.Parameters.AddWithValue("@posY", s.PosY);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();

        }
        static public List<Entidades.Seccion> buscarSeccionLista(string lote)
        {
            List<Entidades.Seccion> secciones = new List<Entidades.Seccion>();
            Conexion.OpenConnection();
            Entidades.Seccion s = new Entidades.Seccion();

            string query = "Select* from seccion where idLote like @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idLote", lote);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                s = new Entidades.Seccion();
                s.IdSeccion = reader.GetString("idSeccion");
                s.IdLote = reader.GetString("idLote");
                s.IdBloque = reader.GetString("idBloque");
                s.Area = reader.GetDouble("area");
                s.Posicion = reader.GetInt32("posicion");
                s.NumPlantas = reader.GetInt32("numPlantas");
                s.PosX = reader.GetInt32("posX");
                s.PosY = reader.GetInt32("posY");
                s.FechaSiembra = reader.GetDateTime("fechaSiembra");
                s.FechaInicial = reader.GetDateTime("fechaInicial");
                s.FechaProgramada = reader.GetDateTime("fechaProgramada");
                s.Detalle = reader.GetString("detalle");
                s.TipoSemilla = reader.GetString("tipoSemilla");
                s.PesoSemilla = reader.GetString("pesoSemilla");
                s.Paquete = reader.GetString("idPaquete");

                secciones.Add(s);
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return secciones;

        }
        static public List<Entidades.Seccion> buscarSeccionLista(string lote, string bloque)
        {
            List<Entidades.Seccion> secciones = new List<Entidades.Seccion>();
            Conexion.OpenConnection();
            Entidades.Seccion s = new Entidades.Seccion();

            string query = "Select* from seccion where idLote like @idLote AND idBloque LIKE @idBloque ";
            query = query + "Order by idSeccion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idLote", lote);
            comando.Parameters.AddWithValue("@idBloque", bloque);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                s = new Entidades.Seccion();
                s.IdSeccion = reader.GetString("idSeccion");
                s.IdLote = reader.GetString("idLote");
                s.IdBloque = reader.GetString("idBloque");
                s.Area = reader.GetDouble("area");
                s.Posicion = reader.GetInt32("posicion");
                s.NumPlantas = reader.GetInt32("numPlantas");
                s.PosX = reader.GetInt32("posX");
                s.PosY = reader.GetInt32("posY");
                s.FechaSiembra = reader.GetDateTime("fechaSiembra");
                s.FechaProgramada = reader.GetDateTime("fechaProgramada");
                s.Detalle = reader.GetString("detalle");
                s.TipoSemilla = reader.GetString("tipoSemilla");
                s.PesoSemilla = reader.GetString("pesoSemilla");
                s.Paquete = reader.GetString("idPaquete");
                secciones.Add(s);
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return secciones;

        }
        static public List<Entidades.Seccion> buscarSeccionLista(string lote, string bloque, bool forza)
        {
            List<Entidades.Seccion> secciones = new List<Entidades.Seccion>();
            Conexion.OpenConnection();
            Entidades.Seccion s = new Entidades.Seccion();

            string query = "Select* from seccion where idLote like @idLote AND idBloque LIKE @idBloque ";
            if (forza) { query = query + "AND posicion >= 20 "; }
            query = query + "Order by idSeccion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idLote", lote);
            comando.Parameters.AddWithValue("@idBloque", bloque);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                s = new Entidades.Seccion();
                s.IdSeccion = reader.GetString("idSeccion");
                s.IdLote = reader.GetString("idLote");
                s.IdBloque = reader.GetString("idBloque");
                s.Area = reader.GetDouble("area");
                s.Posicion = reader.GetInt32("posicion");
                s.NumPlantas = reader.GetInt32("numPlantas");
                s.PosX = reader.GetInt32("posX");
                s.PosY = reader.GetInt32("posY");
                s.FechaSiembra = reader.GetDateTime("fechaSiembra");
                s.FechaProgramada = reader.GetDateTime("fechaProgramada");
                s.Detalle = reader.GetString("detalle");
                s.TipoSemilla = reader.GetString("tipoSemilla");
                s.PesoSemilla = reader.GetString("pesoSemilla");
                s.GrupoForza = reader.GetString("grupoForza");
                s.Paquete = reader.GetString("idPaquete");
                secciones.Add(s);
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return secciones;

        }

       
        static public DataTable buscarSeccionTabla(string grupo,string lote)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select idSeccion,idBloque,posicion,fechaInicial,grupoForza from seccion Where grupoForza = @grupoForza and idLote = @lote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@grupoForza", grupo);
            comando.Parameters.AddWithValue("@lote", lote);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }
        static public Entidades.Seccion buscarSeccion(string idSeccion, string lote, string bloque)
        {
            Conexion.OpenConnection();
            Entidades.Seccion s = new Entidades.Seccion();

            string query = "Select * from seccion WHERE idSeccion = @idSeccion and idBloque = @idBloque and idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idSeccion", idSeccion);
            comando.Parameters.AddWithValue("@idBloque", bloque);
            comando.Parameters.AddWithValue("@idLote", lote);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                s.IdSeccion = reader.GetString("idSeccion");
                s.IdLote = reader.GetString("idLote");
                s.IdBloque = reader.GetString("idBloque");
                s.Area = reader.GetDouble("area");
                s.Posicion = reader.GetInt32("posicion");
                s.NumPlantas = reader.GetInt32("numPlantas");
                s.PosX = reader.GetInt32("posX");
                s.PosY = reader.GetInt32("posY");
                s.FechaSiembra = reader.GetDateTime("fechaSiembra");
                s.FechaProgramada = reader.GetDateTime("fechaProgramada");
                s.FechaInicial = reader.GetDateTime("fechaInicial");
                s.Detalle = reader.GetString("detalle");
                s.GrupoForza = reader.GetString("grupoForza");
                s.Paquete = reader.GetString("idPaquete");
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
            string query = "Select* from seccion";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }

        static public void eliminar(Entidades.Seccion s)
        {
            Conexion.OpenConnection();

            string query = "call eliminarSeccion(@idLote, @idBloque, @idSeccion)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSeccion", s.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", s.IdBloque);
            comando.Parameters.AddWithValue("@idLote", s.IdLote);
            comando.Prepare();

            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }

        static public List<Entidades.Seccion> buscarSeccionPorLote(string lote)
        {
            List<Entidades.Seccion> secciones = new List<Entidades.Seccion>();
            Conexion.OpenConnection();
            string query;
            Entidades.Seccion b = new Entidades.Seccion();

            query = "Select * from seccion where idLote = @lote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@lote", lote);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                b = new Entidades.Seccion();
                b.IdSeccion = reader.GetString("idSeccion");
                b.IdLote = reader.GetString("idLote");
                b.IdBloque = reader.GetString("idBloque");
                b.Area = reader.GetDouble("area");
                b.Posicion = reader.GetInt32("posicion");
                b.NumPlantas = reader.GetInt32("numPlantas");
                b.PosX = reader.GetInt32("posX");
                b.PosY = reader.GetInt32("posY");
                b.FechaSiembra = reader.GetDateTime("fechaSiembra");
                b.FechaInicial = reader.GetDateTime("fechaInicial");
                b.FechaProgramada = reader.GetDateTime("fechaProgramada");
                b.Detalle = reader.GetString("detalle");
                b.GrupoForza = reader.GetString("grupoForza");
                b.Paquete = reader.GetString("idPaquete");
                b.Bloqueo = reader.GetBoolean("bloqueo");
                secciones.Add(b);
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return secciones;

        }
        static public List<Entidades.Seccion> buscarSeccion(string grupo)
        {
            List<Entidades.Seccion> secciones = new List<Entidades.Seccion>();
            Conexion.OpenConnection();
            string query;
            Entidades.Seccion b = new Entidades.Seccion();

            query = "Select * from seccion where grupoForza = @grupoForza";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@grupoForza", grupo);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                b = new Entidades.Seccion();
                b.IdSeccion = reader.GetString("idSeccion");
                b.IdLote = reader.GetString("idLote");
                b.IdBloque = reader.GetString("idBloque");
                b.Area = reader.GetDouble("area");
                b.Posicion = reader.GetInt32("posicion");
                b.NumPlantas = reader.GetInt32("numPlantas");
                b.PosX = reader.GetInt32("posX");
                b.PosY = reader.GetInt32("posY");
                b.FechaSiembra = reader.GetDateTime("fechaSiembra");
                b.FechaInicial = reader.GetDateTime("fechaInicial");
                b.FechaProgramada = reader.GetDateTime("fechaProgramada");
                b.Detalle = reader.GetString("detalle");
                b.GrupoForza = reader.GetString("grupoForza");
                b.Paquete = reader.GetString("idPaquete");
                secciones.Add(b);
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return secciones;

        }
        /*    static public obtenerFechaSiembra(Entidades.Seccion s) {
                string query = "Select * from fechaSiembra where idLote like @idLote and idBloque = @idBloque";
                MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
                comando.Parameters.AddWithValue("@idLote", s.IdLote);
                comando.Parameters.AddWithValue("@idBloque", s.IdBloque);
                return 
            }*/
        static public void aumentarPosicion(Entidades.Seccion seccion)
        {
            Conexion.OpenConnection();
            string query = "UPDATE seccion set posicion = posicion +1 WHERE idSeccion = @idSeccion and idBloque = @idBloque and idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
   
            comando.Parameters.AddWithValue("@idSeccion", seccion.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", seccion.IdBloque);
            comando.Parameters.AddWithValue("@idLote", seccion.IdLote);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
            calcularFechaSiguiente(seccion);
        }
         static public void calcularFechaSiguiente(Entidades.Seccion seccion) {
            Entidades.Seccion s = buscarSeccion(seccion.IdSeccion, seccion.IdLote, seccion.IdBloque); 
            Entidades.DetalleAplicacion a = DAO.DetalleAplicacion.getDetallePaquetePosicion(s.Paquete, s.Posicion+1);
            DateTime dt = s.FechaInicial.AddDays(a.Tiempo);
            Conexion.OpenConnection();
            string query = "UPDATE seccion set fechaProgramada = @fechaProgramada  WHERE idSeccion = @idSeccion and idBloque = @idBloque and idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@fechaProgramada", dt);
            comando.Parameters.AddWithValue("@idSeccion", s.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", s.IdBloque);
            comando.Parameters.AddWithValue("@idLote", s.IdLote);
            comando.Prepare();
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
            
        }
        static public void insertar(Entidades.Seccion s)
        {
            Entidades.DetalleAplicacion da = DAO.DetalleAplicacion.getDetallePaquetePosicion(s.Paquete, s.Posicion);
            Conexion.OpenConnection();

            string query = "call insertarSeccion(@idSeccion, @idLote, @idBloque, @area, @numPlantas, @posX, @posY,@fechaSiembra,@tipoSemilla,@pesoSemilla)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSeccion", s.IdSeccion);
            comando.Parameters.AddWithValue("@idLote", s.IdLote);
            comando.Parameters.AddWithValue("@idBloque", s.IdBloque);
            comando.Parameters.AddWithValue("@area", s.Area);
            comando.Parameters.AddWithValue("@numPlantas", s.NumPlantas);
            comando.Parameters.AddWithValue("@posX", s.PosX);
            comando.Parameters.AddWithValue("@posY", s.PosY);
            comando.Parameters.AddWithValue("@fechaSiembra", s.FechaSiembra);
            comando.Parameters.AddWithValue("@tipoSemilla", s.TipoSemilla);
            comando.Parameters.AddWithValue("@pesoSemilla", s.PesoSemilla);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
            //calcularFechaSiguiente(s);
        }

        void actualizarFecha() {


        }

        static public void agregarGrupo(Entidades.Seccion s, string grupo, string paquete, int posicion, DateTime fechaInicio)
        {
            Entidades.DetalleAplicacion da = DAO.DetalleAplicacion.getDetallePaquetePosicion(paquete, 0);

            Conexion.OpenConnection();
            string query = "UPDATE seccion set grupoForza = @grupoForza, posicion = @pos, idPaquete = @paquete,  fechaInicial = @fechaInicial, fechaProgramada = @fechaProgramada  WHERE idSeccion = @idSeccion and idBloque = @idBloque and idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSeccion", s.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", s.IdBloque);
            comando.Parameters.AddWithValue("@idLote", s.IdLote);
            comando.Parameters.AddWithValue("@pos", posicion);
            comando.Parameters.AddWithValue("@grupoForza", grupo);
            comando.Parameters.AddWithValue("@paquete", paquete);
            comando.Parameters.AddWithValue("@fechaInicial", fechaInicio);
            comando.Parameters.AddWithValue("@fechaProgramada", fechaInicio.AddDays(da.Tiempo));
            comando.Prepare();
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();


            //calcularFechaSiguiente(s);
        }
        static public void agregarGrupo(Entidades.Seccion s, Entidades.GrupoForza g)
        {
            Entidades.DetalleAplicacion da = DAO.DetalleAplicacion.getDetallePaquetePosicion(g.Paquete, 0);

            Conexion.OpenConnection();
            string query = "UPDATE seccion set grupoForza = @grupoForza, posicion = @pos, idPaquete = @paquete,  fechaInicial = @fechaInicial, fechaProgramada = @fechaProgramada  WHERE idSeccion = @idSeccion and idBloque = @idBloque and idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSeccion", s.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", s.IdBloque);
            comando.Parameters.AddWithValue("@idLote", s.IdLote);
            comando.Parameters.AddWithValue("@pos", -1);
            comando.Parameters.AddWithValue("@grupoForza", g.IdGrupo);
            comando.Parameters.AddWithValue("@paquete", g.Paquete);
            comando.Parameters.AddWithValue("@fechaInicial", g.Fecha);
            comando.Parameters.AddWithValue("@fechaProgramada", g.Fecha.AddDays(da.Tiempo));
            comando.Prepare();
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();


            //calcularFechaSiguiente(s);
        }
        static public void cambiarBloqueo(Entidades.Seccion s,bool opcion)
        {
            Conexion.OpenConnection();
            string query = "UPDATE seccion set bloqueo = @bloqueo WHERE idSeccion = @idSeccion and idBloque = @idBloque and idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idSeccion", s.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", s.IdBloque);
            comando.Parameters.AddWithValue("@idLote", s.IdLote);
            comando.Parameters.AddWithValue("@bloqueo", opcion);
            comando.Prepare();
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
            //calcularFechaSiguiente(s);
        }
        static public void quitarGrupo(Entidades.Seccion s)
        {
            Conexion.OpenConnection();
            string query = "UPDATE seccion set grupoForza = 'Sin Grupo', bloqueo = false, posicion = -1, idPaquete = 'Sin Paquete' WHERE idSeccion = @idSeccion and idBloque = @idBloque and idLote = @idLote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSeccion", s.IdSeccion);
            comando.Parameters.AddWithValue("@idBloque", s.IdBloque);
            comando.Parameters.AddWithValue("@idLote", s.IdLote);
            comando.Prepare();
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();


            //calcularFechaSiguiente(s);
        }

        static public void modificar(Entidades.Seccion s)
        {
            Conexion.OpenConnection();

            string query = "call modificarSeccion(@idSeccion, @idLote, @idBloque, @area, @numPlantas,@fechaSiembra, @tipoSemilla,@pesoSemilla)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@idSeccion", s.IdSeccion);
            comando.Parameters.AddWithValue("@idLote", s.IdLote);
            comando.Parameters.AddWithValue("@idBloque", s.IdBloque);
            comando.Parameters.AddWithValue("@area", s.Area);
            comando.Parameters.AddWithValue("@numPlantas", s.NumPlantas);
            comando.Parameters.AddWithValue("@fechaSiembra", s.FechaSiembra);
            comando.Parameters.AddWithValue("@tipoSemilla", s.TipoSemilla);
            comando.Parameters.AddWithValue("@pesoSemilla", s.PesoSemilla);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
        static public List<Entidades.Notificacion> Notificaciones()
        {
            List<Entidades.Notificacion> l = new List<Entidades.Notificacion>();
            Conexion.OpenConnection();
            string query = "call eventosProximos()";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                string idLote = reader.GetString("idLote");
                string idBloque = reader.GetString("idBloque");
                string idSeccion = reader.GetString("idSeccion");
                string fecha = reader.GetDateTime("fechaProgramada").ToString("MMMM dd, yyyy");
                string posicion = reader.GetInt32("posicion").ToString();
                string nombreAplicacion = reader.GetString("nombre");

                Entidades.Notificacion notificacion = new Entidades.Notificacion();
               
                Entidades.Seccion s = new Entidades.Seccion();
                s.IdSeccion = reader.GetString("idSeccion");
                s.IdBloque = reader.GetString("idBloque");
                s.IdLote = reader.GetString("idLote");
                s.FechaProgramada = reader.GetDateTime("fechaProgramada");
                s.Posicion = reader.GetInt32("posicion");


                Entidades.Notificacion n = new Entidades.Notificacion();
                
            }
            Conexion.CloseConnection();
            return l;
        }
        static public DataTable historialProductos(String lote, String bloque, String seccion, DateTime fromDate, DateTime toDate)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Call buscarSeccion_Producto(@Lote, @Bloque, @Seccion, @fromDate, @toDate)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@Lote", lote);
            comando.Parameters.AddWithValue("@Bloque", bloque);
            comando.Parameters.AddWithValue("@Seccion", seccion);
            comando.Parameters.AddWithValue("@fromDate", fromDate);
            comando.Parameters.AddWithValue("@toDate", toDate);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }


        static public DataTable buscarSeccionGrupo(string lote, string bloque, string seccion, string grupo)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select idLote AS Lote,idBloque AS Bloque,idSeccion AS Seccion,grupoForza AS Grupo from seccion Where idLote LIKE @idLote AND idBloque LIKE @idBloque AND idSeccion LIKE @idSeccion AND grupoForza Like @grupo ORDER BY idlote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idLote", "%"+lote+"%");
            comando.Parameters.AddWithValue("@idBloque", "%"+bloque+ "%");
            comando.Parameters.AddWithValue("@idSeccion", "%"+seccion+ "%");
            comando.Parameters.AddWithValue("@grupo", grupo);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();

            return dtDatos;
        }
        static public DataTable buscarSeccionGrupo2(string grupo)
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select s.idLote AS Lote,s.idBloque AS Bloque,s.idSeccion AS Seccion,s.grupoForza AS Grupo, s.idPaquete as Paquete, s.posicion+1 AS Posicion, a.nombre AS Aplicacion, s.fechaProgramada AS FechaProgramada from seccion s inner join detalleaplicacion dp on s.posicion+1 = dp.posicion and s.idPaquete = dp.idPaquete inner join aplicacion a on a.idAplicacion = dp.idAplicacion Where grupoForza Like @grupo ORDER BY idlote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@grupo", grupo);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();

            return dtDatos;
        }
    }
}
