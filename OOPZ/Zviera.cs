using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZ
{
    abstract class Zviera
    {
        protected string plemeno, charakterZvuk;
        protected int maxRychlost, pocetNoh;
        protected bool leziePoStromoch;
        protected bool nakrmeny;

        public Zviera(string plemeno, string charakterZvuk, int maxRychlost, int pocetNoh, bool leziePoStromoch)
        {
            this.plemeno = plemeno;
            this.charakterZvuk = charakterZvuk;
            this.pocetNoh = pocetNoh;
            this.maxRychlost = maxRychlost;
            this.leziePoStromoch = leziePoStromoch;
        }

        public virtual void VydajZvuk()
        {
            Console.WriteLine("Toto je všeobecný zvuk zvieraťa:{0}\n", charakterZvuk);
        }
        public void VypisInfo()
        {
            Console.WriteLine("Charakteristiky zvierat:\n"+"Nazov plemena:{0}\nMaximalna mozna zadana rychlost v km/h:{1}\nPocet noh:{2}\nDokaze liezt po stromoch:{3}", plemeno, maxRychlost, pocetNoh, leziePoStromoch);
        }

        public abstract void NakrmZviera();
    }
}
