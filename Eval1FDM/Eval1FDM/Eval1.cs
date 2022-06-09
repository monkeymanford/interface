using System;
using System.Collections.Generic;

namespace Eval1FDM
{
    public class Eval1
    {
        public Eval1(){}

        public static void Exo01()
        {
            // création des instances de Férié:
            Ferie fete01 = new Ferie("Fête du Canada", "1er Juillet");
            Ferie fete02 = new Ferie("Fête du Travail", "1er Lundi de Septembre");
            Ferie fete03 = new Ferie("Action de grâce", "2e Lundi d'Octobre");
            Ferie fete04 = new Ferie("Jour de Noël", "25 Décembre");

            // création des instances de DateFériée:        
            DateFeriee dateFeriee01 = new DateFeriee(fete01, new DateTime(2022, 07, 01));
            DateFeriee dateFeriee02 = new DateFeriee(fete02, new DateTime(2022, 09, 05));
            DateFeriee dateFeriee03 = new DateFeriee(fete03, new DateTime(2022, 10, 10));
            DateFeriee dateFeriee04 = new DateFeriee(fete04, new DateTime(2022, 12, 25));

            // création d'une instance de Calendrier:
            Calendrier annee2022 = new Calendrier(2022);

            // on ajoute les objets DateFériée à la liste dans Calendrier:
            annee2022.AjoutDateFeriee(dateFeriee01);
            annee2022.AjoutDateFeriee(dateFeriee02);
            annee2022.AjoutDateFeriee(dateFeriee03);
            annee2022.AjoutDateFeriee(dateFeriee04);

            // formatage du tableau:
            Console.WriteLine("{0, -25}{1, -15}{2, -25}", "Événement", "Jour", "Date");

            // on affiche les instances de la liste des dates fériées dans l'objet Calendrier:
            foreach (DateFeriee x in annee2022.GetListDatesFeriees())
            {
                Console.WriteLine("{0, -25}{1, -15}{2, -25}", x.GetTitre(), x.JourSemaine(), x.DateLongue());
            }
        }

        public static void Exo02()
        {
            // création des instances de Férié en utilisant le constructeur qui permet d'avoir un code:
            Ferie fete01 = new Ferie(701, "Fête du Canada", "1er Juillet");
            Ferie fete02 = new Ferie(901, "Fête du Travail", "1er Lundi de Septembre");
            Ferie fete03 = new Ferie(1012, "Action de grâce", "2e Lundi d'Octobre");
            Ferie fete04 = new Ferie(1225, "Jour de Noël", "25 Décembre");

            // création d'une instance Dictionary:
            var dictionnaireFeries = new Dictionary<int, Ferie>();

            // ajout des objets Férié au Dictionary:
            dictionnaireFeries.Add(fete01.GetCode(), fete01);
            dictionnaireFeries.Add(fete02.GetCode(), fete02);
            dictionnaireFeries.Add(fete03.GetCode(), fete03);
            dictionnaireFeries.Add(fete04.GetCode(), fete04);

            // affichage des objets (n.6):
            Console.WriteLine("\r\nRetour des objets:");
            foreach (var index in dictionnaireFeries)
            {
                Console.WriteLine(index);
            }

            // affichage des clés (n.7):
            Console.WriteLine("\r\nRetour des clés:");
            foreach (var index in dictionnaireFeries)
            {
                Console.WriteLine(index.Key);
            }

            // affichage de l'objet 901:
            Console.WriteLine("\r\nRetour de l'élément 901:");
            Console.WriteLine(dictionnaireFeries[901]);
        }

        public static void Exo03()
        {
            // explication pour EXERCICE 3 :
            //
            // Il suffit de créer un bloc try/catch atour du code qui permet la saisie des nouvelles dates
            // fériées à ajouter à la liste du calendrier, on y met un un if statement qui prédéfinie les
            // limites des codes acceptés, si le code saisie n'est pas dans ces limites, on throw une exception
            // qui avertit l'utilisateur que ce code n'est pas dans les limites permises.
            //
            // Ceci peut aussi simplement être implémenté avec un if-statement lorsque celà est acceptable.
        }

    }
}
