using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /// <summary>
    /// 模板方法模式：定义一个操作中的算法骨架，而将一些步骤延迟到子类中。模板方法使子类可以不改变算法的结构即可以重定义某些算法的步骤
    /// </summary>
    public abstract class Template
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}
