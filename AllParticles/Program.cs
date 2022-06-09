using System;

namespace AllParticles
{
    class Program
    {
        static void Main(string[] args)
        {
            double population = 7000000000;
            double nbYears = 8604;
            double growthRate = 1.0111;

            for (int i = 0; i < nbYears; i++)
            {
                population *= growthRate;
            }

            Console.WriteLine(population);
        }
    }
}
