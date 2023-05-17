using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory       //Concrete Product 
{
    public class UniformeFutbol : IUniforme
    {
        public string UsefulFunctionUniforme()
        {
            return "Uniforme de fútbol.";
        }

        public string AnotherUsefulFunctionUniforme(IBalon collaborator)
        {
            var result = collaborator.UsefulFunctionBalon();
            return $"Uniforme de fútbol con ({result})";
        }
    }

    public class UniformeVoleibol : IUniforme
    {
        public string UsefulFunctionUniforme()
        {
            return "Uniforme de Voleibol.";
        }
        public string AnotherUsefulFunctionUniforme(IBalon collaborator)
        {
            var result = collaborator.UsefulFunctionBalon();
            return $"Uniforme de voleibol con ({result})";
        }
    }
}
