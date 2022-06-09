using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab2
{
    public class EmployeConsultant : Employe
    {
        public EmployeConsultant(int numero, string nom, float tauxHoraire) : base(numero, nom, tauxHoraire)
        {
        }

        override
        public float Absences(float heures)
        {
            var a = 45 - heures;
            if (a < 0)
                return 0;
            return a;
        }

        override
        public float Supplementaires(float heures)
        {
            var s = heures - 40;
            if (s < 0)
                return 0;
            return s;
        }

        public Boolean ValideFacture(float heures, float montant)
        {
            return SalaireHebdomadaire(heures) == montant;
        }
    }
}
