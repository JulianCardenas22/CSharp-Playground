using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.Prototype
{
   public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
