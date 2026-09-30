using System;
using System.Collections.Generic;
using System.Text;

namespace Onsdag_CleanCodeIntroduktion
{
    public class Car
    {
        //Klass Car med Brand, Model, Color.
        public string Brand;
        public string Model;
        public string Color;
        //ReadInfo() frågar användaren om bilen.
        public void ReadInfo()
        {
            Console.WriteLine("Vilket Brand?");
            Brand = Console.ReadLine()!;

            Console.WriteLine("Vilken model?");
            Model = Console.ReadLine()!;

            Console.WriteLine("Vilken Färg?");
            Color = Console.ReadLine()!;
        }
        //ShowCar() skriver ut:
        //“Din bil är en röd Volvo V70.”
        public void ShowCar()
        {
            Console.WriteLine($"Din bil är en {Color} {Brand} {Model}");
        }
        
    }
}
