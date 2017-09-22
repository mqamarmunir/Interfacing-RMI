using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MI_DataLayer;

namespace MI_BL
{
    public class clsBLTestAttribute
    {
        clsBLDBConnection _objConnection = new clsBLDBConnection();
        QueryBuilder objQB = new QueryBuilder();
        clsdbMI objdbMI = new clsdbMI();

        public clsBLTestAttribute()
        {

        }
        
        public clsBLTestAttribute(clsBLDBConnection objConn)
        {
            _objConnection = objConn;
        }

        #region Class Variable

        private const string _TableName = "mi_tTestAttribute";
        private const string _Default = "~!@";
        private string _strErr = "";

        private string _AttributeID = _Default;
        private string _Machine_testid = _Default;
        private string _LIMSAttributeID = _Default;

        private string _LIMSAttributeName = _Default;
        private string _MachineAttributeName = _Default;

        private string _EnteredBy = _Default;
        private string _EnteredOn = _Default;
        private string _ClientID = _Default;

        private string _Active = _Default;
        private string _MachineAttributeCode= _Default;

        private string _Channel= _Default;

        #endregion

        #region Properties
        public string StrErr
        {
            get { return _strErr; }
            set { _strErr = value; }
        }

        public string AttributeID
        {
            get { return _AttributeID; }
            set { _AttributeID = value; }
        }
        public string Machine_testid
        {
            get { return _Machine_testid; }
            set { _Machine_testid = value; }
        }
        public string LIMSAttributeID
        {
            get { return _LIMSAttributeID; }
            set { _LIMSAttributeID = value; }
        }
        
        public string LIMSAttributeName
        {
            get { return _LIMSAttributeName; }
            set { _LIMSAttributeName = value; }
        }
        public string MachineAttributeName
        {
            get { return _MachineAttributeName; }
            set { _MachineAttributeName = value; }
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
        public string Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
        public string MachineAttributeCode
        {
            get { return _MachineAttributeCode; }
            set { _MachineAttributeCode = value; }
        }

        public string Channel
        {
            get { return _Channel; }
            set { _Channel= value; }
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
                    objdbMI.Query = "SELECT AttributeID,  LIMSAttributeID, LIMSAttributeName, MachineAttributeName, Active,MachineAttributeCode,Channel  FROM mi_ttestattribute where machine_testid= " + _Machine_testid;
                    break;
                case 2:
                    objdbMI.Query = "SELECT a.channel,a.machineAttributeCode FROM mi.mi_tTestAttribute a join mi_ttests t on a.Machine_testid=t.Machine_testid  where a.channel is not null and t.instrumentid='" + _Machine_testid + "'";
                    break;


                //SELECT t.Machine_TestID,t.LIMS_TestID,t.LIMS_Test_Name,t.Machine_Test_Name,MachineTestCode,AttributeID,LIMSAttributeID,LIMSAttributeName,MachineAttributeName,MachineAttributeCode FROM mi_ttests t,mi_ttestattribute a where t.Machine_TestID=a.Machine_TestID and machineAttributeCode='TSH';
            }
            return  _objConnection._objOperation.DataTrigger_Get_All(objdbMI);
        }

        private string[,] MakeArr()
        {
            string[,] strArrTest = new string[11, 3];
         
            if (!_AttributeID.Equals(_Default))
            {
                strArrTest[0, 0] = "AttributeID";
                strArrTest[0, 1] = _AttributeID;
                strArrTest[0, 2] = "int";
            }
            if (!_Machine_testid.Equals(_Default))
            {
                strArrTest[1, 0] = "Machine_testid";
                strArrTest[1, 1] = _Machine_testid;
                strArrTest[1, 2] = "int";
            }
            if (!_LIMSAttributeID.Equals(_Default))
            {
                strArrTest[2, 0] = "LIMSAttributeID";
                strArrTest[2, 1] = _LIMSAttributeID;
                strArrTest[2, 2] = "string";
            }
            if (!_LIMSAttributeName.Equals(_Default))
            {
                strArrTest[3, 0] = "LIMSAttributeName";
                strArrTest[3, 1] = _LIMSAttributeName;
                strArrTest[3, 2] = "string";
            }
            if (!_MachineAttributeName.Equals(_Default))
            {
                strArrTest[4, 0] = "MachineAttributeName";
                strArrTest[4, 1] = _MachineAttributeName;
                strArrTest[4, 2] = "string";
            }
            if (!_EnteredBy.Equals(_Default))
            {
                strArrTest[5, 0] = "EnteredBy";
                strArrTest[5, 1] = _EnteredBy;
                strArrTest[5, 2] = "int";
            }
            if (!_EnteredOn.Equals(_Default))
            {
                strArrTest[6, 0] = "EnteredOn";
                strArrTest[6, 1] = _EnteredOn;
                strArrTest[6, 2] = "datetime";
            }
            if (!_ClientID.Equals(_Default))
            {
                strArrTest[7, 0] = "ClientID";
                strArrTest[7, 1] = _ClientID;
                strArrTest[7, 2] = "string";
            }

            if (!_Active.Equals(_Default))
            {
                strArrTest[8, 0] = "Active";
                strArrTest[8, 1] = _Active;
                strArrTest[8, 2] = "string";
            }
            if (!_MachineAttributeCode.Equals(_Default))
            {
                strArrTest[9, 0] = "MachineAttributeCode";
                strArrTest[9, 1] = _MachineAttributeCode;
                strArrTest[9, 2] = "string";
            }
            if (!_Channel.Equals(_Default))
            {
                strArrTest[10, 0] = "Channel";
                strArrTest[10, 1] = _Channel;
                strArrTest[10, 2] = "int";
            }
            return strArrTest;
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
