using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            IAcelerador acelerador = new Acelerador();
            IEmbrague embrague = new Embrague();
            IPalancaCambios palancaCambios = new PalancaCambios();

            Centralita centralita = new Centralita(embrague, acelerador, palancaCambios);
            centralita.AumentarMarcha();
        }
    }
}
