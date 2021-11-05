using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class TorreDeControl
    {
        List<Volador> ListaDeVoladores = new List<Volador>();

        public void vuelenTodos()
        {
           foreach(Volador v in ListaDeVoladores)
            {
                v.volador();
            }
        }

        public void agregarVolador(Volador unVolador)
        {
            ListaDeVoladores.Add(unVolador); 
        }
    }
}
