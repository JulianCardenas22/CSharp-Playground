using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.ObserverPattern
{
    class ConcreteObserver : IObserver , IDisplayData
    {
        ConcreteObservable _observable;

        public void Update()
        {
            _observable.GetData();
        }

        public void Display()
        {
            Console.WriteLine("Data:");
        }

        public ConcreteObserver(ConcreteObservable observable)
        {
            _observable = observable;
        }
    }
}
