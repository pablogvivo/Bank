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

        /// <summary>
        /// create the Client entry and the account entry
        /// </summary>
        /// <param name="name">Name of the client</param>
        /// <param name="surname">Surname of the client</param>
        /// <param name="telephone">Telephone of the client</param>
        /// <param name="email">Email of the client</param>
        /// <param name="iban">IBAN of the account</param>
        public void createClient(String name, String surname, String telephone, String email, String iban)
        {
            try
            {
                Connect();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "wrtclient";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("namecl", name);
                cmd.Parameters["namecl"].Direction = System.Data.ParameterDirection.Input;
                cmd.Parameters.AddWithValue("surname", surname);
                cmd.Parameters["surname"].Direction = System.Data.ParameterDirection.Input;
                cmd.Parameters.AddWithValue("telephone", telephone);
                cmd.Parameters["telephone"].Direction = System.Data.ParameterDirection.Input;
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters["email"].Direction = System.Data.ParameterDirection.Input;
                cmd.Parameters.AddWithValue("iban", iban);
                cmd.Parameters["iban"].Direction = System.Data.ParameterDirection.Input;
                MySqlDataReader rdr = cmd.ExecuteReader();
                Close();
            }
            catch (Exception ex)
            {
                errors.Add("Error creating user " + ex.ToString());

            }
        }
        /// <summary>
        /// Deposit money in an account
        /// </summary>
        /// <param name="Iban">IBAN of the account to deposit money</param>
        /// <param name="money"></param>
        public void deposit(String Iban, float money)
        {
            try
            {
                Connect();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "deposit";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ibannum", Iban);
                cmd.Parameters["ibannum"].Direction = System.Data.ParameterDirection.Input;
                cmd.Parameters.AddWithValue("depmoney", money);
                cmd.Parameters["depmoney"].Direction = System.Data.ParameterDirection.Input;
                MySqlDataReader rdr = cmd.ExecuteReader();
                Close();
            }
            catch (Exception ex)
            {
                errors.Add("Error making deposit " + ex.ToString());

            }
        }
        /// <summary>
        /// Transfer money between two acccounts
        /// </summary>
        /// <param name="IbanSend">IBAN of the account that send money</param>
        /// <param name="IbanRecv">IBAN of the account that receive money</param>
        /// <param name="money">Money to transfer</param>
        /// <returns></returns>
        public bool transfer(String IbanSend, String IbanRecv, float money)
        {
            try
            {
                Connect();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "transfer";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ibanSend", IbanSend);
                cmd.Parameters["ibanSend"].Direction = System.Data.ParameterDirection.Input;
                cmd.Parameters.AddWithValue("ibanRecv", IbanRecv);
                cmd.Parameters["ibanRecv"].Direction = System.Data.ParameterDirection.Input;
                cmd.Parameters.AddWithValue("depmoney", money);
                cmd.Parameters["depmoney"].Direction = System.Data.ParameterDirection.Input;
                MySqlDataReader rdr = cmd.ExecuteReader();
                Close(); 
                return true;
            }
            catch (Exception ex)
            {
                errors.Add("Error making transfer " + ex.ToString());
                return false;

            }
        }

        #endregion
    }
}
