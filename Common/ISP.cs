using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct ISPInfo
    {
        public static String S_ID = "S_ID";
        public static String Serial_No = "Serial_No";
        public static String P_ID = "P_ID";
    }
    public class ISP
    {
        Supplier supplier;
        Item item;
        Project project;

        public Supplier Supplier
        {
            get
            {
                return supplier;
            }

            set
            {
                supplier = value;
            }
        }

        public Item Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
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
