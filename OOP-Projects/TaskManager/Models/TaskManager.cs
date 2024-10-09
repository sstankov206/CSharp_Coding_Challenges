using System;
using System.Collections.Generic;
using System.Linq;

public class TaskManager
{
    private List<Task> tasks = new List<Task>();
    private int nextId = 1;

    public void AddTask(string title, string description)
    { 
        var task = new Task(nextId++, title, description);
        tasks.Add(task);
    }

    public void RemoveTask(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.Remove(task);
            Console.WriteLine($"Task {id} removed.");
        }
        else
        {
            Console.WriteLine($"Task {id} not found.");
        }

        public void ListTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        public void CompleteTask(int id)
        { 
            var task = tasks.FirstOrDefault(t=>t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine($"Task {id} marked as completed.");
            }
            else
            {
                Console.WriteLine($"Task {id} not found.");
            }
        }
    }



}