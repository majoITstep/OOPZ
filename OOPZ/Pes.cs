using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZ
{
    class Pes : Zviera
    {
        private string vyuzitie;
        public Pes(string plemeno, string charakterZvuk, int maxRychlost, int pocetNoh, bool leziePoStromoch, string vyuzitie) : base(plemeno, charakterZvuk, maxRychlost, pocetNoh, leziePoStromoch)
        {
            this.vyuzitie = vyuzitie;
        }
        public override void VydajZvuk()
        {
            Console.WriteLine("Charakteristicky zvuk psa:{0}\n",charakterZvuk);
                          
        }
        public new void VypisInfo()
        {
            Console.WriteLine("Charakteristika psa:\n" + "Nazov plemena:{0}\nMaximalna rychlost:{1}\nPocet noh:{2}\nDokaze liezt po stromoch:{3}\nVyuzitie:{4}", plemeno, maxRychlost, pocetNoh, leziePoStromoch, vyuzitie);
        }
    }
}
