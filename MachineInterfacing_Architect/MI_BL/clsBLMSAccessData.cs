using System;
using System.Collections.Generic;
using System.Text;
using MI_DataLayer;
using System.Data;

namespace MI_BL
{
    public class clsBLMSAccessData
    {
        clsBLDBConnection _objConnection = new clsBLDBConnection();
        QueryBuilder objQB = new QueryBuilder();
        clsdbMI objMI = new clsdbMI();

        public clsBLMSAccessData()
        { 
        }

        public clsBLMSAccessData(clsBLDBConnection objconn)
        {
            _objConnection = objconn;
        }

        #region Class Variable

        private const string _Default = "~!@";
        private string _StrErr = "";

        private string _ID = _Default;
        private string _EnteredOn = _Default;
        private string _LABID = _Default;
        
        private string _AttributeCode = _Default;
        private string _Result = _Default;
        private string _UserName= _Default;

        #endregion 

        #region Properties

        public string StrErr 
        {
            get { return _StrErr; }
            set { _StrErr = value; }
        }

        public string ID
        {
            get { return _ID;}
            set { _ID = value; }
        }

        public string EnteredOn
        {
            get { return _EnteredOn; }
            set { _EnteredOn= value; }
        }

        public string LABID
        {
            get { return _LABID; }
            set { _LABID = value; } 
        }

        public string AttributeCode
        {
            get { return _AttributeCode; }
            set { _AttributeCode= value; }
        }

        public string Result
        {
            get { return _Result; }
            set { _Result= value; }
        }

        public string UserName
        {
            get{return _UserName;}
            set { _UserName = value; }
        }

        #endregion

        #region Method
    
        public DataView GetAll(int flag)
        {
            switch (flag)
            {
                case 1://get Data Immulite2000 from ACCESS file
                    objMI.Query = "SELECT ID,RecDTime,PatID,TName,TResult,UName FROM TestResult where ID > " + _ID;
                    break ;
            }
            return  _objConnection._objOperation.DataTrigger_AccessGet_All(objMI);
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
