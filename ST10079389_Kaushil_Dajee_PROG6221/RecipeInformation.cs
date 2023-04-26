using System.Collections.Generic;
namespace ST10079389_Kaushil_Dajee_PROG6221
{
    internal class RecipeInformation
    {
        // Class for holding recipe information in a constructor for specific recipes
        public RecipeInformation(string[] recipeName, string[] recipeIngridients, string[] measurementIngrident, string[] steps, double[] quantity, double[] originalquantity)
        {
            this.recipeName = recipeName;
            this.recipeIngridients = recipeIngridients;
            this.measurementIngrident = measurementIngrident;
            this.steps = steps;
            this.quantity = quantity;
            this.originalquantity = originalquantity;
        }
        // List to hold saved recipes and method to add a new recipe to the list
        List<RecipeInformation> recipes = new List<RecipeInformation>();
        public string[] recipeName { get; set; }
        public string[] recipeIngridients { get; set; }
        public string[] measurementIngrident { get; set; }
        public string[] steps { get; set; }
        public double[] quantity { get; set; }
        public double[] originalquantity { get; set; }
        public void saveRecipes(string[] recipeName, string[] recipeIngridients, string[] measurementIngrident, string[] steps, double[] quantity, double[] originalquantity)
        {
            RecipeInformation myRecipe = new RecipeInformation(recipeName, recipeIngridients, measurementIngrident, steps, quantity, originalquantity);
            recipes.Add(myRecipe);
        }
    }
}
