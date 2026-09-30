using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Onsdag_CleanCodeIntroduktion
{
    public class Burger
    {
        //Skapa en klass Burger med Bread, Meat, Topping.
        public string Bread;
        public string Meat;
        public string Topping;
        //ReadInfo() låter användaren bygga en egen burgare via Console.

        //public void ReadInfo()
        //{
        //    Console.WriteLine($"Vilket bröd vill du ha?");
        //    Bread = Console.ReadLine()!;

        //    Console.WriteLine($"Vilket kött vill du ha?");
        //    Meat = Console.ReadLine()!;

        //    Console.WriteLine($"Vilken topping vill du ha?");
        //    Topping = Console.ReadLine()!;
        //}
        ////DescribeBurger() skriver ut:
        //public void DescribeBurger()
        //{
        //    Console.WriteLine($"Din burgare har {Bread} bröd,{Meat} kött och {Topping} som topping ");
        //}
        //“Din burgare har Ljust bröd, Nötkött och Ost som topping.”

    }
}
