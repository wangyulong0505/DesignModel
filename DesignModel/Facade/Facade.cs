using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// 为子系统中的一组接口提供一个一致的界面，此模式定义了一个高层接口，这个接口使得这个子系统更加容易使用
    /// </summary>
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        void MethodA()
        {
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
        }

        void MethodB()
        {
            two.MethodTwo();
            three.MethodThree();
            four.MethodFour();
        }
    }
}
