// See https://aka.ms/new-console-template for more information
using ConsoleAppOwen;

class Program
{
    static void Main()
    {
        SwordDamage excalibur = new();
        Random random = new();
        
        while (true)
        {
            Console.WriteLine("---\r\n0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit.");
            char option = Console.ReadKey().KeyChar;
            Console.WriteLine($"\r\nYou pressed {option}");

            if (option != '0' && option != '1' && option != '2' && option != '3')
                return;
            excalibur.SetMagic(option == '1' || option == '3');  
            excalibur.SetFlaming(option == '2' || option == '3');
            excalibur.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            // excalibur.CalculateDamage();
            Console.WriteLine($"Rolled {excalibur.Roll} for {excalibur.Damage} HP"); 
        }
    }
}
