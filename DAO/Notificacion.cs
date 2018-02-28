using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class Notificacion
    {
        static public List<Entidades.Fecha> Eventos()
        {
            int dias = DAO.Configuracion.getConfiguracion().FrecuenciaCorreos;
            List<Entidades.Fecha> eventos = new List<Entidades.Fecha>();
            Conexion.OpenConnection();
            string query = "call eventosProximos(@dias)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@dias", dias);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Entidades.Fecha fecha = new Entidades.Fecha() ;
                fecha.Lote = reader.GetString("idLote");
                fecha.Bloque  = reader.GetString("idBloque");
                fecha.Seccion= reader.GetString("idSeccion");
                fecha.FechaProgramada = reader.GetDateTime("fechaProgramada");
                fecha.Posicion = reader.GetInt32("posicion");
                fecha.Aplicacion = reader.GetString("nombre");
                eventos.Add(fecha);
            }
            Conexion.CloseConnection();
            return eventos;
        }
        static public DataTable getEventos()
        {
            DataTable dtDatos = new DataTable();
            int dias = DAO.Configuracion.getConfiguracion().FrecuenciaCorreos;
            List<Entidades.Fecha> eventos = new List<Entidades.Fecha>();
            Conexion.OpenConnection();
            string query = "call eventosProximos(@dias)";

            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@dias", dias);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }
        static public DataTable ProductosAgotados()
        {
            DataTable dtDatos = new DataTable();
           
            List<Entidades.Notificacion> l = new List<Entidades.Notificacion>();
            Conexion.OpenConnection();
            string query = "Select idProducto,nombre,ingredienteActivo,unidad,cantidad,minimo,maximo from producto Where cantidad <= minimo";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            dtDatos.Columns.Add("Causa");
            
            Conexion.CloseConnection();
            return dtDatos;
       
        }
        static public List<string> getCorreos()
        {
            List<string> l = new List<string>();
            Conexion.OpenConnection();
            string query = "Select* from correos";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) { l.Add(reader.GetString("correo")); }
            Conexion.CloseConnection();
            return l;
        }
        static public DataTable getCorreosTabla()
        {
            Conexion.OpenConnection();
            DataTable dtDatos = new DataTable();
            string query = "Select* from correos";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(comando);
            mdaDatos.Fill(dtDatos);
            Conexion.CloseConnection();
            return dtDatos;
        }
        static public void insertarCorreo(string correo)
        {
            Conexion.OpenConnection();
            string query = "INSERT INTO correos(correo) VALUES (@correo)";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Prepare();
            comando.ExecuteNonQuery();

            Conexion.CloseConnection();
        }
        static public void eliminarCorreo(string correo)
        {
            Conexion.OpenConnection();
            string query = "DELETE FROM correos WHERE correo = @correo";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Prepare();
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
        }
        static public void EnviarCorreos()
        {
            DataTable data = getEventos();
            List<string> correos = getCorreos();
            if (correos.Count == 0) { System.Windows.Forms.MessageBox.Show("No hay correos registrados"); return; }
            if (data.Rows.Count == 0) { System.Windows.Forms.MessageBox.Show("No hay eventos proximos registrados"); return; }
            string body = getHtml(data);
            MailMessage message = new MailMessage();
            foreach (string correo in correos) { message.To.Add(new MailAddress(correo)); }
            message.From = new MailAddress("PinaAlegreNotifications@gmail.com");
            message.Subject = "PIÑA: Notificacion de Eventos";
            message.IsBodyHtml = true;
            message.Body = body;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            NetworkCredential credentials = new NetworkCredential("PinaAlegreNotifications@gmail.com", "pinacolada");
            client.Credentials = credentials;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }
        static public void EnviarCorreosHome()
        {
            DataTable data = getEventos();
            List<string> correos = getCorreos();
            if (getEstadoNotificaciones()) { return; }
            if (correos.Count == 0) {  return; }
            if (data.Rows.Count == 0) { return; }
            string body = getHtml(data);
            MailMessage message = new MailMessage();
            foreach (string correo in correos) { message.To.Add(new MailAddress(correo)); }
            message.From = new MailAddress("PinaAlegreNotifications@gmail.com");
            message.Subject = "PIÑA: Notificacion de Eventos";
            message.IsBodyHtml = true;
            message.Body = body;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            NetworkCredential credentials = new NetworkCredential("PinaAlegreNotifications@gmail.com", "pinacolada");
            client.Credentials = credentials;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }
        /*     static public void EnviarCorreos()
             {
                 List<string> correos = getCorreos();
             //    List<Entidades.Notificacion> notificaciones = Eventos();
                 if (correos.Count == 0) { System.Windows.Forms.MessageBox.Show("No hay correos registrados"); return; }
                 if (notificaciones.Count == 0) { System.Windows.Forms.MessageBox.Show("No hay eventos proximos registrados"); return; }

                 string body = "EVENTOS PROXIMOS\n------------------\n";
                 foreach (Entidades.Notificacion n in notificaciones)
                 {
                     body = body + n.Contenido + "\n------------------\n";
                 }

                 MailMessage message = new MailMessage();
                 foreach (string correo in correos) { message.To.Add(new MailAddress(correo)); }
                 message.From = new MailAddress("PinaAlegreNotifications@gmail.com");
                 message.Subject = "PIÑA: Notificacion de Eventos";
                 message.Body = body;

                 SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

                 NetworkCredential credentials = new NetworkCredential("PinaAlegreNotifications@gmail.com", "pinacolada");
                 client.Credentials = credentials;
                 client.EnableSsl = true;
                 client.DeliveryMethod = SmtpDeliveryMethod.Network;

                 try
                 {
                     client.Send(message);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error: " + ex.ToString());
                 }

             }

             static public void EnviarCorreosHome()
             {
                 List<string> correos = getCorreos();
            //     List<Entidades.Notificacion> notificaciones = Eventos();
                 if (correos.Count == 0) { return; }
              //   if (notificaciones.Count == 0) { return; }
                 if (getEstadoNotificaciones()) { return; }

                 string body = "EVENTOS PROXIMOS\n------------------\n";
                 foreach (Entidades.Notificacion n in notificaciones)
                 {
                     body = body+n.Contenido+ "\n------------------\n";
                 }

                 MailMessage message = new MailMessage();
                 foreach (string correo in correos) { message.To.Add(new MailAddress(correo)); }
                 message.From = new MailAddress("PinaAlegreNotifications@gmail.com");
                 message.Subject = "PIÑA: Notificacion de Eventos";
                 message.Body = body;

                 SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                 client.EnableSsl = true;

                 NetworkCredential credentials = new NetworkCredential("PinaAlegreNotifications@gmail.com", "pinacolada");
                 client.Credentials = credentials;
                 client.DeliveryMethod = SmtpDeliveryMethod.Network;

                 try
                 {
                     client.Send(message);
                     setEstadoNotificaciones();
                 }
                 catch (Exception ex)
                 {
                     System.Windows.Forms.MessageBox.Show("Error: " + ex.ToString());
                 }
             }
             */

        static bool getEstadoNotificaciones()
        {
            Conexion.OpenConnection();
            string query = "Select* from notificacion WHERE fecha LIKE curdate()";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) { Conexion.CloseConnection(); return true; }
            Conexion.CloseConnection();
            return false;
        }
        static void setEstadoNotificaciones()
        {
            Conexion.OpenConnection();
            string query = "UPDATE notificacion SET fecha = curdate()";
            MySqlCommand comando = new MySqlCommand(query, Conexion.Connection);
            comando.Prepare();
            comando.ExecuteNonQuery();
            Conexion.CloseConnection();
        }
        public static string getHtml(DataTable data)
        {
            try
            {
                string messageBody = "<font>Proximos Eventos: </font><br><br>";

                if (data.Rows.Count == 0)
                { return  null; }
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style =\"background-color:#6FA1D2; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style =\"color:#555555;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";

                messageBody += htmlTableStart;
                messageBody += htmlHeaderRowStart;
                messageBody += htmlTdStart + "idLote " + htmlTdEnd;
                messageBody += htmlTdStart + "idBloque " + htmlTdEnd;
                messageBody += htmlTdStart + "idSeccion " + htmlTdEnd;
                messageBody += htmlTdStart + "idPaquete " + htmlTdEnd;
                messageBody += htmlTdStart + "posicion " + htmlTdEnd;
                messageBody += htmlTdStart + "nombre " + htmlTdEnd;
                messageBody += htmlTdStart + "fechaProgramada " + htmlTdEnd;
                messageBody += htmlHeaderRowEnd;

                foreach (DataRow Row in data.Rows)
                {
                    messageBody = messageBody + htmlTrStart;
                    messageBody = messageBody + htmlTdStart + Row["idLote"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["idBloque"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["idSeccion"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["idPaquete"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["posicion"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["nombre"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["fechaProgramada"] + htmlTdEnd;
                    messageBody = messageBody + htmlTrEnd;
                }
                messageBody = messageBody + htmlTableEnd;


            return messageBody;
                
            }
            catch (Exception ex)
            {
                return null ;
            }
        }
    }
}
