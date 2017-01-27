using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct ProjectInfo
    {
        public static String ID = "ID";
        public static String C_ID = "C_ID";
        public static String Name = "Name";
        public static String S_ID = "S_ID";
        public static String Assignment_date = "Assignment_date";

    }
    public class Project
    {
        int ID;
        String Name;
        DateTime Assignment_date;
        Client client;
        Supervisor supervisor;

        public Client Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
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

       

        public Supervisor Supervisor
        {
            get
            {
                return supervisor;
            }

            set
            {
                supervisor = value;
            }
        }

        public DateTime Assignment_date1
        {
            get
            {
                return Assignment_date;
            }

            set
            {
                Assignment_date = value;
            }
        }
    }
}
