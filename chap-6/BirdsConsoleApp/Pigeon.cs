using System;

namespace BirdsConsoleApp
{
    class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                string eggColor = "white";
                double eggSize = Math.Round((double)Randomizer.Next(1, 3) + Randomizer.NextDouble(), 1);
                if (Randomizer.Next(4) == 0)
                    eggs[i] = new BrokenEgg(eggColor);
                else
                    eggs[i] = new Egg(eggSize, eggColor);
            }
            return eggs;
        }
    }
}