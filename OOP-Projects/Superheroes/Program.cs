/* Console app with OOP in C#, designed to display
 * info about Superheroes (Marvel vs DC.).
 * The user should be able to query and filter the app,
 * based on the following characteristics:
 * - Name
 * - Age
 * - Universe
 * - Hometown
 * - Character Type
 * - Race Type
 * - List of movies released about hero
 * - List of comic books released about hero
 * - List of catch phrases of hero
 */

using System;
using Superheroes.Models;
using static Superheroes.Models.Superhero;
class Program
{
    static void Main(string[] args)
    { // Create the manager
        SuperheroManager manager = new SuperheroManager();

        // Example: Add superheroes
        Superhero batman = new Superhero("Batman", Universe.DC, "Gotham", 35, "Detective Skills, Martial Arts", CharacterType.Hero, RaceType.Human);
        batman.CatchPhrases.Add("I am vengeance, I am the night!");
        batman.Movies.Add(new Movie("The Dark Knight", 2008));
        batman.Comics.Add(new ComicBook("Batman: Year One", 1987));

        Superhero superman = new Superhero("Superman", Universe.DC, "Smallville", 30, "Super Strength, Flight, Heat Vision", CharacterType.Hero, RaceType.Alien);
        superman.CatchPhrases.Add("Up, up, and away!");
        superman.Movies.Add(new Movie("Man of Steel", 2013));
        superman.Comics.Add(new ComicBook("Action Comics #1", 1938));

        manager.AddSuperhero(batman);
        manager.AddSuperhero(superman);

    }
}
