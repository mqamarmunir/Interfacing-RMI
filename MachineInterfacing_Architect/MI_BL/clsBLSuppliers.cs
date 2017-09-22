using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MI_DataLayer;

namespace MI_BL
{
    public class clsBLSuppliers
    {
        clsBLDBConnection _objConnection = new clsBLDBConnection();
        QueryBuilder objQB = new QueryBuilder();
        clsdbMI objdbMI = new clsdbMI();

        public clsBLSuppliers()
        { }

        public clsBLSuppliers(clsBLDBConnection objConn)
        {
            _objConnection = objConn;
        }

        #region Class Variable

        private const string _TableName = "mi_tsuppliers";
        private const string _Default = "~!@";
        private string _strErr = "";

        private string _SupplierID = _Default;
        private string _Supplier_Name = _Default;
        private string _Address = _Default;

        private string _Phone_1 = _Default;
        private string _Phone_2 = _Default;
        private string _Fax_2 = _Default;

        private string _Fax_1 = _Default;
        private string _Email = _Default;
        private string _CellNo = _Default;

        private string _WebAddress = _Default;
        private string _Linkedin_ID = _Default;
        private string _CP_Name = _Default;

        private string _CP_Designation = _Default;
        private string _CP_Office_Phone = _Default;
        private string _CP_Cell_no = _Default;

        private string _CP_Email = _Default;
        private string _City = _Default;
        private string _EnteredBy = _Default;

        private string _Country = _Default;
        private string _EnteredOn = _Default;
        private string _Clientid = _Default;

        private string _Active = _Default;
        private string _Ref_SupplierID = _Default;

        #endregion

        #region Properties

        public string StrErr
        {
            get { return _strErr; }
            set { _strErr = value; }
        }

        public string SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }
        public string Supplier_Name
        {
            get { return _Supplier_Name; }
            set { _Supplier_Name = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Phone_1
        {
            get { return _Phone_1; }
            set { _Phone_1 = value; }
        }
        public string Phone_2
        {
            get { return _Phone_2; }
            set { _Phone_2 = value; }
        }
        public string Fax_2
        {
            get { return _Fax_2; }
            set { _Fax_2 = value; }
        }
        public string Fax_1
        {
            get { return _Fax_1; }
            set { _Fax_1 = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string CellNo
        {
            get { return _CellNo; }
            set { _CellNo = value; }
        }
        public string WebAddress
        {
            get { return _WebAddress; }
            set { _WebAddress = value; }
        }
        public string Linkedin_ID
        {
            get { return _Linkedin_ID; }
            set { _Linkedin_ID = value; }
        }
        public string CP_Name
        {
            get { return _CP_Name; }
            set { _CP_Name = value; }
        }
        public string CP_Designation
        {
            get { return _CP_Designation; }
            set { _CP_Designation = value; }
        }
        public string CP_Office_Phone
        {
            get { return _CP_Office_Phone; }
            set { _CP_Office_Phone = value; }
        }
        public string CP_Cell_no
        {
            get { return _CP_Cell_no; }
            set { _CP_Cell_no = value; }
        }
        public string CP_Email
        {
            get { return _CP_Email; }
            set { _CP_Email = value; }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string EnteredBy
        {
            get { return _EnteredBy; }
            set { _EnteredBy = value; }
        }
        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }
        public string EnteredOn
        {
            get { return _EnteredOn; }
            set { _EnteredOn = value; }
        }
        public string Clientid
        {
            get { return _Clientid; }
            set { _Clientid = value; }
        }
        public string Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
        public string Ref_SupplierID
        {
            get { return _Ref_SupplierID; }
            set { _Ref_SupplierID = value; }
        }

        #endregion

        #region Method

        public bool Insert()
        {
            if (VailudateData())
            {
                objdbMI.Query = objQB.QBInsert(MakeArr(),_TableName);
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
            if (VailudateData())
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
                case 1://Fill supplier Gridview
                    objdbMI.Query = "select SupplierID, Supplier_Name, Address, Phone_1, Phone_2, Fax_1, Fax_2, Email, CellNo, WebAddress, Linkedin_ID, CP_Name, CP_Designation, CP_Office_Phone, CP_Cell_no, CP_Email, City, Country, Active, Ref_SupplierID from " + _TableName ;
                    break;
                case 2://DUPLICATE SupplierName
                    objdbMI.Query = "SELECT supplierid FROM `mi`.`mi_tsuppliers` where supplier_name='" +_Supplier_Name + "' ";
                    break;
                case 3://fill supplier combobox
                    objdbMI.Query = "SELECT Supplier_Name, SupplierID FROM mi_tsuppliers  where active ='Y';";
                    break;
            }
            return _objConnection._objOperation.DataTrigger_Get_All(objdbMI);
        }

        private string[,] MakeArr()
        {
            string[,] strArrSupp = new string[23, 3];

            if(!_SupplierID.Equals(_Default))
            {
                strArrSupp[0,0]="SupplierID";
                strArrSupp[0,1]=_SupplierID;
                strArrSupp[0,2]="int";
            }
            if(!_Supplier_Name.Equals(_Default))
            {
                strArrSupp[1,0]="Supplier_Name";
                strArrSupp[1,1]=_Supplier_Name;
                strArrSupp[1,2]="string";
            }
            if(!_Address.Equals(_Default))
            {
                strArrSupp[2,0]="Address";
                strArrSupp[2,1]=_Address;
                strArrSupp[2,2]="string";
            }
            if(!_Phone_1.Equals(_Default))
            {
                strArrSupp[3,0]="Phone_1";
                strArrSupp[3,1]=_Phone_1;
                strArrSupp[3,2]="string";
            }
            if(!Phone_2.Equals(_Default))
            {
                strArrSupp[4,0]="Phone_2";
                strArrSupp[4,1]=_Phone_2;
                strArrSupp[4,2]="string";
            }
            if(!_Fax_1.Equals(_Default))
            {
                strArrSupp[5,0]="Fax_1";
                strArrSupp[5,1]=_Fax_1;
                strArrSupp[5,2]="string";
            }
            if(!_Fax_2.Equals(_Default))
            {
                strArrSupp[6,0]="Fax_2";
                strArrSupp[6,1]=_Fax_2;
                strArrSupp[6,2]="string";
            }
            if(!_Email.Equals(_Default))
            {
                strArrSupp[7,0]="Email";
                strArrSupp[7,1]=_Email;
                strArrSupp[7,2]="string";
            }
            if(!_CellNo.Equals(_Default))
            {
                strArrSupp[8,0]="CellNo";
                strArrSupp[8,1]=_CellNo;
                strArrSupp[8,2]="string";
            }
            if(!_WebAddress.Equals(_Default))
            {
                strArrSupp[9,0]="WebAddress";
                strArrSupp[9,1]=_WebAddress;
                strArrSupp[9,2]="string";
            }
            if(!_Linkedin_ID.Equals(_Default))
            {
                strArrSupp[10,0]="Linkedin_ID";
                strArrSupp[10,1]=_Linkedin_ID;
                strArrSupp[10,2]="string";
            }
            if(!_CP_Name.Equals(_Default))
            {
                strArrSupp[11,0]="CP_Name";
                strArrSupp[11,1]=_CP_Name;
                strArrSupp[11,2]="string";
            }
            if(!_CP_Designation.Equals(_Default))
            {
                strArrSupp[12,0]="CP_Designation";
                strArrSupp[12,1]=_CP_Designation;
                strArrSupp[12,2]="string";
            }
            if(!_CP_Office_Phone.Equals(_Default))
            {
                strArrSupp[13,0]="CP_Office_Phone";
                strArrSupp[13,1]=_CP_Office_Phone;
                strArrSupp[13,2]="string";
            }
            if(!_CP_Cell_no.Equals(_Default))
            {
                strArrSupp[14,0]="CP_Cell_no";
                strArrSupp[14,1]=_CP_Cell_no;
                strArrSupp[14,2]="string";
            }
            if(!_CP_Email.Equals(_Default))
            {
                strArrSupp[15,0]="CP_Email";
                strArrSupp[15,1]=_CP_Email;
                strArrSupp[15,2]="string";
            }
            if( !_City.Equals(_Default))
            {
                strArrSupp[16,0]="City";
                strArrSupp[16,1]=_City;
                strArrSupp[16,2]="string";
            }
            if(!_Country.Equals(_Default))
            {
                strArrSupp[17,0]="Country";
                strArrSupp[17,1]=_Country;
                strArrSupp[17,2]="string";

            }
            if(!_EnteredBy.Equals(_Default))
            {
                strArrSupp[18,0]="EnteredBy";
                strArrSupp[18,1]=_EnteredBy;
                strArrSupp[18,2]="int";
            }
            if(!_EnteredOn.Equals(_Default))
            {
                strArrSupp[19,0]="EnteredOn";
                strArrSupp[19,1]=_EnteredOn;
                strArrSupp[19,2]="datetime";
            }
            if(!_Clientid.Equals(_Default))
            {
                strArrSupp[20,0]="Clientid";
                strArrSupp[20,1]=_Clientid;
                strArrSupp[20,2]="string";
            }
            if(!_Active.Equals(_Default))
            {
                strArrSupp[21,0]="Active";
                strArrSupp[21,1]=_Active;
                strArrSupp[21,2]="string";
            }
            if(!_Ref_SupplierID.Equals(_Default))
            {
                strArrSupp[22,0]="Ref_SupplierID";
                strArrSupp[22, 1] = _Ref_SupplierID;
                strArrSupp[22, 2] = "int";
            }
            return strArrSupp;
        }

        #endregion

        #region Validation

        private bool VailudateData()
        {
            if (!ValidateName())
            {
                return false;
            }
            if (!ValidateCPName())
            {
                return false;
            }

           if( !ValidateSuppEmail())
           {
               return false ;
           }

            if(!ValidateCPEmail())
            {
                return false ;
            }
            if (!ValidateWebAddress())
            {
                return false;
            }
            if (!ValidatePhoneCell())
            {
                return false;
            }
            if (!ValidateCPPhoneCell())
            {
                return false;
            }

            return true;
        }

        private bool ValidateName()
        {
            if (_Supplier_Name.Equals(_Default) || _Supplier_Name.Equals(""))
            {
                _strErr = "Supplier Name is Empty";
                return false;
            }
            DataView dv = GetAll(2);

            if (!_SupplierID.Equals(_Default))
            {
                dv.RowFilter = "supplierID<>" + _SupplierID;
            }
            if (dv.Count > 0)
            {
                _strErr = "Supplier Name Already exist";
                return false;
            }

            return true;
        }

        private bool ValidateCPName()
        {
            if (_CP_Name.Equals(_Default) || _CP_Name.Equals(""))
            {
                _strErr = "Contact Person Name is Empty";
                return false;
            }
            return true;
        }

        private bool ValidateSuppEmail()
        {
            if (!_Email.Equals(_Default) && !_Email.Equals(""))
            {
                if (!Validation.IsEmail(_Email))
                {
                    _strErr = "Supplier Invalid Email ";
                    return false;
                }
            }
            return true;
        }

        private bool ValidateCPEmail()
        {
            if (!_CP_Email.Equals(_Default) && !_CP_Email.Equals(""))
            {
                if (!Validation.IsEmail(_CP_Email))
                {
                    _strErr = "Contact Person Invalid Email ";
                    return false;
                }
            }
            return true;
        }

        private bool ValidateWebAddress()
        {
            if (!_WebAddress.Equals(_Default) && !_WebAddress.Equals(""))
            {
                if (!Validation.IsWebAddress(_WebAddress))
                {
                    _strErr = "Invalid Web Address";
                    return false;
                }
            }
            return true;
        }

        private bool ValidatePhoneCell()
        {
            if ((_CellNo.Equals(_Default) || _CellNo.Equals("")) && (_Phone_1.Equals(_Default) || _Phone_1.Equals("")) && ( _Phone_2.Equals(_Default) || _Phone_2.Equals("")))
            {
                _strErr = "Supplier Cell No. and Phone No. is Empty ";
                return false;
            }
            return true;
        }

        private bool ValidateCPPhoneCell()
        {
            if ((_CP_Cell_no.Equals(_Default) || _CP_Cell_no.Equals("")) && (_CP_Office_Phone.Equals(_Default) || _CP_Office_Phone.Equals("") ))
            {
                _strErr = "Contact Person Cell No. and Phone No. is Empty ";
                return false;
            }
            return true;
        }
        #endregion

    }
}

