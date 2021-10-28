using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class CanonSimple : Arma
    {
        public CanonSimple(string nombre, string categoria) : base(nombre, categoria)
        {
        }

        public void TipoDisparo()
        {
            Console.WriteLine("disparando 1 bala a la vez");
        }


    }
}
