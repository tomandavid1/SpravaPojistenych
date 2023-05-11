using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaPojistenych
{
    internal class Sprava
    {
        public List<Pojisteny> pojisteny = new List<Pojisteny>();

        public void PridatPojisteneho(string jmeno, string prijmeni, int vek, int telefon)
        {
            pojisteny.Add(new Pojisteny(jmeno, prijmeni, vek, telefon));
        }
        public string VyhledatPojisteneho(string jmeno, string prijmeni)
        {
            foreach(Pojisteny poj in pojisteny)
            {
                if(jmeno == poj.Jmeno && prijmeni == poj.Prijmeni)
                {
                    return $"{poj}";
                }
            }
            return "Hledanému výrazu neodpovídá žádný pojištěný!";
        }
        public void VypisPojistenych()
        {
            foreach(Pojisteny poj in pojisteny)
            {
                Console.WriteLine(poj);
            }
        }

    }
}
