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
            
            Zviera MojPes = new Pes("Slovensky cuvac", "Hau", 45, 4, false, "pastiersky pes");
            MojPes.VypisInfo();
            MojPes.VydajZvuk();
            MojPes.NakrmZviera();

            Zviera MojaMacka = new Macka("Siamska", "Mnau", 40, 4, true, "dlhosrsta");
            MojaMacka.VypisInfo();
            MojaMacka.VydajZvuk();
            MojaMacka.NakrmZviera();

                     

            Console.ReadLine();
        }
        
    }
}
