using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab2
{
    public class Employe
    {
        protected int numero;
        protected String nom;
        protected float tauxHoraire;

        public Employe(int numero, string nom, float tauxHoraire)
        {
            this.numero = numero;
            this.nom = nom;
            this.tauxHoraire = tauxHoraire;
        }

        public override string ToString()
        {
            return numero+", "+nom;
        }

        public virtual float Absences(float heures)
        {
            var a = 35 - heures;
            if (a < 0)
                return 0;
            return a;
        }

        public virtual float Supplementaires(float heures)
        {
            var s = heures - 35;
            if (s < 0)
                return 0;
            return s;
        }

        //initialement dans la classe Employe puis transférer par l'exercice 2
        public float SalaireHebdomadaire(float heures)
        {
            return tauxHoraire * (heures - Supplementaires(heures)) +
                tauxHoraire * 1.5f * Supplementaires(heures);
        }
    }
}
