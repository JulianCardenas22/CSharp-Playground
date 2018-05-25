using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.DecoratorPattern
{
    // Best Case
    class ConcreteComponent : Component
    {

        

        public override int MethodA()
        {
            return 1;
        }

        public override void MethodB()
        {
            throw new NotImplementedException();
        }
    }
}
