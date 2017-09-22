using System;
using System.Collections.Generic;
using System.Text;


namespace MachineInterfacing
{
    public class clsSharedVariable
    {
        public clsSharedVariable()
        {
        }

        public static string UserName = "";
        public static string ClientID = "0001";
        public static string LoginID = "";
        public static string PersonID = "";

        public static string InstrumentID = "1";
        public static string InstrumentName = "Elecsys2010";
        public static string Supplierid = "1";
        public static string Model = "";
        public static string I_Release = "";
        public static string Patient_no_format = "";
        public static string BarCode_Standard = "";
        public static string Communication_Stnadard = "";
        public static string Communication_method = "";
        public static string PORT = "COM1";
        public static string BaudRate = "9600";
        public static string Parity = "None";
        public static string Stopbit = "One";
        public static string DataBit = "8";
        public static string FlowControl = "None";
        public static string Acknowledgement_code = "1";
        public static string Supplier_Name = "";
        public static string ImmuliteLastRec = "";

        public static string dbUserName = "root";
        public static string dbPWD = "trs_mi_rmi";//

        public static string InItCaps(string str)
        {
            string str1 = new System.Globalization.CultureInfo("en-US").TextInfo.ToTitleCase(str);
            return str1;
        }
    }


}
