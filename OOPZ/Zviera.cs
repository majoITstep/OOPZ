using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZ
{
    class Zviera
    {
        protected string plemeno, charakterZvuk;
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

        public virtual void VydajZvuk()
        {
            Console.WriteLine("Toto je všeobecný zvuk zvieraťa:" + charakterZvuk);
        }
    }
}
