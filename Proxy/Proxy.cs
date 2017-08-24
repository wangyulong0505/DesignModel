using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// 代理模式就是为其他对象提供一个代理以控制对这个对象的访问
    /// </summary>
    public class Proxy:Subject
    {
        RealSubject real;
        public override void Request()
        {
            if (real == null)
            {
                real = new RealSubject();
            }
            real.Request();
        }
    }
}
