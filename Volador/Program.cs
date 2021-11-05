using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Boing747 boing747 = new Boing747();
            Superman superman = new Superman();
            TorreDeControl torredecontrol = new TorreDeControl();

            torredecontrol.agregarVolador(pato);
            torredecontrol.agregarVolador(boing747);
            torredecontrol.agregarVolador(superman);
            torredecontrol.vuelenTodos();

        }
    }
}
