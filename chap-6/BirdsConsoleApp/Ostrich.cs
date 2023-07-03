using System;

namespace BirdsConsoleApp
{
    class Ostrich: Bird
    {   
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                string eggColor = "speckled";
                double eggSize = Math.Round((double)Randomizer.Next(12, 13) + Randomizer.NextDouble(), 1);
                eggs[i] = new Egg(eggSize, eggColor);
            }
            return eggs;
        }
        
    }
}