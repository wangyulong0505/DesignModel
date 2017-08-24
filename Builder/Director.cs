using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        private void CreatePerson()
        {
            builder.BuildHead();
            builder.BuildBody();
            builder.BuildLeftArm();
            builder.BuildRightArm();
            builder.BuildLeftLeg();
            builder.BuildRightLeg();
        }
    }
}
