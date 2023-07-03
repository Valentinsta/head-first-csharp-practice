// See https://aka.ms/new-console-template for more information
Random random = new Random();
int randomInt = random.Next();
Console.WriteLine($"{randomInt}");
int zeroToNine = random.Next(10);
Console.WriteLine($"{zeroToNine}");
int dieRoll= random.Next(1, 7);
Console.WriteLine($"{dieRoll}");
double randomDouble = random.NextDouble();
Console.WriteLine($"{randomDouble}");
double betweenZeroAndNintyNine = random.NextDouble() * 100;
Console.WriteLine($"{betweenZeroAndNintyNine}");
Console.WriteLine($"{(float)randomDouble * 100F}");
Console.WriteLine($"{(decimal)randomDouble * 100M}");

int randomBit = random.Next(2);
Console.WriteLine($"{Convert.ToBoolean(randomBit)}");
decimal price = 99.95M;
Console.WriteLine(price.ToString("c"));
Console.ReadLine();
