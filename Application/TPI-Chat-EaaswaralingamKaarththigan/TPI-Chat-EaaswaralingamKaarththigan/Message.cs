using System;
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
        public int Id;
        public string username;
        public int idemploye;
        public int idtypecompte;

        public Message(string lastname, string firstname, string text, int Id, string username, int idemploye, int idtypecompte)
        {
            this.Id = Id;
            this.lastname = lastname;
            this.firstname = firstname;
            this.text = text;
            this.username = username;
            this.idemploye = idemploye;
            this.idtypecompte = idtypecompte;
        }

        public override string ToString()
        {
            return text;
        }

        
    }
}
