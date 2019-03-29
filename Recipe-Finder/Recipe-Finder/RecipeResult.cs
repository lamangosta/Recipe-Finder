using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeFinder
{
    class RecipeResult
    {
        public string Recipes { get; set; }
        public string Ingredients { get; set; }
        public int PreparationTime { get; set; }
        public int CookTime { get; set; }


        public RecipeResult(string recipes, string ingredients, int preparationtime, int cooktime)
        {
            Recipes = recipes;
            Ingredients = ingredients;
            PreparationTime = preparationtime;
            CookTime = cooktime;
        }

        public RecipeResult()
        {
            return;
        }
    }
}
