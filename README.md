[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/Oa99dRjC)
Code Attribution:

https://stackoverflow.com/questions/2673512/how-to-clear-an-array from Stack Overflow
Jørn Schou-Rode:
https://stackoverflow.com/users/121364/j%c3%b8rn-schou-rode

https://stackoverflow.com/questions/39777795/c-sharp-new-array-class-with-constructor from Stack Overflow
Brendan L:
https://stackoverflow.com/users/4672638/brendan-l

https://stackoverflow.com/questions/7580277/why-use-the-params-keyword from Stack Overflow
MasterMastic:
https://stackoverflow.com/users/825637/mastermastic

https://stackoverflow.com/questions/14973642/how-using-try-catch-for-exception-handling-is-best-practice from Stack Overflow
TylerH:
https://stackoverflow.com/users/2756409/tylerh

https://stackoverflow.com/questions/4272579/how-to-print-full-stack-trace-in-exception from Stack Overflow
Michael Freidgeim:
https://stackoverflow.com/users/52277/michael-freidgeim

I created my console app under the name ST10079389_Kaushil_Dajee_PROG6221 with 3 classes. A recipe book class, recipe information class and the main class Program. The 
recipe information class has a constructor which has arrays as parameters and i created a recipe information list with a method which saaves all these recipes to a list which will be used in part 2. 

I have a recipe book class which has majority of the work and does almost everything for inputting the recipe, to printing the recipe, to scalling and resetting the quantities and deletig all the data it is done in this class.
Menu_Options(): displays a menu with several options, reads the user's input, and calls the appropriate method based on the selected option and if the user has to incorrectly enter something the system will pick it up and keep prompting the user to select properly from the correct options.
InputFail(): prompts the user to input values.
InputRecipe(): allows the user to input the details of a recipe, including the recipe name, the number of ingredients, the names and quantities of the ingredients, the units of measurement for the ingredients, the number of steps required to make the recipe, and the steps required to make the recipe. It then saves the recipe to a list.
PrintRecipe(): prints out the recipe that the user entered.
QuantitySelection(): allows the user to scale the quantity of the ingredients in the recipe by a factor of 0.5, 2.0, or 3.0.
ResetQuantity(): resets the quantity of the ingredients in the recipe to their original values.
ClearAll(): clears all data from the program and the user will start from the beginning all over again.

The next class called RecipeInformation, which is used to hold information about recipes. The class has several properties, including recipeName, recipeIngridients, measurementIngrident, steps, quantity, and originalquantity. Each of these properties is an array that holds information about a specific aspect of the recipe, such as its name, the ingredients used, the measurements of each ingredient, the steps involved in making the recipe, and the quantity of each ingredient used.

The class also includes a constructor that takes in values for each of the properties and initializes them. Additionally, there is a method called saveRecipes that creates a new RecipeInformation object with the provided values for each property and adds it to a list called recipes. This allows the user to save multiple recipes and access them later.

Overall, this program is useful for anyone who wants to store and organize recipe information in a structured manner.And it is in a neat an ordered manner for anyone who views it to easily understand what is going on.

And finally, my last class the main Program which has the main method which welcomes anyone to enter a recipe and select from the following options and the code is executed to start the system.
