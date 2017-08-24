using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ConcreteTemplate:Template
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体方法1实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体方法2实现");
        }
    }
}
