using System.Diagnostics;

namespace MoreDamageConsoleApp
{
    public class ArrowDamage : WeaponDamage
    {
        /// <summary>
        /// The base damage factor
        /// </summary>
        public const decimal BaseMultiplier = .35M;

        /// <summary>
        /// The additional damage caused by the flaming effect.
        /// </summary>
        public const decimal MagicMultiplier = 2.5M;

        /// <summary>
        /// The additional damage caused by the flaming effect.
        /// </summary>
        public const decimal FlameDamage = 1.25M;

        public ArrowDamage(int roll) : base()
        {
            Roll = roll;
        }

        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BaseMultiplier;
            if (Magic)
                baseDamage *= MagicMultiplier;
            if (Flaming)
                Damage = (int)Math.Ceiling(baseDamage + FlameDamage);
            else
                Damage = (int)Math.Ceiling(baseDamage);
            Debug.WriteLine($"Damage = {Damage}");
        }
    }
}