using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace MI_DataLayer
{
    public class clsdbconnection
    {
        private string _Flag = "";

        public string Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }

        public clsdbconnection()
        {
        }

        #region Enumerations

        public enum ConnectionType
        {
            MySQL = 1,
            SQLSERVER = 2,
            Oracle = 3,
            ACCESS=4
        }

        #endregion

        #region "Properties"

        /// <summary>
        /// Get SQL Server Connection
        /// </summary>

        public MySqlConnection Odbc_SQL_Connection
        {
            get { return Dbconnection(clsdbconnection.ConnectionType.MySQL); }
        }

        public OleDbConnection oledb_Ora_Connection
        {
            get { return DbconnectionOra(clsdbconnection.ConnectionType.Oracle); }
        }

        public OleDbConnection oledb_Access_Connection
        {
            get { return DbconnectionAccess(clsdbconnection.ConnectionType.ACCESS); }
        }

        #endregion

        #region "Connection String"

        private MySqlConnection Dbconnection(ConnectionType ConnectToDB)
        {
            string StrConnection = null;

            if (ConnectToDB == ConnectionType.MySQL)
            {
                StrConnection = "Server = localhost; Port = 3306; Database = mi; Uid = root; Pwd =trs_mi_rmi";
                //StrConnection = "Server = localhost; Port = 3306; Database = MI; Uid = root; Pwd = 123";
            }
            else if (ConnectToDB == ConnectionType.SQLSERVER)
            {
                StrConnection = "";
            }
            MySqlConnection Conn = new MySqlConnection(StrConnection);
            try
            {
                Conn.Open();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            return Conn;
        }

        private OleDbConnection DbconnectionOra(ConnectionType ConnectToDB)
        {
            string StrConnection = null;

            if (ConnectToDB == ConnectionType.Oracle)
            {
                StrConnection = "Provider=MSDAORA.1;User ID=whims;Data Source=HIMS;Password=whims";
            }
            else if (ConnectToDB == ConnectionType.SQLSERVER)
            {
                StrConnection = "";
            }
            OleDbConnection Conn = new OleDbConnection(StrConnection);
            try
            {
                Conn.Open();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            return Conn;
        }

        private OleDbConnection DbconnectionAccess(ConnectionType ConnectToDB)
        {
            string StrConnection = null;

            if (ConnectToDB == ConnectionType.ACCESS)
            {
                StrConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Configuration.ConfigurationSettings.AppSettings["ImmuliteAccessPath"].ToString();
            }
            else if (ConnectToDB == ConnectionType.SQLSERVER)
            {
                StrConnection = "";
            }
            OleDbConnection Conn = new OleDbConnection(StrConnection);
            try
            {
                Conn.Open();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            return Conn;
        }

        #endregion
    }
}
