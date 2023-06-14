using Labb1_implementDesign.FactoryMethodDishes.IFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_implementDesign.FactoryMethodDishes
{
    internal class ConcreteDishDessert : IDisch
    {
        public void Operation()
        {
            List<string> Dessert = new List<string>();
            Dessert.Add("IceCream");
            Dessert.Add("Choclate fountain");
            Dessert.Add("Dry Cracker");


            Console.WriteLine("What kind of Dessert would you like?");
            foreach (var items in Dessert)
            {
                Console.WriteLine(items);

            }
            string userDessert = Console.ReadLine();
            if (userDessert.Equals(Dessert))
            {
                Console.WriteLine("Restarting the program");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                LoginMenu.Instance.Run();
            }
            Console.WriteLine("Your dessert is here!");
            Console.WriteLine($"{userDessert}");
            Console.ReadLine();
        }
    }
}
