using System;

namespace Eval1FDM
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercice 1:

            Eval1.Exo01();
            Console.WriteLine();

            // exercice 2:

            Eval1.Exo02();
            Console.WriteLine();

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
