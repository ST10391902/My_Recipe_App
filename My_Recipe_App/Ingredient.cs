using System;

namespace RecipeApp
{
    // Ingredient class representing an ingredient in a recipe
    class Ingredient
    {
        // Properties
        public string Name { get; }    // Name of the ingredient
        public double Quantity { get; }    // Quantity of the ingredient
        public string Unit { get; }    // Unit of measurement for the ingredient

        // Constructor 
        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        // Method to override the ToString() method for custom string representation
        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name}";
        }
    }
}
