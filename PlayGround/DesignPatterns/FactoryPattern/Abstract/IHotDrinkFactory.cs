using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.FactoryPattern.Abstract
{
    interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
