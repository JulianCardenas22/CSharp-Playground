using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.Prototype
{
    [Serializable]
    class Address :IPrototype<Address>
    {
        public int Number { get; set; }
        public String StreetName { get; set; }

        public Address(int number,string streetName)
        {
            Number = number;
            StreetName = streetName;
                
        }

        public Address(Address other)
        {
            this.Number = other.Number;
            this.StreetName = other.StreetName;
        }

        public override string ToString()
        {
            return $"{Number} {StreetName}";
        }

        public Address DeepCopy()        {
            return new Address(Number, StreetName);
        }
    }
}
