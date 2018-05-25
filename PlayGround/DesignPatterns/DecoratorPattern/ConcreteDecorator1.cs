using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.DecoratorPattern
{
    class ConcreteDecorator1 : Decorator
    {
        public ConcreteDecorator1(Component component)
        {
            this.component = component;
        }
        public override int MethodA()
        {
            return this.component.MethodA() + 2;
        }

        public override void MethodB()
        {
            throw new NotImplementedException();
        }
    }
}
