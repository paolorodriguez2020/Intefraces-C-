using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimible
{
    class Foto : Impresora ,Imprimible
    {
        public void imprimir()
        {
            Console.WriteLine("Soy una selfie pal insta  ");

         }
    }
}
