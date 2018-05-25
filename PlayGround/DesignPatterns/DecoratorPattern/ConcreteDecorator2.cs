using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.DecoratorPattern
{
    class ConcreteDecorator2 : Decorator
    {
        public ConcreteDecorator2(Component component)
        {
            this.component = component;
        }
        public override int MethodA()
        {
            return 1 + component.MethodA();
        }

        public override void MethodB()
        {
            throw new NotImplementedException();
        }
    }
}
