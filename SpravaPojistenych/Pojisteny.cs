using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaPojistenych
{
    internal class Pojisteny
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public int Telefon { get; private set; }

        public Pojisteny(string jmeno, string prijmeni, int vek, int telefon) {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }
        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni} {Vek} {Telefon}";
        }
    }
}
