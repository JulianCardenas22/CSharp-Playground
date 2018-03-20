using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel.DesignPatterns.Factory.Abstract
{
    class CoffeeFactory:IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"grind some beans boil water pour {amount} ml add sugar cream , enjoy");
            return new Coffee();
        }
    }
}
