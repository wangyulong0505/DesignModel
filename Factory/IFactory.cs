using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// 工厂模式：定义一个用于创建对象的接口，让子类决定实例化那一个类。工厂模式使一个类的实例化延迟到了他的子类
    /// </summary>
    public interface IFactory
    {
        Product CreateProduct();
    }
}
