using System;
using System.Globalization;
using System.Threading;
using SpectatorProject.Model;

namespace SpectatorProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Name name = new Name("László", "Látó");
            Console.WriteLine("Teljes név tulajdonság: " + name.FullName);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
            DateTime dt = new DateTime(2022, 3, 15);
            string dateString = dt.ToString();
            CreditCard creditCard = new CreditCard("11", dt);

            if (creditCard.Expired)
                Console.WriteLine("Lejárat tulajdonság: a hitelkártya lejárt");
            else
                Console.WriteLine("Lejárat tulajdonság: a hitelkártya érvényes");

            Status status = Status.Active;
            BonusCard bonusCard = new BonusCard("12", status, 30000);

            if (bonusCard.Usable)
                Console.WriteLine("Próba: a bónuszkártya használható");
            else
            {
                Console.WriteLine("A bonuszkártya nem használható!");
            }
            Spectator spectator = new Spectator(name, creditCard, bonusCard);
            Console.WriteLine(spectator);




            Console.ReadKey();
        }
    }
}
