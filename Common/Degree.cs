using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Degree
    {
        public struct DegreeInfo
        {
            public static String ID_Num = "ID_Num";
            public static String S_Degree = "S_Degree";
        }
        Staff staff;
        String S_Degree;

        public Staff Staff
        {
            get
            {
                return staff;
            }

            set
            {
                staff = value;
            }
        }

        public string S_Degree1
        {
            get
            {
                return S_Degree;
            }

            set
            {
                S_Degree = value;
            }
        }
    }
}
