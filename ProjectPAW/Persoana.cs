using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW
{
    public abstract class Persoana
    {
        public int Id { get; set; }

        private string nume;
        private string adresaEmail;
        private string nrTel;

        public Persoana(int cod, string n,  string email, string nr)
        {
            if (Id >= 0)
                Id = cod;
            nume = n;            
            adresaEmail = email;
            nrTel = nr;
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value != null)
                    nume = value;
            }
        }
       public string AdresaEmail
        {
            get { return adresaEmail; }
            set
            {
                if (value != null)
                    adresaEmail = value;
            }
        }
        public string NrTel
        {
            get { return this.nrTel; }
            set
            {
                if (value != null)
                    nrTel = value;
            }
        }

        public override string ToString()
        {
            return "Persoana cu codul : " + Id + ", numele : " + nume;
        }

    }
}