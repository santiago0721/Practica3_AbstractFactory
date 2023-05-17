using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_AbstractFactory        //Concrete Product 
{
    public class BalonFutbol: IBalon
    {
        public string UsefulFunctionBalon()
        {
            return "Balón de fútbol.";
        }
    }

    public class BalonVoleibol : IBalon
    {
        public string UsefulFunctionBalon()
        {
            return "Balón de Voleibol.";
        }
    }
}
