﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Phone_Numbers
    {
        public struct Phone_NumbersInfo
        {
            public static String ID = "ID";
            public static String Phone = "Phone";
        }
        Staff staff;
        String Phone;

        public Staff Staff
        {
            get
            {
                return staff;
            }

            set
            {
                staff = value;
            }
        }

        public string Phone1
        {
            get
            {
                return Phone;
            }

            set
            {
                Phone = value;
            }
        }
    }
}
