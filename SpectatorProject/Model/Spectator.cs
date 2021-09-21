using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorProject.Model
{
    class Spectator
    {
        //rejtett adattagok
        private Name name;
        private CreditCard creditCard;
        private BonusCard bonusCard;

        //konstruktor
        public Spectator(Name name, CreditCard creditCard, BonusCard bonusCard)
        {
            this.name = name;
            this.creditCard = creditCard;
            this.bonusCard = bonusCard;
        }

        public override string ToString()
        {
            string result = "Néző adatai:";

            result += "\n" + name + "\n" + creditCard + "\n" + bonusCard;
            return result;
        }
    }
}
