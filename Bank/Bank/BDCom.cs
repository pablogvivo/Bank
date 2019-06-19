using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bank
{
    class BDCom
    {
        //////////////////////////////////
        //          VARIABLES           //
        //////////////////////////////////

        private MySqlConnection connection;
        private string _server, _database, _uid, _password, _connectionString;
        private List<String> errors;
        public List<string> Errors
        {
            get => errors;
        }

        //////////////////////////////////
        //        CONSTRUCTORS          //
        //////////////////////////////////

        #region Constructors
        /// <summary>
        /// Inicializa una conexion con la base de datos
        /// </summary>
        /// <param name="Server">Servidor al que nos conectamos</param>
        /// <param name="Database">Base de datos a la que conectarse</param>
        /// <param name="UID">Usuario con el que nos conectamos</param>
        /// <param name="Password">Password para conectarse</param>
        public BDCom(String Server, String Database, String UID, String Password)
        {
            _server = Server;
            _database = Database;
            _uid = UID;
            _password = Password;
            _connectionString = "SERVER=" + _server + ";" + "DATABASE=" +
            _database + ";" + "UID=" + _uid + ";" + "PASSWORD=" + _password + ";";
            errors = new List<string>();
        }
        #endregion

        //////////////////////////////////
        //           MEMBERS            //
        //////////////////////////////////

        #region Members            
        /// <summary>
        /// Open the connection 
        /// </summary>
        /// <returns></returns>    
        private bool Connect()
        {
            try
            {
                connection = new MySqlConnection(_connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                errors.Add("Error connecting to the database " + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Close the connection to the database
        /// </summary>
        /// <returns></returns>
        private bool Close()
        {
            try
            {
                connection.Close();
                connection.Dispose();
                return true;
            }
            catch
            {
                errors.Add("Error closing MySQL server connection");
                return false;
            }
        }


        #endregion
    }
}
