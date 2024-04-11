using System;

namespace RecipeApp
{
    // Main class containing the entry point of the program
    class Program
    {
        // Main method
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to the Recipe App!");

            // Create a new recipe instance
            Recipe recipe = new Recipe();

            // Get recipe details from the user
            Console.Write("Enter recipe name: ");
            recipe.Name = Console.ReadLine();

            Console.Write("Enter number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            // Prompt for ingredient details and add them to the recipe
            for (int i = 0; i < ingredientCount; i++)
            {
                Console.Write($"Enter name of ingredient {i + 1}: ");
                string ingredientName = Console.ReadLine();

                Console.Write($"Enter quantity of {ingredientName}: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write($"Enter unit of measurement for {ingredientName}: ");
                string unit = Console.ReadLine();

                recipe.AddIngredient(new Ingredient(ingredientName, quantity, unit));
            }

            Console.Write("Enter number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            // Prompt for recipe steps and add them to the recipe
            for (int i = 0; i < stepCount; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                string stepDescription = Console.ReadLine();
                recipe.AddStep(stepDescription);
            }

            // Display the recipe details
            Console.WriteLine("\nRecipe Details:");
            Console.WriteLine(recipe);

            // Farewell message
            Console.WriteLine("\nThank you for using the Recipe App!");
        }
    }
}
