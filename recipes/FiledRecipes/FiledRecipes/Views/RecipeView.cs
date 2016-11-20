using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {
            Console.Clear(); 
            Header = recipe.Name; 
            ShowHeaderPanel(); 

            Console.WriteLine("\nIngredienser");
            Console.WriteLine("=============");
            
            foreach(Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            int instructionCount = 1; 

            Console.WriteLine("\nGör så här");
            Console.WriteLine("============");
            foreach (string instructions in recipe.Instructions)
            {
                Console.WriteLine("<{0}>", instructionCount);
                Console.WriteLine(instructions);
                instructionCount++;
                Console.WriteLine(); 
            }
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {

            foreach (Recipe recipe in recipes)
            {
                Show(recipe);
                ContinueOnKeyPressed();
            } 
        }
    }
}
