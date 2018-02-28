using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Pedido
    {
        static public List<Entidades.DetallePedido> getPedido(double area,int aplicacion,string etapa,ref List<Entidades.DetallePedido> l)
        {
            bool encontro = false;
            Conexion.OpenConnection();
        
            MySqlCommand comando = new MySqlCommand("obtenerDetalleAplicacion", Conexion.Connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_area", area);
            comando.Parameters.AddWithValue("_aplicacion", aplicacion);
            comando.Parameters.AddWithValue("_etapa", etapa);
            comando.ExecuteNonQuery();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.DetallePedido d = new Entidades.DetallePedido();
                d.IProducto = reader.GetString("idproducto");
                d.Nombre = reader.GetString("nombre");
                d.Unidad = reader.GetString("unidad");
                d.Area = reader.GetDouble("_area");
                d.DosisTotal = reader.GetDouble("dosisTotal");
                d.CostoH = reader.GetDouble("costo");
                d.CostoTotal = reader.GetDouble("costoTotal");
                foreach (Entidades.DetallePedido detalle in l) {

                    if (detalle.IProducto == d.IProducto)
                    {
                    
                        detalle.Area += d.Area;
                        detalle.DosisTotal += d.DosisTotal;
                        detalle.CostoTotal += d.CostoTotal;
                        encontro = true;
                        break;

                    }
                    
                   


                }

                if (!encontro)
                {
                    l.Add(d);

                }
                else {
                    encontro = false;
                }


            }
            Conexion.CloseConnection();
            return l;
        }

    }
}
