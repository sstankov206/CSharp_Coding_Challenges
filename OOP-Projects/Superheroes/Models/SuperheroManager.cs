using System;
using System.Collections.Generic;
using System.Linq;
using static Superheroes.Models.Superhero;


namespace Superheroes.Models
{
    public class SuperheroManager
    {
        public List<Superhero> Superheroes { get; set; }

        public SuperheroManager()
        {
            Superheroes = new List<Superhero>();
        }

        // Add a superhero
        public void AddSuperhero(Superhero superhero)
        {
            Superheroes.Add(superhero);
        }

        // Filter superheroes by Universe (Marvel/DC)
        public List<Superhero> FilterByUniverse(Universe universe)
        {
            return Superheroes.Where(s => s.Universe == universe).ToList();
        }

        // Filter superheroes by Character Type (Hero/Villain)
        public List<Superhero> FilterByCharacterType(CharacterType characterType)
        {
            return Superheroes.Where(s => s.CharacterType == characterType).ToList();
        }

        // Filter superheroes by Age
        public List<Superhero> FilterByAge(int age)
        {
            return Superheroes.Where(s => s.Age == age).ToList();
        }

        // Filter superheroes by Hometown
        public List<Superhero> FilterByHometown(string hometown)
        {
            return Superheroes.Where(s => s.Hometown == hometown).ToList();
        }

        // Get movies of a superhero
        public List<Movie> GetMovies(Superhero superhero)
        {
            return superhero.Movies;
        }

        // Get comics of a superhero
        public List<ComicBook> GetComics(Superhero superhero)
        {
            return superhero.Comics;
        }

        // Get superheroes by Catchphrase
        public List<Superhero> GetByCatchPhrase(string catchphrase)
        {
            return Superheroes.Where(s => s.CatchPhrases.Contains(catchphrase)).ToList();
        }
    }
}
