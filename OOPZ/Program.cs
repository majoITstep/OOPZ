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
            Zviera MojeZviera = new Zviera("Terier", "Zvuk", 50, 4, false);
            MojeZviera.VydajZvuk();

            Pes MojPes = new Pes("Slovensky cuvac", "Hau", 45, 4, false, "pastiersky pes");
            MojPes.VydajZvuk();

            Macka MojaMacka = new Macka("Siamska", "Mnau", 40, 4, true, "dlhosrsta");
            MojaMacka.VydajZvuk();

            Console.ReadLine();
        }
        
    }
}
