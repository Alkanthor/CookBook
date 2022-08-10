using System.Collections.Generic;

namespace CookBook
{
    public class Cookbook
    {
        public List<string> Ingredients { get; set; }
        public List<RecipeItem> Recipes { get; set; }

        public Cookbook()
        {
            Ingredients = new List<string>();
            Recipes = new List<RecipeItem>();
        }
    }
}