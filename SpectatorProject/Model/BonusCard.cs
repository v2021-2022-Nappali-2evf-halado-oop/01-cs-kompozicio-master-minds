using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorProject.Model
{
    enum Status
    {
        Active,
        Inactive,
        Expired
    }

    /// <summary>
    /// Bonusz CLass
    /// </summary>
    class BonusCard
    {
        /// <summary>
        /// Adattagok létrehozva
        /// </summary>

        float balance;
        string cardmumber;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="cardmumber"></param>
        public BonusCard(float balance, string cardmumber)
        {
            this.Balance = balance;
            this.Cardmumber = cardmumber;
        }

        public float Balance { get => balance; set => balance = value; }
        public string Cardmumber { get => cardmumber; set => cardmumber = value; }
    }
}
