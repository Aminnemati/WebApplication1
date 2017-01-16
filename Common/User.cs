using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct UserInfo
    {
        public static String ID = "Username";
        public static String Code = "Pass";
    }
    public class User
    {
        String ID, Code;

        public string Code1
        {
            get
            {
                return Code;
            }

            set
            {
                Code = value;
            }
        }

        public string ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }
    }
}
