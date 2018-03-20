using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel.DesignPatterns.Factory.Abstract
{
    class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Nice Tea");
        }
    }
}
