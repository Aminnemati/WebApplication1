using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;

namespace UI
{
    public static class UIUtility
    {
        static Common.User user;

        public static User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }
    }
}