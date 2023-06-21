
using ElephantSwapping;

class Program
{
    static void Main(string[] args)
    {
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        while (true)
        {
            Console.WriteLine("---\r\nPress 1 for Lloyd, 2 for Lucinda, 3 to swap.");
            char option = Console.ReadKey().KeyChar;
            Console.WriteLine($"\r\nYou pressed {option}");

            switch (option)
            {
                case '1':
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                    break;

                case '2':
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                    break;

                case '3':
                    Elephant tempElephant = lucinda; 
                    lucinda = lloyd;
                    lloyd = tempElephant;
                    Console.WriteLine("Refereces have been swapped.");
                    break;

                case '4':
                    lloyd = lucinda;
                    lloyd.EarSize = 4331;
                    lloyd.WhoAmI();
                    break;

                case '5':
                    lucinda.SpeakTo(lloyd, "Hi Lloyd!");
                    break;

                case 'q':
                case 'Q':
                    Console.WriteLine("Quiting...");
                    return;

                default:
                    Console.WriteLine($"Invalid option selected.");
                    break;
            }
        }
    }
}