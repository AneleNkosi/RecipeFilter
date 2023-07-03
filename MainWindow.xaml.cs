using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace RecipeFilter
{

    public partial class MainWindow : Window
    {
        private List<Recipe> recipes = new List<Recipe>
        {
 
           
        };
        
        public List<Recipe> FilterRecipesByIngredient(string ingredient)
        {
            string ingredientName = txtIngredient.Text;
            List<Recipe> filteredRecipes = recipes.Where(r => r.Ingredients.Contains(ingredientName)).ToList();
            return recipes.Where(recipe => recipe.Ingredients.Contains(ingredient)).ToList();
        }

        public List<Recipe>FilterRecipesByCalories(int maxCalories)
        {
            int MaxCalories = (int)sliderMaxCalories.Value;
            List<Recipe> filteredRecipes=recipes.Where(r=> r.Calories <=maxCalories).ToList();
            return recipes.Where(recipe => recipe.Calories <= maxCalories).ToList();
        }
       
        

        public MainWindow()
        {
            InitializeComponent();
            recipes = new List<Recipe>();

            // Populate the food group ComboBox with options
            
        }
        private void FilterRecipes_Click(object sender, RoutedEventArgs e)
        {
            string ingredient = txtIngredient.Text;
            string foodGroup = cmbFoodGroup.SelectedItem as string;
            int maxCalories = (int)sliderMaxCalories.Value;

            // Perform the filtering based on the selected criteria
            List<Recipe> filteredRecipes = new List<Recipe>();

            foreach (Recipe recipe in recipes)
            {
                if ((string.IsNullOrEmpty(ingredient) || recipe.Ingredients.Contains(ingredient)) &&
                    (string.IsNullOrEmpty(foodGroup) || recipe.FoodGroup == foodGroup) &&
                    recipe.Calories <= maxCalories)
                {
                    filteredRecipes.Add(recipe);
                }
            }

            // Display the filtered recipes in the ListView
            lvRecipes.ItemsSource = filteredRecipes;
        }

        // Sample method to get the list of food groups (you can replace this with your actual data retrieval logic)
        private void cmbFoodGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedFoodGroup = cmbFoodGroup.SelectedItem.ToString();
            List<Recipe> filterRecipes = recipes.Where(r => r.FoodGroup == selectedFoodGroup).ToList();
            
        }
        
            
        }
    }






