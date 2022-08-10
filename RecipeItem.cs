using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook
{
    public class RecipeItem
    {
        public string Name { get; set; }
        public string RecipeUrl { get; set; }
        public List<string> MustIngredients { get; set; }
        public List<string> OptIngredients { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsSpicy { get; set; }
        public Complexity Complexity { get; set; }
        public string Instructions { get; set; }
        public int MyRating { get; set; }
    }
}
