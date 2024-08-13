using System.Collections.Generic;
namespace Lab.Inheritance.Ex5
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void AddRange(Stack<string> newStack)
        {
            while (newStack.Any())
            {
                var value = newStack.Pop();
                this.Push(value);
            }
        }
    }
}
