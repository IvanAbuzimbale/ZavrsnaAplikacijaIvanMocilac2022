using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsnaAplikacijaIvanMocilac2022
{
    class KucniObjekt
    {
        string imeObjekta;
        string vlasnikObjekta;
        string cijena;

        public KucniObjekt(string imeObjekta, string vlasnikObjekta, string cijena)
        {
            this.imeObjekta = imeObjekta;
            this.vlasnikObjekta = vlasnikObjekta;
            this.cijena = cijena;
        }

        public string ImeObjekta { get => imeObjekta; set => imeObjekta = value; }
        public string VlasnikObjekta { get => vlasnikObjekta; set => vlasnikObjekta = value; }
        public string Cijena { get => cijena; set => cijena = value; }
    }
}
