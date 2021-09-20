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
        private float balance;
        private Status status;
        private string cardNumber;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <param name="status"></param>
        /// <param name="balance"></param>
        public BonusCard(string cardNumber, Status status, float balance)
        {
            this.Balance = balance;
            this.Status = status;
            this.CardNumber = cardNumber;
        }


        /// <summary>
        /// Getter-Setter
        /// </summary>
        public float Balance { get => balance; set => balance = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        internal Status Status { get => status; set => status = value; }
    }
}
