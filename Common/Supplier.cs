using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct SupplierInfo
    {
        public static String ID = "ID";
        public static String Name = "Name";
    }
    public class Supplier
    {
        int ID;
        String Name;

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
    }
}
