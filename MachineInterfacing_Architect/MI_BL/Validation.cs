using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;

namespace MI_BL
{
    public class Validation
    {
        CultureInfo ObjDateFormat = new CultureInfo("ur-PK");

        public Validation()
        {
        }

        /// <summary>
        /// To test Name (Mr M Salahuddin Khan)
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public bool IsName(string strName)
        {
            Regex objReg = new Regex(@"(^[A-Za-z]+\s?)*[A-Za-z]$");
            return objReg.IsMatch(strName);
        }

        public static bool IsEmail(string strEmail)
        {
            Regex objReg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return objReg.IsMatch(strEmail);
        }

        public bool IsAddress(string strAddress)
        {
            Regex objReg = new Regex(@"^[A-Za-z0-9\s]+([\/\.-]*)?[A-Za-z0-9\s]+$");
            return objReg.IsMatch(strAddress);

        }

        public bool IsDate(string strDate)
        {
            Regex objReg = new Regex(@"^[0-3][0-9]\/[0-1][0-9]\/[0-9][0-9][0-9][0-9]$");

            if (objReg.IsMatch(strDate))
            {
                ObjDateFormat.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                System.Threading.Thread.CurrentThread.CurrentCulture = ObjDateFormat;

                try
                {
                    System.DateTime.Parse(strDate);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool IsTime(string strTime)
        {
            Regex objReg = new Regex(@"(^[1][0-2]|^[1-9]|^[0][1-9]):[0-5][0-9]\s(AM|PM)$");

            if (objReg.IsMatch(strTime))
            {
                ObjDateFormat.DateTimeFormat.ShortTimePattern = "hh:mm tt";
                System.Threading.Thread.CurrentThread.CurrentCulture = ObjDateFormat;

                try
                {
                    System.DateTime.Parse(strTime);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool IsNIC(string strNIC)
        {
            Regex objReg = new Regex(@"^[0-9]+[-][0-9]+[-][0-9]+$");
            return objReg.IsMatch(strNIC);
        }

        /// <summary>
        /// Function to test for Positive Integers with zero exclusive
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public bool IsNaturalNumber(string strNumber)
        {
            Regex objNotNaturalPattern = new Regex("[^0-9]");
            Regex objNaturalPattern = new Regex("0*[1-9][0-9]*");
            return !objNotNaturalPattern.IsMatch(strNumber) &&
                objNaturalPattern.IsMatch(strNumber);
        }

        /// <summary>
        /// Function to test for Positive Integers with zero inclusive
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public bool IsWholeNumber(string strNumber)
        {
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strNumber);
        }

        /// <summary>
        /// Function to Test for Integers both Positive & Negative
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public bool IsInteger(string strNumber)
        {
            Regex objNotIntPattern = new Regex("[^0-9-]");
            Regex objIntPattern = new Regex("^-[0-9]+$|^[0-9]+$");
            return !objNotIntPattern.IsMatch(strNumber) && objIntPattern.IsMatch(strNumber);
        }

        /// <summary>
        /// Function to test whether the input string is a valid Positive Integer or Real number
        /// </summary>
        /// <param name="strNumber">String to validate</param>
        /// <returns>Boolean</returns>
        public bool IsPositiveNumber(string strNumber)
        {
            Regex objNotPositivePattern = new Regex("[^0-9.]");
            Regex objPositivePattern = new Regex("^[.][0-9]+$|[0-9]*[.]*[0-9]+$");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");

            return !objNotPositivePattern.IsMatch(strNumber) && objPositivePattern.IsMatch(strNumber) && !objTwoDotPattern.IsMatch(strNumber);
        }

        /// <summary>
        /// Function to test whether the string is valid number or not
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns>bool</returns>		
        public bool IsNumber(string strNumber)
        {
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");
            return !objNotNumberPattern.IsMatch(strNumber) &&
                !objTwoDotPattern.IsMatch(strNumber) &&
                !objTwoMinusPattern.IsMatch(strNumber) &&
                objNumberPattern.IsMatch(strNumber);
        }


        /// <summary>
        /// Function To test for Alphabets. 
        /// </summary>
        /// <param name="strToCheck"></param>
        /// <returns>bool</returns>
        public bool IsAlpha(string strToCheck)
        {
            Regex objAlphaPattern = new Regex("[^a-zA-Z][a-zA-Z.]$");
            return !objAlphaPattern.IsMatch(strToCheck);
        }


        /// <summary>
        /// Function to Check for AlphaNumeric.
        /// </summary>
        /// <param name="strToCheck"></param>
        /// <returns>bool</returns>
        public bool IsAlphaNumeric(string strToCheck)
        {
            Regex objAlphaNumericPattern = new Regex("[^a-zA-Z0-9][a-zA-Z0-9]$");

            return !objAlphaNumericPattern.IsMatch(strToCheck);
        }

        /// <summary>
        /// In database apostrophe sign(') is used to identify the boundary of string, that is why if any input data have apostrophe then it must be replaced with double apostrophe
        /// </summary>
        /// <param name="inputString">String required to be check and transform</param>
        /// <returns>Replaced string</returns>
        public string ReplaceApostrophe(string inputString)
        {
            return inputString.Replace("'", "''");
        }

       public static bool IsWebAddress(string strWebAddress)
        {
            Regex objReg = new Regex(@"(http(s)?://)?([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
            return objReg.IsMatch(strWebAddress);
        }
        #region "Old System Validations (Not currently in used and commented)"
        /*
        public bool IsPLNo(string strToCheck)
		{
			Regex objAlphaNumericPattern = new Regex(@"^([a-zA-Z0-9]+[-])*[0-9]*[0-9]$");

			return objAlphaNumericPattern.IsMatch(strToCheck);   
		}

		public bool IsEntitledPatientId(string patientId){
			if(patientId.ToLower().IndexOf("e")==0)
			{
				return true;
			}
			return false;
		}

		public bool IsBloodGroup(string strToCheck)
		{
			Regex objBGPattern = new Regex(@"^[A-Z][A-Z]?\+$|^[A-Z][A-Z]?[-]$");
			return objBGPattern.IsMatch(strToCheck);
		}

        public bool IsBBName(string strBBName)
        {
            Regex objReg = new Regex(@"^[A-Za-z0-9]([A-Za-z0-9]+\s?\(?[\+-]?\)?\s?)*$");
            return objReg.IsMatch(strBBName);
        }
        */
        #endregion
    }
}
