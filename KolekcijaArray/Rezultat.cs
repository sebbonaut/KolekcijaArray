using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaArray
{
    internal class Rezultat : IComparable //<Rezultat>
    {
        Osoba osoba;
        public readonly string sifra;
        public readonly int bodovi;
        public Rezultat(Osoba osoba, string sifra, int bodovi)
        {
            this.osoba = osoba;
            this.sifra = sifra;
            this.bodovi = bodovi;
        }
        public override string ToString()
            => sifra + " (" + osoba + "): " +
               bodovi + " bodova";

        public int CompareTo(Rezultat? other)
        {
            if (other == null)
                return -1;
            return bodovi - other.bodovi;
        }

        public int CompareTo(object? obj)
        {
            if (obj != null && obj is not Rezultat)
                throw new InvalidOperationException("CompareTo:" +
                    " Nije Rezultat!");
            return (obj == null) ? -1
                : bodovi - ((Rezultat)obj).bodovi;
        }
    }
}
