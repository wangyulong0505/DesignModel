using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class StrategyA : SuperStrategy
    {
        public override void GetStrategy()
        {
            Console.WriteLine("StrategyA");
        }
    }
}
