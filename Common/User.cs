using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct UserInfo
    {
        public static String Username = "Username";
        public static String Pass = "Pass";
        public static String ID = "ID";
    }
    public class User
    {
        int ID;
        String Username, Pass;

        public int ID1
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

        public string Pass1
        {
            get
            {
                return Pass;
            }

            set
            {
                Pass = value;
            }
        }

        public string Username1
        {
            get
            {
                return Username;
            }

            set
            {
                Username = value;
            }
        }
    }
}
