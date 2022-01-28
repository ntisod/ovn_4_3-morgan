using System;
using System.Collections.Generic;

namespace Övning_4._3
{
    /// <summary>
    /// Den här klassen användes för att samla förnamn, efternamn, mail och telefon. Jag kan sen göra en lista med klassen.
    /// </summary>
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
