using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Product
    {
        private void Use() 
        {
            Console.WriteLine("Use");
        }

        private void Discard() 
        {
            Console.WriteLine("Discard");
        }
    }
}
