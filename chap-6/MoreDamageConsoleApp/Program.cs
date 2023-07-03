using System;

namespace MoreDamageConsoleApp
{
    class Program
    {
        private static Random random = new();
        static void Main()
        {
            WeaponDamage weaponDamage;

            while (true)
            {
                Console.WriteLine("---\r\n'A' for arrow, 'S' for sword, anything else to quit.");
                char key = char.ToUpper(Console.ReadKey().KeyChar);
                switch (key)
                {
                    case 'A':
                        weaponDamage = new ArrowDamage(RollDice(1));
                        break;
                    case 'S':
                        weaponDamage = new SwordDamage(RollDice(3));
                        break;
                    default:
                        return;
                }

                Console.WriteLine("---\r\n0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit.");
                char option = Console.ReadKey().KeyChar;
                Console.WriteLine($"\r\nYou pressed {option}");

                if (option != '0' && option != '1' && option != '2' && option != '3')
                    return;
                weaponDamage.Magic = option == '1' || option == '3';
                weaponDamage.Flaming = option == '2' || option == '3';
                
                Console.WriteLine($"Rolled {weaponDamage.Roll} for {weaponDamage.Damage} HP");
            }
        }

        static int RollDice(int dice)
        {
            int diceRoll = 0;
            for (int i = 0; i < dice; i++)
            {
                diceRoll += random.Next(1, 7);
            }
            return diceRoll;
        }
    }
}