using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace CookBook
{
    public class CookBookManager: ICookBookManager
    {
        public Cookbook Cookbook { get; set; }
        public List<string> IngredientsAvailable { get; set; }

        public CookBookManager()
        {
            Cookbook= new Cookbook();
        }
        public void AddRecipe(RecipeItem recipe)
        {
            Cookbook.Recipes.Add(recipe);
        }

        public void DeleteRecipe(RecipeItem recipe)
        {
            throw new NotImplementedException();
        }

        public void ExportJsonFile(string path)
        {
            string jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(Cookbook, Formatting.Indented);
            File.WriteAllText(path, jsonStr);
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
