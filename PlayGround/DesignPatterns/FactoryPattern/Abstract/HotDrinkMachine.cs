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

        public IHotDrink MakeDrinkOp(){

            Console.WriteLine("Available Drinks");
            for (int i = 0; i < factoriesList.Count; i++){
              var tuple = factoriesList[i];
              WriteLine("{0}: {1} ",i, tuple.Item1);
            }

            Console.WriteLine("Select One");


            while (true)
            {
                string s = "";
                if ((s = ReadLine()) != null && int.TryParse(s, out int i)
                                   && i >= 0 && i < factoriesList.Count){

                    WriteLine("Amount :");
                    s = ReadLine();
                    if (s != null && int.TryParse(s, out int amount) && amount > 0){
                        return factoriesList[i].Item2.Prepare(amount);
                    }
                }
                else { 
                    WriteLine("Invalid Drink");
                }
            }
        }
    }
}   
