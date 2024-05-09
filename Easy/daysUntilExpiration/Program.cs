/* Challenge: Improve renewal rate of subscriptions
 
You've been asked to add a feature to your company's software. The feature is intended 
to improve the renewal rate of subscriptions to the software. Your task is to display a 
renewal message when a user logs into the software system and is notified their subscription 
will soon end. You'll need to add a couple of decision statements to properly add branching 
logic to the application to satisfy the requirements.

*/

using System;
class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        //condition check for remainder of subscription, printing output message: 
        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            discountPercentage = 10;
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }

        if (discountPercentage > 0)
        {
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
        }
    }
}