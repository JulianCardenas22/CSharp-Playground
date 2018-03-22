using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PlayGround.DesignPatterns.FactoryPattern.Abstract
{
    class HotDrinkMachine
    {
        public enum AvaibleDrink
        {
            Coffee, Tea
        }

        private Dictionary<AvaibleDrink, IHotDrinkFactory> factories = new Dictionary<AvaibleDrink, IHotDrinkFactory>();

        public HotDrinkMachine()     {
            var drinks = typeof(AvaibleDrink);
        
            foreach (AvaibleDrink drink in Enum.GetValues(drinks)) {
                var drinkName = Enum.GetName(drinks, drink);
                var factory = (IHotDrinkFactory)Activator.CreateInstance(Type.GetType(drinks.Namespace+"."+ drinkName+ "Factory"));
                factories.Add(drink,factory);
            }
        }
        
        public IHotDrink  MakeDrink(AvaibleDrink drink , int amount){
            return factories[drink].Prepare(amount);
        }

     
    }
}   
