using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook
{
    public class CookBookManager: ICookBookManager
    {
        public List<RecipeItem> Recipes { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> IngredientsAvailable { get; set; }
        public void AddRecipe(RecipeItem recipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipe(RecipeItem recipe)
        {
            throw new NotImplementedException();
        }

        public void ExportJsonFile()
        {
            throw new NotImplementedException();
        }

        public void ImportFromFile()
        {
            throw new NotImplementedException();
        }

        public List<RecipeItem> CalculateRecommendations()
        {
            throw new NotImplementedException();
        }
    }
}
