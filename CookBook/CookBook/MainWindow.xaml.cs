using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CookBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string defaultRecipePath = $"./defaultRecipe.json";
        public MainWindow()
        {
            InitializeComponent();
            CookBookManager cookBookManager = new CookBookManager();

            //Block of test data
            List<string> testDataIngredients = new List<string>(){ "flour", "eggs", "milk", "jam", "soy sauce", "chicken meat", "whipping cream" };
            RecipeItem pancakes = new RecipeItem()
            {
                Name = "Pancakes",
                MustIngredients = new List<string>() { "flour", "eggs", "milk", "jam"},
                OptIngredients = new List<string>() { "whipping cream"},
                Complexity = Complexity.VeryFast,
            };
            cookBookManager.Cookbook.Ingredients = testDataIngredients;
            cookBookManager.AddRecipe(pancakes);
            cookBookManager.ExportJsonFile(defaultRecipePath);
        }
    }
}
