/* Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased,
 * and vice versa.
 * 
 * Examples:
 * 
 * ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

ReverseCase("MANY THANKS") ➞ "many thanks"

ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS

*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine(); // reading input
		Console.Write(ReverseCase(str)); //invoking the "ReverseCase" method and passing the input through it.



    }

    //creating a method called "" that reverses the case of each letter in the input string
    public static string ReverseCase (string str)
	{
		char[] returnString = str.ToCharArray(); //converts the input to an array of characters
		for (int i = 0; i < str.Length; i++) //traversing the array of characters
		{
			if (Char.IsLower(str[i])) //if the character is lowercase, make it uppercase
			{
				returnString[i] = Char.ToUpper(str[i]);
			}
			else  //else make the character lowercase
			{
				returnString[i] = Char.ToLower(str[i]);
			}
		}
		return new string(returnString); //printing output as a new string
	}

}