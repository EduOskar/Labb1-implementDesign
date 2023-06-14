using Labb1_implementDesign.FactoryMethodDishes.IFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_implementDesign.FactoryMethodDishes
{
    internal class ConcreteDishMainCourse : IDisch
    {

        public void Operation()
        {
            List<string> sideDishes = new List<string>();
            sideDishes.Add("Mashed potatoes");
            sideDishes.Add("Fries");
            sideDishes.Add("Rice");
            List<string> mainDishes = new List<string>();
            mainDishes.Add("meat");
            mainDishes.Add("chicken");
            mainDishes.Add("fish");


            Console.WriteLine("What kind of Sidedish would you like?");
            foreach (var sides in sideDishes)
            {
                Console.WriteLine(sides);

            }
            string userSideDish = Console.ReadLine();
            if (userSideDish.Equals(sideDishes))
            {
                Console.WriteLine("Restarting the program");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                LoginMenu.Instance.Run();
            }
            Console.WriteLine("What kind of maindish would you like´?");
            foreach (var item in mainDishes)
            {
                Console.WriteLine(item);
            }

            var userMainDish = Console.ReadLine();
            if (userMainDish.Equals(sideDishes))
            {
                Console.WriteLine("Restarting the program");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                LoginMenu.Instance.Run();
            }

            Console.WriteLine("Your maindish is created!");
            Console.WriteLine($"{userMainDish} with {userSideDish}");
        }
    }
}
