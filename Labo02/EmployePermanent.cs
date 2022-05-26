namespace Labo02
{
    public class EmployePermanent : Employe
    {
        private float taux_impot;
        private float cotisation_assurance;
        private float taux_cotisation_retraite;

        public EmployePermanent(
                            int numero, string nom,
                            float taux_horaire,
                            float taux_impot,
                            float cotisation_assurance,
                            float cotisation_retraite)
                            : base(numero, nom, taux_horaire)
        {
            this.taux_impot = taux_impot;
            this.cotisation_assurance = cotisation_assurance;
            this.taux_cotisation_retraite = cotisation_retraite;
        }

        public float salaire_hebdomadaire(float heures)
        {
            return (heures - Supplementaires(heures)) * taux_horaire 
                    + (Supplementaires(heures) * taux_horaire * 1.5f);
        }

        public float paie_hebdomadaire(float heures)
        {
            return salaire_hebdomadaire(heures) 
                    - (1 - taux_impot / 100 - taux_cotisation_retraite / 100)
                    - cotisation_assurance;
        }
    }
}