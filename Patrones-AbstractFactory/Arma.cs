using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    abstract class Arma
    {

        public string Nombre { get; private set; }
        public string Categoria { get; private set; }

        protected Arma(string nombre, string categoria)
        {
            Nombre = nombre;
            Categoria = categoria;
        }

        public  void Descripcion()
        {
            Console.Write($"nombre: {Nombre}\n Categoria: {Categoria}\n Disparo!: ");
            TipoDisparo();
        }
        public virtual void TipoDisparo()
        {

        }
    }
}
