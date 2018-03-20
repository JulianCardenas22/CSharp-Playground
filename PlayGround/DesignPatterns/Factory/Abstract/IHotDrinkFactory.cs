using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel.DesignPatterns.Factory.Abstract
{
    interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
