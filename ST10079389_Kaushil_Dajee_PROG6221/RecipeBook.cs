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
                    //Input();
                    break;
                case 2:
                    if (opt)
                    {
                        //Output();

                    }
                    else
                    {
                        Selection();
                    }
                    break;
                case 3:
                    if (opt)
                    {
                        //QuantitySelecttion();
                    }
                    else
                    {
                        Selection();
                    }
                    break;
                case 4:
                    if (opt)
                    {
                        //ResetQuantity();
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

    }
}
