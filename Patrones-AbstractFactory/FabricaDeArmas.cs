using Patrones_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class FabricaDeArmas
    {
        public IArma GetArma(string tipoDisparo)
        {
            return tipoDisparo switch
            {
                "Cañon Simple" => new CanonSimple(),
                "Cañon Triple" => new CanonTriple(),
                "Cañon Rafaga" => new CanonRafaga(),
                _ => null,
            };
        }
    }
}
