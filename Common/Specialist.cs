using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Specialist
    {
        public struct SpecialistInfo
        {
            public static String S_ID = "S_ID";
        }
        Staff staff;

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
    }
}
