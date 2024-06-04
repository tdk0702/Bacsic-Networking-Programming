﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lab3.Task6.Communicator
{
    internal class Messages
    {
        public String sender { get; set; }
        public String receiver { get; set; }
        public String message { get; set; }
        public Messages(String sender, String recerver, String message)
        {
            this.sender = sender;
            this.receiver = recerver;
            this.message = message;
        }
        [JsonConstructor]
        public Messages() { }
    }
}