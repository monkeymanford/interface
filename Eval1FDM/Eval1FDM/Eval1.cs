using System;
using System.Collections.Generic;

namespace Eval1FDM
{
    public class Eval1
    {
        public Eval1(){}

        public static void Exo01()
        {
            Ferie fete01 = new Ferie("Fête du Canada", "1er Juillet");
            Ferie fete02 = new Ferie("Fête du Travail", "1er Lundi de Septembre");
            Ferie fete03 = new Ferie("Action de grâce", "2e Lundi d'Octobre");
            Ferie fete04 = new Ferie("Jour de Noël", "25 Décembre");
          
            DateFeriee dateFeriee01 = new DateFeriee(fete01, new DateTime(2022, 07, 01));
            DateFeriee dateFeriee02 = new DateFeriee(fete02, new DateTime(2022, 09, 05));
            DateFeriee dateFeriee03 = new DateFeriee(fete03, new DateTime(2022, 10, 10));
            DateFeriee dateFeriee04 = new DateFeriee(fete04, new DateTime(2022, 12, 25));

            List<DateFeriee> listeDatesFeriees = new List<DateFeriee>();
            Calendrier annee2022 = new Calendrier(2022);

            listeDatesFeriees.Add(dateFeriee01);
            listeDatesFeriees.Add(dateFeriee02);
            listeDatesFeriees.Add(dateFeriee03);
            listeDatesFeriees.Add(dateFeriee04);

            Console.WriteLine("{0, -25}{1, -15}{2, -25}", "Événement", "Jour", "Date");

            foreach (DateFeriee x in listeDatesFeriees)
            {
                Console.WriteLine("{0, -25}{1, -15}{2, -25}", x.GetTitre(), x.JourSemaine(), x.DateLongue());
            }

        }

        public static void Exo02()
        {
            Ferie fete01 = new Ferie(701, "Fête du Canada", "1er Juillet");
            Ferie fete02 = new Ferie(901, "Fête du Travail", "1er Lundi de Septembre");
            Ferie fete03 = new Ferie(1012, "Action de grâce", "2e Lundi d'Octobre");
            Ferie fete04 = new Ferie(1225, "Jour de Noël", "25 Décembre");

            var dictionnaireFeries = new Dictionary<int, Ferie>();

            dictionnaireFeries.Add(fete01.GetCode(), fete01);
            dictionnaireFeries.Add(fete02.GetCode(), fete02);
            dictionnaireFeries.Add(fete03.GetCode(), fete03);
            dictionnaireFeries.Add(fete04.GetCode(), fete04);

            Console.WriteLine("\r\nRetour des objets:");
            foreach (var index in dictionnaireFeries)
            {
                Console.WriteLine(index);
            }

            Console.WriteLine("\r\nRetour des clés:");
            foreach (var index in dictionnaireFeries)
            {
                Console.WriteLine(index.Key);
            }

            Console.WriteLine("\r\nRetour de l'élément 901:");
            Console.WriteLine(dictionnaireFeries[901]);

        }

        public static void Exo03()
        {

        }

    }
}
