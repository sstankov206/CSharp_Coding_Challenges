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
    }
}
