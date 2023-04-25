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
        public void Menu_Options()
        {
            Console.WriteLine("Please select from the following options:" +
                "\n1. Entering the Recipe" +
                "\n2. Viewing the Recipe" +
                "\n3. Scaling the quantity of the ingridents" +
                "\n4. Resetting the quantity" +
                "\n5. Clear all data" +
                "\n6. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Input();
                    break;
                case 2:
                    if (opt)
                    {
                        Output();

                    }
                    else
                    {
                        Selection();
                    }
                    break;
                case 3:
                    if (opt)
                    {
                        QuantitySelecttion();
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
                        //ClearAll();
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
                    break;
            }
        }
        public void Selection()
        {
            Console.WriteLine("You need to input values");
            Menu_Options();
        }
        public void Input()
        {
            try
            {
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
                Console.WriteLine("Recipe has been saved successfully");
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
                Menu_Options();
            }
        }
        public void Output()
        {
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
                Menu_Options();
            }
        }
        public void QuantitySelecttion()
        {
            Console.WriteLine("Select from the following options:" +
                "\n1. Scaling the quantity of your ingridients by 0.5" +
                "\n2. Scaling the quantity of your ingridients by 2" +
                "\n3. Scaling the quantity of the ingridents by 3");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    for (int i = 0; i < quantity.Length; i++)
                    {
                        quantity[i] = quantity[i] * 0.5;
                    }
                    Menu_Options();
                    // code block
                    break;
                case 2:
                    for (int i = 0; i < quantity.Length; i++)
                    {
                        quantity[i] = quantity[i] * 2;
                    }
                    Menu_Options();
                    // code block
                    break;
                case 3:
                    for (int i = 0; i < quantity.Length; i++)
                    {
                        quantity[i] = quantity[i] * 3;
                    }
                    Menu_Options();
                    // code block
                    break;
                default:
                    Console.WriteLine("Sorry, Invalid Option");
                    //Console.Beep();
                    break;
            }
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
                Menu_Options();
            }
        }
    }
}
