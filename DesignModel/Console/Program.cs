using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod;

namespace Console
{
    class Program
    {
        //客户端调用
        static void Main(string[] args)
        {
            //简单工厂模式

            //代理模式

            //策略模式
            /*
            var strategyInstance = Assembly.Load("Strategy").CreateInstance("Strategy."+)
            */
            //装饰模式

            //工厂模式
            //IFactory factory = new ProductAFactory();
            //Product product = factory.CreateProduct();

            //模板方法模式
            /*
            ConcreteTemplate t = new ConcreteTemplate();
            t.TemplateMethod();
            */
            //
            //
            //
            //
            /*
            Parent p = new Son();
            p.doGet();
            */
            //Console被占用所以需要使用全命名空间+类型
            global::System.Console.WriteLine();
            System.Console.ReadKey();
        }
    }
}
