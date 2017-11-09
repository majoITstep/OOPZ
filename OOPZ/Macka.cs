using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZ
{
    class Macka : Zviera
    {
        private string typSrsti;
        public Macka(string plemeno, string charakterZvuk, int maxRychlost, int pocetNoh, bool leziePoStromoch, string typSrsti) : base(plemeno, charakterZvuk, maxRychlost, pocetNoh, leziePoStromoch)
        {
            this.typSrsti = typSrsti;
        }
        public override void VydajZvuk()
        {
            Console.WriteLine("Charakteristicky zvuk macky:{0}", charakterZvuk);
        }
    
    }
}
