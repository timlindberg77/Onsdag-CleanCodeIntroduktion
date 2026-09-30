namespace Onsdag_CleanCodeIntroduktion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa en konsolapplikation som konverterar en summa pengar från en valuta till en annan.
            //Inkludera typkonverteringar, operatörer och kontrollflöde.

            //Instruktioner:
            //Be användaren att ange en summa pengar i SEK.
            Console.WriteLine("Vänligen ange din summa (Sek)");
            double UserMoneySek = double.Parse(Console.ReadLine());
            //Ange en lista över tillgängliga valutor(t.ex.EUR, GBP, JPY, USD).
            double EuroExchRate = 0.088;
            double GBPExchRate = 0.0757;
            double JPYExchRate = 15.72;
            double USDExchRate = 0.10;
            Console.WriteLine($"En krona är likamed följande: Euro {EuroExchRate}, GBP {GBPExchRate}, JPY {JPYExchRate}, USD {USDExchRate}.");
            Console.WriteLine("Vilken av det följande valutorna vill du byta till?");
            Console.WriteLine(" Svara med fljande förkortning: EUR, GBP, JPY, USD");
            //Använd en switch-sats för att hantera valutaomvandlingen.
            //Utför omvandlingen med multiplikationsoperatorer och skriv gjutning vid behov.
            string ValutaSvar = Console.ReadLine().ToUpper();
            double ConvertedCurrency = 0;

            switch (ValutaSvar)
            {
                case ("EUR"):
                    ConvertedCurrency = UserMoneySek * EuroExchRate;
                break;

                case ("GBP"):
                    ConvertedCurrency = UserMoneySek * GBPExchRate;
                    break;

                case ("JPY"):
                    ConvertedCurrency = UserMoneySek * JPYExchRate;
                    break;

                case ("USD"):
                    ConvertedCurrency = UserMoneySek * USDExchRate;
                    break;
                default:
                    Console.WriteLine("Okänd valuta.");
                    return;

            }
            //Visa det konverterade .
            Console.WriteLine($"Du har konverterat dina {UserMoneySek}Sek till {ConvertedCurrency}{ValutaSvar}");

        }
    }
}
