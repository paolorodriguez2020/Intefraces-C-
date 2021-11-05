using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimible
{
    class Documento :Impresora ,  Imprimible
    {
        public void imprimir()
        {
            Console.WriteLine("Soy un documento de Word"); 
        }
    }
}
