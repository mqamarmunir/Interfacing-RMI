using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace MI_DataLayer
{
    public interface Iinterface
    {
        #region "Methods"

        MySqlCommand Insert();

        MySqlCommand Update();

        MySqlCommand Delete();

        MySqlCommand Get_All();

        MySqlCommand Get_Single();

        MySqlCommand Get_Max();

        OleDbCommand OraInsert();

        OleDbCommand OraUpdate();

        OleDbCommand OraDelete();

        OleDbCommand OraGet_All();

        OleDbCommand OraGet_Single();

        OleDbCommand OraGet_Max();

        OleDbCommand AccessInsert();

        OleDbCommand AccessUpdate();

        OleDbCommand AccessDelete();

        OleDbCommand AccessGet_All();

        OleDbCommand AccessGet_Single();

        OleDbCommand AccessGet_Max();


        #endregion
    }
}
