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
        public void PopisPsa()
        {
            Console.WriteLine("Charakteristika psa");
        }

    }
}
