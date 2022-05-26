using System;

namespace Labo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp01 = new EmployePermanent(1234, "Abi Jo", 50, 40, 50, 5);

            Console.WriteLine($"paie hebdomadaire de emp01 : {emp01.paie_hebdomadaire(37)}");
        }
    }
}
