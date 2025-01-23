using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyCwiczenia
{
    public class Uczen
    {
        public string Imie { get; set; }
        public int Wiek { get; set; }
        public bool Czy_powtarza { get; set; }
        public string Zawod { get; set; }

        public Uczen(string imie, int wiek, bool czy_powtarza, string zawod)
        {
            Imie = imie;
            Wiek = wiek;
            Czy_powtarza = czy_powtarza;
            Zawod = zawod;
        }
    }
}
