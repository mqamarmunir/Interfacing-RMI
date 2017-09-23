using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MI_DataLayer;

namespace MI_BL
{
    public class clsBLTest
    {
        clsBLDBConnection _objConnection = new clsBLDBConnection();
        QueryBuilder objQB = new QueryBuilder();
        clsdbMI objdbMI = new clsdbMI();

        public clsBLTest()
        {

        }
        public clsBLTest(clsBLDBConnection objConn)
        {
            _objConnection = objConn;
        }

        #region Class Variable

        private const string _TableName = "mi_tTests";
        private const string _Default = "~!@";
        private string _strErr = "";

        private string _Machine_testid = _Default;
        private string _Lims_testid = _Default;
        private string _Lims_test_name = _Default;

        private string _Machine_Test_name = _Default;
        private string _LOINC_code = _Default;
        private string _Instrumentid = _Default;

        private string _EnteredBy = _Default;
        private string _EnteredOn = _Default;
        private string _ClientID = _Default;

        private string _Active = _Default;
        private string _DeptID= _Default;
        private string _MachineTestCode = _Default;


        private string _DSerialnos = _Default;

        
        #endregion

        #region Properties
        public string StrErr
        {
            get { return _strErr; }
            set { _strErr = value; }
        }

        public string Machine_testid
        {
            get { return _Machine_testid; }
            set { _Machine_testid = value; }
        }
        public string Lims_testid
        {
            get { return _Lims_testid; }
            set { _Lims_testid = value; }
        }
        public string Lims_test_name
        {
            get { return _Lims_test_name; }
            set { _Lims_test_name = value; }
        }
        public string Machine_Test_name
        {
            get { return _Machine_Test_name; }
            set { _Machine_Test_name = value; }
        }
        public string LOINC_code
        {
            get { return _LOINC_code; }
            set { _LOINC_code = value; }
        }
        public string Instrumentid
        {
            get { return _Instrumentid; }
            set { _Instrumentid = value; }
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
        public string DeptID
        {
            get { return _DeptID; }
            set { _DeptID = value; }
        }
        public string MachineTestCode
        {
            get { return _MachineTestCode; }
            set { _MachineTestCode= value; }
        }

        public string DSerialnos
        {
            get { return _DSerialnos; }
            set { _DSerialnos = value; }
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
                case 1://fill main test Gridview 
                    objdbMI.Query = "SELECT t.Machine_testid, t.Lims_testid, t.Lims_test_name, t.Machine_Test_name ,t.LOINC_code, t.Instrumentid,i.Instrument_Name, t.Active,t.deptID,t.MachineTestCode,'Add Attribute' as Attribute FROM " + _TableName + " t,mi_tinstruments i where t.Instrumentid=i.instrumentid;;";
                    break;
                case 2: //select test which are already select from Main DB
                    objdbMI.Query = "SELECT cast(ifnull(group_concat(lpad(lims_testid,6,'0') ),0) as char) as TestList FROM mi_ttests";
                    break;
                case 3: //check Duplicate MachineTestName 
                    objdbMI.Query = "SELECT Machine_testID FROM mi_ttests m where machine_test_Name='" + _Machine_Test_name + "'";
                    break;
                case 4: //check Duplicate Machine Test Code
                    objdbMI.Query = "SELECT Machine_testID FROM mi_ttests m where machineTestCode='" + _MachineTestCode + "'";
                    break;
                case 5: //Fill Subdepartment ComboBox
                    objdbMI.Query = "SELECT Subdepartmentid,Name as SubDeptName FROM bc_lims.dc_tp_subdepartments d where d.active='Y';";
                    break;
                case 6://fill Test combobox from Main db
                    objdbMI.Query = "select cast(concat(concat(SubDepartmentID,':'),testid) as char) as testid ,test_Name as TestName from bc_lims.dc_tp_test t where active ='Y' ";
                    if (!_DeptID.Equals(_Default))
                    {
                        objdbMI.Query += " and SubDepartmentID = " + _DeptID + "";
                    }
                    objdbMI.Query += " order by test_Name";
                    break;
                case 7://fill Attribue list for selected Test.
                    objdbMI.Query = "select attributeid,attribute_Name from bc_lims.dc_tp_attributes t where testid=" + _Lims_testid + " and Active ='Y' order by attribute_Name";
                    break;
                case 8:
                    objdbMI.Query = "Select machinetestcode from mi_ttests where instrumentid=21 and Active='Y' and lims_testid in(" + _Lims_testid + ")";
                    break;
                    
            }
            return  _objConnection._objOperation.DataTrigger_Get_All(objdbMI);
        }

        public DataView OraGetAll(int flag)
        {
            switch (flag)
            {
                case 1://fill Test combobox from Main db
                    //objdbMI.Query = "select concat(concat(sectionID,':'),testid) as testid ,test as TestName from ls_ttest t where active ='Y' and testid not in(" + _Lims_testid + ")";
                    objdbMI.Query = "select concat(concat(sectionID,':'),testid) as testid ,test as TestName from ls_ttest t where active ='Y' ";
                    if (!_DeptID.Equals(_Default))
                    {
                        objdbMI.Query += " and Sectionid = '" + _DeptID  + "'";
                    }
                    objdbMI.Query += " order by test";
                    break;
                case 2://fill Section from Main DB.
                    objdbMI.Query = "select SectionId,SectionName from ls_tsection t where t.active='Y' ";
                    break;
                case 3://fill Attribue list for selected Test.
                    objdbMI.Query = "select attributeid,attribute as attribute_Name from ls_ttestattribute t where testid='" + _Lims_testid + "' and Active ='Y' order by attribute";
                    break;
                case 4://Getting the list of pending Tests(currently for CBC)
                    objdbMI.Query = @"SELECT lt2.DSerialNo,lt.labid,lt.prno,lv.patientname,lv.psex,lv.pdob,NVL(lt.referredby,'Other') as referredby,lt2.deliverydate,
                                        CASE WHEN lt.iop='I' THEN lv.wardname ELSE 'Out' END AS PatientWardInfo,lt2.ordered
                                        FROM ls_tmtransaction lt INNER JOIN ls_tdtransaction lt2 ON lt2.mserialno = lt.mserialno
                                        INNER JOIN ls_vpatient lv ON lv.prno=lt.prno and lv.mserialno=lt.mserialno
                                        WHERE lt2.processid='0004' AND lt2.testid='000781'
                                        AND (TO_CHAR(lt2.enteredate,'dd/mm/yyyy')=TO_CHAR(SYSDATE,'dd/mm/yyyy') or TO_CHAR(lt2.enteredate,'dd/mm/yyyy')=TO_CHAR(SYSDATE-1,'dd/mm/yyyy')) and (lt2.Ordered!='Y' or lt2.ordered is null) and rownum<=15";
                    break;
                case 5://Getting the list of pending Tests(Machine Name:Architect cobas E411)
                    objdbMI.Query = @"SELECT lt.labid,
       wm_Concat(lt2.DSerialNo) DSerialNOs,
       wm_concat(lt2.testid) TestIDs,
       lt.prno,
       lv.patientname,
       lv.psex,
       lv.pdob,
       NVL(lt.referredby, 'Other') as referredby,
       
       CASE
         WHEN lt.iop = 'I' THEN
          lv.wardname
         ELSE
          'Out'
       END AS PatientWardInfo
  FROM ls_tmtransaction lt
 INNER JOIN ls_tdtransaction lt2
    ON lt2.mserialno = lt.mserialno
 INNER JOIN ls_vpatient lv
    ON lv.prno = lt.prno
   and lv.mserialno = lt.mserialno
 Inner Join ls_ttestmethod ltm
    on ltm.Testid = lt2.testid
    and ltm.M_Default = 'Y'

 WHERE ltm.methodid in
       ('0161','0162','0163','0164')
   AND (TO_CHAR(lt2.enteredate, 'dd/mm/yyyy') =
       TO_CHAR(SYSDATE, 'dd/mm/yyyy') or
       TO_CHAR(lt2.enteredate, 'dd/mm/yyyy') =
       TO_CHAR(SYSDATE - 1, 'dd/mm/yyyy'))

       and lt2.Processid='0004'
 and (lt2.ordered is null or lt2.ordered!='Y')
 group by lt.labid,
          lt.prno,
          lv.patientname,
          lv.psex,
          lv.pdob,
          lt.referredby,
          lt.iop,
          lv.wardname";  
//                    objdbMI.Query = @"SELECT lt.labid,
//                                           wm_Concat(lt2.DSerialNo) DSerialNOs,
//                                           wm_concat(lt2.testid) TestIDs,
//                                           lt.prno,
//                                           lv.patientname,
//                                           lv.psex,
//                                           lv.pdob,
//                                           NVL(lt.referredby, 'Other') as referredby,
//       
//                                           CASE
//                                             WHEN lt.iop = 'I' THEN
//                                              lv.wardname
//                                             ELSE
//                                              'Out'
//                                           END AS PatientWardInfo,
//                                           lt2.ordered
//                                      FROM ls_tmtransaction lt
//                                     INNER JOIN ls_tdtransaction lt2
//                                        ON lt2.mserialno = lt.mserialno
//                                     INNER JOIN ls_vpatient lv
//                                        ON lv.prno = lt.prno
//                                       and lv.mserialno = lt.mserialno
//                                     Inner Join ls_ttestmethod ltm
//                                        on ltm.Testid = lt2.testid
//                                       and ltm.M_Default = 'Y'
//
//                                     WHERE  lt2.Testid in('000863','000865','000868')
//                                       AND (TO_CHAR(lt2.enteredate, 'dd/mm/yyyy') =
//                                           TO_CHAR(SYSDATE, 'dd/mm/yyyy') or
//                                           TO_CHAR(lt2.enteredate, 'dd/mm/yyyy') =
//                                           TO_CHAR(SYSDATE - 1, 'dd/mm/yyyy'))
//                                       and rownum<5
//                                       
//                                     group by lt.labid,
//                                              lt.prno,
//                                              lv.patientname,
//                                              lv.psex,
//                                              lv.pdob,
//                                              lt.referredby,
//                                              lt.iop,
//                                              lv.wardname,
//                                              lt2.ordered";
                    break;//AND ltm.methodid in ('0128', '0126', '0108', '0109') and (lt2.Ordered != 'Y' or lt2.ordered is null)  lt2.processid = '0004' and
                                       
            }
            return _objConnection._objOperation.DataTrigger_OraGet_All(objdbMI);
        }

        public bool oraupdate_ordereddtransaction()
        {
            objdbMI.Query = @"Update ls_tdtransaction set ordered='Y' where DSerialno in (" + _DSerialnos + ")";
            _objConnection._objOperation.Start_OraTransaction();
            _strErr = _objConnection._objOperation.DataTrigger_OraUpdate(objdbMI);
            //_objConnection._objOperation.End_OraTransaction();
            if (!_strErr.Equals("True"))
            {
                _objConnection._objOperation.End_OraTransaction();
                return true;

            }
            else
            {
                StrErr = _objConnection._objOperation.OperationError;
                _objConnection._objOperation.End_OraTransaction();
                return false;
            }
        }

        private string[,] MakeArr()
        {
            string[,] strArrTest = new string[12, 3];

            if (!_Machine_testid.Equals(_Default))
            {
                strArrTest[0, 0] = "Machine_testid";
                strArrTest[0, 1] = _Machine_testid;
                strArrTest[0, 2] = "int";
            }
            if (!_Lims_testid.Equals(_Default))
            {
                strArrTest[1, 0] = "Lims_testid";
                strArrTest[1, 1] = _Lims_testid;
                strArrTest[1, 2] = "string";
            }
            if (!_Lims_test_name.Equals(_Default))
            {
                strArrTest[2, 0] = "Lims_test_name";
                strArrTest[2, 1] = _Lims_test_name;
                strArrTest[2, 2] = "string";
            }
            if (!_Machine_Test_name.Equals(_Default))
            {
                strArrTest[3, 0] = "Machine_Test_name";
                strArrTest[3, 1] = _Machine_Test_name;
                strArrTest[3, 2] = "string";
            }
            if (!_LOINC_code.Equals(_Default))
            {
                strArrTest[4, 0] = "LOINC_code";
                strArrTest[4, 1] = _LOINC_code;
                strArrTest[4, 2] = "string";
            }
            if (!_Instrumentid.Equals(_Default))
            {
                strArrTest[5, 0] = "Instrumentid";
                strArrTest[5, 1] = _Instrumentid;
                strArrTest[5, 2] = "int";
            }
            if (!_EnteredBy.Equals(_Default))
            {
                strArrTest[6, 0] = "EnteredBy";
                strArrTest[6, 1] = _EnteredBy;
                strArrTest[6, 2] = "int";
            }
            if (!_EnteredOn.Equals(_Default))
            {
                strArrTest[7, 0] = "EnteredOn";
                strArrTest[7, 1] = _EnteredOn;
                strArrTest[7, 2] = "datetime";
            }
            if (!_ClientID.Equals(_Default))
            {
                strArrTest[8, 0] = "ClientID";
                strArrTest[8, 1] = _ClientID;
                strArrTest[8, 2] = "string";
            }

            if (!_Active.Equals(_Default))
            {
                strArrTest[9, 0] = "Active";
                strArrTest[9, 1] = _Active;
                strArrTest[9, 2] = "string";
            }

            if (!_DeptID.Equals(_Default))
            {
                strArrTest[10, 0] = "DeptID";
                strArrTest[10, 1] = _DeptID;
                strArrTest[10, 2] = "string";
            }

            if (!_MachineTestCode.Equals(_Default))
            {
                strArrTest[11, 0] = "MachineTestCode";
                strArrTest[11, 1] = _MachineTestCode;
                strArrTest[11, 2] = "string";
            }

            return strArrTest;
        }

        #endregion

        #region Validation

        private bool ValidateData()
        {
            if (!ValidateInstrument())
            {
                return false;
            }
            if (!ValidateLIMSTestName())
            {
                return false;
            }
            if (!ValidateMachineTestCode())
            {
                return false;
            }
            if (!ValidateMachineTestName())
            {
                return false;
            }
            return true;
        }

        private bool ValidateInstrument()
        {
            if (_Instrumentid.Equals(_Default))
            {
                _strErr = "Please Select Instrument ";
                return false;
            }
            return true;
        }

        private bool ValidateMachineTestName()
        {
            if (_Machine_Test_name.Equals(""))
            {
                _strErr = "Please Enter Machine Test Name ";
                return false;
            }
            //DataView dv = GetAll(3);

            //if (!_Machine_testid.Equals(_Default))
            //{
            //    dv.RowFilter = "Machine_testid <>" + _Machine_testid;
            //}
            //if (dv.Count > 0)
            //{
            //    _strErr = "Machine Test Name Already exist";
            //    return false;
            //}
            return true;
        }

        private bool ValidateMachineTestCode()
        {
            if (_MachineTestCode.Equals(""))
            {
                _strErr = "Please Enter Machine Test Code";
                return false;
            }
            //DataView dv = GetAll(4);

            //if (!_Machine_testid.Equals(_Default))
            //{
            //    dv.RowFilter = "Machine_testid <>" + _Machine_testid;
            //}
            //if (dv.Count > 0)
            //{
            //    _strErr = "Machine Test Code Already exist";
            //    return false;
            //}
            return true;
        }

        private bool ValidateLIMSTestName()
        {
            if (_Lims_test_name.Equals(_Default))
            {
                _strErr = "Please Select LIMS Test Name ";
                return false;
            }
            return true;
        }

        #endregion
    }
}
