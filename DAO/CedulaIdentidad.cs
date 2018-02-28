using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using System.Data;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CedulaIdentidad
    {


        static public void cambiarEstadoAplicacion(int cedula,bool estado) {

            Conexion.OpenConnection();

            MySqlCommand comando = new MySqlCommand("update cedulaidentidad set estadoAplicacion=@estado where idCedula = @idCedula", Conexion.Connection);
           
            comando.Parameters.AddWithValue("@idCedula", cedula);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();

        

    }
        static public void insertarCedula(Entidades.CedulaIdentidad a)
        {
            Conexion.OpenConnection();
            
            string query = "insert into cedulaIdentidad (fechaProgramada,numTractor,numSpray,cultivo,clima,chofer,programacion,muestreo,nombreAplicacion,cicloAplicacion,idAplicacion,ltsRequeridosH,totalLtsRequeridos,totalBoonesRequeridos,areaTotal,fechaCreacion,lote,costoTotal,grupoForza,etapa,interCosecha,periodoReingreso,periodoCosecha) values(@fechaProgramada,@numTractor,@numSpray,@cultivo,@clima,@chofer,@prog,@mues,@nombreAplicacion,@cicloAplicacion,@idAplicacion, @ltsRequeridosH,@totalLtsRequeridos,@totalBoonesRequeridos,@areaTotal,@fechaCreacion,@lote,@costoTotal,@grupoForza,@etapa,@InterCosecha,@periodoReingreso,@periodoCosecha)";
            
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            comando.Parameters.AddWithValue("@fechaProgramada", a.FechaProgramada);
            comando.Parameters.AddWithValue("@numTractor", a.NumTractor);
            comando.Parameters.AddWithValue("@numSpray", a.NumSpray);
            comando.Parameters.AddWithValue("@cultivo", a.Cultivo);
            comando.Parameters.AddWithValue("@clima", a.Clima);
            comando.Parameters.AddWithValue("@chofer", a.Chofer);
            comando.Parameters.AddWithValue("@prog", a.JustProgramacion);
            comando.Parameters.AddWithValue("@mues", a.JustMuestreo);
            comando.Parameters.AddWithValue("@nombreAplicacion", a.NombreAplicacion);
            comando.Parameters.AddWithValue("@cicloAplicacion", a.Posicion);
            comando.Parameters.AddWithValue("@idAplicacion", a.IdAplicacion);
            comando.Parameters.AddWithValue("@ltsRequeridosH", a.LtsRequeridos);
            comando.Parameters.AddWithValue("@totalLtsRequeridos", a.TotalLtsRequeridos);
            comando.Parameters.AddWithValue("@totalBoonesRequeridos", a.TotalBoonesRequeridos);
            comando.Parameters.AddWithValue("@areaTotal", a.AreaTotal);
            comando.Parameters.AddWithValue("@fechaCreacion", a.FechaCreacion);
            comando.Parameters.AddWithValue("@lote", a.Lote);
            comando.Parameters.AddWithValue("@costoTotal", a.CostoTotal);
            comando.Parameters.AddWithValue("@grupoForza", a.GrupoForza);
            comando.Parameters.AddWithValue("@InterCosecha", a.InterCosecha1);
            comando.Parameters.AddWithValue("@periodoReingreso", a.PeriodoReingreso);
            comando.Parameters.AddWithValue("@etapa", a.Etapa);
            comando.Parameters.AddWithValue("@periodoCosecha", a.PeriodoCosecha);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
        }


        static public List<Entidades.Producto> obtenerProductosCedula(int cedula)
        {
            List<Entidades.Producto> l = new List<Entidades.Producto>();
            Conexion.OpenConnection();
            string query = "Select * from detallecedulaproductos Where idCedula = @cedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.Producto p = new Entidades.Producto();
                p.Cantidad = reader.GetDouble("totalDosis");
                p.IdProducto = reader.GetString("idProducto");

                l.Add(p);
            }
            Conexion.CloseConnection();
            return l;
        }

        static public void actualizarCedula(int idCedula,double costoNuevo) {

            Conexion.OpenConnection();

            MySqlCommand comando = new MySqlCommand("actualizarCedula", Conexion.Connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_idCedula", idCedula);
            comando.Parameters.AddWithValue("_costoNuevo", costoNuevo);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();

        }
        static public void insertarDetalleProductos(Entidades.DetalleProductos a)
        {
            Conexion.OpenConnection();

            string query = "insert into detallecedulaproductos (idCedula,idProducto,nombreComercial,ingredienteActivo,dosisH,totalDosis,tipo,costo,costoH,numRegistro,dias,UM) values(@idCedula,@idProducto,@nombreComercial,@ingredienteActivo,@dosiH,@totalDosis,@tipo,@costo,@costoH,@numRegistro,@dias,@UM)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idCedula", a.Cedula);
            comando.Parameters.AddWithValue("@idProducto", a.Codigo);
            comando.Parameters.AddWithValue("@nombreComercial", a.NombreComercial);
            comando.Parameters.AddWithValue("@ingredienteActivo", a.IngredienteActivo);
            comando.Parameters.AddWithValue("@dosiH", a.DosisH);
            comando.Parameters.AddWithValue("@totalDosis", a.TotalDosis);
            comando.Parameters.AddWithValue("@costo", a.Costo);
            comando.Parameters.AddWithValue("@tipo", a.Tipo);
            comando.Parameters.AddWithValue("@costoH", a.CostoH);
            comando.Parameters.AddWithValue("@UM", a.UM1);
            comando.Parameters.AddWithValue("@dias", a.Intervalo);
            comando.Parameters.AddWithValue("@numRegistro", a.NumRegistro);

            comando.ExecuteNonQuery();
            Conexion.CloseConnection();

          
        }



        static public void cambiarEstadoCedula(string estado,int cedula) {
          
            Conexion.OpenConnection();
            string query = "Update cedulaidentidad set estado = @estado where idCedula = @cedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
           

        }
         
        static public Entidades.CedulaIdentidad obtenerCedula(int cedula)
        {
            Conexion.OpenConnection();
            Entidades.CedulaIdentidad c = new Entidades.CedulaIdentidad();

            string query = "Select * from cedulaidentidad Where idCedula = @cedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                c.IdCedula = reader.GetInt32("idCedula");
               
                c.FechaProgramada = reader.GetDateTime("fechaProgramada");
                try
                {
                    c.FechaReal = reader.GetDateTime("fechaReal");
                }
                catch {
                   
                }
                try
                {
                    c.HoraInicio = reader.GetDateTime("horaInicio");
                    c.HoraFinal = reader.GetDateTime("horaFinal");
                    c.Clima = reader.GetString("clima");
                }
                  
                catch
            {
                 
            }
                c.Cultivo = reader.GetString("cultivo");
                c.NumTractor = reader.GetString("numTractor");
                c.NumSpray = reader.GetString("numSpray");
                c.Cultivo = reader.GetString("cultivo");
                c.IdAplicacion = reader.GetInt32("idAplicacion");
                c.TotalBoonesRequeridos = reader.GetDouble("totalBoonesRequeridos");
                c.LtsRequeridos = reader.GetDouble("ltsRequeridosH");
                c.TotalLtsRequeridos = reader.GetDouble("totalLtsRequeridos");
                c.Chofer = reader.GetString("chofer");
                c.JustProgramacion = reader.GetBoolean("programacion");
                c.JustMuestreo = reader.GetBoolean("muestreo");
                c.NombreAplicacion = reader.GetString("nombreAplicacion");
                c.AreaTotal = reader.GetDouble("areaTotal");
                c.CostoTotal = reader.GetDouble("costoTotal");
                c.Etapa = reader.GetString("etapa");
                
                Conexion.CloseConnection();
                return c;
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return c;

        }
        static public void agregarInformacionAdicionalCedula(Entidades.CedulaIdentidad c)
        {

            Conexion.OpenConnection();

            string query = "Update cedulaidentidad set fechaReal = @fechaReal, horaInicio = @horaInicio, horaFinal = @horaFinal, clima = @clima where idCedula = @idCedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@fechaReal", c.FechaReal);
            comando.Parameters.AddWithValue("@horaInicio", c.HoraInicio);
            comando.Parameters.AddWithValue("@horaFinal", c.HoraFinal);
            comando.Parameters.AddWithValue("@clima", c.Clima);
            comando.Parameters.AddWithValue("@idCedula", c.IdCedula);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();

        }
        static public int obtenerUltimoDato()
        {
            int cedula= 0;
            Conexion.OpenConnection();
            string query = "SELECT * FROM cedulaIdentidad ORDER BY idCedula DESC";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cedula = reader.GetInt32("idCedula");
                Conexion.CloseConnection();
                return cedula;
            }
            Conexion.CloseConnection();
            return 0;
        }


            static public string obtenerSiguiente() {
            Conexion.OpenConnection();
            string query = "SELECT `AUTO_INCREMENT` FROM  INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'pina'  AND TABLE_NAME = 'cedulaidentidad'";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            MySqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            int i = Convert.ToInt16(dr["AUTO_INCREMENT"].ToString());
            Conexion.CloseConnection();
            return i.ToString();


        }
        static public DataTable mostrarCedula(string estado)
        {

            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "select idCedula as 'ID Cedula', lote as 'Lote',fechaCreacion as 'Fecha Creacion',etapa as 'Etapa',nombreAplicacion as 'Nombre Aplicacion',cicloAplicacion as 'Ciclo Aplicacion',costoTotal as 'Costo($)' ,fechaProgramada as 'Fecha Programada'  from cedulaidentidad where estado = @estado";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Prepare();
            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;


        }
        static public DataTable mostrarProductosCedula(Entidades.CedulaIdentidad c)
        {

            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select p.idProducto,p.nombreComercial,p.ingredienteActivo,p.dosisH as 'Dosis(H)',p.costoH as 'Costo(UM)',p.UM as 'UM',p.tipo as 'Clasificacion', p.numRegistro as '# Registro',p.dias as 'InterCosecha', p.totalDosis as 'DosisTotal', p.costo as 'CostoTotal'  from detallecedulaproductos p where p.idCedula = @idCedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idCedula", c.IdCedula);
            comando.Prepare();
            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);

            Conexion.CloseConnection();
            return dtDatos;


        }
        static public DataTable mostrarSeccionesCedula(Entidades.CedulaIdentidad c)
        {

            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "select * from detalleseccioncedula where idCedula = @idCedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idCedula", c.IdCedula);
            comando.Prepare();
            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;


        }
        static public List<Entidades.Seccion> ListSeccionesCedula(int c)
        {

            Conexion.OpenConnection();
            List<Entidades.Seccion> secciones = new List<Entidades.Seccion>();
            string query = "select * from detalleseccioncedula where idCedula = @idCedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idCedula", c);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read()) {
                Entidades.Seccion seccion = new Entidades.Seccion();

                seccion.IdLote = reader.GetInt32("lote").ToString();
                seccion.IdBloque = reader.GetInt32("bloque").ToString();
                seccion.IdSeccion = reader.GetInt32("seccion").ToString();
                secciones.Add(seccion);
            }
           
            Conexion.CloseConnection();
            return secciones;


        }
        static public List<Entidades.DetalleProductos> ListProductosCedula(int c)
        {

            Conexion.OpenConnection();
            List<Entidades.DetalleProductos> productos = new List<Entidades.DetalleProductos>();
            string query = "select * from detallecedulaproductos where idCedula = @idCedula";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idCedula", c);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.DetalleProductos producto = new Entidades.DetalleProductos();
                producto.Cedula = reader.GetInt32("idCedula");
                producto.Codigo = reader.GetInt32("idProducto");
                producto.TotalDosis = reader.GetDouble("totalDosis");
                productos.Add(producto);
            }

            Conexion.CloseConnection();
            return productos;
            
        }
        static public DataTable buscarCedula(string busqueda,string lote,string grupo, string estado)
        {

            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "select idCedula as 'ID Cedula', case when estadoAplicacion = 1 then 'Aplicada' else 'No Aplicada' end as Estado , lote as 'Lote',grupoForza as 'Grupo',fechaCreacion as 'Fecha Creacion',etapa as 'Etapa',nombreAplicacion as 'Nombre Aplicacion',cicloAplicacion as 'Ciclo Aplicacion',costoTotal as 'Costo($)', fechaProgramada as 'Fecha Programada' from cedulaidentidad where lote Like @lote and grupoForza like @grupo and estado = @estado and (idCedula like @busqueda or nombreAplicacion like @busqueda)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
            comando.Parameters.AddWithValue("@lote", lote);
            comando.Parameters.AddWithValue("@grupo", grupo);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Prepare();
          
            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
          
            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);

            Conexion.CloseConnection();
            return dtDatos;


        }


           
        

        static public void insertarDetalleSeccion(Entidades.DetalleSecciones a)
        {
            Conexion.OpenConnection();

            string query = "insert into detalleseccioncedula (idCedula,lote,bloque,seccion,area) values(@idCedula,@lote,@bloque,@seccion,@area)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idCedula", a.Cedula);
            comando.Parameters.AddWithValue("@lote", a.Lote);
            comando.Parameters.AddWithValue("@bloque", a.Bloque);
            comando.Parameters.AddWithValue("@seccion", a.Seccion);
            comando.Parameters.AddWithValue("@area", a.AreaTotal);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
        }
        static public void insertarDetalleSpray(Entidades.SprayBoom s, int cedula)
        {
            Conexion.OpenConnection();

            string query = "insert into detallecedulapray (idCedula,idSprayBoom, capacidad, psi, rpm, boquilla, km, marcha, metodo) values(@cedula,@idSprayBoom, @capacidad, @psi, @rpm, @boquilla, @km, @marcha, @metodo)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@cedula", cedula);
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

        static public List<Entidades.Lote> buscarLotes()
        {
            List<Entidades.Lote> lotes = new List<Entidades.Lote>();
            Conexion.OpenConnection();
            Entidades.Lote b = new Entidades.Lote();

            string query = "Select DISTINCT lote from cedulaIdentidad ORDER BY lote";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                b = new Entidades.Lote();
                b.IdLote = reader.GetString("lote");
                lotes.Add(b);
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return lotes;

        }
        static public List<Entidades.GrupoForza> buscarGrupo()
        {
            List<Entidades.GrupoForza> grupos = new List<Entidades.GrupoForza>();
            Conexion.OpenConnection();
            Entidades.GrupoForza b = new Entidades.GrupoForza();

            string query = "Select DISTINCT grupoForza from cedulaIdentidad ORDER BY grupoForza";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                b = new Entidades.GrupoForza();
                b.IdGrupo = reader.GetString("grupoForza");
                grupos.Add(b);
            }
            //retorna valores nulos en caso de no encontrar coincidencias
            Conexion.CloseConnection();
            return grupos;

        }
    }
    
}
