namespace Labo02
{
    public class Employe
    {
        protected int numero;
        protected string nom;
        protected float taux_horaire;


        public Employe(int numero, string nom, float taux_horaire)
        {
            this.numero = numero;
            this.nom = nom;
            this.taux_horaire = taux_horaire;
        }

        public override string ToString()
        {
            return $"{numero},{nom},{taux_horaire}";
        }

        public virtual float Absences(float heures)
        {
            if (heures >= 35) return 0;
            else return 35 - heures;
        }

        public virtual float Supplementaires(float heures)
        {
            if (heures >= 35) return heures - 35;
            else return 0;
        }

        // initialement dans la classe EmployePermanent
        public float Salaire_hebdomadaire(float heures)
        {
            return (heures - Supplementaires(heures)) * taux_horaire
                    + Supplementaires(heures) * taux_horaire * 1.5f;
        }

        // ajouté pour illustrer davantage le polymorphisme
        public float Paie_hebdomadaire(float heures)
        {
            return Salaire_hebdomadaire(heures);
        }



    }
}