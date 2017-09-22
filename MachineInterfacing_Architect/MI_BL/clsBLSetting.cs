using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MI_DataLayer;

namespace MI_BL
{
    public class clsBLSetting
    {
        clsBLDBConnection _objConnection = new clsBLDBConnection();
        QueryBuilder objQB = new QueryBuilder();
        clsdbMI objdbMI = new clsdbMI();

        public clsBLSetting()
        {

        }

        public clsBLSetting(clsBLDBConnection objConn)
        {
            _objConnection = objConn;
        }

        #region Class Variable

        private const string _TableName = "mi_setting";
        private const string _Default = "~!@";
        private string _strErr = "";

        private string _ID = _Default;
        private string _Parameter1 = _Default;
        private string _Parameter2 = _Default;

        private string _Parameter3 = _Default;
        private string _Parameter4 = _Default;

        #endregion

        #region Properties
        public string StrErr
        {
            get { return _strErr; }
            set { _strErr = value; }
        }

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Parameter1
        {
            get { return _Parameter1; }
            set { _Parameter1 = value; }
        }
        public string Parameter2
        {
            get { return _Parameter2; }
            set { _Parameter2 = value; }
        }
        public string Parameter3
        {
            get { return _Parameter3; }
            set { _Parameter3= value; }
        }
        public string Parameter4
        {
            get { return _Parameter4; }
            set { _Parameter4 = value; }
        }
        
        #endregion

        #region Method

        public bool Insert()
        {
            if (ValidateData())
            {
                objdbMI.Query = objQB.QBInsert(MakeArr(), _TableName);
                _strErr = _objConnection._objOperation.DataTrigger_Insert(objdbMI);
                if (_strErr.Equals("Error"))
                {
                    _strErr = _objConnection._objOperation.OperationError;
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update()
        {
            if (ValidateData())
            {
                objdbMI.Query = objQB.QBUpdate(MakeArr(), _TableName);
                _strErr = _objConnection._objOperation.DataTrigger_Update(objdbMI);
                if (_strErr.Equals("Error"))
                {
                    _strErr = _objConnection._objOperation.OperationError;
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataView GetAll(int flag)
        {
            switch (flag)
            {
                case 1:
                    objdbMI.Query = "SELECT ID, Parameter1, Parameter2, Parameter3, Parameter4 FROM mi_setting ";
                    if (!_ID.Equals(_Default))
                    {
                        objdbMI.Query += " where ID = '" + _ID + "'";
                    }
                    break;
            }
            return  _objConnection._objOperation.DataTrigger_Get_All(objdbMI);
        }

        private string[,] MakeArr()
        {
            string[,] strArrSetting = new string[5, 3];
         
            if (!_ID.Equals(_Default))
            {
                strArrSetting[0, 0] = "ID";
                strArrSetting[0, 1] = _ID;
                strArrSetting[0, 2] = "string";
            }
            if (!_Parameter1.Equals(_Default))
            {
                strArrSetting[1, 0] = "Parameter1";
                strArrSetting[1, 1] = _Parameter1;
                strArrSetting[1, 2] = "sting";
            }
            if (!_Parameter2.Equals(_Default))
            {
                strArrSetting[2, 0] = "Parameter2";
                strArrSetting[2, 1] = _Parameter2;
                strArrSetting[2, 2] = "string";
            }
            if (!_Parameter3.Equals(_Default))
            {
                strArrSetting[3, 0] = "Parameter3";
                strArrSetting[3, 1] = _Parameter3;
                strArrSetting[3, 2] = "string";
            }
            if (!_Parameter4.Equals(_Default))
            {
                strArrSetting[4, 0] = "Parameter4";
                strArrSetting[4, 1] = _Parameter4;
                strArrSetting[4, 2] = "string";
            }
            
            return strArrSetting;
        }

        #endregion

        #region Validation

        private bool ValidateData()
        {
            return true;
        }

        #endregion
    }
}
