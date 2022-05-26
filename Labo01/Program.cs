using System;
using System.Collections.Generic;

namespace Labo01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // numéro 1:

            Console.Clear();
            Console.Write("Quel est votre prenom? ");
            string name = Console.ReadLine();
            Console.Write("Quel est votre nom? ");
            string surname = Console.ReadLine();
            Console.WriteLine("Bonjour "+ name + " "+surname);
            Console.ReadLine();

            // numéro 2:

            //Console.WriteLine("Les amis de "+name+":");
            //Console.WriteLine("---------------------");
            //Console.WriteLine("");

            // numéro 9:
            Console.Clear();
            Console.Write("Veuillez entrer la note: ");
            int note = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\r\n");
            if (note >= 90) Console.WriteLine("Excellent!");
            else if (note >= 80) Console.WriteLine("Très Bien.");
            else if (note >= 60) Console.WriteLine("Bien");
            else if (note >= 50) Console.WriteLine("Admissible au rattrapage");
            else Console.WriteLine("Échec!!");
            Console.ReadLine();

            // numéro 10:
            Console.Clear();
            Console.Write("Veuillez entrer un nombre entier: ");
            int entier = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\r\n");
            int somme = 0;
            for (int i = 1; i <= entier; i++) somme += i;
            Console.WriteLine("La somme des "+ entier +" nombres entiers est "+ somme);
            Console.ReadLine();

            // numéro 11:
            List<string> liste = new List<string>();
            Console.Clear();
            while (true) {
                Console.Write("Faites votre saisie: ");
                liste.Add(Console.ReadLine());
                Console.Write("\r\nSaisir un autre élément? (o/n)");
                if (Console.ReadLine() == "n") break;
            }

            Console.Clear();
            Console.WriteLine("Éléments saisis: \r\n");
            foreach (string item in liste) Console.WriteLine(item);


        }
    }
}
