using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;

namespace MI_DataLayer
{
    public class clsoperation
    {
        private string strMsg = "";
        private string StrOperationError;

        protected MySqlConnection Conn;
        protected MySqlCommand ObjCmd;
        protected MySqlTransaction DbTrans;

        protected OleDbConnection Ora_Conn;
        protected OleDbCommand Ora_ObjCmd;
        protected OleDbTransaction Ora_DbTrans;

        protected OleDbConnection Access_Conn;
        protected OleDbCommand Access_ObjCmd;
        protected OleDbTransaction Access_DbTrans;

        protected clsdbconnection Objconn = new clsdbconnection();

        public clsoperation()
        {
        }

        #region "Properties"

        public string OperationError
        {
            get { return StrOperationError; }
            set { StrOperationError = value; }
        }

        public string StrMsg
        {
            set { strMsg = value; }
        }

        /// <summary>
        /// For Mysql
        /// </summary>
        /// 
        public MySqlConnection GetConnection
        {
            get { return Conn; }
        }

        public MySqlTransaction DBTransaction
        {
            get { return DbTrans; }
        }

        /// <summary>
        /// For Oracle
        /// </summary>

        public OleDbConnection GetOraConnection
        {
            get { return Ora_Conn; }
        }

        public OleDbTransaction OraDBTransaction
        {
            get { return Ora_DbTrans; }
        }
        /// <summary>
        /// 
        /// </summary>
        public OleDbConnection GetAccessConnection
        {
            get { return Access_Conn; }
        }

        public OleDbTransaction AccessDBTransaction
        {
            get { return Access_DbTrans; }
        }

        #endregion

        #region "Enumeration"

        public enum Get_PKey : byte
        {
            Yes = 1,
            No = 2
        }
        #endregion

        #region "Error_Transction"
     
        /// <summary>
        /// For Mysql
        /// </summary>
        
        public void Open_Connection()
        {
            // Get Database connection
            Conn = Objconn.Odbc_SQL_Connection;
        }

        public void Start_Transaction()
        {
            // Declare Transaction Variable by beginning a new transaction
            DbTrans = Conn.BeginTransaction();
        }

        public void End_Transaction()
        {
            if (strMsg.Equals("Error"))
            {
                // Rollback transaction
                DbTrans.Rollback();
            }
            else
            {
                // commit transaction
                DbTrans.Commit();
            }
        }

        public void Close_Connection()
        {
            Conn.Close();
            Conn.Dispose();
            Conn = null;
        }

        /// <summary>
        /// For Oracle
        /// </summary>

        public void Open_OraConnection()
        {
            // Get Database connection
            Ora_Conn = Objconn.oledb_Ora_Connection;
        }

        public void Start_OraTransaction()
        {
            // Declare Transaction Variable by beginning a new transaction
            Ora_DbTrans = Ora_Conn.BeginTransaction();
        }

        public void End_OraTransaction()
        {
            if (strMsg.Equals("Error"))
            {
                // Rollback transaction
                Ora_DbTrans.Rollback();
            }
            else
            {
                // commit transaction
                Ora_DbTrans.Commit();
            }
        }

        public void Close_OraConnection()
        {
            Ora_Conn.Close();
            Ora_Conn.Dispose();
            Ora_Conn = null;
        }

///
        public void Open_AccessConnection()
        {
            // Get Database connection
            Access_Conn = Objconn.oledb_Access_Connection;
        }

        public void Start_AccessTransaction()
        {
            // Declare Transaction Variable by beginning a new transaction
            Access_DbTrans = Access_Conn.BeginTransaction();
        }

        public void End_AccessTransaction()
        {
            if (strMsg.Equals("Error"))
            {
                // Rollback transaction
                Access_DbTrans.Rollback();
            }
            else
            {
                // commit transaction
                Access_DbTrans.Commit();
            }
        }

        public void Close_AccessConnection()
        {
            Access_Conn.Close();
            Access_Conn.Dispose();
            Access_Conn = null;
        }

#endregion

        #region DataAccess

        /// 
        /// <summary>
        /// For MYsql
        /// </summary>
        /// 
        public string DataTrigger_Insert(Iinterface Entity)
        {
            try
            {
                ObjCmd = Entity.Insert();
                ObjCmd.Connection = Conn;
                ObjCmd.Transaction = DbTrans;
                ObjCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Record can not be inserted.";
                strMsg = "Error";
            }

            return strMsg;
        }

        public string DataTrigger_Update(Iinterface Entity)
        {
            try
            {
                ObjCmd = Entity.Update();
                ObjCmd.Connection = Conn;
                ObjCmd.Transaction = DbTrans;
                ObjCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Record can not be updated.";
                strMsg = "Error";
            }

            return strMsg;
        }

        public string DataTrigger_Delete(Iinterface Entity)
        {
            ObjCmd = Entity.Delete();
            ObjCmd.Transaction = DbTrans;

            try
            {
                ObjCmd.Connection = Conn;
                ObjCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Record can not be deleted.";
                strMsg = "Error";
            }

            return strMsg;
        }

        public DataView DataTrigger_Get_All(Iinterface Entity)
        {
            ObjCmd = Entity.Get_All();
            ObjCmd.Connection = Conn;

            try { ObjCmd.Transaction = DbTrans; }
            catch { }

            MySqlDataAdapter da = new MySqlDataAdapter(ObjCmd);
            DataSet DS = new DataSet();
            da.Fill(DS);

            DataView DV = new DataView(DS.Tables[0]);

            return DV;
        }

        public DataView DataTrigger_Get_Single(Iinterface Entity)
        {
            // Get Database connection
            Conn = Objconn.Odbc_SQL_Connection;

            ObjCmd = Entity.Get_Single();
            ObjCmd.Connection = Conn;

            // Dataadapter
            MySqlDataAdapter da = new MySqlDataAdapter(ObjCmd);

            // fill dataset
            DataSet DS = new DataSet();
            da.Fill(DS);

            // Create the DataView Object
            DataView DV = new DataView(DS.Tables[0]);

            return DV;
        }

        public string DataTrigger_Get_Max(Iinterface Entity)
        {
            try
            {
                ObjCmd = Entity.Get_Max();
                ObjCmd.Connection = Conn;

                try { ObjCmd.Transaction = DbTrans; }
                catch { }

                MySqlDataAdapter da = new MySqlDataAdapter(ObjCmd);
                DataSet DS = new DataSet();
                da.Fill(DS);

                return DS.Tables[0].Rows[0]["MaxID"].ToString();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Maximum Primary Key can not be extracted.";
                strMsg = "Error";
            }

            return strMsg;
        }

        /// <summary>
        /// For Oracle
        /// </summary>
        
        public string DataTrigger_OraInsert(Iinterface Entity)
        {
            try
            {
                Ora_ObjCmd = Entity.OraInsert();
                Ora_ObjCmd.Connection = Ora_Conn;
                Ora_ObjCmd.Transaction = Ora_DbTrans;
                Ora_ObjCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Record can not be inserted.";
                strMsg = "Error";
            }

            return strMsg;
        }

        public string DataTrigger_OraUpdate(Iinterface Entity)
        {
            try
            {
                Ora_ObjCmd = Entity.OraUpdate();
                Ora_ObjCmd.Connection = Ora_Conn;
                Ora_ObjCmd.Transaction = Ora_DbTrans;
                Ora_ObjCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Record can not be updated.";
                strMsg = "Error";
            }

            return strMsg;
        }

        public string DataTrigger_OraDelete(Iinterface Entity)
        {
            Ora_ObjCmd = Entity.OraDelete();
            Ora_ObjCmd.Transaction = Ora_DbTrans;

            try
            {
                Ora_ObjCmd.Connection = Ora_Conn;
                Ora_ObjCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Record can not be deleted.";
                strMsg = "Error";
            }

            return strMsg;
        }

        public DataView DataTrigger_OraGet_All(Iinterface Entity)
        {
            Ora_ObjCmd = Entity.OraGet_All();
            Ora_ObjCmd.Connection = Ora_Conn;

            try { Ora_ObjCmd.Transaction = Ora_DbTrans; }
            catch { }

            OleDbDataAdapter da = new OleDbDataAdapter(Ora_ObjCmd);
            DataSet DS = new DataSet();
            da.Fill(DS);

            DataView DV = new DataView(DS.Tables[0]);

            return DV;
        }

        public DataView DataTrigger_OraGet_Single(Iinterface Entity)
        {
            // Get Database connection
            Ora_Conn = Objconn.oledb_Ora_Connection;

            Ora_ObjCmd = Entity.OraGet_Single();
            Ora_ObjCmd.Connection = Ora_Conn;

            // Dataadapter
            OleDbDataAdapter da = new OleDbDataAdapter(Ora_ObjCmd);

            // fill dataset
            DataSet DS = new DataSet();
            da.Fill(DS);

            // Create the DataView Object
            DataView DV = new DataView(DS.Tables[0]);

            return DV;
        }

        public string DataTrigger_OraGet_Max(Iinterface Entity)
        {
            try
            {
                Ora_ObjCmd = Entity.OraGet_Max();
                Ora_ObjCmd.Connection = Ora_Conn;

                try { Ora_ObjCmd.Transaction = Ora_DbTrans; }
                catch { }

                OleDbDataAdapter da = new OleDbDataAdapter(Ora_ObjCmd);
                DataSet DS = new DataSet();
                da.Fill(DS);

                return DS.Tables[0].Rows[0]["MaxID"].ToString();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Maximum Primary Key can not be extracted.";
                strMsg = "Error";
            }

            return strMsg;
        }

        /// Access
        /// 
        public string DataTrigger_AccessInsert(Iinterface Entity)
        {
            try
            {
                Access_ObjCmd = Entity.OraInsert();
                Access_ObjCmd.Connection = Access_Conn;
                Access_ObjCmd.Transaction = Access_DbTrans;
                Access_ObjCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Record can not be inserted.";
                strMsg = "Error";
            }

            return strMsg;
        }

        public string DataTrigger_AccessUpdate(Iinterface Entity)
        {
            try
            {
                Access_ObjCmd = Entity.OraUpdate();
                Access_ObjCmd.Connection = Access_Conn;
                Access_ObjCmd.Transaction = Access_DbTrans;
                Access_ObjCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Record can not be updated.";
                strMsg = "Error";
            }

            return strMsg;
        }

        public string DataTrigger_AccessDelete(Iinterface Entity)
        {
            Access_ObjCmd = Entity.AccessDelete();
            Access_ObjCmd.Transaction = Access_DbTrans;

            try
            {
                Access_ObjCmd.Connection = Access_Conn;
                Access_ObjCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Record can not be deleted.";
                strMsg = "Error";
            }

            return strMsg;
        }

        public DataView DataTrigger_AccessGet_All(Iinterface Entity)
        {
            Access_ObjCmd = Entity.AccessGet_All();
            Access_ObjCmd.Connection = Access_Conn;

            try { Ora_ObjCmd.Transaction = Access_DbTrans; }
            catch { }

            OleDbDataAdapter da = new OleDbDataAdapter(Access_ObjCmd);
            DataSet DS = new DataSet();
            da.Fill(DS);

            DataView DV = new DataView(DS.Tables[0]);

            return DV;
        }

        public DataView DataTrigger_AccessGet_Single(Iinterface Entity)
        {
            // Get Database connection
            Access_Conn = Objconn.oledb_Access_Connection;

            Access_ObjCmd = Entity.AccessGet_Single();
            Access_ObjCmd.Connection = Access_Conn;

            // Dataadapter
            OleDbDataAdapter da = new OleDbDataAdapter(Access_ObjCmd);

            // fill dataset
            DataSet DS = new DataSet();
            da.Fill(DS);

            // Create the DataView Object
            DataView DV = new DataView(DS.Tables[0]);

            return DV;
        }

        public string DataTrigger_AccessGet_Max(Iinterface Entity)
        {
            try
            {
                Access_ObjCmd = Entity.AccessGet_Max();
                Access_ObjCmd.Connection = Access_Conn;

                try { Access_ObjCmd.Transaction = Access_DbTrans; }
                catch { }

                OleDbDataAdapter da = new OleDbDataAdapter(Access_ObjCmd);
                DataSet DS = new DataSet();
                da.Fill(DS);

                return DS.Tables[0].Rows[0]["MaxID"].ToString();
            }
            catch (Exception e)
            {
                OperationError = (e.Message) + "Sorry, Maximum Primary Key can not be extracted.";
                strMsg = "Error";
            }

            return strMsg;
        }

        #endregion
    }
}
