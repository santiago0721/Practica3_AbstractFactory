using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory            //Concrete Factory
{
    internal class FutbolFactory: IDeportesFactory
    {
        public IBalon CrearBalon()
        {
            return new BalonFutbol();  //Retorna el producto concreto
        }

        public IUniforme CrearUniforme()
        {
            return new UniformeFutbol();
        }
    }
}
