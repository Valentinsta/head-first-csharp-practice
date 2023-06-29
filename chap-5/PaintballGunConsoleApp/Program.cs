using PaintballGunConsoleApp;

class Program
{
    static int ReadInt(int defaultValue, string prompt)
    {
        Console.WriteLine($"{prompt} [{defaultValue}]");
        if (int.TryParse(Console.ReadLine(), out int inputValue))
            return inputValue;
        return defaultValue;
    }
    static bool ReadBool(bool defaultValue, string prompt)
    {
        Console.WriteLine($"{prompt} [{defaultValue}]");
        if (bool.TryParse(Console.ReadLine(), out bool inputValue))
            return inputValue;
        return defaultValue;
    }

    static void Main(string[] args)
    {
        PaintballGun gun = new(
            ReadInt(100, "Number of balls?"),
            ReadInt(8, "Magazine size?"),
            ReadBool(false, "Reload at start?")
        );

        while (true)
        {
            Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
            if (gun.BallsLoaded == 0) Console.WriteLine("WARNING: You're out of ammo");
            Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
            char key = Console.ReadKey(true).KeyChar;
            if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
            else if (key == 'r') gun.Reload();
            else if (key == '+') gun.Balls += gun.MagazineSize;
            else if (key == 'q') return;
        }
    }
}