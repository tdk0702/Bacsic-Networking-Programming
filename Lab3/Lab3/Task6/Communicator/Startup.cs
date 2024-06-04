using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Task6.Communicator
{
    internal class Startup
    {
        public String onlUser { get; set; }
        public Startup(String onlUser)
        {
            this.onlUser = onlUser;
        }
    }
}
