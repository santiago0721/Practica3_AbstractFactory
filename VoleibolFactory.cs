using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Practica3_AbstractFactory.VoleibolFactory;

namespace Practica3_AbstractFactory       //Concrete Factory
{
    internal class VoleibolFactory: IDeportesFactory
    {
        public IBalon CrearBalon()
        {
            return new BalonVoleibol();
        }

        public IUniforme CrearUniforme()
        {
            return new UniformeVoleibol();
        }
        
    }
}
