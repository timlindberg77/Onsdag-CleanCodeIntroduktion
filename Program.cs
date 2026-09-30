namespace Onsdag_CleanCodeIntroduktion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Skapa en konsolapplikation som konverterar en summa pengar från en valuta till en annan.
            ////Inkludera typkonverteringar, operatörer och kontrollflöde.

            ////Instruktioner:
            ////Be användaren att ange en summa pengar i SEK.
            //Console.WriteLine("Vänligen ange din summa (Sek)");
            //double UserMoneySek = double.Parse(Console.ReadLine());
            ////Ange en lista över tillgängliga valutor(t.ex.EUR, GBP, JPY, USD).
            //double EuroExchRate = 0.088;
            //double GBPExchRate = 0.0757;
            //double JPYExchRate = 15.72;
            //double USDExchRate = 0.10;
            //Console.WriteLine($"En krona är likamed följande: Euro {EuroExchRate}, GBP {GBPExchRate}, JPY {JPYExchRate}, USD {USDExchRate}.");
            //Console.WriteLine("Vilken av det följande valutorna vill du byta till?");
            //Console.WriteLine(" Svara med fljande förkortning: EUR, GBP, JPY, USD");
            ////Använd en switch-sats för att hantera valutaomvandlingen.
            ////Utför omvandlingen med multiplikationsoperatorer och skriv gjutning vid behov.
            //string ValutaSvar = Console.ReadLine().ToUpper();
            //double ConvertedCurrency = 0;

            //switch (ValutaSvar)
            //{
            //    case ("EUR"):
            //        ConvertedCurrency = UserMoneySek * EuroExchRate;
            //    break;

            //    case ("GBP"):
            //        ConvertedCurrency = UserMoneySek * GBPExchRate;
            //        break;

            //    case ("JPY"):
            //        ConvertedCurrency = UserMoneySek * JPYExchRate;
            //        break;

            //    case ("USD"):
            //        ConvertedCurrency = UserMoneySek * USDExchRate;
            //        break;
            //    default:
            //        Console.WriteLine("Okänd valuta.");
            //        return;

            //}
            ////Visa det konverterade .
            //Console.WriteLine($"Du har konverterat dina {UserMoneySek}Sek till {ConvertedCurrency}{ValutaSvar}");

            //Skapa en konsolapp som kontrollerar styrkan på ett lösenord som användaren har angett.
            //Den här appen bör bedöma lösenordets styrka baserat på olika kriterier som längd, närvaro av specialtecken och siffror.
            //Den introducerar strängmanipulation, if-else -satser och loopar.

            //Instruktioner:
            //Be användaren att ange ett lösenord.
            //Använd en rad villkor för att kontrollera:
            Console.WriteLine("Skapa ett lösenord: ");
            String UserPassword = Console.ReadLine()!;
            //Lösenordets längd(bör vara minst 8 tecken).
            bool PassWordLengthCheck = UserPassword.Length >= 8;
            //Innehåller både stora och små bokstäver.
            bool PassWordCapitalLeters = UserPassword.Any(char.IsUpper) && UserPassword.Any(char.IsLower);
            //Innehåller minst ett nummer.
            bool PassWordNumberCheck = UserPassword.Any(char.IsDigit);
            //Innehåller minst ett specialtecken.
            bool PassWordSpecialLettersCheck = UserPassword.Any(x => !char.IsLetterOrDigit(x));
            //skapar ett poäng systemsom för if satsen lättare
            int PassWordCheckPoints = 0;
            if (PassWordLengthCheck) PassWordCheckPoints++;
            if (PassWordCapitalLeters) PassWordCheckPoints++;
            if (PassWordNumberCheck) PassWordCheckPoints++;
            if (PassWordSpecialLettersCheck) PassWordCheckPoints++;
            //Ge feedback om lösenordet är "Svagt", "Moderat" eller "Starkt" baserat på dessa kontroller.
            if (PassWordCheckPoints == 2 || PassWordCheckPoints == 3) 
            {
                Console.WriteLine("Lösenordet är  moderat");
            }
            else if (PassWordCheckPoints == 4)
            {
                Console.WriteLine("Lösenordet är Starkt");
            }
            else
            {
                Console.WriteLine("Lösenordet är för svagt");
            }
            //testat poängystemet
            Console.WriteLine($"{PassWordCheckPoints}");
           

        }
    }
}
