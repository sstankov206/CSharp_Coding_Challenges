/* Suppose you work for a manufacturing company. 
 * The company needs you to complete an inventory of your warehouse to determine the number
 * of products that are ready to ship. In addition to the total number of finished products, 
 * you need to report the number of finished products stored in each individual bin in
 * your warehouse, along with a running total. This running total will be used to create 
 * an audit trail so you can double-check your work and identify "shrinkage".
 */

using System;

class Program { 
public static void Main(string[] args)
    {
        int[] inventory = { 200, 450, 700, 175, 250 };
        int sum = 0;

        //variable to the current bin number and display the running total:
        int bin = 0;

        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        //printing output:
        Console.WriteLine($"We have {sum} items in inventory.");




    }

}

