using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqXMLDokumenti
{
    class Stanje
    {
        int kolicina_knjiga;

        public Osoba(int kolicina_knjiga)
        {
            this.Kolicina_knjiga = kolicina_knjiga;
        }

        public int Kolicina_knjiga { get => kolicina_knjiga; set => kolicina_knjiga = value; }
    }
}
