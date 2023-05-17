using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory
{
    internal class Cliente
    {
        public void Main() 
        {
            Console.WriteLine("---");
            ClientMethod(new FutbolFactory());
            Console.WriteLine();

            Console.WriteLine("---");
            ClientMethod(new VoleibolFactory());
        }

        public void ClientMethod(IDeportesFactory factory)
        {
            var balon = factory.CrearBalon();
            var uniforme = factory.CrearUniforme();

            Console.WriteLine(uniforme.UsefulFunctionUniforme());
            Console.WriteLine(uniforme.AnotherUsefulFunctionUniforme(balon));

        }
    }
}
