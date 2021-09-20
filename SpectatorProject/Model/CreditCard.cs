using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorProject.Model
{   
    /// <summary>
    /// Hitelkártya osztály
    /// </summary>
    class CreditCard
    {
        /// <summary>
        /// Adattagok felvétele
        /// </summary>
        private DateTime expiredate;
        private string cardNumber;

        /// <summary>
        /// Konstruktor létrejött
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <param name="expiredate"></param>
        public CreditCard(string cardNumber, DateTime expiredate)
        {
            this.Expiredate = expiredate;
            this.CardNumber = cardNumber;
        }
        /// <summary>
        /// Getter setter létrejött.
        /// </summary>
        public DateTime Expiredate { get => expiredate; set => expiredate = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
    }
}
