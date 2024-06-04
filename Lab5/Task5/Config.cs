using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Config
    {
        public string MailServer { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string SSL { get; set; }

        public string nickname { get; set; }
    }
}
