﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Chat_EaaswaralingamKaarththigan
{
    class Message
    {
        public string lastname;
        public string firstname;
        public string text;
        public string Id;

        public Message(string lastname, string firstname, string text)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.text = text;

        }

        
    }
}
