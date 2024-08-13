
using System;
using System.Collections.Generic;
using Lab.Inheritance.Ex5;

class Program
{
    static void Main(string[] args)
    {
        StackOfStrings myStack = new StackOfStrings();

        var newStack = new Stack<string>();
        int input = int.Parse(Console.ReadLine());
        for (int i = 0; i < input; i++)
        {
            newStack.Push(Console.ReadLine());
        }

        myStack.AddRange(newStack);

        while (!myStack.IsEmpty())
        {
            Console.WriteLine(myStack.Pop());
        }
    }
}