using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqXMLDokumenti
{
    class Evidencija
    {
        int kljuc;
        DateTime podizanje = new DateTime();
        DateTime vracanje = new DateTime();

        public Evidencija(int kljuc, DateTime podizanje, DateTime vracanje)
        {
            this.Kljuc = kljuc;
            this.Podizanje = podizanje;
            this.Vracanje = vracanje;
        }

        public int Kljuc { get => kljuc; set => kljuc = value; }
        public DateTime Podizanje { get => podizanje; set => podizanje = value; }
        public DateTime Vracanje { get => vracanje; set => vracanje = value; }
    }
}
