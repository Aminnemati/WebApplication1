using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct Item_TypeInfo
    {
        public static String Name = "Name";
        public static String Model = "Model";
        public static String Type = "Type";
        public static String Quantity = "Quantity";
    }
    public class Item_Type
    {
        int Quantity;
        String Name, Model, Type;

        public int Quantity1
        {
            get
            {
                return Quantity;
            }

            set
            {
                Quantity = value;
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

        public string Model1
        {
            get
            {
                return Model;
            }

            set
            {
                Model = value;
            }
        }

        public string Type1
        {
            get
            {
                return Type;
            }

            set
            {
                Type = value;
            }
        }
    }
}
