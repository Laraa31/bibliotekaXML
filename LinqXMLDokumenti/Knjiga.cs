﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqXMLDokumenti
{
    internal class Knjiga
    {
        const int knjiga_id;
        string autor, izdavač;
        int godRod;

        public Korisnik(string ime, string prezime, int godRod)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.GodRod = godRod;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int GodRod { get => godRod; set => godRod = value; }
        public override string ToString()
        {
            return "Ime: " + ime + " Prezime: " + prezime + "\r\nGodina rodenja: " + godRod;
        }
    }
}
