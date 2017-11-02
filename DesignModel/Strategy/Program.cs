using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //构造函数初始化时传入对应的策略名字初始化不同的策略
            StrategyContext context = new StrategyContext("StrategyA");
            context.DoSomeThing();
            Console.ReadLine();
        }
    }
}
