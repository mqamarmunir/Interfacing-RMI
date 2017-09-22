using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MI_DataLayer;

namespace MI_BL
{
    public class clsBLResult
    {
        clsBLDBConnection _objConnection = new clsBLDBConnection();
        QueryBuilder objQB = new QueryBuilder();
        clsdbMI objdbMI = new clsdbMI();

        public clsBLResult()
        { }

        public clsBLResult(clsBLDBConnection objConn)
        {
            _objConnection = objConn;
        }

        #region Class Variable

        private const string _TableName = "mi_tresult";
        private const string _Default = "~!@";
        private string _strErr = "";

        private string _ResultID = _Default;
        private string _BookingID = _Default;
        private string _AttributeID = _Default;
        private string _Result = _Default;
        private string _EnteredBy = _Default;
        private string _EnteredOn = _Default;
        private string _ClientID = _Default;
        private string _Status = _Default;

        #endregion

        #region Peoperties

        public string StrErr
        {
            get { return _strErr; }
            set { _strErr = value; }
        }

        public string ResultID
        {
            get { return _ResultID; }
            set { _ResultID = value; }
        }

        public string BookingID
        {
            get { return _BookingID; }
            set { _BookingID = value; }
        }

        public string AttributeID
        {
            get { return _AttributeID; }
            set { _AttributeID = value; }
        }
        public string Result
        {
            get { return _Result; }
            set { _Result = value; }
        }
        public string EnteredBy
        {
            get { return _EnteredBy; }
            set { _EnteredBy = value; }
        }
        public string EnteredOn
        {
            get { return _EnteredOn; }
            set { _EnteredOn = value; }
        }
        public string ClientID
        {
            get { return _ClientID; }
            set { _ClientID = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
   
        #endregion

        #region Mothod

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
                    _strErr = _objConnection._objOperation.OperationError + "\n" + objdbMI.Query;
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
                    objdbMI.Query = "select * from " + _TableName;
                    break;
            }

            return _objConnection._objOperation.DataTrigger_Get_All(objdbMI);
        }

        private string[,] MakeArr()
        {
            string[,] strArrRes = new string[8, 3];

            if (!_ResultID.Equals(_Default))
            {
                strArrRes[0, 0] = "ResultID";
                strArrRes[0, 1] = _ResultID;
                strArrRes[0, 2] = "int";
            }
            if (!_BookingID.Equals(_Default))
            {
                strArrRes[1, 0] = "BookingID";
                strArrRes[1, 1] = _BookingID;
                strArrRes[1, 2] = "int";
            }
            if (!_AttributeID.Equals(_Default))
            {
                strArrRes[2, 0] = "AttributeID";
                strArrRes[2, 1] = _AttributeID;
                strArrRes[2, 2] = "int";
            }
            if (!_Result.Equals(_Default))
            {
                strArrRes[3, 0] = "Result";
                strArrRes[3, 1] = _Result;
                strArrRes[3, 2] = "string";
            }
            if (!_EnteredBy.Equals(_Default))
            {
                strArrRes[4, 0] = "EnteredBy";
                strArrRes[4, 1] = _EnteredBy;
                strArrRes[4, 2] = "int";
            }
            if (!_EnteredOn.Equals(_Default))
            {
                strArrRes[5, 0] = "EnteredOn";
                strArrRes[5, 1] = _EnteredOn;
                strArrRes[5, 2] = "datetime";
            }
            if (!_ClientID.Equals(_Default))
            {
                strArrRes[6, 0] = "ClientID";
                strArrRes[6, 1] = _ClientID;
                strArrRes[6, 2] = "string";
            }

            if (!_Status.Equals(_Default))
            {
                strArrRes[7, 0] = "Status";
                strArrRes[7, 1] = _Status;
                strArrRes[7, 2] = "string";
            }
            
            return strArrRes;
        }

        #endregion

        #region Validations

        private bool ValidateData()
        {
            return true;
        }

        #endregion
    }
}
