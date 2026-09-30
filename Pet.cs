using System;
using System.Collections.Generic;
using System.Text;

namespace Onsdag_CleanCodeIntroduktion
{
    public class Pet
    {
        //Skapa en klass Pet med Name, AnimalType (t.ex.hund / katt / kanin), och FavoriteFood.
        public string Name;
        public string AnimalType;
        public string FavoritFood;
        //Metod ReadInfo() frågar användaren om dessa värden.
        public void ReadInfo()
        {
            Console.WriteLine($"Vad heter Djuret?");
            Name = Console.ReadLine()!;

            Console.WriteLine($"Vad är {Name} för typ av djur?");
            AnimalType = Console.ReadLine()!;

            Console.WriteLine($"Vad är är {Name}s favorit mat?");
            FavoritFood = Console.ReadLine()!;
        }
        //Metod Introduce() skriver ut:
        //“Jag heter Fido, jag är en hund och jag älskar köttbullar!”
        public void Introduce()
        {
            Console.WriteLine($"Hej jag heter {Name}, jag är en {AnimalType} och jag älskar {FavoritFood}");
        }

    }
}
