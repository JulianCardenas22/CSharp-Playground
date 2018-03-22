using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.Prototype
{
    [Serializable]
    class Person : IPrototype<Person>
    {
        public String Name { get; set; }
        public Address Adress { get; set; }

        public Person(Person other)
        {
            this.Name = other.Name;
            this.Adress = other.Adress;
        }
        public Person(string name, Address address)
        {
            this.Name = name;
            this.Adress = address.DeepCopy();
        }


        public override string ToString()
        {
            return $"{Name}  {Adress}";
        }
        public Person DeepCopy()
        {
            return new Person(Name, Adress);
        }
    }
}
