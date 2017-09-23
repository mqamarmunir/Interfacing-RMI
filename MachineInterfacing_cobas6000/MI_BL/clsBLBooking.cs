using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MI_DataLayer;

namespace MI_BL
{
    public class clsBLBooking
    {
        clsBLDBConnection _objConnection = new clsBLDBConnection();
        QueryBuilder objQB = new QueryBuilder();
        clsdbMI objdbMI=new clsdbMI();

        public clsBLBooking()
        { }

        public clsBLBooking(clsBLDBConnection objConn)
        {
            _objConnection = objConn;
        }

        #region Class Variable

        private const string _TableName = "mi_tbooking";
        private const string _Default = "~!@";
        private string _strErr = "";

        private string _BookingID=_Default ;
        private string _LabID = _Default;
        private string _PatientID=_Default ;
        private string _Patient_name=_Default ;
        private string _Test_Code=_Default;
        private string _Machine_TestID=_Default;
        private string _Test_Name=_Default;
        private string _InstrumentID=_Default;
        private string _Machine_Time=_Default;
        private string _SeqID=_Default;
        private string _BatchNo=_Default;
        private string _Sample_Type=_Default;
        private string _EnteredBy=_Default;
        private string _EnteredOn=_Default;
        private string _ClientID=_Default;
        private string _Active = _Default;
        private string _SendOn = _Default;
        private string _RecievedOn = _Default;

        private string _MachineAttributeCode = _Default;

        #endregion

        #region Peoperties

        public string StrErr
        {
            get {return _strErr;}
            set{_strErr =value ;}
        }

        public string BookingID
        {
            get{return _BookingID;}
            set{_BookingID =value;}
        }

        public string LabID
        {
            get { return _LabID; }
            set { _LabID= value; }
        }

        public string PatientID
        {
            get {return _PatientID;}
            set {_PatientID=value;}
        }
        public string Patient_name
        {
            get{return _Patient_name;}
            set {_Patient_name=value; }
        }
        public string Test_Code
        {
            get{return _Test_Code;}
            set{_Test_Code=value;}
        }
        public string Machine_TestID
        {
            get{return _Machine_TestID ;}
            set{_Machine_TestID =value;}
        }
        public string Test_Name
        {
            get{return _Test_Name;}
            set{_Test_Name =value;}
        }
        public string InstrumentID
        {
            get{return _InstrumentID;}
            set{_InstrumentID=value; }
        }
        public string Machine_Time
        {
            get{return _Machine_Time;}
            set{_Machine_Time=value ;}
        }
        public string SeqID
        {
            get{return  _SeqID;}
            set{_SeqID=value ;}
        }
        public string BatchNo
        {
            get{return _BatchNo ;}
            set{_BatchNo=value ;}
        }
        public string Sample_Type
        {
            get{return _Sample_Type ;}
            set{_Sample_Type =value ;}
        }
        public string EnteredBy
        {
            get{return _EnteredBy ;}
            set{_EnteredBy=value ;}
        }
        public string EnteredOn
        {
            get{return _EnteredOn;}
            set{_EnteredOn =value ;}
        }
        public string ClientID
        {
            get{return _ClientID ;}
            set{_ClientID=value ;}
        }
        public string Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
        public string SendOn
        {
            get { return _SendOn; }
            set { _SendOn= value; }
        }
        public string RecievedOn
        {
            get { return _RecievedOn; }
            set { _RecievedOn= value; }
        }

        public string MachineAttributeCode
        {
            get { return _MachineAttributeCode; }
            set { _MachineAttributeCode = value; }
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
                    objdbMI.Query = "select * from " + _TableName;
                    break;
                case 2://test count for today
                    objdbMI.Query = "SELECT count(Bookingid) as TestCount FROM " + _TableName + "  where instrumentid= " + _InstrumentID + " and date(enteredon)=date(now())";
                    break;
                case 3://test Detail for today
                    objdbMI.Query = "SELECT  b.Patient_name,b.LabID, b.Test_Code, b.Test_Name,r.result,b.ReceivedOn FROM " + _TableName + " b, mi_tresult r where  b.bookingid=r.bookingid and instrumentid= " + _InstrumentID + " and date(b.enteredon)=date(now())";
                    break;
                case 4: //draw Graph 
                    objdbMI.Query = "SELECT  count(m.bookingid) as TestCount,  " + _Test_Name + " FROM mi_tbooking  m  where instrumentid= " + _InstrumentID + "  order by m.enteredon Desc";
                    break;
                case 5: //Fill TestInfo according to MachineAttributeCode
                    objdbMI.Query = "SELECT a.attributeid,a.MachineAttributeCode,t.Machine_Test_name, t.Machine_testid, t.MachineTestCode, t.Instrumentid FROM mi_ttests t,mi_ttestattribute a where a.Machine_TestID=t.Machine_TestID and a.MachineAttributeCode='" + _MachineAttributeCode + "'";
                    break;
                case 6: //Get Max bookingid
                    objdbMI.Query = "SELECT max(bookingid) as bookingid FROM mi_tbooking m";
                    break;
                case 7: //Duplicate labid
                    objdbMI.Query = "SELECT bookingid FROM mi_tbooking m where labid='"+_LabID+"';";
                    break;
            }

            return _objConnection._objOperation.DataTrigger_Get_All(objdbMI);
        }

        private string[,] MakeArr()
        {
            string[,] strArrRes = new string[18, 3];

            if(!_BookingID.Equals(_Default ))
            {
                strArrRes[0,0]="bookingID";
                strArrRes[0,1]=_BookingID;
                strArrRes[0,2]="int";
            }
            if(_PatientID.Equals(_Default ))
            {
                strArrRes[1,0]="PatientID";
                strArrRes[1,1]=_PatientID;
                strArrRes[1,2]="string";
            }
            if(!_Patient_name.Equals(_Default))
            {
                strArrRes[2,0]="Patient_name";
                strArrRes[2,1]=_Patient_name;
                strArrRes[2,2]="string";
            }
            if(!_Test_Code.Equals(_Default))
            {
                strArrRes[3,0]="Test_Code";
                strArrRes[3,1]=_Test_Code;
                strArrRes[3,2]="string";
            }
            if(!_Machine_TestID.Equals(_Default))
            {
                strArrRes[4,0]="Machine_TestID";
                strArrRes[4,1]=_Machine_TestID;
                strArrRes[4,2]="string";
            }
            if(!_Test_Name.Equals(_Default))
            {
                strArrRes[5,0]="Test_Name";
                strArrRes[5,1]=_Test_Name;
                strArrRes[5,2]="string";
            }
            if(!_InstrumentID.Equals(_Default))
            {
                strArrRes[6,0]="InstrumentID";
                strArrRes[6,1]=_InstrumentID;
                strArrRes[6,2]="int";
            }
            if(!_Machine_Time.Equals(_Default))
            {
                strArrRes[7,0]="Machine_Time";
                strArrRes[7,1]=_Machine_Time;
                strArrRes[7,2]="datetime";
            }
            if(!_SeqID.Equals(_Default))
            {
                strArrRes[8,0]="SeqID";
                strArrRes[8,1]=_SeqID;
                strArrRes[8,2]="string";
            }
            if(!_BatchNo.Equals(_Default))
            {
                strArrRes[9,0]="BatchNo";
                strArrRes[9,1]=_BatchNo;
                strArrRes[9,2]="string";
            }
            if( _Sample_Type.Equals(_Default))
            {
                strArrRes[10,0]="Sample_Type";
                strArrRes[10,1]=_Sample_Type;
                strArrRes[10,2]="string";
            }
            if(!_EnteredBy.Equals(_Default))
            {
                strArrRes[11,0]="EnteredBy";
                strArrRes[11,1]=_EnteredBy;            
                strArrRes[11,2]="int";
            }
            if(!_EnteredOn.Equals(_Default))
            {
                strArrRes[12,0]="EnteredOn";
                strArrRes[12,1]=_EnteredOn;
                strArrRes[12,2]="datetime";
            }
            if(!_ClientID.Equals(_Default))
            {
                strArrRes[13,0]="ClientID";
                strArrRes[13,1]=_ClientID;
                strArrRes[13,2]="string";
            }
            if (!_Active.Equals(_Default))
            {
                strArrRes[14, 0] = "Active";
                strArrRes[14, 1] = _Active;
                strArrRes[14, 2] = "string";
            }
            if (!_SendOn.Equals(_Default))
            {
                strArrRes[15, 0] = "SendOn";
                strArrRes[15, 1] = _SendOn;
                strArrRes[15, 2] = "datetime";
            }
            if (!_RecievedOn.Equals(_Default))
            {
                strArrRes[16, 0] = "ReceivedOn";
                strArrRes[16, 1] = _RecievedOn;
                strArrRes[16, 2] = "datetime";
            }
            if (!_LabID.Equals(_Default))
            {
                strArrRes[17, 0] = "LabID";
                strArrRes[17, 1] = _LabID;
                strArrRes[17, 2] = "string";
            }
            return strArrRes;
        }

        #endregion

        #region Validations

        private bool ValidateData()
        {
            return true ;
        }

        #endregion
    }
}
