using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    static public class Conexion
    {

        static private string server = "localhost";
        static private string database = "pina";
        static private string uid = "root";
        static private string password = "lmora";
        static string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        static private MySqlConnection connection = new MySqlConnection(connectionString);

        public static MySqlConnection Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }


      static public void OpenConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                { connection.Open(); }
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        throw new Exception("Cannot connect to server.  Contact administrator", ex);

                    case 1045:
                        throw new Exception("Invalid username/password, please try again");
                }
               
            }
        }


        //Close connection
        static public void CloseConnection()
        {
            try
            {
               if (connection.State == ConnectionState.Open)
                { connection.Close(); }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Initialize values

    }

    }

