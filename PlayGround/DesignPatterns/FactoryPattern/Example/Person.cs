using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.FactoryPattern.Example
{
    class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get ; set; }

        private  Person(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id}  Name: {Name}";
        }

       public class PersonFactory : IPersonFactory
        {
            private static int id = 0;

            public IPerson CreatePersonByName(string name)   {
                return new Person(id++, name);
            }
        }
    }
}
