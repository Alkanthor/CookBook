using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook
{
    public interface ICookBookManager
    {
        List<RecipeItem> Recipes { get; set; }
        List<string> Ingredients { get; set; }
        List<string> IngredientsAvailable { get; set; }
        void AddRecipe(RecipeItem recipe);
        void DeleteRecipe(RecipeItem recipe);
        void ExportJsonFile();
        void ImportFromFile();
        List<RecipeItem> CalculateRecommendations();
    }
}
