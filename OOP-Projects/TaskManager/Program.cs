//Description: Simple Task Manager app that implements OOP principles
// and is able to create, update, delete tasks.

using System;
using Task_Manager.Models;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();
        string command;

        do
        {
            Console.WriteLine("Enter a command (add, remove, list, complete, exit):");
            command = Console.ReadLine();

            switch (command)
            {
                case "add":
                    Console.Write("Enter task title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter task description: ");
                    string description = Console.ReadLine();
                    taskManager.AddTask(title, description);
                    break;

                case "remove":
                    Console.Write("Enter task ID to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int removeId))
                    {
                        taskManager.RemoveTask(removeId);
                    }
                    break;

                case "list":
                    taskManager.ListTasks();
                    break;

                case "complete":
                    Console.Write("Enter task ID to complete: ");
                    if (int.TryParse(Console.ReadLine(), out int completeId))
                    {
                        taskManager.CompleteTask(completeId);
                    }
                    break;

                case "exit":
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }

        } while (command != "exhit");
    }
}
