using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MI_DataLayer;

namespace MI_BL
{
    public class clsBLLogin
    {
        clsBLDBConnection _objConnection;
        clsdbMI objdbMI= new clsdbMI();
        QueryBuilder objQB = new QueryBuilder();

        public clsBLLogin()
        {
        }

        public clsBLLogin(clsBLDBConnection objConnection)
        {
            _objConnection = objConnection;
        }

        # region "Class variables"

        private const string Default = "~!@";
        private const string _TableName = "mi_tPersonnel";
        private string StrErrorMessage = "";

        private string _PatientID = Default;
        private string _Salutation = Default;
        private string _FName = Default;
        private string _MName = Default;
        private string _LName = Default;
        private string _LoginID= Default;
        private string _Password = Default;
        
        #endregion

        #region "Properties"

        public string PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }

        public string Salutation
        {
            get { return _Salutation; }
            set { _Salutation = value; }
        }

        public string FName
        {
            get { return _FName; }
            set { _FName = value; }
        }
        
        public string MName
        {
            get { return _MName; }
            set { _MName = value; }
        }

        public string LName
        {
            get { return _LName; }
            set { _LName  = value; }
        }
        
        public string LoginID
        {
            get { return _LoginID; }
            set { _LoginID = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string ErrorMessage
        {
            get { return StrErrorMessage; }
        }

        #endregion

        #region "Method"

        public bool Insert()
        {
            if (ValidateData())
            {
                try
                {
                    objdbMI.Query = objQB.QBInsert(MakeArray(), _TableName);
                    StrErrorMessage = _objConnection._objOperation.DataTrigger_Insert(objdbMI);

                    if (StrErrorMessage.Equals("Error"))
                    {
                        StrErrorMessage = _objConnection._objOperation.OperationError;
                        return false;
                    }
                    return true;
                }
                catch (Exception e)
                {
                    StrErrorMessage = e.Message;
                    return false;
                }
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
                try
                {
                    objdbMI.Query = objQB.QBUpdate(MakeArray(), _TableName);
                    StrErrorMessage = _objConnection._objOperation.DataTrigger_Update(objdbMI);

                    if (StrErrorMessage.Equals("Error"))
                    {
                        StrErrorMessage = _objConnection._objOperation.OperationError;
                        return false;
                    }

                    return true;
                }
                catch (Exception e)
                {
                    StrErrorMessage = e.Message;
                    return false;
                }
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
                    objdbMI.Query = "SELECT personid, trim(concat(salutation ,' ' ,FNAme ,' ',MName,' ' ,LName)) as Name  FROM mi_tpersonnel where loginid='" + _LoginID + "' and pasword='" + _Password + "' and active='Y'";
                    break;
            }

            return _objConnection._objOperation.DataTrigger_Get_All(objdbMI);
        }

        private string[,] MakeArray()
        {
            string[,] strarr = new string[7, 3];

            if (!this._PatientID.Equals(Default))
            {
                strarr[0, 0] = "PatientID";
                strarr[0, 1] = _PatientID;
                strarr[0, 2] = "int";
            }
            if (!this._Salutation.Equals(Default))
            {
                strarr[1, 0] = "Salutation";
                strarr[1, 1] = _Salutation;
                strarr[1, 2] = "string";
            }
            if (!this._FName.Equals(Default))
            {
                strarr[2, 0] = "FName";
                strarr[2, 1] = _FName;
                strarr[2, 2] = "string";
            }
            if (!this._MName.Equals(Default))
            {
                strarr[3, 0] = "MName";
                strarr[3, 1] = _MName;
                strarr[3, 2] = "string";
            }
            if (!this._LName.Equals(Default))
            {
                strarr[4, 0] = "LName";
                strarr[4, 1] = _LName;
                strarr[4, 2] = "string";
            }
            if (!this._LoginID.Equals(Default))
            {
                strarr[5, 0] = "LoginID";
                strarr[5, 1] = _LoginID;
                strarr[5, 2] = "string";
            }
            if (!this._Password.Equals(Default))
            {
                strarr[5, 0] = "Pasword";
                strarr[5, 1] = _Password;
                strarr[5, 2] = "string";
            }

            return strarr;
        }

        #endregion

        #region "Validation"

        private bool ValidateData()
        {
            if (!ValidateID())
            {
                return false;
            }
           
            return true;
        }

        private bool ValidateID()
        {
            return true;
        }

        #endregion

    }
}
