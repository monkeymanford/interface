using System;

namespace ConsoleAppLab2
{
    class Program
    {

        static void MainExoHéritage1à3()
        {
            var ep = new EmployePermanent(1234, "Jean Permanent", 50, 40, 50, 5);
            Console.WriteLine($"Employé permanent ep : {ep}");
            Console.WriteLine("paie ep : {0:c}\n", ep.PaieHebdomadaire(37));
            var ec = new EmployeConsultant(9234, "Marjo Consultant", 100);
            Console.WriteLine($"Employé consultant ec : {ec}");
            Console.WriteLine("salaire ec : {0:c}\n", ec.SalaireHebdomadaire(37));
            Console.WriteLine("facture ec de 3700$ acceptée : {0:c}\n", ec.ValideFacture(37, 3700));
        }

        static void MainExoClasses1à4()
        {
            //Exercice3
            var cp = new CompteBancaire(1234, "Paul", 0);
            var cr = new CompteBancaire(2345, "Rita", 2020);
            for (int i = 0; i < 6; i++)
            {
                cp.Deposer(200);
                cr.Retirer(20);
            }
            cp.Retirer(20);
            cp.Retirer(150);

            Console.WriteLine("PauL : Frais = {0:C}, Intérets = {1:c}\n", cp.Frais(), cp.intérets());
            Console.WriteLine("Rita : Frais = {0:C}, Intérets = {1:c}\n", cr.Frais(), cr.intérets());

        }
        static void Main(string[] args)
        {


            var compte01 = new CompteBancaire(1001, "Jérémie", 2500);

            string choix;
            float montant;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Voulez vous effectuer un retrait ? o/n");
                choix = Console.ReadLine();
                if (choix == "o")
                {
                    Console.WriteLine("Votre solde est de " + compte01.Solde + "$");
                    Console.WriteLine("Quel montant désirez-vous retirer ? ");
                    montant = float.Parse(Console.ReadLine());
                    if (montant > compte01.Solde)
                    {
                        Console.Clear();
                        Console.WriteLine("Ce montant est supérieur à votre solde, veuillez recommencer");
                        Console.WriteLine("Appuyez sur enter pour continuer");
                        Console.ReadLine();
                    }
                    else
                    {
                        compte01.Retirer(montant);
                        Console.WriteLine("Montant retiré, nouveau solde: " + compte01.Solde + "$");
                        Console.WriteLine("Appuyez sur enter pour continuer");
                        Console.ReadLine();
                    }
                }
                else break;

                if (compte01.Solde == 0)
                {
                    Console.WriteLine("Votre compte est vide, vous êtes à présent pauvre.");
                    break;
                }
            }

            Console.WriteLine("Au revoir");
        }
    }
}