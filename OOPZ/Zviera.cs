using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZ
{
    class Zviera
    {
        private string plemeno, charakterZvuk;
        private int maxRychlost, pocetNoh;
        private bool leziePoStromoch;

        public Zviera(string plemeno, string charakterZvuk, int maxRychlost, int pocetNoh, bool leziePoStromoch)
        {
            this.plemeno = plemeno;
            this.charakterZvuk = charakterZvuk;
            this.pocetNoh = pocetNoh;
            this.maxRychlost = maxRychlost;
            this.leziePoStromoch = leziePoStromoch;
        }

        public void VypisInformacie()
        {
            Console.WriteLine("Toto zviera ma tieto charakteristiky:\nPlemeno:{0}\nCharakteristicky zvuk:{1}\nMaximalna rychlost:{2}\nPocet noh:{3}\nLezie po stromoch:{4}", plemeno, charakterZvuk, maxRychlost, pocetNoh, leziePoStromoch);
        }
    }
}
