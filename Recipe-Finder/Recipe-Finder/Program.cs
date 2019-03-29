using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            Console.ReadLine();

        }

    }
 

}
