using System;
using System.Collections.Generic;

namespace Övning_4._3
{
    class Kontakt
    {
        public string Förnamn = "";
        public string Efternamn = "";
        public string Mail = "";
        public string Telefon = "";

        public Kontakt(string förnamn, string efternamn, string mail, string telefon)
        {
            this.Förnamn = förnamn;
            this.Efternamn = efternamn; 
            this.Mail = mail;
            this.Telefon = telefon;
        }

        public override string ToString()
        {
            return Förnamn + " " + Efternamn;
        }
    }
}
