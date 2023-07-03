using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeFilter
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public string FoodGroup { get; set; }
        public int Calories { get; set; }

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<string>();
        }
       
        }
    }

