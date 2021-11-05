using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimible
{
    class Contrato:Impresora,  Imprimible
    {
        public void imprimir()
        {
            Console.WriteLine("Soy un contrato legal");
        }
    }
}
