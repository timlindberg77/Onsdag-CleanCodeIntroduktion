using System;
using System.Collections.Generic;
using System.Text;

namespace Onsdag_CleanCodeIntroduktion
{
     public class Person
    {
        //Skapa en klass Person med Name, Age, FavoriteColor.
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavoritColor { get; set; }

        //Lägg till en metod Introduce() som skriver ut en presentation.
        //Skapa två personer och låt dem presentera sig -Fråga om deras info via Consolen - Console.ReadLine().
        public void Introduce()
        {
            Console.WriteLine($"Hej jag heter {Name}, Jag är {Age} år gammal och min favoritfärg är {FavoritColor}");
        }


    }
}
