using System;

namespace Labo02
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercice 1: Heritage
            var emp01 = new EmployePermanent(1001, "Abi Jo", 50, 40, 50, 5);

            Console.WriteLine($"salaire hebdomadaire de emp01: {emp01.Salaire_hebdomadaire(37)}");
            Console.WriteLine($"paie hebdomadaire de emp01: {emp01.Paie_hebdomadaire(37)}");

            // exercice 3: 
            var emp02 = new EmployeConsultant(1002, "Allie Bad", 90);

            Console.WriteLine($"paie hebdomadaire de emp02: {emp02.Salaire_hebdomadaire(37)}");

            // validation facture
            Console.WriteLine($"validation facture montant 3420 pour 37 heures: {emp02.Valider_facture(3420,37)}");
            Console.WriteLine($"validation facture montant 3330 pour 37 heures: {emp02.Valider_facture(3330,37)}");

            Console.WriteLine(0%2);

        }
    }
}
