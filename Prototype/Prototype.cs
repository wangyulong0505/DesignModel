using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// 原型模式：用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象
    /// </summary>
    public abstract class Prototype
    {
        private String id;

        public String Id
        {
            get { return id; }
        }

        public Prototype(String id)
        {
            this.id = id;
        }

        public abstract Prototype Clone();
    }
}
