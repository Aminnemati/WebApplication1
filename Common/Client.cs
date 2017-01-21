using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct ClientInfo
    {
        public static String ID = "ID";
        public static String Name = "Name";

    }
    public class Client
    {
        String name;
        int ID;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Id1
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

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

        int Id;
    }
}
