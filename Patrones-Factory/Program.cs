using Patrones_AbstractFactory;
using System;

namespace Patrones_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaDeArmas fabrica = new FabricaDeArmas();

            IArma n1 = fabrica.GetArma("Cañon Simple");
            IArma n2 = fabrica.GetArma("Cañon Triple");
            IArma n3 = fabrica.GetArma("Cañon Rafaga");

            n1.Descripcion();
            n2.Descripcion();
            n3.Descripcion();

            Console.ReadKey();

        }

    }
}
