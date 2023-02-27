using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futar
{
    class Futarok
    {
        public int Id { get; set; }

        public string Nev { get; set; }

        public string Tel { get; set; }

        public string Text
        {
            get
            {
                return Nev + " - tel: " + Tel;
            }
        }


        public Futarok(int id, string nev, string tel)
        {
            Id = id;
            Nev = nev;
            Tel = tel;
        }

        public override string ToString()
        {
            return Nev + " - tel: " + Tel;
        }
    }
}
