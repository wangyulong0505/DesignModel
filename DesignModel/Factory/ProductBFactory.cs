using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ProductBFactory:IFactory
    {
        public Product CreateProduct()
        {
            return new ProductB();
        }
    }
}
