using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futar
{
    public class Felhasznalo
    {
        public int Id { get; private set; }

        public string Teljesnev { get; private set; }

        public string Nev { get; private set; }

        public string Jelszo { get; private set; }

        public bool Admin { get; private set; }

        public Felhasznalo(int id, string teljesnev, string nev, string jelszo, bool admin)
        {
            Id = id;
            Teljesnev = teljesnev;
            Nev = nev;
            Jelszo = jelszo;
            Admin = admin;
        }
    }
}
