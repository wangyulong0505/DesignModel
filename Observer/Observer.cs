using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 观察者模式：观察者模式定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象
    /// 这个主题对象在状态发生变化时，会通知所有观察者对象，使他们能够自动更新自己
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update();
    }
}
