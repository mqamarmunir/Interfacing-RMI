using System;
using System.Collections.Generic;
using System.Text;
using MI_DataLayer;
using System.Data;

namespace MI_BL
{
    public class clsBLInterfaced
    {
        clsBLDBConnection _objConnection = new clsBLDBConnection();
        QueryBuilder objQB = new QueryBuilder();
        clsdbMI objMI = new clsdbMI();

        public clsBLInterfaced()
        { 
        }

        public clsBLInterfaced(clsBLDBConnection objconn)
        {
            _objConnection = objconn;
        }

        #region Class Variable

        private const string _Default = "~!@";
        private const string _TableName = "ls_tinterfaced";
        private string _StrErr = "";

        private string _Interfaceid = _Default;
        private string _MSerialNo = _Default;
        private string _Value = _Default;
        private string _LimsAttributeID= _Default;
        
        #endregion 

        #region Properties

        public string StrErr 
        {
            get { return _StrErr; }
            set { _StrErr = value; }
        }

        public string Interfaceid
        {
            get { return _Interfaceid;}
            set { _Interfaceid = value; }
        }

        public string MSerialNo
        {
            get { return _MSerialNo; }
            set { _MSerialNo = value; }
        }

        public string Value 
        {
            get { return _Value; }
            set { _Value = value; } 
        }

        public string LimsAttributeID
        {
            get { return _LimsAttributeID; }
            set { _LimsAttributeID = value; }
        }
       
        #endregion

        #region Method
    
        public bool Insert()
        {
            if (ValidateData())
            {
                objMI.Query = objQB.QBInsert(MakeArr(), _TableName);
                _StrErr = _objConnection._objOperation.DataTrigger_OraInsert(objMI);
                if (_StrErr.Equals("Error"))
                {
                    _StrErr = _objConnection._objOperation.OperationError + "\n" + objMI.Query +"\n";
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
                objMI.Query = objQB.QBUpdate(MakeArr(), _TableName);
                StrErr = _objConnection._objOperation.DataTrigger_OraUpdate(objMI);
                if(_StrErr.Equals("Error"))
                {
                    _StrErr =_objConnection._objOperation.OperationError;
                    return false ;
                }
                return true ;
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
                case 1: //Result to upload
                    objMI.Query = "SELECT r.resultid,at.limsattributeid,  b.labid,r.result FROM mi_tbooking b,mi_tresult r,mi_tTestAttribute at where b.bookingid=r.bookingid and r.attributeid =at.attributeid and (r.status=0 or r.status is null) ;";
                    break;
            }
            return  _objConnection._objOperation.DataTrigger_Get_All(objMI);
        }

        public DataView GetAllOra(int flag)
        {
            switch (flag)
            {
                case 1: //Result to upload
                    objMI.Query = "select InterfaceID from ls_ttestattribute where attributeid='" + _LimsAttributeID + "'";
                    break;
            }
            return  _objConnection._objOperation.DataTrigger_OraGet_All(objMI);
        }

        private string[,] MakeArr()
        {
            string[,] arrInterfaced = new string[3, 3];

            if(!_Interfaceid.Equals(_Default))
            {
                arrInterfaced[0, 0] = "Interfaceid";
                arrInterfaced[0, 1] = _Interfaceid;
                arrInterfaced[0, 2] = "string";
            }

            if (!_MSerialNo.Equals(_Default))
            {
                arrInterfaced[1, 0] = "MSerialNo";
                arrInterfaced[1, 1] = _MSerialNo;
                arrInterfaced[1, 2] = "int";
            }

            if (!_Value.Equals(_Default))
            {
                arrInterfaced[2, 0] = "Value";
                arrInterfaced[2, 1] = _Value;
                arrInterfaced[2, 2] = "string";
            }
            return arrInterfaced;
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
