using Labb1_implementDesign.FactoryMethodDishes.IFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_implementDesign.FactoryMethodDishes
{
    internal class ProductFactory
    {
        public IDisch CreateProduct(string type)
        {
            switch (type)
            {
                case "MainCourse":
                    return new ConcreteDishMainCourse();
                case "Dessert":
                    return new ConcreteDishDessert();
                default:
                    throw new ArgumentException("Produkten finns ej");
            }
        }
    }
}
