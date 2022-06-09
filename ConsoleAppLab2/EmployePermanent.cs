using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab2
{
    public class EmployePermanent : Employe
    {
        private float tauxImpot;
        private float cotisationsAssurance;
        private float tauxRetraite;

        public EmployePermanent(int numero, string nom, float tauxHoraire, 
                float tauxImpot, float cotisationsAssurance, float tauxRetraite) : base(numero, nom, tauxHoraire)
        {
            this.tauxImpot = tauxImpot;
            this.cotisationsAssurance = cotisationsAssurance;
            this.tauxRetraite = tauxRetraite;
        }

        //méthode transférée vers Employe par l'exercice 2
/*
        public float SalaireHebdomadaire(float heures)
        {
            return tauxHoraire * (heures - supplementaires(heures)) +
                tauxHoraire * 1.5f * supplementaires(heures);
        }
*/
        
        public float PaieHebdomadaire(float heures)
        {
            var sh = SalaireHebdomadaire(heures);
            var ph = SalaireHebdomadaire(heures) * (1 - tauxImpot / 100 - tauxRetraite / 100)
                - cotisationsAssurance;
            return SalaireHebdomadaire(heures) * (1 - tauxImpot /100 - tauxRetraite/100)
                - cotisationsAssurance;
        }

    }
}
