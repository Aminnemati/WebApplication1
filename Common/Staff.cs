using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct StaffInfo
    {
        public static String ID_Num = "ID_Num";
        public static String FName = "FName";
        public static String LName = "LName";
        public static String Birth_Date = "Birth_Date";
        public static String E_Mail = "E_Mail";
        public static String Salary = "Salary";
    }
    public class Staff
    {
        int ID_Num, Salary;
        DateTime Birth_Date;
        String FName, LName, E_Mail;

        public int ID_Num1
        {
            get
            {
                return ID_Num;
            }

            set
            {
                ID_Num = value;
            }
        }

        public int Salary1
        {
            get
            {
                return Salary;
            }

            set
            {
                Salary = value;
            }
        }

        public DateTime Birth_Date1
        {
            get
            {
                return Birth_Date;
            }

            set
            {
                Birth_Date = value;
            }
        }

        public string FName1
        {
            get
            {
                return FName;
            }

            set
            {
                FName = value;
            }
        }

        public string LName1
        {
            get
            {
                return LName;
            }

            set
            {
                LName = value;
            }
        }

        public string E_Mail1
        {
            get
            {
                return E_Mail;
            }

            set
            {
                E_Mail = value;
            }
        }
    }
}
