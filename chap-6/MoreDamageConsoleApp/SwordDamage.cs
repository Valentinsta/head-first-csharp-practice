using System.Diagnostics;

namespace MoreDamageConsoleApp
{
    public class SwordDamage : WeaponDamage
    {
        /// <summary>
        /// The base damage value for the sword.
        /// </summary>
        public const int BaseDamage = 3;

        /// <summary>
        /// The additional damage caused by the flaming effect.
        /// </summary>
        public const int FlameDamage = 2;

        public SwordDamage(int roll) : base()
        {
            Roll = roll;
        }

        protected override void CalculateDamage()
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