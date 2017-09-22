using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace MI_BL
{
    public class QueryBuilder
    {
        public QueryBuilder()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string QBInsert(string[,] ar, string tableName)
        {
            string toReturn = "Insert into " + tableName + "(";
            int checker = 0;
            string dateFormat = "";

            for (int counter = 0; counter <= ar.GetUpperBound(0); counter++)
            {
                if (ar[counter, 0] != null)
                {
                    if (checker != 0)
                    {
                        toReturn += ",";
                    }

                    toReturn += ar[counter, 0];

                    checker++;
                }
            }

            toReturn += ") Values(";
            checker = 0;

            for (int counter = 0; counter <= ar.GetUpperBound(0); counter++)
            {
                if (ar[counter, 0] != null)
                {
                    if (checker != 0)
                    {
                        toReturn += ",";
                    }

                    switch (ar[counter, 2])
                    {
                        case "string":
                            toReturn += "'" + ar[counter, 1] + "'";
                            break;

                        case "int":
                            toReturn += ar[counter, 1];
                            break;
                        case "date":
                            dateFormat = ConfigurationSettings.AppSettings["DateFormat"].ToString();
                            toReturn += "str_to_date('" + ar[counter, 1] + "','" + dateFormat + "')";
                            break;

                        case "datetime":
                            dateFormat = ConfigurationSettings.AppSettings["DateTimeFormat"].ToString();
                            toReturn += "str_to_date('" + ar[counter, 1] + "','" + dateFormat + "')";
                            break;

                        case "datetime24":
                            dateFormat = ConfigurationSettings.AppSettings["DateTimeFormat24"].ToString();
                            toReturn += "str_to_date('" + ar[counter, 1] + "','" + dateFormat + "')";
                            break;
                        default:
                            toReturn += "'" + ar[counter, 1] + "'";
                            break;
                    }

                    checker++;
                }
            }

            toReturn += ")";

            return toReturn;
        }

        public string QBUpdate(string[,] ar, string tableName)
        {
            string toReturn = "Update " + tableName + " set ";
            int checker = 0;
            string dateFormat = "";

            for (int counter = 1; counter <= ar.GetUpperBound(0); counter++)
            {
                if (ar[counter, 0] != null)
                {
                    if (checker != 0)
                    {
                        toReturn += ",";
                    }

                    switch (ar[counter, 2])
                    {
                        case "string":
                            toReturn += ar[counter, 0] + "='" + ar[counter, 1] + "'";
                            break;

                        case "int":
                            toReturn += ar[counter, 0] + "=" + ar[counter, 1];
                            break;
                        case "date":
                            dateFormat = ConfigurationSettings.AppSettings["DateFormat"].ToString();
                            toReturn += ar[counter, 0] + "=str_to_date('" + ar[counter, 1] + "','" + dateFormat + "')";
                            break;

                        case "datetime":
                            dateFormat = ConfigurationSettings.AppSettings["DateTimeFormat"].ToString();
                            toReturn += ar[counter, 0] + "=str_to_date('" + ar[counter, 1] + "','" + dateFormat + "')";
                            break;

                        case "datetime24":
                            dateFormat = ConfigurationSettings.AppSettings["DateTimeFormat24"].ToString();
                            toReturn += ar[counter, 0] + "=str_to_date('" + ar[counter, 1] + "','" + dateFormat + "')";
                            break;

                        default:
                            toReturn += ar[counter, 0] + "='" + ar[counter, 1] + "'";
                            break;
                    }

                    checker++;
                }
            }

            if (ar[0, 2].Equals("string"))
            {
                toReturn += " Where " + ar[0, 0].ToUpper() + "='" + ar[0, 1].ToUpper() + "'";
            }
            else
            {
                toReturn += " Where " + ar[0, 0].ToUpper() + "=" + ar[0, 1].ToUpper();
            }

            return toReturn;
        }

        /// 
        /// <summary>
        /// Function that generate Query for deletion of records from a single table
        /// </summary>
        /// <param name="colunmName">Column Name by which records will be filtered</param>
        /// <param name="colValue">Value, required to be filtered</param>
        /// <param name="tableName">Table Name</param>
        /// <returns>Deletion Query</returns>
        /// 

        public string QBDelete(string colunmName, string colValue, string tableName)
        {
            string toReturn = "Delete " + tableName + " Where  " + colunmName + " = " + colValue;
            return toReturn;
        }

        public string QBGetMax(string columnName, string tableName)
        {
            return "Select IfNull(Max(" + columnName + "), 0) + 1 As MAXID from " + tableName;
        }
    }
}
