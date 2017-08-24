using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 建造者模式：将一个复杂对象的构建与它的表示相分离，使得同样的构建过程可以创建不同的表示
    /// </summary>
    public abstract class Builder
    {
        protected Pen pen;
        protected Graphics g;

        public Builder(Pen pen, Graphics g)
        {
            this.pen = pen;
            this.g = g;
        }

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildLeftArm();
        public abstract void BuildRightArm();
        public abstract void BuildLeftLeg();
        public abstract void BuildRightLeg();
    }
}
