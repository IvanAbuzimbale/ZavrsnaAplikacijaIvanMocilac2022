using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsnaAplikacijaIvanMocilac2022
{
    class Gost
    {
        string ime;
        string prezime;
        DateTime datumRođenja;
        string brojSkupine;
        string mjestoPrebivališta;

        public Gost(string ime, string prezime, DateTime datumRođenja, string brojSkupine, string mjestoPrebivališta)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumRođenja = datumRođenja;
            this.brojSkupine = brojSkupine;
            this.mjestoPrebivališta = mjestoPrebivališta;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRođenja { get => datumRođenja; set => datumRođenja = value; }
        public string BrojSkupine { get => brojSkupine; set => brojSkupine = value; }
        public string MjestoPrebivališta { get => mjestoPrebivališta; set => mjestoPrebivališta = value; }
    }
}
