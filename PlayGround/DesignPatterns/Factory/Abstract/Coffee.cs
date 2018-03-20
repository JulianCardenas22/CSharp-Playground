using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel.DesignPatterns.Factory.Abstract
{
    class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Nice Coffe");
        }

        public override string ToString()
        {
            return "Just a Nice Coffee";
        }
    }
}
