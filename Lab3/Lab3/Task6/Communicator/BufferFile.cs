using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Task6.Communicator
{
    public class BufferFile
    {
        public String sender { get; set; }
        public String receiver { get; set; }
        public byte[] buffer { get; set; }
        public String extension { get; set; }
        public BufferFile(string sender, string receiver, byte[] buffer, string extension)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.buffer = buffer;
            this.extension = extension;
        }
    }
}
