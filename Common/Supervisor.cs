using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct SupervisorInfo
    {
        public static String S_ID = "S_ID";
    }
    public class Supervisor
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
