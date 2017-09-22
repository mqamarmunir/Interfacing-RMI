using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;

namespace MI_DataLayer
{
    public class clsdbMI : Iinterface
    {
        public clsdbMI()
        {
        }

        # region "Class_Variables"

        private string StrQuery = null;

        # endregion

        #region "Properties"

        public string Query
        {
            get { return StrQuery; }
            set { StrQuery = value; }
        }

        # endregion

        # region "Data_Methods"

        /// <summary>
        /// For MySql DataBase 
        /// </summary>
        /// <returns></returns>
        /// 
        public MySqlCommand Insert()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public MySqlCommand Update()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public MySqlCommand Delete()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public MySqlCommand Get_All()
        {
            MySqlCommand objCommand = new MySqlCommand();
            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public MySqlCommand Get_Single()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public MySqlCommand Get_Max()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        ///
        /// For Oracle Connection
        ///

        public OleDbCommand OraInsert()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public OleDbCommand OraGet_Max()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public OleDbCommand OraUpdate()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public OleDbCommand OraDelete()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public OleDbCommand OraGet_All()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public OleDbCommand OraGet_Single()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        ///MS Access
        ///
        public OleDbCommand AccessInsert()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public OleDbCommand AccessGet_Max()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public OleDbCommand AccessUpdate()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public OleDbCommand AccessDelete()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public OleDbCommand AccessGet_All()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public OleDbCommand AccessGet_Single()
        {
            OleDbCommand objCommand = new OleDbCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }


        #endregion
        

    }
}
