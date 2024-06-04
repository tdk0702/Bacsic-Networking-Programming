using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Task6.Communicator
{
    internal class Json
    {
        public String type { get; set; }
        public String content { get; set; }
        public Json(String type, String content)
        {
            this.type = type;
            this.content = content;
        }
    }
}
