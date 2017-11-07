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
            Zviera MojeZviera = new Zviera("Terier", "Hau", 50, 4, false);
            MojeZviera.VypisInformacie();

            Pes MojPes = new Pes("Slovensky cuvac", "Hau", 45, 4, false, "pastiersky pes");
            MojPes.VypisInformacie();




            Console.ReadLine();
        }
        
    }
}
