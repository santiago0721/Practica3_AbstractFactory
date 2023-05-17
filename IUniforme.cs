using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory
{
    public interface IUniforme      //Interface Abstract Product
    {
        string UsefulFunctionUniforme();
        string AnotherUsefulFunctionUniforme(IBalon collabolator);  
    }
}
