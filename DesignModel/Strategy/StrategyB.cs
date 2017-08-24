using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class StrategyB : SuperStrategy
    {
        public override void GetStrategy()
        {
            Console.WriteLine("StrategyB");
        }
    }
}
