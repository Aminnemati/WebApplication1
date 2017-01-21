using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct SupplyInfo
    {
        public static String ID = "ID";
        public static String Price = "Price";
        public static String Date = "Date";
        public static String Number = "Number";
        public static String Model = "Model";
        public static String Name = "Name";
        public static String Type = "Type";
        public static String S_ID = "S_ID";
    }
    public class Supply
    {
        int ID,Number;
        float Price;
        String Date, Model, Name, Type;
        Supplier supplier;

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

        public int Number1
        {
            get
            {
                return Number;
            }

            set
            {
                Number = value;
            }
        }

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

        public string Date1
        {
            get
            {
                return Date;
            }

            set
            {
                Date = value;
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
    }
}
