using System.Diagnostics;

namespace ConsoleAppOwen
{
    public class SwordDamage
    {
        /// <summary>
        /// The base damage value for the sword.
        /// </summary>
        public const int BaseDamage = 3;

        /// <summary>
        /// The additional damage caused by the flaming effect.
        /// </summary>
        public const int FlameDamage = 2;

        /// <summary>
        /// The total damage inflicted by the sword.
        /// </summary>
        public int Damage { get; private set; }

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
        /// Initializes a new instance of the SwordDamage class with the specified initial roll value.
        /// </summary>
        /// <param name="initialRoll">The initial roll value.</param>
        public SwordDamage(int initialRoll)
        {
            Roll = initialRoll;
        }

        private void CalculateDamage()
        {
            decimal magicMultiplier = Magic ? 1.75M : 1M;
            int flamingDamage = Flaming ? FlameDamage : 0;
            Debug.WriteLine($"Roll = {Roll}");
            Debug.WriteLine($"magicMultiplier = {magicMultiplier}");
            Debug.WriteLine($"BaseDamage = {BaseDamage}");
            Debug.WriteLine($"flamingDamage = {flamingDamage}");
            Damage = (int)(Roll * magicMultiplier) + BaseDamage + flamingDamage;
            Debug.WriteLine($"Damage = {Damage}");
        }
    }
}