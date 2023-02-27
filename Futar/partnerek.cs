using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futar
{
    class Partnerek
    {
        public int Id { get; set; }

        public string Nev { get; set; }

        public string Tel { get; set; }

        public string Kerulet { get; set; }

        public string Utca { get; set; }

        public string Hazszam { get; set; }

        public string Text { get
            {
                return Nev + " - tel: " + Tel + ", " + Kerulet + " " + Utca + " " + Hazszam;
            }
        }

        public Partnerek(int id, string nev, string tel, string kerulet, string utca, string hazszam)
        {
            Id = id;
            Nev = nev;
            Tel = tel;
            Kerulet = kerulet;
            Utca = utca;
            Hazszam = hazszam;
        }
    }
}
