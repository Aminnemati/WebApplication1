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
        String Name,Priority,Status;
        int ID,Budget;

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string Priority1
        {
            get
            {
                return Priority;
            }

            set
            {
                Priority = value;
            }
        }

        public string Status1
        {
            get
            {
                return Status;
            }

            set
            {
                Status = value;
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

        public int Budget1
        {
            get
            {
                return Budget;
            }

            set
            {
                Budget = value;
            }
        }
    }
}
