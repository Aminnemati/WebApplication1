using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Client
    {
        String name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Id1
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        int Id;
    }
}
