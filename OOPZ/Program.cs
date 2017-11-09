using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Zviera MojeZviera = new Zviera("Plemeno", "Zvuk",120, 4, false);
            MojeZviera.VypisInfo();
            MojeZviera.VydajZvuk();

            Pes MojPes = new Pes("Slovensky cuvac", "Hau", 45, 4, false, "pastiersky pes");
            MojPes.VypisInfo();
            MojPes.VydajZvuk();

            Macka MojaMacka = new Macka("Siamska", "Mnau", 40, 4, true, "dlhosrsta");
            MojaMacka.VypisInfo();
            MojaMacka.VydajZvuk();

            Console.ReadLine();
        }
        
    }
}
