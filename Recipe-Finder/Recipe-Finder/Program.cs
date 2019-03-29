using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RecipeFinder;
using RecipeResult;

namespace RecipeFinder
{
    class Program
    {   //-----Main Method
        static void Main(string[] args)
        {
            //-----Locates CSV file
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Recipes.csv");
            var fileContents = ReadRecipeResults(fileName);

            SelectRecipe();

            var recipe = new RecipeResult();
            return;

      
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<string[]> ReadRecipeResults(string fileName)
        {
            var recipeResults = new List<string[]>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values  = line.Split(',');
                    recipeResults.Add(values);
                    Console.WriteLine(values[0].ToString());
                    Console.WriteLine("");
                }
            }
            return recipeResults; 
        }

        public static void SelectRecipe()
        {
            Console.WriteLine("Select a recipe from this list & I will tell the ingredients you'll need & how long it will take to prepare & cook.");
            
            var userResponse = Console.ReadLine();

            //Print Blank Line
            Console.WriteLine();

            //Show the recipe user entered

            Console.WriteLine("Your recipe is {0}.",userResponse);
            Console.ReadLine();

        }

        public static void WriteData(string fileName, List<string[]>recipeResults)
        {
            string RecipeResult = string.Empty;

                foreach (RecipeResults recipe in RecipeResult)
                {
                    RecipeResult +=
                    recipe.Recipes + "," +
                    recipe.Ingredients + "," +
                    recipe.PreparationTime + "," +
                    recipe.CookTime + "," +
                    Environment.NewLine;
                }
            File.WriteAllText(fileName, RecipeResult);
        }



    }
 

}
