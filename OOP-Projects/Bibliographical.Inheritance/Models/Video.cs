﻿using System;

namespace Bibliographical.Inheritance.Models
{
    public class Video: Resource
    {
        public string Director { get; set; }
        public int Runtime { get; set; }
        public string MediaType { get; set; }

        public Video(string title, string category, string director, int runtime, string mediaType)
            : base(title, category)
        { 
            Director = director;
            Runtime = runtime;
            MediaType = mediaType;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"runtime: {Runtime} minutes");
            Console.WriteLine($"Media Type: {MediaType}");
        }
    }
}
