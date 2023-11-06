using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaArray
{
    internal class Osoba
    {
        public readonly string ime, prezime;
        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
        public override string ToString()
            => ime + " " + prezime;
    }
}
