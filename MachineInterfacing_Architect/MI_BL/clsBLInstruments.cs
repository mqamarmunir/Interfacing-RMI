using System;
using System.Collections.Generic;
using System.Text;
using MI_DataLayer;
using System.Data;

namespace MI_BL
{
    public class clsBLInstruments
    {
        clsBLDBConnection _objConnection = new clsBLDBConnection();
        QueryBuilder objQB = new QueryBuilder();
        clsdbMI objMI = new clsdbMI();

        public clsBLInstruments()
        { 
        }
        
        public clsBLInstruments(clsBLDBConnection objconn)
        {
            _objConnection = objconn;
        }

        #region Class Variable

        private const string _Default = "~!@";
        private const string _TableName = "mi_tInstruments";
        private string _StrErr = "";

        private string _InstrumentID = _Default;
        private string _Supplierid = _Default;
        private string _Instrument_Name = _Default;
        
        private string _Model = _Default;
        private string _Release = _Default;
        private string _Description = _Default;

        private string _Manual = _Default;
        private string _Patient_no_format = _Default;
        private string _BarCode_Standard = _Default;

        private string _Bidirectional = _Default;
        private string _Communication_Stnadard = _Default;
        private string _Communication_method = _Default;

        private string _PORT = _Default;
        private string _BaudRate = _Default;
        private string _Parity = _Default;

        private string _Stopbit = _Default;
        private string _DataBit = _Default;
        private string _FlowControl = _Default;

        private string _Acknowledgement_code = _Default;
        private string _EnteredBy = _Default;
        private string _EnteredOn = _Default;

        private string _ClientID = _Default;
        private string _Active = _Default;

        #endregion 

        #region Properties

        public string StrErr 
        {
            get { return _StrErr; }
            set { _StrErr = value; }
        }

        public string InstrumentID
        {
            get { return _InstrumentID;}
            set { _InstrumentID = value; }
        }

        public string Supplierid
        {
            get { return _Supplierid; }
            set { _Supplierid = value; }
        }

        public string Instrument_Name 
        {
            get { return _Instrument_Name; }
            set { _Instrument_Name = value; } 
        }

        public string Model 
        {
            get { return _Model; }
            set { _Model = value; }
        }

        public string Release
        {
            get { return _Release; }
            set { _Release = value; }
        }

        public string Description
        {
            get{return _Description ;}
            set { _Description = value; }
        }

        public string Manual
        {
            get { return _Manual; }
            set { _Manual = value; }
        }

        public string Patient_no_format
        {
            get { return _Patient_no_format; }
            set { _Patient_no_format = value; }
        }

        public string BarCode_Standard
        {
            get { return _BarCode_Standard; }
            set{_BarCode_Standard=value ;}
        }

        public string Bidirectional
        {
            get { return _Bidirectional; }
            set { _Bidirectional = value; }
        }

        public string Communicaton_Stnadard
        {
            get { return _Communication_method; }
            set { _Communication_Stnadard = value; }
        }

        public string Communication_method
        {
            get { return _Communication_method; }
            set { _Communication_method = value; }
        }

        public string PORT
        {
            get { return _PORT; }
            set { _PORT = value; }
        }

        public string BaudRate
        {
            get { return _BaudRate; }
            set { _BaudRate = value; }
        }

        public string Parity
        {
            get { return _Parity; }
            set { _Parity = value; }
        }

        public string Stopbit
        {
            get { return _Stopbit; }
            set { _Stopbit = value; }
        }

        public string DataBit
        {
            get { return _DataBit; }
            set { _DataBit = value; }
        }

        public string FlowControl
        {
            get { return _FlowControl; }
            set { _FlowControl = value; }
        }

        public string Acknowledgement_code
        {
            get { return _Acknowledgement_code; }
            set { _Acknowledgement_code = value; }
        }

        public string EnteredBy
        {
            get{return _EnteredBy ;}
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

        #endregion

        #region Method
    
        public bool Insert()
        {
            if (ValidateData())
            {
                objMI.Query = objQB.QBInsert(MakeArr(), _TableName);
                _StrErr = _objConnection._objOperation.DataTrigger_Insert(objMI);
                if (_StrErr.Equals("Error"))
                {
                    _StrErr = _objConnection._objOperation.OperationError;
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
                StrErr = _objConnection._objOperation.DataTrigger_Update(objMI);
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
                case 1:
                    objMI.Query = "Select i.InstrumentID, i.Supplierid, i.Instrument_Name, i.Model, i.I_Release, i.Description, i.Manual, i.Patient_no_format, i.BarCode_Standard, i.Bidirectional, i.Communication_Stnadard, i.Communication_method, i.PORT, i.BaudRate, i.Parity, i.Stopbit, i.DataBit, i.FlowControl, i.Acknowledgement_code, i.Active,s.Supplier_Name from " + _TableName + " i,mi_tsuppliers s where i.supplierid=s.supplierid";
                    if (!_InstrumentID.Equals(_Default))
                    {
                        objMI.Query += " and i.InstrumentID="  + _InstrumentID;
                    }
                    break ;
                case 2:
                    objMI.Query = "SELECT InstrumentID, Instrument_Name FROM " + _TableName + " where Active='Y'";
                    break ;
                case 3://DUPLICATE Instrument Name
                    objMI.Query = "SELECT InstrumentID FROM mi_tinstruments where instrument_name ='" + _Instrument_Name + "' ";
                    break;
            }
            return  _objConnection._objOperation.DataTrigger_Get_All(objMI);
        }

        private string[,] MakeArr()
        {
            string[,] arrInstruments = new string[23, 3];

            if(!_InstrumentID.Equals(_Default))
            {
                arrInstruments[0, 0] = "InstrumentID";
                arrInstruments[0, 1] = _InstrumentID;
                arrInstruments[0, 2] = "int";
            }

            if (!_Supplierid.Equals(_Default))
            {
                arrInstruments[1, 0] = "Supplierid";
                arrInstruments[1, 1] = _Supplierid;
                arrInstruments[1, 2] = "int";
            }

            if (!_Instrument_Name.Equals(_Default))
            {
                arrInstruments[2, 0] = "Instrument_Name";
                arrInstruments[2, 1] = _Instrument_Name;
                arrInstruments[2, 2] = "string";
            }

            if (!_Model.Equals(_Default))
            {
                arrInstruments[3, 0] = "Model";
                arrInstruments[3, 1] = _Model;
                arrInstruments[3, 2] = "string";
            }

            if (!_Release.Equals(_Default))
            {
                arrInstruments[4, 0] = "I_Release";
                arrInstruments[4, 1] = _Release;
                arrInstruments[4, 2] = "string";
            }

            if (!_Description.Equals(_Default))
            {
                arrInstruments[5, 0] = "Description";
                arrInstruments[5, 1] = _Description;
                arrInstruments[5, 2] = "stringt";
            }

            if (!_Manual.Equals(_Default))
            {
                arrInstruments[6, 0] = "Manual";
                arrInstruments[6, 1] = _Manual;
                arrInstruments[6, 2] = "string";
            }

            if (!_Patient_no_format.Equals(_Default)) 
            {
                arrInstruments[7, 0] = "Patient_no_format";
                arrInstruments[7, 1] = _Patient_no_format;
                arrInstruments[7, 2] = "string";
            }

            if (!_BarCode_Standard.Equals(_Default))
            {
                arrInstruments[8, 0] = "BarCode_Standard";
                arrInstruments[8, 1] = _BarCode_Standard;
                arrInstruments[8, 2] = "string";
            }

            if (!_Bidirectional.Equals(_Default))
            {
                arrInstruments[9, 0] = "Bidirectional";
                arrInstruments[9, 1] = _Bidirectional;
                arrInstruments[9, 2] = "string";
            }

            if (!_Communication_Stnadard.Equals(_Default))
            {
                arrInstruments[10, 0] = "Communication_Stnadard";
                arrInstruments[10, 1] = _Communication_Stnadard;
                arrInstruments[10, 2] = "string";
            }

            if (!_Communication_method.Equals(_Default))
            {
                arrInstruments[11, 0] = "Communication_method";
                arrInstruments[11, 1] = _Communication_method;
                arrInstruments[11, 2] = "string";
            }

            if (!_PORT.Equals(_Default))
            {
                arrInstruments[12,0]="PORT";
                arrInstruments[12, 1] = _PORT;
                arrInstruments[12, 2] = "string";
            }
            if (!_BaudRate.Equals(_Default))
            {
                arrInstruments[13, 0] = "BaudRate";
                arrInstruments[13, 1] = _BaudRate;
                arrInstruments[13, 2] = "int";
            }
            if (!_Parity.Equals(_Default))
            {
                arrInstruments[14, 0] = "Parity";
                arrInstruments[14, 1] = _Parity;
                arrInstruments[14, 2] = "string";
            }

            if (!_Stopbit.Equals(_Default))
            {
                arrInstruments[15, 0] = "Stopbit";
                arrInstruments[15, 1] = _Stopbit;
                arrInstruments[15, 2] = "string";
            }
            if (!_DataBit.Equals(_Default))
            {
                arrInstruments[16,0]="DataBit";
                arrInstruments[16, 1] = _DataBit;
                arrInstruments[16, 2] = "string";
            }

            if (!_FlowControl.Equals(_Default))
            {
                arrInstruments[17, 0] = "FlowControl";
                arrInstruments[17, 1] = _FlowControl;
                arrInstruments[17, 2] = "string";
            }

            if (!_Acknowledgement_code.Equals(_Default))
            {
                arrInstruments[18, 0] = "Acknowledgement_code";
                arrInstruments[18, 1] = _Acknowledgement_code;
                arrInstruments[18, 2] = "int";
            }

            if (!_EnteredBy.Equals(_Default))
            {
                arrInstruments[19, 0] = "EnteredBy";
                arrInstruments[19, 1] = _EnteredBy;
                arrInstruments[19, 2] = "int";
            }

            if (!_EnteredOn.Equals(_Default))
            {
                arrInstruments[20,0]="EnteredOn";
                arrInstruments[20, 1] = _EnteredOn;
                arrInstruments[20, 2] = "datetime";
            }

            if (!_ClientID.Equals(_Default))
            {
                arrInstruments[21,0]="ClientID";
                arrInstruments[21, 1] = _ClientID;
                arrInstruments[21, 2] = "string"; ;
            }
            if(!_Active.Equals(_Default))
            {
                arrInstruments[22,0]="Active";
                arrInstruments[22,1]=_Active;
                arrInstruments[22,2]="string";
            }
            return arrInstruments;
        }

        #endregion 

        #region Validation

        private bool ValidateData()
        {
            if (!ValidateSupplier())
            {
                return false;
            }
            if (!ValidateName())
            {
                return false;
            }

            if (!ValidateModel())
            {
                return false;
            }

            if (!ValidateCommStd())
            {
                return false;
            }
           
            return true;
        }

        private bool ValidateSupplier()
        {
            if (_Supplierid.Equals(_Default) || _Supplierid.Equals("-1"))
            {
                _StrErr = "Please Select Supplier";
                return false;
            }
            return true;
        }

        private bool ValidateName()
        {
            if (_Instrument_Name.Equals(_Default) || _Instrument_Name.Equals(""))
            {
                _StrErr = "Instrument Name is Empty";
                return false;
            }
            DataView dv = GetAll(3);

            if (!_InstrumentID.Equals(_Default))
            {
                dv.RowFilter = "InstrumentID<>" + _InstrumentID;
            }
            if (dv.Count > 0)
            {
                _StrErr = "Instrument Name Already exist";
                return false;
            }

            return true;
        }

        private bool ValidateModel()
        {
            if (_Model.Equals(_Default) || _Model.Equals(""))
            {
                _StrErr = "Model is Empty";
                return false;
            }
            return true;
        }

        private bool ValidateCommStd()
        {
            if (!_Communication_Stnadard.Equals(_Default) && !_Communication_Stnadard.Equals(""))
            {
                _StrErr = "Communication Standard is Empty";
                return false;
            }
            return true;
        }

        #endregion
    }
}

