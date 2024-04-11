using System;

namespace RecipeApp
{
    // Recipe class representing a recipe with ingredients and steps
    class Recipe
    {
        // Properties
        public string Name { get; set; }    // Name of the recipe
        private Ingredient[] ingredients;    // Array to store ingredients
        private string[] steps;    // Array to store steps

        // Constructor
        public Recipe()
        {
            ingredients = new Ingredient[0];
            steps = new string[0];
        }

        // Method to add an ingredient to the recipe
        public void AddIngredient(Ingredient ingredient)
        {
            Array.Resize(ref ingredients, ingredients.Length + 1);
            ingredients[ingredients.Length - 1] = ingredient;
        }

        // Method to add a step to the recipe
        public void AddStep(string step)
        {
            Array.Resize(ref steps, steps.Length + 1);
            steps[steps.Length - 1] = step;
        }

        // Method to override the ToString() method for custom string representation
        public override string ToString()
        {
            string recipeDetails = $"Name: {Name}\n\nIngredients:\n";
            foreach (var ingredient in ingredients)
            {
                recipeDetails += $"{ingredient}\n";
            }

            recipeDetails += "\nSteps:\n";
            for (int i = 0; i < steps.Length; i++)
            {
                recipeDetails += $"{i + 1}. {steps[i]}\n";
            }

            return recipeDetails;
        }
    }
}
