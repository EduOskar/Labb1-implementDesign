using Labb1_implementDesign.FactoryMethodDishes;
using Labb1_implementDesign.FactoryMethodDishes.IFactories;
using Labb1_implementDesign.RunInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_implementDesign
{
    class LoginMenu : IRun
    {
        

        private LoginMenu()
        {

        }
        internal static LoginMenu _instance = null;
        private static readonly object _Object = new object();

        public static LoginMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_Object)
                    {
                        if (_instance == null) 
                        {
                            _instance = new LoginMenu();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Run()
        {
            ProductFactory productFactory = new ProductFactory() { };

            //productFactory.CreateProduct("MainCourse");
            //productFactory.CreateProduct("Dessert");
            IDisch mainCourse = productFactory.CreateProduct("MainCourse");
            IDisch dessert = productFactory.CreateProduct("Dessert");

            mainCourse.Operation();
            dessert.Operation();
            
        }
    }
}
