using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.ObserverPattern
{
    class ConcreteObservable : IObservable
    {
        List<IObserver> _observers;
        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IObserver o in _observers)
                o.Update();
        }
        public void GetData()
        {
       ]

        }
        public ConcreteObservable()
        {
            _observers = new List<IObserver>();
        }
    }
}
