using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PaqueteProducto
    {
        static public void insertarAplicacion(Entidades.PaqueteProducto a)
        {

            Conexion.OpenConnection();
            string query = "insert into paqueteproducto (idAplicacion,idProducto,dosis,unidad,etapa) values(@idAplicacion,@idProducto,@dosis,@unidad,@etapa)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idAplicacion", a.IdAplicacion);
            comando.Parameters.AddWithValue("@idProducto", a.IdProducto);
            comando.Parameters.AddWithValue("@dosis", a.Dosis);
            comando.Parameters.AddWithValue("@unidad", a.Unidad);
            comando.Parameters.AddWithValue("@etapa", a.IdEtapa);
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
       
        }

        static public void eliminarAplicacion(Entidades.PaqueteProducto a)
        {

            Conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE from paqueteproducto where idAplicacion = @idAplicacion and etapa =@etapa and idProducto =@idProducto", Conexion.Connection);
            cmd.Parameters.AddWithValue("@idAplicacion", a.IdAplicacion);
            cmd.Parameters.AddWithValue("@idProducto", a.IdProducto);
            cmd.Parameters.AddWithValue("@etapa", a.IdEtapa);
            cmd.ExecuteNonQuery();
            Conexion.CloseConnection();

        }

        static public void modificarDosis(Entidades.PaqueteProducto a)
        {

            Conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE paqueteproducto SET dosis = @dosis WHERE idProducto = @idProducto AND idAplicacion = @idAplicacion and etapa = @etapa", Conexion.Connection);
            cmd.Parameters.AddWithValue("@dosis", a.Dosis);
            cmd.Parameters.AddWithValue("@idAplicacion", a.IdAplicacion);
            cmd.Parameters.AddWithValue("@idProducto", a.IdProducto);
            cmd.Parameters.AddWithValue("@etapa", a.IdEtapa);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Conexion.CloseConnection();

        }
        static public DataTable mostrarProductos(int idAplicacion,string etapa)
        {

            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base

            string query = "select p.idProducto,p.nombre,p.ingredienteActivo,pc.dosis as 'Dosis(H)',p.costo as 'Costo(UM)',p.unidad as 'UM',p.tipo as 'Clasificacion', p.numRegistro as '# Registro',p.periodoReingreso as 'P.Reing(H)',p.dias as 'InterCosecha' from paqueteproducto pc inner join producto p on pc.idProducto = p.idProducto where pc.idAplicacion = @idAplicacion and pc.etapa = @etapa";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idAplicacion", idAplicacion);
            comando.Parameters.AddWithValue("@etapa", etapa);
            
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;


        }


        static public DataTable mostrarProductosEtapa(int idAplicacion, string etapa)
        {

            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base

            string query = "select p.idProducto,p.nombre,p.ingredienteActivo, pc.dosis as 'Dosis(H)',p.unidad as 'UM',p.dias as 'InterCosecha' from paqueteproducto pc inner join producto p on pc.idProducto = p.idProducto where pc.idAplicacion = @idAplicacion and pc.etapa = @etapa";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@idAplicacion", idAplicacion);
            comando.Parameters.AddWithValue("@etapa", etapa);

            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;


        }


    }
}
