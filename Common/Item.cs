using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Item
    {
        public struct IntemInfo
        {
            public static String Serial_No = "Serial_No";
            public static String Price = "Price";
            public static String Name = "Name";
            public static String Type = "Type";
            public static String Model = "Model";
        }
        float Price;
        String Serial_No;
        Item_Type item_Type;

        public float Price1
        {
            get
            {
                return Price;
            }

            set
            {
                Price = value;
            }
        }

        public string Serial_No1
        {
            get
            {
                return Serial_No;
            }

            set
            {
                Serial_No = value;
            }
        }

        public Item_Type Item_Type
        {
            get
            {
                return item_Type;
            }

            set
            {
                item_Type = value;
            }
        }
    }
}
