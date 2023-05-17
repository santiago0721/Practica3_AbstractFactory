using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory       //Interface Abstract Factory
{
    public interface IDeportesFactory
    {
        IBalon CrearBalon();
        IUniforme CrearUniforme();

    }
}
