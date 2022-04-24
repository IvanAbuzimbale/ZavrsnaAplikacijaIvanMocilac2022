using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsnaAplikacijaIvanMocilac2022
{
    class Rezervacija
    {
        DateTime datumDolaska;
        DateTime datumeOdlaska;
        string brojSkupine;
        string imeVlasnikaRezervacije;
        string brojGostiju;
        string imeObjekta;

        public Rezervacija(DateTime datumDolaska, DateTime datumeOdlaska, string brojSkupine, string imeVlasnikaRezervacije, string brojGostiju, string imeObjekta)
        {
            this.datumDolaska = datumDolaska;
            this.datumeOdlaska = datumeOdlaska;
            this.brojSkupine = brojSkupine;
            this.imeVlasnikaRezervacije = imeVlasnikaRezervacije;
            this.brojGostiju = brojGostiju;
            this.imeObjekta = imeObjekta;
        }

        public DateTime DatumDolaska { get => datumDolaska; set => datumDolaska = value; }
        public DateTime DatumeOdlaska { get => datumeOdlaska; set => datumeOdlaska = value; }
        public string BrojSkupine { get => brojSkupine; set => brojSkupine = value; }
        public string ImeVlasnikaRezervacije { get => imeVlasnikaRezervacije; set => imeVlasnikaRezervacije = value; }
        public string BrojGostiju { get => brojGostiju; set => brojGostiju = value; }
        public string ImeObjekta { get => imeObjekta; set => imeObjekta = value; }
    }
}
