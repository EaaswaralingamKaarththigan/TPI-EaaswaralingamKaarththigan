﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Chat_EaaswaralingamKaarththigan
{
    public class utilisateur
    {
        public string lastname;
        public string firstname;
        public string user;
        public int idtypecompte;
        public int id;

        public utilisateur(int id, string user, int idtypecompte)
        {
            this.id = id;
            this.user = user;
            this.idtypecompte = idtypecompte;
        }

        public override string ToString()
        {
            return user;
        }
    }
}
