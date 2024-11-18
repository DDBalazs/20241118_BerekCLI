using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241118_BerekCLI
{
    internal class Berek
    {
        private string nev;
        private string neme;
        private string reszleg;
        private int belepes;
        private int ber;

        public string Nev { get => nev; set => nev = value; }
        public string Neme { get => neme; set => neme = value; }
        public string Reszleg { get => reszleg; set => reszleg = value; }
        public int Belepes { get => belepes; set => belepes = value; }
        public int Ber { get => ber; set => ber = value; }

        public Berek(string sor)
        {
            string[] b = sor.Split(";");

            Nev = b[0];
            Neme = b[1];
            Reszleg = b[2];
            Belepes = int.Parse(b[3]);
            Ber = int.Parse(b[4]);
        }

    }
}
