﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Task_Category
    {
        public struct Task_CategoryInfo
        {
            public static String ID = "ID";
            public static String Name = "Name";
        }
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
