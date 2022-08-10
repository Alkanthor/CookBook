using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook
{
    public interface ICookBookManager
    {
        Cookbook Cookbook { get; set; }
        List<string> IngredientsAvailable { get; set; }
        void AddRecipe(RecipeItem recipe);
        void DeleteRecipe(RecipeItem recipe);
        void ExportJsonFile(string path);
        void ImportFromFile(string path);
        List<RecipeItem> CalculateRecommendations();
    }
}
