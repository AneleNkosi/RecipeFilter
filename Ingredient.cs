using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeFilter
{
   public class Ingredient
    {
     public string Name { get; set; }
        public int Calories { get; set; }
        public string Quantity { get; set; }
        public string UnitOfMeasurment { get; set; }
        public string FoodGroup { get; set; }
         public Ingredient(string name, int calories, string quantity, string unitOfMeasurment, string foodGroup)
        {
            Name = name;
            Calories = calories;
            Quantity = quantity;
            UnitOfMeasurment = unitOfMeasurment;
            FoodGroup = foodGroup;
        }
    }
}
