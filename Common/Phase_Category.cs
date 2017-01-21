using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct Phase_CategoryInfo
    {
        public static String Code = "ID";
        public static String Name = "Name";
        public static String Description = "Description";
    }
    public class Phase_Category
    {
        int code;
        String Name, Description;

        public int Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
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

        public string Description1
        {
            get
            {
                return Description;
            }

            set
            {
                Description = value;
            }
        }
    }
}
