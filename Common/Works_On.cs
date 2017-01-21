using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct Works_OnInfo
    {
        public static String ID_Num = "ID_Num";
        public static String P_ID = "P_ID";
        public static String Hours = "Hours";
    }
    public class Works_On
    {
        int Hours;
        Staff staff;
        Project project;

        public int Hours1
        {
            get
            {
                return Hours;
            }

            set
            {
                Hours = value;
            }
        }

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

        public Project Project
        {
            get
            {
                return project;
            }

            set
            {
                project = value;
            }
        }
    }
}
