using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BuildThinPerson:Builder
    {
        public BuildThinPerson(Pen pen, Graphics g):base(pen,g)
        {
            //
        }

        public override void BuildHead()
        {
            g.DrawEllipse(pen, 50, 20, 30, 30);
        }

        public override void BuildBody()
        {
            g.DrawRectangle(pen, 60, 50, 10, 50);
        }

        public override void BuildLeftArm()
        {
            g.DrawLine(pen, 3, 3, 5, 5);
        }

        public override void BuildRightArm()
        {
            g.DrawLine(pen, 3, 3, 5, 5);
        }

        public override void BuildLeftLeg()
        {
            g.DrawLine(pen, 3, 3, 5, 5);
        }

        public override void BuildRightLeg()
        {
            g.DrawLine(pen, 3, 3, 5, 5);
        }
    }
}
