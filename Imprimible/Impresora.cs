using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimible
{
    class Impresora
    {
        List<Imprimible> ColaDelImpresion = new List<Imprimible>();

        
        public void ImprimirTodo()
        {
            foreach(Imprimible i in ColaDelImpresion)
            {
                i.imprimir();
            }

        }

        public void AgregarImprimible(Imprimible unimprimible)
        {
            ColaDelImpresion.Add(unimprimible);
        }
    }
}
