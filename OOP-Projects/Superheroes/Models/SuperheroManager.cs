using System;
using System.Collections.Generic;
using System.Linq;


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
    }
}
