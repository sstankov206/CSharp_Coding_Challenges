/* Create a class Smoothie and do the following:

Create a property called Ingredients.
Create a GetCost method which calculates the total cost of the ingredients used to make the smoothie.
Create a GetPrice method which returns the number from GetCost plus the number from GetCost multiplied by 1.5. 
Round to two decimal places.
Create a GetName method which gets the ingredients and puts them in alphabetical order into a nice 
descriptive sentence. If there are multiple ingredients, add the word "Fusion" to the end but otherwise,
add "Smoothie". Remember to change "-berries" to "-berry". See the examples below.

Ingredient	Price:

Strawberries	£1.50
Banana	£0.50
Mango	£2.50
Blueberries	£1.00
Raspberries	£1.00
Apple	£1.75
Pineapple	£3.50

Examples:

s1 = Smoothie(new string[] { "Banana" })

s1.Ingredients ➞ { "Banana" }

s1.GetCost() ➞ "£0.50"

s1.GetPrice() ➞ "£1.25"

s1.GetName() ➞ "Banana Smoothie"

*/

using System;
class Program {

    public static void Main(string[] args) {
    
    var smoothie1 = new FruitSmoothie.FruitSmoothie(new string[] { "Banana" });
        Console.WriteLine(string.Join(", ", smoothie1.Ingredients));
        Console.WriteLine(smoothie1.GetCost());
        Console.WriteLine(smoothie1.GetPrice());
        Console.WriteLine(smoothie1.GetName());
        Console.WriteLine();
    var smoothie2 = new FruitSmoothie.FruitSmoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
        Console.WriteLine(string.Join(", ", smoothie2.Ingredients));
        Console.WriteLine(smoothie2.GetCost());
        Console.WriteLine(smoothie2.GetPrice());
        Console.WriteLine(smoothie2.GetName());
    } 
}
