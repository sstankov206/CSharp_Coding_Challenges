using System;
using System.Collections.Generic;
using System.Linq;

namespace Superheroes.Models
{
    public enum CharacterType { Hero, Villain }
    public enum Universe { Marvel, DC }
    public enum RaceType { Human, Alien, Demigod, Spirit, Other }
    public class Superhero
    {
        public string Name { get; set; }
        public Universe Universe { get; set; }
        public string Hometown { get; set; }
        public int? Age { get; set; }  // Nullable if unknown
        public string Superpower { get; set; }
        public CharacterType CharacterType { get; set; }
        public RaceType RaceType { get; set; }
        public List<Movie> Movies { get; set; }
        public List<ComicBook> Comics { get; set; }
        public List<string> CatchPhrases { get; set; }

        // Constructor to initialize the superhero object
        public Superhero(string name, Universe universe, string hometown, int? age, string superpower,
                         CharacterType characterType, RaceType raceType)
        {
            Name = name;
            Universe = universe;
            Hometown = hometown;
            Age = age;
            Superpower = superpower;
            CharacterType = characterType;
            RaceType = raceType;
            Movies = new List<Movie>();
            Comics = new List<ComicBook>();
            CatchPhrases = new List<string>();
        }

        public class Movie
        {
            public string Title { get; set; }
            public int Year { get; set; }

            public Movie(string title, int year)
            {
                Title = title;
                Year = year;
            }
        }

        public class ComicBook
        {
            public string Title { get; set; }
            public int Year { get; set; }

            public ComicBook(string title, int year)
            {
                Title = title;
                Year = year;
            }
        }
    }
}

