using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorProject.Model
{
    /// <summary>
    /// Név osztály
    /// </summary>
    class Name
    {
        /// <summary>
        /// adattagok
        /// </summary>
        private string firstName;
        private string lastName;


        /// <summary>
        /// Minden adattagot tartalmazó konstruktor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Módosítható ís írható tulajdonság
        /// </summary>
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
