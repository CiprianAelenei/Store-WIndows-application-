using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW
{    public class Client : Persoana
    {
       private bool cardFidel;
        public CategoryEnum Category { get; set; }

        private Tranzactii tranzactie;

        public Client(int id, string nume, string email, string nrTelefon, 
             bool cardexist, Tranzactii tr) : base(id, nume, email, nrTelefon)
        {
            
            cardFidel = cardexist;
           
            tranzactie = tr;
        }

        public bool CardFidel
        {
            get
            {
                return cardFidel;
            }
            set
            {
                cardFidel = value;
            }
        }
    }
}

