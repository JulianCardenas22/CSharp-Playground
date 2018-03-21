using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.FactoryPattern.Abstract
{
    class HotDrinkMachineOp {

        private List<Tuple<String, IHotDrinkFactory>> drinkFactories = new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachineOp(){
            var factories =  typeof(HotDrinkMachineOp).Assembly.GetTypes();
            foreach (var factory in factories){
                //         factory: IHotDrinkFactory                                
                if( typeof(IHotDrinkFactory).IsAssignableFrom(factory)  && !factory.IsInterface){
                    var factoryName = factory.Name.Replace("Factory", String.Empty);
                    drinkFactories.Add(Tuple.Create(factoryName, (IHotDrinkFactory)Activator.CreateInstance(factory)));
                }
            }
        }

        public IHotDrink MakeDrink(){

            Console.WriteLine("Avialable Drinks");
            for (int i = 0; i < drinkFactories.Count; i++)
            {
                var tuple = drinkFactories[i].Item1;
                Console.WriteLine("{0}: {1}",i,tuple);
            }

            Console.WriteLine("Select One");

            return null;

            while (true)
            {
                String input = Console.ReadLine();
                if (!String.IsNullOrEmpty(input) && int.TryParse(input , out int drink) 
                                         && drink >= 0 && drink< drinkFactories.Count){

                    input = Console.ReadLine();
                    if (!String.IsNullOrEmpty(input) && int.TryParse(input, out int amount) && amount > 0)
                        drinkFactories[drink].Item2.Prepare(amount);

                }
            }
        }
    }
}
