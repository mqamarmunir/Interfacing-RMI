using System;
using System.Collections.Generic;
using System.Text;
using MI_DataLayer;

namespace MI_BL
{
    public class clsBLDBConnection
    {
        public clsoperation _objOperation;

        public clsBLDBConnection()
        {
            _objOperation = new clsoperation();
        }

        public void Connection_Open()
        {
            _objOperation.Open_Connection();
        }

        public void Transaction_Begin()
        {
            _objOperation.Start_Transaction();
        }

        public void Transaction_ComRoll()
        {
            _objOperation.End_Transaction();
        }

        public void Connection_Close()
        {
            _objOperation.Close_Connection();
        }

        /// <summary>
        /// For Oralcle
        /// </summary>
        /// 
        public void OraConnection_Open()
        {
            _objOperation.Open_OraConnection();
        }

        public void OraTransaction_Begin()
        {
            _objOperation.Start_OraTransaction();
        }

        public void OraTransaction_ComRoll()
        {
            _objOperation.End_OraTransaction();
        }

        public void OraConnection_Close()
        {
            _objOperation.Close_OraConnection();
        }

        public void SetRollBackStatus()
        {
            _objOperation.StrMsg = "Error";
        }

        /// <summary>
        /// For MSACCESS
        /// </summary>
        /// 
        public void AccessConnection_Open()
        {
            _objOperation.Open_AccessConnection();
        }

        public void AccessTransaction_Begin()
        {
            _objOperation.Start_AccessTransaction();
        }

        public void AccessTransaction_ComRoll()
        {
            _objOperation.End_AccessTransaction();
        }

        public void AccessConnection_Close()
        {
            _objOperation.Close_AccessConnection();
        }
    }
}
