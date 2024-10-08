using System;
using System.ComponentModel.Design.Serialization;

namespace Task_Manager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Task(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Id}: {Title} - {(IsCompleted ? "Completed" : "Pending")}\nDescription: {Description}";
        }
    }
}
