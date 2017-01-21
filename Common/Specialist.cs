using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct SpecialistInfo
    {
        public static String S_ID = "S_ID";
    }
    public class Specialist
    {
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
