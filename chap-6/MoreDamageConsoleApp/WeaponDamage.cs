using System;

namespace MoreDamageConsoleApp
{
    abstract public class WeaponDamage
    {
        /// <summary>
        /// The total damage inflicted by the sword.
        /// </summary>
        public int Damage { get; protected set; }

        private int roll;
        /// <summary>
        /// The roll value used to calculate the damage.
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool flaming = false;
        /// <summary>
        /// Determines whether the sword is flaming.
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        private bool magic = false;
        /// <summary>
        /// Determines whether the sword is magical.
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// Initializes a new instance of the WeaponDamage class.
        /// </summary>
        public WeaponDamage() { }
        protected abstract void CalculateDamage();

    }
}