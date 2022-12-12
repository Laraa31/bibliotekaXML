using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqXMLDokumenti
{
    internal class Korisnik
    {
        int korisnik_id;
        string email;
        string ime,prezime,adresa;
        int brojTelefona;

        public Korisnik(int korisnik_id, string email, string ime, string prezime, string adresa, int brojTelefona)
        {
            this.korisnik_id = korisnik_id;
            this.email = email;
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.brojTelefona = brojTelefona;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public int BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public int Korisnik_id { get => korisnik_id; set => korisnik_id = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return "Ime: " + " Prezime: " + Prezime + "\r\nGodina rodenja: " + godRod;
        }
    }
}
