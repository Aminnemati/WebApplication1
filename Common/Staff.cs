using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Staff
    {
        public struct StaffInfo
        {
            public static String ID_Num = "ID_Num";
            public static String FName = "FName";
            public static String LName = "LName";
            public static String Employment_Date = "Employment_Date";
            public static String Birth_Date = "Birth_Date";
            public static String Address = "Adress";
            public static String E_Mail = "E_Mail";
            public static String Salary = "Salary";
        }
        int ID_Num, Salary;
        String FName, LName, Employment_Date, Birth_Date, Address, E_Mail;

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

        public string Employment_Date1
        {
            get
            {
                return Employment_Date;
            }

            set
            {
                Employment_Date = value;
            }
        }

        public string Birth_Date1
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

        public string Address1
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
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
