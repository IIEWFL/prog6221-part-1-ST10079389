using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10079389_Kaushil_Dajee_PROG6221
{
    internal class RecipeBook
    {
        public bool opt;
        private string[] recipeName = new string[1];
        private string[] recipeIngridients, measurementIngrident, steps;
        private double[] quantity, originalQuantity;
        private const double ScalingFactorHalf = 0.5;
        private const double ScalingFactorDouble = 2.0;
        private const double ScalingFactorTriple = 3.0;
        public void Menu_Options()
        {
            Console.WriteLine("Please select from the following options:" +
                "\n1. Entering the Recipe" +
                "\n2. Viewing the Recipe" +
                "\n3. Scaling the quantity of the ingridents" +
                "\n4. Resetting the quantity" +
                "\n5. Clear all data" +
                "\n6. Exit");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            switch (option)
            {
                case 1:
                        InputRecipe();
                    break;
                case 2:
                    if (opt)
                    {
                        PrintRecipe();
                    }
                    else
                    {
                        Selection();
                    }
                    break;
                case 3:
                    if (opt)
                    {
                        QuantitySelection();
                    }
                    else
                    {
                        Selection();
                    }
                    break;
                case 4:
                    if (opt)
                    {
                        ResetQuantity();
                    }
                    else
                    {
                        Selection();
                    }
                    break;
                case 5:
                    if (opt)
                    {
                        ClearAll();
                    }
                    else
                    {
                        Selection();
                    }
                    break;
                case 6:
                    Environment.Exit(6);
                    break;
                default:
                    Console.WriteLine("Sorry, invalid option!");
                    Menu_Options();
                    break;
            }
        }
        public void Selection()
        {
            Console.WriteLine("You need to input values");
            Menu_Options();
        }
        public void InputRecipe()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Enter the Recipes Name");
                recipeName[0] = Console.ReadLine();
                Console.WriteLine("Enter the number of ingridients for " + recipeName[0]);
                int numberOfIngridients = Convert.ToInt32(Console.ReadLine());
                recipeIngridients = new string[numberOfIngridients];
                quantity = new double[numberOfIngridients];
                originalQuantity = new double[numberOfIngridients];
                measurementIngrident = new string[numberOfIngridients];
                Console.WriteLine("Enter the names of the ingridients");
                for (int i = 0; i < numberOfIngridients; i++)
                {
                    recipeIngridients[i] = Console.ReadLine();
                }
                for (int i = 0; i < numberOfIngridients; i++)
                {
                    Console.WriteLine("Enter the quantity of the " + recipeIngridients[i] + " and the unit of measurement (e.g. 2 table spoons)");
                    string input = Console.ReadLine();

                    string[] inputArray = input.Split(' ');
                    if (double.TryParse(inputArray[0], out double quantityValue))
                    {
                        quantity[i] = quantityValue;
                        originalQuantity[i] = quantity[i];
                    }
                    measurementIngrident[i] = inputArray[1];
                }
                Console.WriteLine("Enter the number of steps required to make " + recipeName[0]);
                int numberOfSteps = Convert.ToInt32(Console.ReadLine());
                steps = new string[numberOfSteps];
                Console.WriteLine("Enter the steps reuired to make " + recipeName[0]);
                for (int i = 0; i < numberOfSteps; i++)
                {
                    steps[i] = Console.ReadLine();
                }
                opt = true;
                RecipeInformation blonde = new RecipeInformation(recipeName, recipeIngridients, measurementIngrident, steps, quantity, originalQuantity);
                blonde.saveRecipes(recipeName, recipeIngridients, measurementIngrident, steps, quantity, originalQuantity);
                Console.WriteLine("Your recipe has been saved successfully!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The input value is too large. Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred");
            }
            finally
            {
                Console.WriteLine();
                Menu_Options();
            }
        }
        public void PrintRecipe()
        {
            Console.WriteLine();
            try
            {
                Console.WriteLine("Recipe Name: " + recipeName[0]);
                Console.WriteLine("Recipe Ingridients: ");
                for (int i = 0; i < recipeIngridients.Length; i++)
                {
                    Console.WriteLine("-" + recipeIngridients[i]);
                }
                for (int i = 0; i < recipeIngridients.Length; i++)
                {
                    Console.WriteLine($"The quantity of {recipeIngridients[i]} is {quantity[i]} {measurementIngrident[i]}");
                }
                Console.WriteLine($"The steps for making {recipeName[0]}");
                for (int i = 0; i < steps.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{steps[i]}");
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Sorry, you did not input any values");
            }
            finally
            {
                Console.WriteLine();
                Menu_Options();
            }
        }
        public void QuantitySelection()
        {
            Console.WriteLine();
            Console.WriteLine("Select from the following options:" +
                "\n1. Scaling the quantity of your ingredients by 0.5" +
                "\n2. Scaling the quantity of your ingredients by 2" +
                "\n3. Scaling the quantity of the ingredients by 3" +
                "\n4. Cancel");
            int option;
            if (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 4)
            {
                Console.WriteLine("Sorry, invalid option");
                Menu_Options();
                return;
            }

            switch (option)
            {
                case 1:
                    ScaleQuantities(ScalingFactorHalf);
                    break;
                case 2:
                    ScaleQuantities(ScalingFactorDouble);
                    break;
                case 3:
                    ScaleQuantities(ScalingFactorTriple);
                    break;
                case 4:
                    Console.WriteLine();
                    Menu_Options();
                    return;
            }

            QuantityCorrect();
            Menu_Options();
        }

        private void ScaleQuantities(double scalingFactor)
        {
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] *= scalingFactor;
            }
        }

        private void QuantityCorrect()
        {
            Console.WriteLine("The quantity of your ingredients has been scaled successfully");
            Console.WriteLine();
        }

        public void ResetQuantity()
        {
            try
            {
                for (int i = 0; i < originalQuantity.Length; i++)
                {
                    quantity[i] = originalQuantity[i];
                }
                Console.WriteLine("Success, the quantity of your indgridients has been reset to the original quantity");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorrry, could not rest the quantity");
            }
            finally
            {
                Console.WriteLine();
                Menu_Options();
            }
        }
        public void ClearAll()
        {
            Console.WriteLine("Are you sure you want to clear all data? This action cannot be undone. To confirm, please enter 'DELETE'.");
            string confirmation = Console.ReadLine();
            if (confirmation == "DELETE")
            {
                try
                {
                    Array.Clear(recipeName, 0, recipeName.Length);
                    Array.Clear(recipeIngridients, 0, recipeIngridients.Length);
                    Array.Clear(measurementIngrident, 0, measurementIngrident.Length);
                    Array.Clear(steps, 0, steps.Length);
                    Array.Clear(quantity, 0, quantity.Length);
                    Array.Clear(originalQuantity, 0, originalQuantity.Length);
                    opt = false;
                    Console.WriteLine("All data has been deleted.");
                    Console.WriteLine();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Sorry, data could not be deleted due to an index out of range error.");
                }
            }
            else
            {
                Console.WriteLine("Data deletion cancelled.");
            }
            Menu_Options();
        }

    }
}
