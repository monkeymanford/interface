namespace Labo02
{
    public class EmployeConsultant : Employe
    {
        public EmployeConsultant(int numero, string nom, float taux_horaire) : base(numero, nom, taux_horaire)
        {

        }

        public override float Absences(float heures)
        {
            if (heures >= 40) return 0;
            else return 35 - heures;
        }

        public override float Supplementaires(float heures)
        {
            if (heures >= 40) return heures - 35;
            else return 0;
        }

        public bool Valider_facture(float montant, float heures)
        {
            return montant == Salaire_hebdomadaire(heures);
        }

    }
}